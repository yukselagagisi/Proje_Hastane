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
    public partial class HastaGirisFrm : Form
    {
        AnaSayfaFrm _anaSayfaFrm;
        public HastaGirisFrm(AnaSayfaFrm anaSayfaFrm)
        {
            InitializeComponent();
            _anaSayfaFrm = anaSayfaFrm;
        }

        private void HastaGirisFrm_Load(object sender, EventArgs e)
        {

        }

        private void HastaGirisFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _anaSayfaFrm.Show();
        }

        private void UyeOlLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayitFrm hastaKayitFrm = new HastaKayitFrm(this);
            hastaKayitFrm.Show();
            this.Hide();
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TBLHASTALAR WHERE HASTATC = @p1 AND HASTASIFRE = @p2", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", TCTxt.Text);
                    cmd.Parameters.AddWithValue("@p2", SifreTxt.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        HastaDetayFrm hastaDetayFrm = new HastaDetayFrm(this, TCTxt.Text);
                        hastaDetayFrm.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("TC No ve/veya şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dr.Close();
                }
                conn.Close();
            }
        }
    }
}
