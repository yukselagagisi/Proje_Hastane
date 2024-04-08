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
    public partial class DoktorDetayFrm : Form
    {
        DoktorGirisFrm _doktorGirisFrm;
        string _TCNO;
        public DoktorDetayFrm(DoktorGirisFrm doktorGirisFrm, string TCNO)
        {
            InitializeComponent();
            _doktorGirisFrm = doktorGirisFrm;
            _TCNO = TCNO;
        }

        private void DoktorDetayFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _doktorGirisFrm.Show();
        }

        private void RandevuListele()
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT RANDEVUID, RANDEVUTARIHSAAT, BRANSAD, HASTAAD + ' ' + HASTASOYAD HASTA, RANDEVUDETAY FROM TBLRANDEVULAR LEFT JOIN TBLBRANSLAR ON RANDEVUBRANS = BRANSID LEFT JOIN TBLDOKTORLAR ON RANDEVUDOKTOR = DOKTORID LEFT JOIN TBLHASTALAR ON RANDEVUHASTA = HASTAID WHERE DOKTORTC = @p1 AND RANDEVUDURUM = 0", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", _TCNO);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void DoktorDetayFrm_Load_1(object sender, EventArgs e)
        {
            TCLbl.Text = _TCNO;

            // Ad soyad çekme   

            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT DOKTORAD, DOKTORSOYAD FROM TBLDOKTORLAR WHERE DOKTORTC = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", _TCNO);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            AdSoyadLbl.Text = dr[0] + " " + dr[1];
                        }
                        dr.Close();
                    }
                }
                conn.Close();
            }

            RandevuListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; // Headerlara (Column başlıklarına) tıklayınca gelen hatayı kaldırmak için kullanıldı
            RandevuDetayTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BilgiDuzenleBtn_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenle doktorBilgiDuzenle = new DoktorBilgiDuzenle(this, _TCNO);
            doktorBilgiDuzenle.Show();
            this.Hide();
        }

        private void DuyurularBtn_Click(object sender, EventArgs e)
        {
            SekreterDuyurularFrm sekreterDuyurularFrm = new SekreterDuyurularFrm();
            sekreterDuyurularFrm.Show();
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
