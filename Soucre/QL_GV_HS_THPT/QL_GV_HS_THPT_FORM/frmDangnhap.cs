using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_GV_HS_THPT_BUS;

namespace QL_GV_HS_THPT_FORM
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }
        BUS_tblUser bus_User = new BUS_tblUser();
        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == null)
            {
                MessageBox.Show("Chưa nhập tên đăng nhập !");
            }
            if(txtPassword.Text == null)
            {
                MessageBox.Show("Chưa nhập mật khẩu !");
            }
            if(bus_User.checkLogin(txtUsername.Text, txtPassword.Text) != null)
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckcHienpw_CheckedChanged(object sender, EventArgs e)
        {
            if(ckcHienpw.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
