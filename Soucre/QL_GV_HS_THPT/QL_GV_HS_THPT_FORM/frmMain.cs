using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GV_HS_THPT_FORM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void danhSáchGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiaovien gv = new frmGiaovien();
            gv.Show();
        }

        private void thêmGiáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThemGV gv = new frmThemGV();
            gv.Show();
        }
    }
}
