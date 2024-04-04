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
    public partial class SekreterGirisFrm : Form
    {
        AnaSayfaFrm _anaSayfaFrm;
        public SekreterGirisFrm(AnaSayfaFrm anaSayfaFrm)
        {
            InitializeComponent();
            _anaSayfaFrm = anaSayfaFrm;
        }

        private void SekreterGirisFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _anaSayfaFrm.Show();
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TBLSEKRETERLER WHERE SEKRETERTC = @p1 AND SEKRETERSIFRE = @p2", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", TCTxt.Text);
                    cmd.Parameters.AddWithValue("@p2", SifreTxt.Text);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            SekreterDetayFrm sekreterDetayFrm = new SekreterDetayFrm(this, TCTxt.Text);
                            sekreterDetayFrm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("TC No ve/veya şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dr.Close();
                    }
                }
                conn.Close();
            }
        }
    }
}
