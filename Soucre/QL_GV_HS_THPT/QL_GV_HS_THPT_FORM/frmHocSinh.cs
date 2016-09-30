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
using System.Data;

namespace QL_GV_HS_THPT_FORM
{
    public partial class frmHocsinh : Form
    {
        public frmHocsinh()
        {
            InitializeComponent();
        }

        private SQL_tblHocsinh DAL_HS = new SQL_tblHocsinh();
        private EC_tblHocsinh EC_HS = new EC_tblHocsinh();
        private SQL_tblLop DAL_Lop = new SQL_tblLop();

        private bool _them = false;
        private void frmHocsinh_Load(object sender, EventArgs e)
        {
            //load from dgv
            DataTable tb = DAL_HS.getAllHocsinh();
            dgvDanhSach.DataSource = tb;
            cboLop.DataSource = DAL_Lop.getAllLop();
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count - 1)
            {
                txtMaHS.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                txtTenHS.Text = dgvDanhSach.Rows[e.RowIndex].Cells["Ho"].Value.ToString() + " " + dgvDanhSach.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                txtDiaChi.Text = dgvDanhSach.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                cboLop.SelectedValue = dgvDanhSach.Rows[e.RowIndex].Cells["Lop"].Value.ToString();
                cboTonGiao.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TonGiao"].Value.ToString();
                cboGT.SelectedItem = dgvDanhSach.Rows[e.RowIndex].Cells["GT"].Value.ToString();
                cboDanToc.Text = dgvDanhSach.Rows[e.RowIndex].Cells["DanToc"].Value.ToString();
                dtpNS.Text = dgvDanhSach.Rows[e.RowIndex].Cells["NS"].Value.ToString();
            }
            if (e.RowIndex >= dgvDanhSach.Rows.Count - 1)
            {
                txtDiaChi.ResetText();
                txtTenHS.ResetText();
                txtMaHS.ResetText();
                txtMaHS.Focus();
                cboGT.ResetText();
                cboDanToc.ResetText();
                cboTonGiao.ResetText();
                dtpNS.ResetText();
                cboLop.ResetText();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            btnLuu.Enabled = true;
            txtDiaChi.ResetText(); txtDiaChi.Enabled = true;
            txtTenHS.ResetText(); txtTenHS.Enabled = true;
            txtMaHS.ResetText(); txtMaHS.Enabled = true;
            txtMaHS.Focus();
            cboGT.SelectedIndex = 0; cboGT.Enabled = true;
            cboDanToc.SelectedIndex = 0; cboDanToc.Enabled = true;
            cboTonGiao.SelectedIndex = 0; cboTonGiao.Enabled = true;
            dtpNS.Value = new DateTime(DateTime.Today.Year - 16,1,1); dtpNS.Enabled = true;
            cboLop.ResetText(); cboLop.Enabled = true;
            dgvDanhSach.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            EC_HS.MaHS = txtMaHS.Text;
            tach(txtTenHS.Text);
            EC_HS.Ho = _Ho;
            EC_HS.Ten = _Ten;
            EC_HS.NgaySinh = dtpNS.Text;
            EC_HS.GT = cboGT.Text;
            EC_HS.DanToc = cboDanToc.Text;
            EC_HS.TonGiao = cboTonGiao.Text;
            EC_HS.MaLop = cboLop.SelectedValue.ToString();
            EC_HS.DiaChi = txtDiaChi.Text;
            if (EC_HS.MaHS != "")
            {
                if (_them)
                {
                    DAL_HS.addHocsinh(EC_HS);
                    dgvDanhSach.DataSource = DAL_HS.getAllHocsinh();
                    _them = false;
                }
                else
                {
                    DAL_HS.updateHocsinh(EC_HS);
                    dgvDanhSach.DataSource = DAL_HS.getAllHocsinh();
                }
            }
            btnLuu.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTenHS.Enabled = false;
            txtMaHS.Enabled = false;
            cboGT.Enabled = false;
            cboDanToc.Enabled = false;
            cboTonGiao.Enabled = false;
            dtpNS.Enabled = false;
            cboLop.Enabled = false;
            dgvDanhSach.Enabled = true;
        }

        private static string _Ho = "";
        private static string _Ten = "";
        private void tach(string vao)
        {
            char[] temp = vao.ToCharArray();
            int _i = vao.Length-1;
            bool _chuathayten = true;
            if (_i > 0)
            {
                while (temp[_i] != ' ' || _chuathayten)
                {
                    if (temp[_i] != ' ') _chuathayten = false;
                    _i--;
                }
                _Ho = vao.Substring(0, _i);
                _Ten = vao.Substring(_i + 1);
            }   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTenHS.Enabled = true;
            cboGT.Enabled = true;
            cboDanToc.Enabled = true;
            cboTonGiao.Enabled = true;
            dtpNS.Enabled = true;
            cboLop.Enabled = true;
            dgvDanhSach.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            EC_HS.MaHS = txtMaHS.Text;
            if (EC_HS.MaHS != "") DAL_HS.delHocsinh(EC_HS);
            dgvDanhSach.DataSource = DAL_HS.getAllHocsinh();
        }

    }
}
