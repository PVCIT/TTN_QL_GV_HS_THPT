using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_GV_HS_THPT_DAL;
using QL_QV_HS_THPT_Entity;
using System.Data;

namespace QL_GV_HS_THPT_BUS
{
    public class BUS_tblHocSinh
    {
        SQL_tblHocsinh bus = new SQL_tblHocsinh();
        public void addHocsinh(EC_tblHocsinh et)
        {
            bus.addHocsinh(et);
        }
        //Sua du lieu
        public void updateHocSinh(EC_tblHocsinh et)
        {
            bus.updateHocsinh(et);
        }
        //Xoa du lieu
        public void delHocSinh(EC_tblHocsinh et)
        {
            bus.delHocsinh(et);
        }
        //select
        public DataTable getAllHocSInh()
        {
            return bus.getAllHocsinh();
        }
        public DataTable getHocSinh(string dk)
        {
            return bus.getHocsinh(dk);
        }
        public DataTable DoDLMaLop(string dk)
        {
            return bus.DoDLMaLop(dk);
        }
        
    }
}
