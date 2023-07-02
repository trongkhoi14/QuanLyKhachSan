using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class TourDuLichDAO
    {
        private static TourDuLichDAO instance;
        public static TourDuLichDAO Instance
        {
            get { if (instance == null) instance = new TourDuLichDAO(); return instance; }
            set => instance = value;
        }
        private TourDuLichDAO() { }

        [Obsolete]
        public DataTable LayDSTour()
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.TOURDULICH");
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
