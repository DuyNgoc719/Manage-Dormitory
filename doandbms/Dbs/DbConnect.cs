using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace doandbms.Dbs
{
    public class DbConnect
    {
        private readonly string connectionString =
            "Data Source=localhost;Initial Catalog=QLSV;Integrated Security=True";

        public SqlConnection Connection { get; private set; }

        public void OpenConnection()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(connectionString);

                if (Connection.State == ConnectionState.Closed)
                    Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở kết nối: {ex.Message}");
            }
        }

        // Đóng kết nối cơ sở dữ liệu
        public void CloseConnection()
        {
            try
            {
                if (Connection != null && Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đóng kết nối: {ex.Message}");
            }
        }

        // Thực thi câu lệnh INSERT, UPDATE, DELETE hoặc Stored Procedure
        public bool ExecuteNonQuery(string query, CommandType commandType, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.CommandType = commandType;

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực thi câu lệnh: {ex.Message}");
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public object ExecuteScalar(string query, CommandType commandType, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.CommandType = commandType;

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();  // Trả về kết quả từ thủ tục
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực thi câu lệnh: {ex.Message}");
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        // Lấy dữ liệu từ cơ sở dữ liệu (SELECT hoặc gọi stored procedure trả về bảng)
        public DataTable ExecuteQuery(string query, CommandType commandType, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.CommandType = commandType;

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
        public int ExecuteScalarQuery(string query, CommandType commandType, SqlParameter[] parameters = null)
        {
            int result = 0;
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.CommandType = commandType;

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

    }
}
