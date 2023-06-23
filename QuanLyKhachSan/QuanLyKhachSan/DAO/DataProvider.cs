using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class DataProvider
    {
                
        private static DataProvider instance;

        private string connectionSTR = "";

        public string role = "";

        public string username = "";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value;
        }
        private DataProvider() { }


        // Thiết lập chuỗi kết nối
        [Obsolete]
        public void SetConnectionString(string connectionString)
        {

            // Set lại connection string
            connectionSTR = connectionString;
            // TODO
            try
            {
                // Truy vấn để lấy dữ liệu từ bảng NHANVIEN
                string query = "SELECT * FROM HOTELADMIN.NHANVIEN";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connectionSTR);
                DataTable data = new DataTable();
                adapter.Fill(data);

                // Kiểm tra xem có dữ liệu và cột role tồn tại không
                if (data.Rows.Count > 0 && data.Columns.Contains("VAITRO"))
                {
                    // Gán giá trị của cột role vào thuộc tính role của lớp DataProvider
                    
                    username = data.Rows[0]["MANV"].ToString();
                }
                else
                {
                    //TODO
                }
            }
            catch (Exception)
            {
                //TODO
            }
        }

        [Obsolete]
        // Kiểm tra kết nối
        public bool TestConnection()
        {
            OracleConnection connection = new OracleConnection(connectionSTR);
            // Kiểm tra kết nối
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
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
