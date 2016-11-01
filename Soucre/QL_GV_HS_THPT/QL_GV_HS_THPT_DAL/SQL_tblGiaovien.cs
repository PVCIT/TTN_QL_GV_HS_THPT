﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QV_HS_THPT_Entity;
using System.Data;

namespace QL_GV_HS_THPT_DAL
{
    public class SQL_tblGiaovien
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addGiaovien(EC_tblGiaovien et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblGiaovien	(MaGV,Ho,Ten,GT,SDT,NgaySinh,DiaChi,Luong,MaMon) VALUES ( '"+et.MaGV+"' , N'"+et.Ho+"', N'"+et.Ten+"', N'"+et.GT+"', '"+et.SDT+"', '"+et.NgaySinh+"', N'"+et.DiaChi+"', '"+et.Luong+"', '"+et.MaMon+"')");
        }
        
        //Sua du lieu
        public void updateGiaovien(EC_tblGiaovien et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE   tblGiaovien   SET  Ho = N'"+et.Ho+"', Ten = N'"+et.Ten+"', GT = N'"+et.GT+"', NgaySinh = '"+et.NgaySinh+"', SDT = '"+et.SDT+"', Luong = '"+et.Luong+"', DiaChi = N'"+et.DiaChi+"', MaMon = '"+et.MaMon+"' WHERE MaGV = '"+et.MaGV+"'");
        }
        //Xoa du lieu
        public void delGiaovien(EC_tblGiaovien et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblGiaovien WHERE MaGV = '"+et.MaGV+"'");
        }
        //select
        public DataTable getAllgiaovien()
        {
            return cn.getDatatable(@"SELECT * FROM tblGiaovien ");
        }
        public DataTable getGiaovien(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblGiaovien " + dk);
        }
        public DataTable GioiTinh()
        {
            return cn.getDatatable(@"SELECT DISTINCT GT FROM tblGiaoVien");
        }
    }
}
