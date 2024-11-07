using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doandbms.Dbs
{
    public class QlyRepository
    {
        private DbConnect dbConnect = new DbConnect();
        public DataTable ShowSinhVienInToa(string toa)
        {
            string querry = "SELECT * FROM SinhVien WHERE SinhVien.MaToa = @MaToa";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
               new SqlParameter ("@MaToa",toa)
            };
            DataTable dt = new DataTable();
            dt = dbConnect.ExecuteQuery(querry,CommandType.Text,sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return dt;
            } else
            {
                return null;
            }
        }

        public DataTable SearchSvKeyDown(string search,string toa)
        {
            string query = "SELECT * FROM dbo.fn_TimKiemSinhVien(@SearchTerm, @MaToa)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@SearchTerm",search),
                new SqlParameter("@MaToa",toa)
            };
            DataTable dt = new DataTable();
            dt = dbConnect.ExecuteQuery(query,CommandType.Text,sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public void ChangeInforQli(string toa, string hoten)
        {
            string query = "sp_SuaQuanLy";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaToa", toa),
                new SqlParameter("@HoTen", hoten)
            };

            object result = dbConnect.ExecuteScalar(query, CommandType.StoredProcedure, sqlParameters);
            string message = result?.ToString();

            if (message == "success")
            {
                MessageBox.Show("Thay đổi thành công");
            }
            else
            {
                MessageBox.Show("Thay đổi thất bại: ");
            }
        }
        public void DeleteSv(string mssv)
        {
            string query = "sp_XoaSinhVien";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaSv",mssv)
            };
            bool success = dbConnect.ExecuteNonQuery(query, CommandType.StoredProcedure, sqlParameters);
            if (success)
            {
                MessageBox.Show("Xóa Thành Công");
            } else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

    }
}
