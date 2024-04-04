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
    public partial class SekreterRandevuListesiFrm : Form
    {
        SekreterDetayFrm _sekreterDetayFrm;
        int _randevuID;
        public SekreterRandevuListesiFrm(SekreterDetayFrm sekreterDetayFrm)
        {
            InitializeComponent();
            _sekreterDetayFrm = sekreterDetayFrm;
        }

        private void SekreterRandevuListesiFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _sekreterDetayFrm.RandevuID = _randevuID;
            _sekreterDetayFrm.IDCek();
        }

        private void SekreterRandevuListesiFrm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString)) 
            {
                using (SqlCommand cmd = new SqlCommand("SELECT RANDEVUID ID, RANDEVUTARIHSAAT AS 'TARİH SAAT', BRANSAD BRANŞ, DOKTORAD + ' ' + DOKTORSOYAD DOKTOR, RANDEVUDURUM DURUM, RANDEVUHASTA HASTA, RANDEVUDETAY DETAY FROM TBLRANDEVULAR LEFT JOIN TBLBRANSLAR ON RANDEVUBRANS = BRANSID LEFT JOIN TBLDOKTORLAR ON RANDEVUDOKTOR = DOKTORID", conn)) 
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; // Headerlara (Column başlıklarına) tıklayınca gelen hatayı kaldırmak için kullanıldı
            _randevuID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
