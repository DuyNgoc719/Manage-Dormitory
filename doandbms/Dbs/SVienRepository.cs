using doandbms.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace doandbms.Dbs
{
    public class SVienRepository
    {
        DbConnect dbConnect = new DbConnect();
        public void UpdateSinhVien(SinhVien sv)
        {
            string querry = "sp_SuaSinhVien";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaSV", sv.MaSv),
                new SqlParameter("@HoTen", sv.HoTen),
                new SqlParameter("@NgaySinh", sv.NgaySinh),
                new SqlParameter("@GioiTinh", sv.Sex),
                new SqlParameter("@CCCD", sv.Cccd),
                new SqlParameter("@DiaChi", sv.DiaChi),
                new SqlParameter("@SDT", sv.Sdt),
                new SqlParameter("@MaPhong", sv.MaPhong),
                new SqlParameter("@MaToa", sv.MaToa),
                new SqlParameter("@Image", sv.Anh)
            };
            bool success = dbConnect.ExecuteNonQuery(querry,CommandType.StoredProcedure,sqlParameters);
            if (success)
            {
                MessageBox.Show("Thành Công");
            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
        }
        public DataTable GetSoNguoiSoNguoiDaO(string MaPhong)
        {
            string query = "sp_GetSoNguoiSoNguoiDaO";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhong", MaPhong)
            };

            DataTable dt = dbConnect.ExecuteQuery(query, CommandType.StoredProcedure, sqlParameters);

            return dt;
        }

        public void TaoSKDatPhong(string maSv,string MaPhong,string SoKy,string NgayNhan)
        {
            string query = "sp_InsertSKDatPhong";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@MaSv", maSv),
            new SqlParameter("@MaPhong", MaPhong),
            new SqlParameter("@SoKy", int.Parse(SoKy)),
            new SqlParameter("@NgayNhanPhong",DateTime.Parse( NgayNhan) ),

            };
            bool success = dbConnect.ExecuteNonQuery(query, CommandType.StoredProcedure, sqlParameters);
            if (success)
            {
                MessageBox.Show("Thành Công");
            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
        }
        public bool CheckNgayTraPhong(string MaSv)
        {
            string query = "SELECT dbo.fn_CheckNgayTraPhong(@MaSv)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                 new SqlParameter("@MaSv", MaSv)
            };
            object result = dbConnect.ExecuteScalar(query, CommandType.Text, sqlParameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToBoolean(result);
            }
            return false;
        }


        public void UpDateTraPhong(string MaSv, int SoKy)
        {
            string querry = "UpdateNgayTraPhong";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaSv",MaSv),
                new SqlParameter("@SoKy",SoKy)
            };
            bool success = dbConnect.ExecuteNonQuery(querry, CommandType.StoredProcedure, sqlParameters);
            if (success)
            {
                MessageBox.Show("Cập nhật Thành Công");
            }
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại");
            }
        }

    }
}
