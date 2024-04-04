using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class HastaBilgiDuzenleFrm : Form
    {
        HastaDetayFrm _hastaDetay;
        public HastaBilgiDuzenleFrm(HastaDetayFrm hastaDetay)
        {
            InitializeComponent();
            _hastaDetay = hastaDetay;
        }

        private void HastaBilgiDuzenleFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _hastaDetay.Show();
        }

        private void HastaBilgiDuzenleFrm_Load(object sender, EventArgs e)
        {
            string[] splittedAdSoyad = _hastaDetay.AdSoyad.Split(' ');
            TCTxt.Text = _hastaDetay.TCNO;
            AdTxt.Text = splittedAdSoyad[0];
            SoyadTxt.Text = string.IsNullOrEmpty(splittedAdSoyad[1]) ? splittedAdSoyad[2] : splittedAdSoyad[1]; // BURAYA TEKRAR BAKILACAK

            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT HASTATELEFON, HASTASIFRE, HASTACINSIYET FROM TBLHASTALAR WHERE HASTATC = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", _hastaDetay.TCNO);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TelefonTxt.Text = dr[0].ToString();
                            SifreTxt.Text = dr[1].ToString();

                            switch (dr[2])
                            {
                                case "ERKEK": ErkekRb.Checked = true; break;
                                case "KADIN": KadınRb.Checked = true; break;
                            }
                        }
                        dr.Close();
                    }
                }
                conn.Close();
            }
        }

        private void BilgiGuncelleBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE TBLHASTALAR SET HASTAAD = @p1, HASTASOYAD = @p2, HASTATC = @p3, HASTATELEFON = @p4, HASTASIFRE = @p5, HASTACINSIYET = @p6 WHERE HASTATC = @p7", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", AdTxt.Text.Length > 0 ? AdTxt.Text : "null");
                    cmd.Parameters.AddWithValue("@p2", SoyadTxt.Text.Length > 0 ? SoyadTxt.Text : "null");
                    cmd.Parameters.AddWithValue("@p3", TCTxt.Text.Length > 0 ? TCTxt.Text : "null");
                    cmd.Parameters.AddWithValue("@p4", TelefonTxt.Text.Length > 0 ? TelefonTxt.Text : "null");
                    cmd.Parameters.AddWithValue("@p5", SifreTxt.Text.Length > 0 ? SifreTxt.Text : "null");
                    switch (ErkekRb.Checked)
                    {
                        case true: cmd.Parameters.AddWithValue("@p6", "ERKEK"); break;
                    }
                    switch (KadınRb.Checked)
                    {
                        case true: cmd.Parameters.AddWithValue("@p6", "KADIN"); break;
                    }
                    cmd.Parameters.AddWithValue("@p7", _hastaDetay.TCNO);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Bilgileriniz Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
