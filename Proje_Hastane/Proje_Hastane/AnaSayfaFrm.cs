using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class AnaSayfaFrm : Form
    {
        public AnaSayfaFrm()
        {
            InitializeComponent();
        }

        private void HastaBtn_Click(object sender, EventArgs e)
        {
            HastaGirisFrm hastaGirisFrm = new HastaGirisFrm(this);
            hastaGirisFrm.Show();
            this.Hide();
        }

        private void DoktorBtn_Click(object sender, EventArgs e)
        {
            DoktorGirisFrm doktorGirisFrm = new DoktorGirisFrm(this);
            doktorGirisFrm.Show();
            this.Hide();
        }

        private void SekreterBtn_Click(object sender, EventArgs e)
        {
            SekreterGirisFrm sekreterGirisFrm = new SekreterGirisFrm(this);
            sekreterGirisFrm.Show();
            this.Hide();
        }

        private void AnaSayfaFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
