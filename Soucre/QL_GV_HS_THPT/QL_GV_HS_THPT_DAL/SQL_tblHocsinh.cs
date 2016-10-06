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
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblHocSinh (MaHS, Ho, Ten, GT, NgaySinh, DiaChi, MaLop) 
                                VALUES (N'"+et.MaHS+"',N'"+et.Ho+"',N'"+et.Ten+"',N'"+et.GT+"',N'"+et.NgaySinh+"',N'"+et.DiaChi+"',N'"+et.MaLop+"')	");
        }
        //Sua du lieu
        public void updateHocsinh(EC_tblHocsinh et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblHocSinh SET Ho =N'" + et.Ho + "', Ten =N'" + et.Ten + "', GT =N'" +
                et.GT + "', NgaySinh =N'" + et.NgaySinh + "', DiaChi =N'" + et.DiaChi + "', MaLop =N'" + et.MaLop + "' where MaHS=N'"+et.MaHS+"'");
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
        public DataTable DoDLMaLop(string dk)
        {
            return cn.getDatatable("SELECT MaLop FROM tblLop "+dk);
        }
    }
}
