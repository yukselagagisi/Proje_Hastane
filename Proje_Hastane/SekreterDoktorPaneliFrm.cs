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
    public partial class SekreterDoktorPaneliFrm : Form
    {
        SekreterDetayFrm _sekreterDetayFrm;
        public SekreterDoktorPaneliFrm(SekreterDetayFrm sekreterDetayFrm)
        {
            InitializeComponent();
            _sekreterDetayFrm = sekreterDetayFrm;
        }

        private void DoktorListele()
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT DOKTORID ID, DOKTORAD AD, DOKTORSOYAD SOYAD, TBLBRANSLAR.BRANSAD BRANŞ, DOKTORTC TC, DOKTORSIFRE ŞİFRE FROM TBLDOKTORLAR LEFT JOIN TBLBRANSLAR ON TBLDOKTORLAR.DOKTORBRANS = TBLBRANSLAR.BRANSID", conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void SekreterDoktorPaneliFrm_Load(object sender, EventArgs e)
        {
            DoktorListele();

            // Branş Comboboxını Doldurma
            foreach (DataRow brans in _sekreterDetayFrm.Branslar)
            {
                BransCmb.Items.Add(brans[1]);
            }
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO TBLDOKTORLAR (DOKTORAD, DOKTORSOYAD, DOKTORBRANS, DOKTORTC, DOKTORSIFRE) VALUES (@p1, @p2, @p3, @p4, @p5)", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", AdTxt.Text.Length > 0 ? AdTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p2", SoyadTxt.Text.Length > 0 ? SoyadTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p3", BransCmb.Text.Length > 0 ? BransCmb.SelectedValue : -1);
                    cmd.Parameters.AddWithValue("@p4", TCNOTxt.Text.Length > 0 ? TCNOTxt.Text : "00000000000");
                    cmd.Parameters.AddWithValue("@p5", SifreTxt.Text.Length > 0 ? SifreTxt.Text : "null");
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Doktor Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DoktorListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; // Headerlara (Column başlıklarına) tıklayınca gelen hatayı kaldırmak için kullanıldı

            AdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            SoyadTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            BransCmb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TCNOTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            SifreTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM TBLDOKTORLAR WHERE DOKTORTC = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", TCNOTxt.Text.Length > 0 ? TCNOTxt.Text : "00000000000");
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Doktor Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DoktorListele();
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE TBLDOKTORLAR SET DOKTORAD = @p1, DOKTORSOYAD = @p2, DOKTORBRANS = @p3, DOKTORSIFRE = @p4 WHERE DOKTORTC = @p5", conn)) 
                {
                    cmd.Parameters.AddWithValue("@p1", AdTxt.Text.Length > 0 ? AdTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p2", SoyadTxt.Text.Length > 0 ? SoyadTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p3", BransCmb.Text.Length > 0 ? BransCmb.SelectedValue : -1);
                    cmd.Parameters.AddWithValue("@p4", SifreTxt.Text.Length > 0 ? SifreTxt.Text.ToUpper() : "null");
                    cmd.Parameters.AddWithValue("@p5", TCNOTxt.Text.Length > 0 ? TCNOTxt.Text.ToUpper() : "00000000000");
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Doktor Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DoktorListele();
            }
        }
    }
}
