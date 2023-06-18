using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class CTPhieuNhanPhongDAO
    {
        private static CTPhieuNhanPhongDAO instance;
        public static CTPhieuNhanPhongDAO Instance
        {
            get { if (instance == null) instance = new CTPhieuNhanPhongDAO(); return instance; }
            set => instance = value;
        }
        private CTPhieuNhanPhongDAO() { }
    }
}
