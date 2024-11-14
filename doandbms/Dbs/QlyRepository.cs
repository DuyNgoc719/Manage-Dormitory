using doandbms.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public void ChangeInforQli(string toa, string hoten,string maQl)
        {
            string query = "sp_SuaQuanLy";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaToa", toa),
                new SqlParameter("@HoTen", hoten),
                new SqlParameter("MaQly",maQl)
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

        public void ChangeSv(SinhVien sv)
        {
            string querry = "sp_SuaSinhVien";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaSV",sv.MaSv),
                new SqlParameter("@HoTen",sv.HoTen),
                new SqlParameter("@NgaySinh ",sv.NgaySinh),
                new SqlParameter("@GioiTinh",sv.Sex),
                new SqlParameter("@CCCD ",sv.Cccd),
                new SqlParameter("@DiaChi ",sv.DiaChi),
                new SqlParameter("@SDT",sv.Sdt),
                new SqlParameter("@MaPhong ",sv.MaPhong),
                new SqlParameter("@MaToa",sv.MaToa)
                 
            };
            bool success = dbConnect.ExecuteNonQuery(querry, CommandType.StoredProcedure, sqlParameters);
            if (success)
            {
                MessageBox.Show("Thay đổi thành công");
            } else
            {
                MessageBox.Show("Thay đổi thất bại");
            }
        }

        

        public void UpdatePhongSoNguoi(string oldP,string newP)
        {
            string querry = "sp_UpdatePhongSoNguoi";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@OldMaPhong",oldP),
                new SqlParameter("@NewMaPhong",newP)
            };
            bool success = dbConnect.ExecuteNonQuery(querry,CommandType.StoredProcedure, sqlParameters);
            if (success)
            {
                MessageBox.Show("Đổi phòng thành công");
            } else
            {
                MessageBox.Show("Đổi phòng thất bại");
            }
        }

        public DataTable LoadSkDatPhong(string maSv)
        {
            string query = "sp_GetSuKienDatPhongData";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaSV", maSv)
            };

            DataTable dt = new DataTable();
            dt = dbConnect.ExecuteQuery(query, CommandType.StoredProcedure, sqlParameters);

            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }



    }
}
