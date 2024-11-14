using doandbms.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doandbms.Dbs
{
    public class AccountRepository
    {
        private DbConnect dbConnect = new DbConnect();
        public void AddAccount(string username, string password, string email, string role)
        {
            string procedureName = "sp_ThemAccount";

            SqlParameter[] parameters = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@email", email),
                new SqlParameter("@role", role)
            };

            bool success = dbConnect.ExecuteNonQuery(procedureName, CommandType.StoredProcedure, parameters);
            MessageBox.Show(success ? "Thêm tài khoản thành công!" : "Thêm tài khoản thất bại.");
        }

        public void AddQly(string maQl, string name, string toaQl,string chucVu,string username)
        {
            string function = "sp_ThemQly";

            SqlParameter[] parameters = {
                new SqlParameter("@maQl", maQl),
                new SqlParameter("@name", name),
                new SqlParameter("@toaQl", toaQl),
                new SqlParameter("@chucVu", chucVu),
                new SqlParameter("username",username)
            };

            bool success = dbConnect.ExecuteNonQuery(function, CommandType.StoredProcedure, parameters);
            MessageBox.Show(success ? "Cập nhật thành công!" : "Cập nhật thất bại.");
        }
        public void AddSv(string MaSv, string name, string MaToa, string cccd, string MaPhong,string sdt,string username)
        {
            string function = "sp_ThemSinhVien";

            SqlParameter[] parameters = {
                new SqlParameter("@MaSv", MaSv),
                new SqlParameter("@HoTen", name),
                new SqlParameter("@MaToa", MaToa),
                new SqlParameter("@MaPhong", MaPhong),
                new SqlParameter("@CCCD",cccd),
                new SqlParameter("@SDT",sdt),
                new SqlParameter("@username",username)
            };

            bool success = dbConnect.ExecuteNonQuery(function, CommandType.StoredProcedure, parameters);
            MessageBox.Show(success ? "Cập nhật thành công!" : "Cập nhật thất bại.");
        }

        public string CheckLogin(string username, string password)
        {
            string query = "SELECT dbo.sp_CheckLogin(@username, @password) AS AccountId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            DataTable resultTable = dbConnect.ExecuteQuery(query, CommandType.Text, parameters);

            if (resultTable.Rows.Count > 0)
            {
                return resultTable.Rows[0]["AccountId"]?.ToString();
            }

            return null;
        }
        public bool CheckEmailExists(string email)
        {
            string query = "SELECT dbo.fn_CheckEmailExistence(@Email) AS EmailExists";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };

            DataTable resultTable = dbConnect.ExecuteQuery(query, CommandType.Text, parameters);

            if (resultTable.Rows.Count > 0)
            {
                bool emailExists = Convert.ToBoolean(resultTable.Rows[0]["EmailExists"]);
                return emailExists;
            }

            return false;  
        }

        public void UpdatePassword(string email, string newPassword)
        {
            string query = "UPDATE Account SET Password = @Password WHERE Email = @Email";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Password", newPassword),
                new SqlParameter("@Email", email)
            };

            dbConnect.ExecuteQuery(query, CommandType.Text, parameters);
        }



        public QuanLy GetQuanLyById(string id)
        {
            string query = "SELECT * FROM QuanLy WHERE MaQL = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@id", id)
            };

            DataTable resultTable = dbConnect.ExecuteQuery(query, CommandType.Text, parameters);

            if (resultTable.Rows.Count > 0)
            {
                return new QuanLy
                {
                    MaQl = resultTable.Rows[0]["MaQL"].ToString(),
                    Name = resultTable.Rows[0]["HoTen"].ToString(),
                    MaToaQl = resultTable.Rows[0]["MaToaQL"].ToString(),
                };
            }
            return null;
        }
        public SinhVien GetSinhVienById(string id)
        {
            string query = "SELECT * FROM SinhVien WHERE MaSv = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@id", id)
            };

            DataTable resultTable = dbConnect.ExecuteQuery(query, CommandType.Text, parameters);

            if (resultTable.Rows.Count > 0)
            {
                byte[] anh = resultTable.Rows[0]["Anh"] as byte[];
                //bool isActive = Convert.ToBoolean(resultTable.Rows[0]["IsActive"]);
                return new SinhVien
                {
                    MaSv = resultTable.Rows[0]["MaSv"].ToString(),
                    HoTen = resultTable.Rows[0]["HoTen"].ToString(),
                    NgaySinh = Convert.ToDateTime(resultTable.Rows[0]["NgaySinh"]),
                    Sex = resultTable.Rows[0]["GioiTinh"].ToString(),
                    Cccd = resultTable.Rows[0]["CCCD"].ToString(),
                    DiaChi = resultTable.Rows[0]["DiaChi"].ToString(),
                    Sdt = resultTable.Rows[0]["SDT"].ToString(),
                    MaPhong = resultTable.Rows[0]["MaPhong"].ToString(),
                    MaToa = resultTable.Rows[0]["MaToa"].ToString(),
                    Anh = anh,
                    //Duyet = isActive
                };
            }
            return null;
        }
        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
