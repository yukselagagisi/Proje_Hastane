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
using System.Windows.Forms.VisualStyles;

namespace Proje_Hastane
{
    public partial class SekreterDetayFrm : Form
    {
        SekreterGirisFrm _sekreterGirisFrm;
        string _TCNO;
        DataTable _branslar = new DataTable();
        System.Int32 _randevuID;

        public SekreterDetayFrm(SekreterGirisFrm sekreterGirisFrm, string TCNO)
        {
            InitializeComponent();
            _sekreterGirisFrm = sekreterGirisFrm;
            _TCNO = TCNO;
        }

        public DataTable Branslar
        {
            get { return _branslar; }
        }

        public System.Int32 RandevuID
        {
            set { _randevuID = value; }
        }

        public void IDCek()
        {
            IDTxt.Text = _randevuID.ToString();
        }

        private void SekreterDetayFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _sekreterGirisFrm.Show();
        }

        private void SekreterDetayFrm_Load(object sender, EventArgs e)
        {
            TCLbl.Text = _TCNO;



            // Ad Soyad Çekme
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT SEKRETERADSOYAD FROM TBLSEKRETERLER WHERE SEKRETERTC = @p1", conn))
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

            // Branşları tabloya çekme
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT BRANSID ID, BRANSAD BRANŞ FROM TBLBRANSLAR WHERE BRANSDURUM = 1", conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        // Branşları comboboxa çekme
                        BransCmb.ValueMember = "ID";
                        BransCmb.DisplayMember = "BRANŞ";
                        BransCmb.DataSource = dt;
                        BransCmb.SelectedIndex = -1;

                        _branslar = dt;
                    }
                }
                conn.Close();
            }

            // Doktorları tabloya çekme
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TBLDOKTORLAR.DOKTORAD + ' ' + TBLDOKTORLAR.DOKTORSOYAD AS 'AD SOYAD', TBLBRANSLAR.BRANSAD BRANŞ FROM TBLDOKTORLAR LEFT JOIN TBLBRANSLAR ON TBLDOKTORLAR.DOKTORBRANS = TBLBRANSLAR.BRANSID", conn))
                {
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

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                string[] doktorCmbArray = DoktorCmb.Text.Split(' ');

                using (SqlCommand cmd = new SqlCommand("SELECT DOKTORID FROM TBLDOKTORLAR WHERE DOKTORAD = @p1 AND DOKTORSOYAD = @p2", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", !string.IsNullOrEmpty(doktorCmbArray[0]) ? doktorCmbArray[0] : "null");
                    cmd.Parameters.AddWithValue("@p2", !string.IsNullOrEmpty(doktorCmbArray[1]) ? doktorCmbArray[1] : doktorCmbArray[2]);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dr.Read();

                            using (SqlCommand cmd2 = new SqlCommand("INSERT INTO TBLRANDEVULAR (RANDEVUTARIHSAAT, RANDEVUBRANS, RANDEVUDOKTOR, RANDEVUDURUM) VALUES (@p3, @p4, @p5, @p6)", conn))
                            {
                                cmd2.Parameters.AddWithValue("@p3", TarihDtp.Text);
                                cmd2.Parameters.AddWithValue("@p4", BransCmb.SelectedValue);
                                cmd2.Parameters.AddWithValue("@p5", dr[0]);

                                switch (AktifRb.Checked)
                                {
                                    case true: cmd2.Parameters.AddWithValue("@p6", "1"); break;
                                }
                                switch (PasifRb.Checked)
                                {
                                    case true: cmd2.Parameters.AddWithValue("@p6", "0"); break;
                                }
                                dr.Close();
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }

                conn.Close();
            }

            MessageBox.Show("Randevu Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BransCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Doktorları comboboxa çekme
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TBLDOKTORLAR.DOKTORID ,TBLDOKTORLAR.DOKTORAD + ' ' + TBLDOKTORLAR.DOKTORSOYAD AS 'AD SOYAD', TBLBRANSLAR.BRANSAD BRANŞ FROM TBLDOKTORLAR LEFT JOIN TBLBRANSLAR ON TBLDOKTORLAR.DOKTORBRANS = TBLBRANSLAR.BRANSID WHERE TBLBRANSLAR.BRANSID = @p1", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", BransCmb.Text.Length > 0 ? BransCmb.SelectedIndex + 1 : -1);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) 
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        DoktorCmb.ValueMember = "DOKTORID";
                        DoktorCmb.DisplayMember = "AD SOYAD";
                        DoktorCmb.DataSource = dt;
                    }
                }
            }
        }

        private void OlusturBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO TBLDUYURULAR (DUYURU) VALUES (@p1) ", conn))
                {
                    cmd.Parameters.AddWithValue("@p1", DuyuruOlusturTxt.Text.Length > 0 ? DuyuruOlusturTxt.Text : "null");
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Duyuru Oluşturuldu", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DuyuruOlusturTxt.Clear();
        }

        private void DoktorPaneliBtn_Click(object sender, EventArgs e)
        {
            SekreterDoktorPaneliFrm sekreterDoktorPaneliFrm = new SekreterDoktorPaneliFrm(this);
            sekreterDoktorPaneliFrm.Show();
        }

        private void BransPaneliBtn_Click(object sender, EventArgs e)
        {
            SekreterBransPaneliFrm sekreterBransPaneliFrm = new SekreterBransPaneliFrm(this);
            sekreterBransPaneliFrm.Show();
        }

        private void RandevuListesiBtn_Click(object sender, EventArgs e)
        {
            SekreterRandevuListesiFrm sekreterRandevuListesiFrm = new SekreterRandevuListesiFrm(this);
            sekreterRandevuListesiFrm.Show();
        }

        private void DuyurularBtn_Click(object sender, EventArgs e)
        {
            SekreterDuyurularFrm sekreterDuyurularFrm = new SekreterDuyurularFrm();
            sekreterDuyurularFrm.Show();
        }
    }
}
