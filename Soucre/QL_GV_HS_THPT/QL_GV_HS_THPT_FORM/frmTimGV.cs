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
    public partial class frmTimGV : Form
    {
        private bool _dangTimMaGV = false;
        private bool _dangTimHoGV = false;
        private bool _dangTimTenGV = false;
        private bool _dangTimMaMon = false;
        private bool _dangTimDiaChi = false;
        
        private BUS_tblGiaovien busGV = new BUS_tblGiaovien();
        public frmTimGV()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void txtTimMaGV_Click(object sender, EventArgs e)
        {
            if (_dangTimMaGV)
            {
                txtTimMaGV.SelectionStart = txtTimMaGV.Text.Length;
            }
            else
            {
                txtTimMaGV.SelectAll();
            }            
        }

        private void txtTimHoGV_Click(object sender, EventArgs e)
        {
            if (_dangTimHoGV)
            {
                txtTimHoGV.SelectionStart = txtTimHoGV.Text.Length;
            }
            else
            {
                txtTimHoGV.SelectAll();
            } 
        }

        private void txtTimTenGV_Click(object sender, EventArgs e)
        {
            if (_dangTimTenGV)
            {
                txtTimTenGV.SelectionStart = txtTimTenGV.Text.Length;
            }
            else
            {
                txtTimTenGV.SelectAll();
            } 
        }

        private void cboTimMaMon_Click(object sender, EventArgs e)
        {
            cboTimMaMon.SelectionStart = cboTimMaMon.Text.Length;
            BUS_tblGiaovien busGV = new BUS_tblGiaovien();
            DataTable tb = busGV.getField("MaMon");
            cboTimMaMon.Items.Clear();
            cboTimMaMon.Items.Add("Tất cả");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cboTimMaMon.Items.Add(tb.Rows[i]["MaMon"].ToString());
            }
        }

        private void cboTimDiaChi_Click(object sender, EventArgs e)
        {
            cboTimDiaChi.SelectionStart = cboTimDiaChi.Text.Length;
            BUS_tblGiaovien busGV = new BUS_tblGiaovien();
            DataTable tb = busGV.getField("DiaChi");
            cboTimDiaChi.Items.Clear();
            cboTimDiaChi.Items.Add("Tất cả");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cboTimDiaChi.Items.Add(tb.Rows[i]["DiaChi"].ToString());
            }
        }

        private void txtTimMaGV_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMaGV.Text != "") _dangTimMaGV = true;
            else _dangTimMaGV = false;
            string dieukien = "where MaGV like N'%" + txtTimMaGV.Text + "%'";
            if (_dangTimHoGV) dieukien += "AND Ho like N'%" + txtTimHoGV.Text + "%'";
            if (_dangTimTenGV) dieukien += "AND Ten like N'%" + txtTimTenGV.Text + "%'";
            if (_dangTimMaMon)
            {
                if (cboTimMaMon.SelectedIndex != 0) dieukien += "AND MaMon like N'%" + cboTimMaMon.Text + "%'";
            }
            if (_dangTimDiaChi)
            {
                if (cboTimDiaChi.SelectedIndex != 0) dieukien += "AND DiaChi like N'%" + cboTimDiaChi.Text + "%'";
            }
            DataTable tbl = busGV.getGiaovien(dieukien);
            dgvGiaoVien.DataSource = tbl;
        }

        private void frmTimGV_Load(object sender, EventArgs e)
        {
            DataTable tbl = busGV.getAllgiaovien();
            dgvGiaoVien.DataSource = tbl;
        }

        private void txtTimHoGV_TextChanged(object sender, EventArgs e)
        {
            if (txtTimHoGV.Text != "") _dangTimHoGV = true;
            else _dangTimHoGV = false;
            string dieukien = "where Ho like N'%" + txtTimHoGV.Text + "%'";
            if (_dangTimMaGV) dieukien += "AND MaGV like N'%" + txtTimMaGV.Text + "%'";
            if (_dangTimTenGV) dieukien += "AND Ten like N'%" + txtTimTenGV.Text + "%'";
            if (_dangTimMaMon)
            {
                if (cboTimMaMon.SelectedIndex != 0) dieukien += "AND MaMon like N'%" + cboTimMaMon.Text + "%'";
            }
            if (_dangTimDiaChi)
            {
                if (cboTimDiaChi.SelectedIndex != 0) dieukien += "AND DiaChi like N'%" + cboTimDiaChi.Text + "%'";
            }
            DataTable tbl = busGV.getGiaovien(dieukien);
            dgvGiaoVien.DataSource = tbl;
        }

        private void txtTimTenGV_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTenGV.Text != "") _dangTimTenGV = true;
            else _dangTimTenGV = false;
            string dieukien = "where MaGV like N'%" + txtTimTenGV.Text + "%'";
            if (_dangTimHoGV) dieukien += "AND Ho like N'%" + txtTimHoGV.Text + "%'";
            if (_dangTimMaGV) dieukien += "AND MaGV like N'%" + txtTimMaGV.Text + "%'";
            if (_dangTimMaMon)
            {
                if (cboTimMaMon.SelectedIndex != 0) dieukien += "AND MaMon like N'%" + cboTimMaMon.Text + "%'";
            }
            if (_dangTimDiaChi)
            {
                if (cboTimDiaChi.SelectedIndex != 0) dieukien += "AND DiaChi like N'%" + cboTimDiaChi.Text + "%'";
            }
            DataTable tbl = busGV.getGiaovien(dieukien);
            dgvGiaoVien.DataSource = tbl;
        }

        private void cboTimMaMon_TextChanged(object sender, EventArgs e)
        {
            if (cboTimMaMon.SelectedIndex != 0) _dangTimMaMon = true;
            else _dangTimMaMon = false;
            string dieukien = "";
            if (cboTimMaMon.SelectedIndex == 0) dieukien = "where MaMon like N'%'";
            else dieukien = "where MaMon like N'%" + cboTimMaMon.Text + "%'";
            if (_dangTimMaGV) dieukien += "AND MaGV like N'%" + txtTimMaGV.Text + "%'";
            if (_dangTimHoGV) dieukien += "AND Ho like N'%" + txtTimHoGV.Text + "%'";
            if (_dangTimTenGV) dieukien += "AND Ten like N'%" + txtTimTenGV.Text + "%'";
            if (_dangTimDiaChi)
            {
                if (cboTimDiaChi.SelectedIndex != 0) dieukien += "AND DiaChi like N'%" + cboTimDiaChi.Text + "%'";
            }
            DataTable tbl = busGV.getGiaovien(dieukien);
            dgvGiaoVien.DataSource = tbl;
        }

        private void cboTimDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (cboTimDiaChi.SelectedIndex != 0) _dangTimDiaChi = true;
            else _dangTimDiaChi = false;
            string dieukien = "";
            if (cboTimDiaChi.SelectedIndex == 0) dieukien = "where DiaChi like N'%'";
            else dieukien = "where DiaChi like N'%" + cboTimDiaChi.Text + "%'";
            if (_dangTimMaGV) dieukien += "AND MaGV like N'%" + txtTimMaGV.Text + "%'";
            if (_dangTimHoGV) dieukien += "AND Ho like N'%" + txtTimHoGV.Text + "%'";
            if (_dangTimTenGV) dieukien += "AND Ten like N'%" + txtTimTenGV.Text + "%'";
            if (_dangTimMaMon)
            {
                if (cboTimMaMon.SelectedIndex != 0) dieukien += "AND MaMon like N'%" + cboTimMaMon.Text + "%'";
            }
            DataTable tbl = busGV.getGiaovien(dieukien);
            dgvGiaoVien.DataSource = tbl;
        }
    }
}
