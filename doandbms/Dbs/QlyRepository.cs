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
    }
}
