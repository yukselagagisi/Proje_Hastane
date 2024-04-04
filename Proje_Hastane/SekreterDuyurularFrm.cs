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
    public partial class SekreterDuyurularFrm : Form
    {
        public SekreterDuyurularFrm()
        {
            InitializeComponent();
        }

        private void SekreterDuyurularFrm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLBaglantisi.connectionString)) 
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDUYURULAR", conn)) 
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
    }
}
