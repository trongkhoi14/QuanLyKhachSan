﻿using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDichVuDAO
    {
        private static PhieuDichVuDAO instance;
        public static PhieuDichVuDAO Instance
        {
            get { if (instance == null) instance = new PhieuDichVuDAO(); return instance; }
            set => instance = value;
        }
        private PhieuDichVuDAO() { }

        [Obsolete]
        public DataTable LTLayPhieuDichVuTheoPDP(string MaPDP)
        {
            string query = string.Format("SELECT D.TENDV, C.SOLUONG, D.DONVITINH, C.LICHSUDUNG, C.GHICHU, D.GIADV " +
                                         "FROM HOTELADMIN.PHIEUDICHVU P " +
                                         "JOIN HOTELADMIN.CT_PHIEUDICHVU C ON C.MAPDV = P.MAPDV " +
                                         "JOIN HOTELADMIN.DICHVU D ON D.MADV = C.MADV " +
                                         "WHERE P.MAPDP = '{0}'", MaPDP);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable LayMaPhieuDichVu(string MaPDP)
        {
            string query = string.Format($"SELECT MAPDV FROM HOTELADMIN.PHIEUDICHVU WHERE MAPDP = '{MaPDP}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
