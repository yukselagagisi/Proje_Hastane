using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class HastaKayitFrm : Form
    {
        HastaGirisFrm _hastaGirisFrm;
        public HastaKayitFrm(HastaGirisFrm hastaGirisFrm)
        {
            InitializeComponent();
            _hastaGirisFrm = hastaGirisFrm;
        }

        private void HastaKayitFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _hastaGirisFrm.Show();
        }

        private void KayıtYapBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn  = new SqlConnection(SQLBaglantisi.connectionString)) 
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO TBLHASTALAR (HASTAAD, HASTASOYAD, HASTATC, HASTATELEFON, HASTASIFRE, HASTACINSIYET) values (@p1, @p2, @p3, @p4, @p5, @p6)", conn)) 
                {
                    cmd.Parameters.AddWithValue("@p1", AdTxt.Text.Length > 0 ? AdTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p2", SoyadTxt.Text.Length > 0 ? SoyadTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p3", TCTxt.Text.Length > 0 ? TCTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p4", TelefonTxt.Text.Length > 0 ? TelefonTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p5", SifreTxt.Text.Length > 0 ? SifreTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p6", ErkekChk.Checked ? "ERKEK" : "KADIN");
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kaydınız gerçekleşmiştir. Şifreniz: " + SifreTxt.Text , "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }
    }
}
