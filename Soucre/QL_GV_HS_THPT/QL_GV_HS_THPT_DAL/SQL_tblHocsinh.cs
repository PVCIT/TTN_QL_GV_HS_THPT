using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QV_HS_THPT_Entity;
using System.Data;

namespace QL_GV_HS_THPT_DAL
{
    public class SQL_tblHocsinh
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addHocsinh(EC_tblHocsinh et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblHocsinh(MaHS, Ho, Ten, GT, NgaySinh, TonGiao, DanToc, MaLop, DiaChi)
                                                        values('" + et.MaHS + "', N'" + et.Ho + "', N'" + et.Ten + "', N'" + et.GT + "', '" + et.NgaySinh + "', N'" + et.TonGiao + "', N'" + et.DanToc + "', '" + et.MaLop + "', N'" + et.DiaChi + "')");
        }
        //Sua du lieu
        public void updateHocsinh(EC_tblHocsinh et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblHocsinh SET Ho = N'" + et.Ho + "', Ten = N'" + et.Ten + "', GT = N'" + et.GT + "', NgaySinh = '" + et.NgaySinh + "', DanToc = N'" + et.DanToc + "', TonGiao = N'" + et.TonGiao + "', MaLop = '" + et.MaLop + "', DiaChi = N'" + et.DiaChi + "' where MaHS = '" + et.MaHS + "'");
        }
        //Xoa du lieu
        public void delHocsinh(EC_tblHocsinh et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblHocsinh WHERE MaHS = '" + et.MaHS + "'");
        }
        //select
        public DataTable getAllHocsinh()
        {
            return cn.getDatatable(@"SELECT * FROM tblHocsinh ");
        }
        public DataTable getHocsinh(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblHocsinh " + dk);
        }
    }
}
