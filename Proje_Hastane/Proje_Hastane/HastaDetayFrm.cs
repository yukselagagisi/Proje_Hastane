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
    public partial class HastaDetayFrm : Form
    {
        HastaGirisFrm _hastaGirisFrm;
        string _TCNO;
        string _adSoyad;
        public HastaDetayFrm(HastaGirisFrm hastaGirisFrm, string TCNO)
        {
            InitializeComponent();
            _hastaGirisFrm = hastaGirisFrm;
            _TCNO = TCNO;
        }

        public string TCNO
        {
            get { return _TCNO; }
        }

        public string AdSoyad
        {
            get { return _adSoyad; }
        }

        private void HastaDetayFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _hastaGirisFrm.Show();
        }

        private void HastaDetayFrm_Load(object sender, EventArgs e)
        {
            // TC Çekme
            TCLbl.Text = _TCNO;

            // Ad-Soyad Çekme
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT HASTAAD+' '+HASTASOYAD FROM TBLHASTALAR WHERE HASTATC = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", _TCNO);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            AdSoyadLbl.Text = dr[0].ToString();
                        }
                        dr.Close();
                    }
                }
                conn.Close();
            }
            _adSoyad = AdSoyadLbl.Text;

            //Header Çekme
            this.Text = AdSoyadLbl.Text;

            //Randevu Geçmişi Çekme
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT RANDEVUID ID, RANDEVUTARIHSAAT as 'TARİH VE SAAT', RANDEVUBRANS BRANŞ, RANDEVUDOKTOR DOKTOR, RANDEVUDURUM DURUM, RANDEVUHASTA HASTA FROM TBLRANDEVULAR LEFT JOIN TBLHASTALAR ON TBLRANDEVULAR.RANDEVUHASTA = TBLHASTALAR.HASTAID WHERE TBLHASTALAR.HASTATC = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", _TCNO);
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

        private void BransCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox'a Seçilen Branş'ın Doktorunu Çekme
            DoktorCmb.Items.Clear();
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT DOKTORAD + ' ' + DOKTORSOYAD FROM TBLDOKTORLAR LEFT JOIN TBLBRANSLAR ON TBLDOKTORLAR.DOKTORBRANS = TBLBRANSLAR.BRANSID WHERE TBLBRANSLAR.BRANSAD = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", BransCmb.Text.Length > 0 ? BransCmb.Text : "null");
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DoktorCmb.Items.Add(dr[0]);
                        }
                        dr.Close();
                    }
                }
                conn.Close();
            }
        }

        private void DoktorCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TBLRANDEVULAR.RANDEVUID ID, TBLRANDEVULAR.RANDEVUTARIHSAAT AS 'TARİH/SAAT', TBLBRANSLAR.BRANSAD BRANŞ, TBLDOKTORLAR.DOKTORAD + ' ' + TBLDOKTORLAR.DOKTORSOYAD DOKTOR, TBLRANDEVULAR.RANDEVUDURUM DURUM FROM TBLRANDEVULAR LEFT JOIN TBLDOKTORLAR ON TBLRANDEVULAR.RANDEVUDOKTOR = TBLDOKTORLAR.DOKTORID LEFT JOIN TBLBRANSLAR ON TBLRANDEVULAR.RANDEVUBRANS = TBLBRANSLAR.BRANSID WHERE TBLDOKTORLAR.DOKTORAD = @p1 AND TBLDOKTORLAR.DOKTORSOYAD = @p2 AND TBLRANDEVULAR.RANDEVUDURUM = 1 ", conn))
                {
                    string[] doktorCmbArray = DoktorCmb.Text.Split(' ');

                    cmd.Parameters.AddWithValue("@p1", doktorCmbArray[0].Length > 0 ? doktorCmbArray[0] : "null");
                    cmd.Parameters.AddWithValue("@p2", !string.IsNullOrEmpty(doktorCmbArray[1]) ? doktorCmbArray[1].Trim() : doktorCmbArray[2].Trim());
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void DuzenleLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaBilgiDuzenleFrm hastaBilgiDuzenleFrm = new HastaBilgiDuzenleFrm(this);
            hastaBilgiDuzenleFrm.Show();
            this.Hide();
        }

        private void RandevuAlBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT HASTAID FROM TBLHASTALAR WHERE HASTATC = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", TCLbl.Text);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();

                        using (SqlCommand cmd2 = new SqlCommand("UPDATE TBLRANDEVULAR SET RANDEVUHASTA = @p2, RANDEVUDETAY = @p3, RANDEVUDURUM = 0 WHERE RANDEVUID = @p4", conn)) 
                        {
                            cmd2.Parameters.AddWithValue("@p2", Convert.ToInt32(dr[0]));
                            cmd2.Parameters.AddWithValue("@p3", NotTxt.Text);
                            cmd2.Parameters.AddWithValue("@p4", IDTxt.Text);

                            dr.Close();
                            cmd2.ExecuteNonQuery();
                        }
                    }

                }
                MessageBox.Show("Randevu Alındı", "Randevu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; // Headerlara (Column başlıklarına) tıklayınca gelen hatayı kaldırmak için kullanıldı
            IDTxt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
