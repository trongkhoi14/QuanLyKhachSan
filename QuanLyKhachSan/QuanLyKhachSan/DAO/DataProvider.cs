﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    class DataProvider
    {
                
        private static DataProvider instance;

        private string connectionSTR = "";

        public string role = "";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value;
        }
        private DataProvider() { }
        
        [Obsolete]
        // Thiết lập chuỗi kết nối:
        public void SetConnectionString(string connectionString)
        {
            // Set lại connection string
            connectionSTR = connectionString;

            // Kiểm tra thử xem chuỗi này kết nối được không
            OracleConnection connection = new OracleConnection(connectionSTR);

            connection.Open();
            try
            {
                // Truy vấn để lấy dữ liệu từ bảng NHANVIEN
                string query = "SELECT * FROM MYADMIN.NHANVIEN";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                DataTable data = new DataTable();
                adapter.Fill(data);

                // Kiểm tra xem có dữ liệu và cột role tồn tại không
                if (data.Rows.Count > 0 && data.Columns.Contains("VAITRO"))
                {
                    // Gán giá trị của cột role vào thuộc tính role của lớp DataProvider
                    role = data.Rows[0]["VAITRO"].ToString();
                }
                else
                {
                    // Xử lý khi không tìm thấy dữ liệu hoặc cột role
                    role = "admin"; // hoặc gán giá trị mặc định khác

                }
            }
            catch (Exception)
            {
                role = "";
            }

            connection.Close();
        }
                
        [Obsolete]
        // Dùng cho SELECT (trả về dạng bảng)
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                OracleDataAdapter adapter = new OracleDataAdapter(command);
                try
                {
                    adapter.Fill(data);
                }
                catch (Exception)
                {
                    connection.Close();
                    return new DataTable();
                }


                connection.Close();
            }
            return data;
        }
                
        [Obsolete]
        // Dùng cho INSERT, UPDATE, DELETE (trả về số dòng thực thi thành công) 
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

    }
}
