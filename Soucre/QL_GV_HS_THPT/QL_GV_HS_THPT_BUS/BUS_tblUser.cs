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
    public class BUS_tblUser
    {
        SQL_tblUser bus = new SQL_tblUser();
        public void addUser(EC_tblUser et)
        {
            bus.addUser(et);
        }
        //Sua du lieu
        public void updateUser(EC_tblUser et)
        {
            bus.updateUser(et);
        }
        //Xoa du lieu
        public void delUser(EC_tblUser et)
        {
            bus.delUser(et);
        }
        //select
        public DataTable getAlluser()
        {
            return bus.getAlluser();
        }
        public DataTable getUser(string dk)
        {
            return bus.getUser(dk);
        }
        // check login
        public string checkLogin(string Username, string Password)
        {
            return bus.checkLogin(Username, Password);
        }

    }
}
