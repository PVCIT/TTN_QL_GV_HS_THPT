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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void nhậpHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocsinh frmHS = new frmHocsinh("TimKiem");
            this.Hide();
            
            //frmHS.TopLevel = false;
           // pnlMain.Controls.Add(frmGV);
            frmHS.Show();
        }

        private void thêmGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimGV frmGV = new frmTimGV();
            this.Hide();
            frmGV.Show();
        }
    }
}
