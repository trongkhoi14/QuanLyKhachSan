using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PhieuNhanPhongDAO
    {
        private static PhieuNhanPhongDAO instance;
        public static PhieuNhanPhongDAO Instance
        {
            get { if (instance == null) instance = new PhieuNhanPhongDAO(); return instance; }
            set => instance = value;
        }
        private PhieuNhanPhongDAO() { }
    }
}
