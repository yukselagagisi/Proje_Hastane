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
    public partial class DoktorBilgiDuzenle : Form
    {
        DoktorDetayFrm _doktorDetayFrm;
        string _TCNO;
        public DoktorBilgiDuzenle(DoktorDetayFrm doktorDetayFrm, string TCNO)
        {
            InitializeComponent();
            _doktorDetayFrm = doktorDetayFrm;
            _TCNO = TCNO;
        }

        private void DoktorBilgiDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            _doktorDetayFrm.Show();
        }

        private void DoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            TCTxt.Text = _TCNO;
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT DOKTORAD, DOKTORSOYAD, BRANSAD, DOKTORSIFRE FROM TBLDOKTORLAR LEFT JOIN TBLBRANSLAR ON DOKTORBRANS = BRANSID WHERE DOKTORTC = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", _TCNO);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            AdTxt.Text = dr[0].ToString();
                            SoyadTxt.Text = dr[1].ToString();
                            BransCmb.Text = dr[2].ToString();
                            SifreTxt.Text = dr[3].ToString();
                        }
                        dr.Close();
                    }
                }
                conn.Close();
            }

            //ComboBox'a Branşları Çekme
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TBLBRANSLAR", conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            BransCmb.Items.Add(dr[1].ToString());
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
                using (SqlCommand cmd = new SqlCommand("UPDATE TBLDOKTORLAR SET DOKTORAD = @p1, DOKTORSOYAD = @p2, DOKTORBRANS = @p3, DOKTORTC = @p4, DOKTORSIFRE = @p5 WHERE DOKTORTC = @p6", conn)) 
                {
                    cmd.Parameters.AddWithValue("@p1", AdTxt.Text.Length > 0 ? AdTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p2", SoyadTxt.Text.Length > 0 ? SoyadTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p3", BransCmb.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@p4", TCTxt.Text.Length > 0 ? TCTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p5", SifreTxt.Text.Length > 0 ? SifreTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p6", _TCNO);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Güncelleme Yapıldı", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
