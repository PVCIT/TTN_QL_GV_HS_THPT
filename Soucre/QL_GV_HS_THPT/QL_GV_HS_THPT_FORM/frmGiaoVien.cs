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
        SQL_tblMonhoc mh = new SQL_tblMonhoc();
        DataTable dt = new DataTable();
        public void SetNull()
        {
            txtMaGV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            dtpNS.Value = new DateTime(1900, 1, 1);
            txtSDT.Text = "";
            txtLuong.Text = "";
            //txtMH.Text = "";
            txtDiaChi.Text = "";
        }
        public frmGiaovien()
        {
            InitializeComponent();
        }

        private void frmGiaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_GV_HS_THPTDataSet.tblGiaovien' table. You can move, or remove it, as needed.
            this.tblGiaovienTableAdapter.Fill(this.qL_GV_HS_THPTDataSet.tblGiaovien);
            KhoaDieuKhien();
        }
        public void MoDieuKhien()
        {
            txtMaGV.ReadOnly = false;
            txtHo.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtLuong.ReadOnly = false;
            txtMH.ReadOnly = false;
        }
        public void KhoaDieuKhien()
        {
            txtMaGV.ReadOnly = true;
            txtHo.ReadOnly = true;
            txtTen.ReadOnly = true;
            dtpNS.Value = new DateTime(1900,1,1);
            txtSDT.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtLuong.ReadOnly = true;
            txtMH.ReadOnly = true;

            //button
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            btnRefresh.Enabled = false;
            btnSave.Enabled = false;
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
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnRefresh.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            cbGT.DataSource = gv.GioiTinh();
            cbGT.DisplayMember = "GT";
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

        private void grview_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
            try
            {
                txtMaGV.Text = grview_GV.Rows[dong].Cells[0].Value.ToString();
                txtHo.Text = grview_GV.Rows[dong].Cells[1].Value.ToString();
                txtTen.Text = grview_GV.Rows[dong].Cells[2].Value.ToString();
                cbGT.Text = grview_GV.Rows[dong].Cells[3].Value.ToString();
                dtpNS.Text = grview_GV.Rows[dong].Cells[4].Value.ToString();
                txtSDT.Text = grview_GV.Rows[dong].Cells[5].Value.ToString();
                txtDiaChi.Text = grview_GV.Rows[dong].Cells[6].Value.ToString();
                txtLuong.Text = grview_GV.Rows[dong].Cells[7].Value.ToString();
                txtMH.Text = grview_GV.Rows[dong].Cells[8].Value.ToString();
            }
            catch {}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            teacher.MaGV = txtMaGV.Text;
            teacher.Ho = txtHo.Text;
            teacher.Ten = txtTen.Text;
            teacher.NgaySinh = dtpNS.Value.ToShortDateString();
            teacher.GT = cbGT.Text;
            teacher.Luong = txtLuong.Text;
            teacher.DiaChi = txtDiaChi.Text;
            teacher.MaMon = txtMH.Text;
            teacher.SDT = txtSDT.Text;
            gv.updateGiaovien(teacher);
            MessageBox.Show("Bạn đã cập nhật thành công!!!","Thông Báo",MessageBoxButtons.OK);
        }
    }
}
