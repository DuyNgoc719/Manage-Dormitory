using doandbms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doandbms.Design
{
    public partial class QuanLiHopDong : UserControl
    {
        QuanLy quanLy = new QuanLy();
        string connectionString = "Data Source=C_NORMAL\\CNORMAL;Initial Catalog=QLSV;Integrated Security=True";
        public QuanLiHopDong(QuanLy quanLy)
        {
            this.quanLy = quanLy;
            InitializeComponent();
        }
        private void LoadDataGridViewHopDong()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SuKienDatPhong";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                dtg_hopDong.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanLiHopDong_Load(object sender, EventArgs e)
        {
            LoadDataGridViewHopDong();
        }

        private void txt_searchHopDong_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchSuKienDatPhong(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM dbo.SearchSuKienDatPhong(@Keyword)"; // Đảm bảo gọi đúng hàm trong SQL Server

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Sử dụng tham số với giá trị tìm kiếm
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Kiểm tra xem DataTable có chứa dữ liệu không trước khi gán vào DataGridView
                        if (dt.Rows.Count > 0)
                        {
                            dtg_hopDong.DataSource = dt;  // Cập nhật DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hợp đồng với từ khóa '" + keyword + "'.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }
        private void txt_searchHopDong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = txt_searchHopDong.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {
                    SearchSuKienDatPhong(keyword);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
