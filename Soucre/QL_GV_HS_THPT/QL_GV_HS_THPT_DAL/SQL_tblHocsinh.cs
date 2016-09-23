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
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblHocsinh	");
        }
        //Sua du lieu
        public void updateHocsinh(EC_tblHocsinh et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE	tblHocsinh	SET   ");
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
