using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QV_HS_THPT_Entity
{
    public class EC_tblHocsinh
    {
        private string _MaHS;
        public string MaHS
        {
            get { return _MaHS; }
            set { _MaHS = value;}
        }

        private string _Ho;
        public string Ho
        {
            get { return _Ho; }
            set { _Ho = value; }
        }
 
        private string _Ten;
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        
        private string _GT;
        public string GT
        {
            get { return _GT; }
            set { _GT = value; }
        }
        
        private string _NgaySinh;
        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
       
        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        
        private string _PhuHuynh;
        public string PhuHuynh
        {
            get { return _PhuHuynh; }
            set { _PhuHuynh = value; }
        }
        
        private string _LopTruong;
        public string LopTruong
        {
            get { return _LopTruong; }
            set { _LopTruong = value; }
        }
        
        private string _MaLop;
        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
    }
}
