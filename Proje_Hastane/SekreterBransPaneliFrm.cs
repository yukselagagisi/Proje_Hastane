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
    public partial class SekreterBransPaneliFrm : Form
    {
        SekreterDetayFrm _sekreterDetayFrm;
        public SekreterBransPaneliFrm(SekreterDetayFrm sekreterDetayFrm)
        {
            InitializeComponent();
            _sekreterDetayFrm = sekreterDetayFrm;
        }

        private void BransListele() 
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TBLBRANSLAR", conn))
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

        private void SekreterBransPaneliFrm_Load(object sender, EventArgs e)
        {
            BransListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; // Headerlara (Column başlıklarına) tıklayınca gelen hatayı kaldırmak için kullanıldı
            IDTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            AdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            switch (dataGridView1.Rows[e.RowIndex].Cells[2].Value)
            {
                case true: AktifRb.Checked = true; break;
                case false: PasifRb.Checked = true; break;
            }
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO TBLBRANSLAR (BRANSAD, BRANSDURUM) VALUES (@p1, @p2)", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", AdTxt.Text.Length > 0 ? AdTxt.Text.ToUpper() : "null");
                    switch (AktifRb.Checked)
                    {
                        case true: cmd.Parameters.AddWithValue("@p2", 1); break;
                        case false: cmd.Parameters.AddWithValue("@p2", 0); break;
                    }
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Branş Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BransListele();
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE TBLBRANSLAR SET BRANSAD = @p1, BRANSDURUM = @p2 WHERE BRANSID = @p3", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", AdTxt.Text.Length > 0 ? AdTxt.Text.ToUpper() : "null");
                    switch (AktifRb.Checked)
                    {
                        case true: cmd.Parameters.AddWithValue("@p2", 1); break;
                        case false: cmd.Parameters.AddWithValue("@p2", 0); break;
                    }
                    cmd.Parameters.AddWithValue("@p3", IDTxt.Text.Length > 0 ? Convert.ToInt32(IDTxt.Text) : -1);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Branş Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BransListele();
        }
    }
}
