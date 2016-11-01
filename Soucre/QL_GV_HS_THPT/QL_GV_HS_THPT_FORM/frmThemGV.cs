using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_GV_HS_THPT_DAL;
using QL_QV_HS_THPT_Entity;
namespace QL_GV_HS_THPT_FORM
{
    public partial class frmThemGV : Form
    {
        SQL_tblGiaovien giaovien = new SQL_tblGiaovien();
        EC_tblGiaovien gv = new EC_tblGiaovien();
        public void SetNull()
        {
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtGV.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
        }
        public frmThemGV()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmThemGV_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SQL_tblMonhoc monhoc = new SQL_tblMonhoc();
            dt = monhoc.getAllMonhoc();
            cbMH.DataSource = dt;
            cbMH.DisplayMember = "MaMon";
            cbTenMH.DataSource = dt;
            cbTenMH.DisplayMember = "TenMon"; 
        }

        private void dtp_FormatChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtGV.Text == "")
            {
                lbMessage.Text = "Bạn chưa điền đủ thông tin!!!";
                return;
            }
            else
            {
                gv.MaGV = txtGV.Text;
                gv.MaMon = cbMH.Text;
                gv.Ho = txtHo.Text;
                gv.Ten = txtTen.Text;
                gv.NgaySinh = dtp.Value.ToShortDateString();
                gv.SDT = txtSDT.Text;
                gv.DiaChi = txtDiaChi.Text;
                if (chkNam.Checked == true)
                {
                    gv.GT = "Nam";
                }
                else
                {
                    gv.GT = "Nữ";
                }
                giaovien.addGiaovien(gv);
                MessageBox.Show("Bạn đã lưu thành công!!!", "Thông Báo", MessageBoxButtons.OK);
                SetNull();
            }
            
        }
        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked == true)
            {
                chkNu.Checked = false;
            }
        }
        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked == true)
            {
                chkNam.Checked = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát???","Questions",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
