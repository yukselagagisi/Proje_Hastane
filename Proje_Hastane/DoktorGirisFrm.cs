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
    public partial class DoktorGirisFrm : Form
    {
        AnaSayfaFrm _anaSayfaFrm;
        public DoktorGirisFrm(AnaSayfaFrm anaSayfaFrm)
        {
            InitializeComponent();
            _anaSayfaFrm = anaSayfaFrm;
        }

        private void DoktorGirisFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _anaSayfaFrm.Show();
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString)) 
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDOKTORLAR WHERE DOKTORTC = @p1 AND DOKTORSIFRE = @p2", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", TCTxt.Text);
                    cmd.Parameters.AddWithValue("@p2", SifreTxt.Text);

                    using (SqlDataReader dr = cmd.ExecuteReader()) 
                    {
                        if (dr.Read()) 
                        {
                            DoktorDetayFrm doktorDetayFrm = new DoktorDetayFrm(this, TCTxt.Text);
                            doktorDetayFrm.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("TC No ve/veya şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                conn.Close();
            }
        }
    }
}
