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
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblGiangday	");
        }
        //Sua du lieu
        public void updateGiangday(EC_tblGiangday et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE	tblGiangday	SET   ");
        }
        //Xoa du lieu
        public void delGiangday(EC_tblGiangday et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblGiangday WHERE MaGV = '" + et.Ngayday + "'");
        }
        //select
        public DataTable getAllGiangday()
        {
            return cn.getDatatable(@"SELECT * FROM tblGiangday ");
        }
        public DataTable getGiangday(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblGiangday " + dk);
        }
    }
}
