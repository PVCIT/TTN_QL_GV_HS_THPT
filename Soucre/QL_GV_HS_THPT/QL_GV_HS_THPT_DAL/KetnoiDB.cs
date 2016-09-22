using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_GV_HS_THPT_DAL
{
    public class KetnoiDB
    {
        public static SqlConnection connect;
        //Mo ket noi
        public static void MoKetNoi()
        {
            if(KetnoiDB.connect == null)
            {
                KetnoiDB.connect = new SqlConnection(@"Data Source=CONG-PC\PVC_IT;Initial Catalog=QL_GV_HS_THPT;Integrated Security=SSPI;");
            }                                           
            if(KetnoiDB.connect.State != ConnectionState.Open )
            {
                KetnoiDB.connect.Open();
            }
        }
        //Dong ket noi
        public void DongKetNoi()
        {
            if(KetnoiDB.connect.State != null)
            {
                if (KetnoiDB.connect.State == ConnectionState.Open)
                {
                    KetnoiDB.connect.Close();
                }
            }
        }
        //Thuc thi cau lenh SQL: insert, update, delete
        public void ThucThiCauLenhSQL(string strSql)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlCmd = new SqlCommand(strSql, connect);
                sqlCmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch{}
        }
        
        //Lay du lieu ra bang: select
        public DataTable getDatatable(string strSql)
        {
            try 
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDa = new SqlDataAdapter(strSql, connect);
                sqlDa.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch { return null; }
        }

        //Lay gia tri dau cua bang khi select
        public string getValue(string strSql)
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand(strSql, connect);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            while(sqlDr.Read())
            {
                temp = sqlDr[0].ToString();
            }
            DongKetNoi();
            return temp;

        }
    }
}
