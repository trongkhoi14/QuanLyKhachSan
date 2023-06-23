using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        [Obsolete]
        public DataTable LTLayPNP(string maPDP)
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.PHIEUNHANPHONG WHERE MAPDP = '{0}'", maPDP);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public DataTable LTLayDanhSachPNP()
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.PHIEUNHANPHONG");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public int LTThem(string maPNP, string maPDP, string maNV)
        {
            string query = string.Format("INSERT INTO HOTELADMIN.PHIEUNHANPHONG (MAPNP, NGAYLAP, MAPDP, MANV) VALUES('{0}', SYSDATE, '{1}', '{2}')", maPNP, maPDP, maNV);
            //MessageBox.Show(maPNP);
            return DataProvider.Instance.ExecuteNonQuery(query);
            //return 1;
        }
    }
}
