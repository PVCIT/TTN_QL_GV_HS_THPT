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
using QL_GV_HS_THPT_DAL;
using QL_GV_HS_THPT_FORM;
using QL_QV_HS_THPT_Entity;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace QL_GV_HS_THPT_FORM
{
    public partial class frmHocsinh : Form
    {
        private bool _dangTimMa = false;
        private bool _dangTimHo = false;
        private bool _dangTimTen = false;
        private bool _dangTimMaLop = false;
        private bool _dangTimDanToc = false;
        private bool _dangTimTonGiao = false;

        private BUS_tblHocSinh busHS = new BUS_tblHocSinh();
        public frmHocsinh()
        {
            InitializeComponent();
        }
        public frmHocsinh(string action)
        {
            InitializeComponent();
            if (action=="TimKiem")
            grbThongTinHocSinh.Enabled = false;
            btnLamMoiDuLieu.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblGT_Click(object sender, EventArgs e)
        {

        }

        private void lblTonGiao_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Dispose();
        }

        private void txtTimMaHS_Click(object sender, EventArgs e)
        {
            if (_dangTimMa)
            {
                txtTimMaHS.SelectionStart = txtTimMaHS.Text.Length;
            }
            else
            {
                txtTimMaHS.SelectAll();
            }
        }

        private void txtTimHoHS_Click(object sender, EventArgs e)
        {
            if (_dangTimHo)
            {
                txtTimHoHS.SelectionStart = txtTimHoHS.Text.Length;
            }
            else
            {
                txtTimHoHS.SelectAll();
            }
        }

        private void txtTimTenHS_Click(object sender, EventArgs e)
        {
            if (_dangTimTen)
            {
                txtTimTenHS.SelectionStart = txtTimTenHS.Text.Length;
            }
            else
            {
                txtTimTenHS.SelectAll();
            }
        }

        private void cboTimMaLop_Click(object sender, EventArgs e)
        {
            cboTimMaLop.SelectionStart = cboTimMaLop.Text.Length;
            BUS_tblHocSinh busHs = new BUS_tblHocSinh();
            DataTable tb = busHs.getField("MaLop");
            cboTimMaLop.Items.Clear();
            cboTimMaLop.Items.Add("Tất cả");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cboTimMaLop.Items.Add(tb.Rows[i]["MaLop"].ToString());
            }
        }

        private void cboTimDanToc_Click(object sender, EventArgs e)
        {
            cboTimDanToc.SelectionStart = cboTimDanToc.Text.Length;
            BUS_tblHocSinh busHs = new BUS_tblHocSinh();
            DataTable tb = busHs.getField("DanToc");
            cboTimDanToc.Items.Clear();
            cboTimDanToc.Items.Add("Tất cả");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cboTimDanToc.Items.Add(tb.Rows[i]["DanToc"].ToString());
            }
        }

        private void cboTimTonGiao_Click(object sender, EventArgs e)
        {
            cboTimTonGiao.SelectionStart = cboTimTonGiao.Text.Length;
            BUS_tblHocSinh busHs = new BUS_tblHocSinh();
            DataTable tb = busHs.getField("TonGiao");
            cboTimTonGiao.Items.Clear();
            cboTimTonGiao.Items.Add("Tất cả");
            for(int i = 0; i < tb.Rows.Count; i++)
            {
                cboTimTonGiao.Items.Add(tb.Rows[i]["TonGiao"].ToString());
            }
        }

        private void frmHocsinh_Load(object sender, EventArgs e)
        {
            DataTable tbl = busHS.getAllHocsinh();
            dgvHocSinh.DataSource = tbl;
        }

        private void txtTimMaHS_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMaHS.Text != "") _dangTimMa = true;
            else _dangTimMa = false;
            string dieukien = "where MaHS like N'%" + txtTimMaHS.Text + "%'";
            if (_dangTimHo) dieukien += "AND Ho like N'%" + txtHo.Text + "%'";
            if (_dangTimTen) dieukien += "AND Ten like N'%" + txtTen.Text + "%'";
            if (_dangTimMaLop)
            {
                if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimDanToc.Text + "%'";
            }
            if (_dangTimDanToc)
            {
                if (cboTimDanToc.SelectedIndex != 0) dieukien += "AND DanToc like N'%" + cboTimDanToc.Text + "%'";
            }
            if (_dangTimTonGiao)
            {
                if (cboTimTonGiao.SelectedIndex != 0) dieukien += "AND TonGiao like N'%" + cboTimTonGiao.Text + "%'";
            }
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }
     
        private void txtTimHo_TextChanged(object sender, EventArgs e)
        {
            if (txtTimHoHS.Text != "") _dangTimHo = true;
            else _dangTimHo = false;
            string dieukien = "where Ho like N'%" + txtTimHoHS.Text + "%'";
            if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
            if (_dangTimHo) dieukien += "AND Ho like N'%" + txtHo.Text + "%'";
            if (_dangTimMaLop)
            {
                if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimMaLop.Text + "%'";
            }
            if (_dangTimDanToc)
            {
                if (cboTimDanToc.SelectedIndex != 0) dieukien += "AND DanToc like N'%" + cboTimDanToc.Text + "%'";
            }
            if (_dangTimTonGiao)
            {
                if (cboTimTonGiao.SelectedIndex != 0) dieukien += "AND TonGiao like N'%" + cboTimTonGiao.Text + "%'";
            }
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }
        private void cboTimDanToc_TextChanged(object sender, EventArgs e)
        {
            if (cboTimDanToc.SelectedIndex != 0) _dangTimDanToc = true;
            else _dangTimDanToc = false;
            string dieukien = "";
            if (cboTimDanToc.SelectedIndex == 0) dieukien = "where DanToc like N'%'";
            else dieukien = "where DanToc like N'%" + cboTimDanToc.Text + "%'";
            if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
            if (_dangTimHo) dieukien += "AND Ho like N'%" + txtHo.Text + "%'";
            if (_dangTimMaLop)
            {
                if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimMaLop.Text + "%'";
            }
            if (_dangTimTonGiao)
            {
                if (cboTimTonGiao.SelectedIndex != 0) dieukien += "AND TonGiao like N'%" + cboTimTonGiao.Text + "%'";
            }
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }
        private void cboTimTonGiao_TextChanged(object sender, EventArgs e)
        {
            if (cboTimTonGiao.SelectedIndex != 0) _dangTimTonGiao = true;
            else _dangTimTonGiao = false;
            string dieukien = "";
            if (cboTimTonGiao.SelectedIndex == 0) dieukien = "where TonGiao like N'%'";
            else dieukien = "where TonGiao like N'%" + cboTimTonGiao.Text + "%'";
            if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
            if (_dangTimHo) dieukien += "AND Ho like N'%" + txtHo.Text + "%'";
            if (_dangTimMaLop)
            {
                if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimMaLop.Text + "%'";
            }
            if (_dangTimDanToc)
            {
                if (cboTimDanToc.SelectedIndex != 0) dieukien += "AND DanToc like N'%" + cboTimDanToc.Text + "%'";
            }
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }
        private void txtTimTenHS_Enter(object sender, EventArgs e)
        {
            txtTen.SelectionStart = txtTen.Text.Length;
        }
        private void txtTimHoHS_Enter(object sender, EventArgs e)
        {
            txtHo.SelectionStart = txtHo.Text.Length;
        }
        private void txtTimMaHS_Enter(object sender, EventArgs e)
        {
            txtMaHS.SelectionStart = txtMaHS.Text.Length;
        }
        private void txtTimMaLop_Enter(object sender, EventArgs e)
        {
            cboMaLop.SelectionStart = cboMaLop.Text.Length;
        }
        private void txtTimDanToc_Enter(object sender, EventArgs e)
        {
            cboDanToc.SelectionStart = cboDanToc.Text.Length;
        }
        private void txtTimTonGiao_Enter(object sender, EventArgs e)
        {
            cboTonGiao.SelectionStart = cboTonGiao.Text.Length;
        }

        private void txtTimTenHS_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTenHS.Text != "") _dangTimTen = true;
            else _dangTimTen = false;
            string dieukien = "where Ten like N'%" + txtTimTenHS.Text + "%'";
            if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
            if (_dangTimTen) dieukien += "AND Ten like N'%" + txtTen.Text + "%'";
            if (_dangTimMaLop)
            {
                if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimMaLop.Text + "%'";
            }
            if (_dangTimDanToc)
            {
                if (cboTimDanToc.SelectedIndex != 0) dieukien += "AND DanToc like N'%" + cboTimDanToc.Text + "%'";
            }
            if (_dangTimTonGiao)
            {
                if (cboTimTonGiao.SelectedIndex != 0) dieukien += "AND TonGiao like N'%" + cboTimTonGiao.Text + "%'";
            }
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }

        private void cboTimMaLop_TextChanged(object sender, EventArgs e)
        {
            if (cboTimMaLop.SelectedIndex != 0) _dangTimMaLop = true;
            else _dangTimMaLop = false;
            string dieukien = "";
            if (cboTimMaLop.SelectedIndex == 0) dieukien = "where MaLop like N'%'";
            else dieukien = "where MaLop like N'%" + cboTimMaLop.Text + "%'";
            if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
            if (_dangTimHo) dieukien += "AND Ho like N'%" + txtHo.Text + "%'";
            if (_dangTimTonGiao)
            {
                if (cboTimTonGiao.SelectedIndex != 0) dieukien += "AND TonGiao like N'%" + cboTimTonGiao.Text + "%'";
            }
            if (_dangTimDanToc)
            {
                if (cboTimDanToc.SelectedIndex != 0) dieukien += "AND DanToc like N'%" + cboTimDanToc.Text + "%'";
            }
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }

        private void frmHocsinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Dispose();
        }
    }
}
