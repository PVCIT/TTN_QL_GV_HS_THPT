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
    public partial class frmSuaGV : Form
    {
        SQL_tblGiaovien gv = new SQL_tblGiaovien();
        SQL_tblMonhoc mh = new SQL_tblMonhoc();
        EC_tblGiaovien teacher = new EC_tblGiaovien();
        public frmSuaGV()
        {
            InitializeComponent();
        }

        private void frmSuaGV_Load(object sender, EventArgs e)
        {


            /* DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            // Đổ dữ liệu vào MAGV
            dt = gv.getAllgiaovien();
            cbMaGV.DataSource = dt;
            cbMaGV.DisplayMember = "MaGV";
            //Đổ dữ liệu vào MaMH
            cbMa.DataSource = dt;
            cbMa.DisplayMember = "MaMon";
            txtHo.Text = dt.Rows[0][1].ToString();
            txtTen.Text = dt.Rows[0][2].ToString();
            //Đổ dữ liệu vào Ten MonHoc
            //string dk = "where MaMon = '"+cbMa.Text+"'";
            //dt1 = mh.getMonhoc(dk);
            //cbTen.DataSource = dt1;
            //cbTen.DisplayMember = "TenMon";*/
            LoadGV();
        }
        private void LoadGV()
        {
            lap:
            DataTable dt = gv.getAllgiaovien();
            cbMaGV.DataSource = dt;
            cbMaGV.DisplayMember = "MaGV";
            cbMa.DataSource = dt;
            cbMa.DisplayMember = "MaMon";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cbMaGV.Text == dt.Rows[i][0].ToString())
                {
                    txtHo.Text = dt.Rows[i][1].ToString();
                    txtTen.Text = dt.Rows[i][2].ToString();
                    txtGT.Text = dt.Rows[i][3].ToString();
                    //dtp.Value.ToShortDateString() = dt.Rows[i][4].ToString();
                    txtSDT.Text = dt.Rows[i][5].ToString();
                    txtDiaChi.Text = dt.Rows[i][6].ToString();
                    txtLuong.Text = dt.Rows[i][7].ToString();
                }
                else
                {
                    //goto lap;
                }
                
            }

        }
    }
}
