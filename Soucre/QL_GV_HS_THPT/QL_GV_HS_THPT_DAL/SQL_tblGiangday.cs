using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QV_HS_THPT_Entity;
using System.Data;

namespace QL_GV_HS_THPT_DAL
{
    public class SQL_tblGiangday
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addGiangday(EC_tblGiangday et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblGiangday(MaGV , MaLop, Ngayday, Tietday) values('" + et.MaGV + "','" + et.MaLop + "','" + et.Ngayday + "','" + et.Tietday + "')");
        }
        //Sua du lieu
        public void updateGiangday(EC_tblGiangday et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblGiangday SET Ngayday = '" + et.Ngayday + "', Tietday = '" + et.Tietday + "' WHERE MaGV = '" + et.MaGV + "' and MaLop = '" + et.MaLop + "' and Ngayday = '" + et.Ngayday + "'");
        }
        //Xoa du lieu
        public void delGiangday(EC_tblGiangday et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblGiangday WHERE MaGV = '" + et.MaGV + "' and MaLop = '" + et.MaLop + "' and Tietday = '" + et.Tietday + "' and Ngayday = '" + et.Ngayday + "'");
        }
        //select
        public DataTable getAllGiangday()
        {
            return cn.getDatatable(@"SELECT * FROM tblGiangday ");
        }
        public DataTable getAllGiangday(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblGiangday " + dk);
        }
        //select chi tiet
        public DataTable getThongTinGD()
        {
            return cn.getDatatable(@"SELECT (Ho + ' ' + Ten) as HoTen , Ngayday, Tietday, TenLop FROM tblGiangday, tblGiaovien, tblLop where tblGiangday.MaGV = tblGiaoVien.MaGV and tblGiangday.MaLop = tblLop.MaLop order by HoTen, TenLop");
        }
        public DataTable getThongTinGD(string dk)
        {
            return cn.getDatatable(@"SELECT (Ho + ' ' + Ten) as HoTen , Ngayday, Tietday, TenLop FROM tblGiangday, tblGiaovien, tblLop where tblGiangday.MaGV = tblGiaoVien.MaGV and tblGiangday.MaLop = tblLop.MaLop " + dk + " order by HoTen, TenLop");
        }
    }
}
