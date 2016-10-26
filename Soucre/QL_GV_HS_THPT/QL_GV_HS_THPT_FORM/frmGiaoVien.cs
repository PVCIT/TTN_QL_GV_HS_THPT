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
    public partial class frmGiaovien : Form
    {
        SQL_tblGiaovien gv = new SQL_tblGiaovien();
        EC_tblGiaovien teacher = new EC_tblGiaovien();
        public frmGiaovien()
        {
            InitializeComponent();
        }

        private void frmGiaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_GV_HS_THPTDataSet.tblGiaovien' table. You can move, or remove it, as needed.
            this.tblGiaovienTableAdapter.Fill(this.qL_GV_HS_THPTDataSet.tblGiaovien);
            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text",grview_GV.DataSource,"MaGV");
            txtHo.DataBindings.Clear();
            txtHo.DataBindings.Add("Text", grview_GV.DataSource, "Ho");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", grview_GV.DataSource, "Ten");
            txtGT.DataBindings.Clear();
            txtGT.DataBindings.Add("Text", grview_GV.DataSource, "GT");
            txtNS.DataBindings.Clear();
            txtNS.DataBindings.Add("Text", grview_GV.DataSource, "NgaySinh");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", grview_GV.DataSource, "SDT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grview_GV.DataSource, "DiaChi");
            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("Text", grview_GV.DataSource, "Luong");
            txtMH.DataBindings.Clear();
            txtMH.DataBindings.Add("Text", grview_GV.DataSource, "MaMon");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGiaovien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemGV addGV = new frmThemGV();
            addGV.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            grview_GV.DataSource = gv.getAllgiaovien();
            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text", grview_GV.DataSource, "MaGV");
            txtHo.DataBindings.Clear();
            txtHo.DataBindings.Add("Text", grview_GV.DataSource, "Ho");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", grview_GV.DataSource, "Ten");
            txtGT.DataBindings.Clear();
            txtGT.DataBindings.Add("Text", grview_GV.DataSource, "GT");
            txtNS.DataBindings.Clear();
            txtNS.DataBindings.Add("Text", grview_GV.DataSource, "NgaySinh");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", grview_GV.DataSource, "SDT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grview_GV.DataSource, "DiaChi");
            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("Text", grview_GV.DataSource, "Luong");
            txtMH.DataBindings.Clear();
            txtMH.DataBindings.Add("Text", grview_GV.DataSource, "MaMon");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmSuaGV EditGV = new frmSuaGV();
            EditGV.Show();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            teacher.MaGV = txtMaGV.Text;
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn xóa???","Question",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                gv.delGiaovien(teacher);
            }
        }
    }
}
