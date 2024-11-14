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
    public partial class QuanLiPhong : UserControl
    {
        QuanLy quanLy = new QuanLy();
        string connectionString = "Data Source=C_NORMAL\\CNORMAL;Initial Catalog=QLSV;Integrated Security=True";
        public QuanLiPhong(QuanLy quanLy)
        {
            this.quanLy = quanLy;
            InitializeComponent();
        }
        private void LoadDataGridViewPhong()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Phong";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                dtg_phong.DataSource = dt;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanLiPhong_Load_1(object sender, EventArgs e)
        {
            LoadDataGridViewPhong();
        }
        private string selectedMaPhong;

        private void dtg_phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtg_phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_phong.Rows[e.RowIndex];
                selectedMaPhong = row.Cells["MaPhong"].Value.ToString();
            }
        }
        private void dtg_phong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng được double-click là hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_phong.Rows[e.RowIndex];

                // Gán giá trị của từng cột vào các TextBox tương ứng
                txt_maPhong.Text = row.Cells["MaPhong"].Value.ToString();
                txt_loaiPhong.Text = row.Cells["LoaiPhong"].Value.ToString();
                txt_maToa.Text = row.Cells["MaToa"].Value.ToString();
                txt_soNguoiDaO.Text = row.Cells["SoNguoiDaO"].Value.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng cần xoá.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DeletePhong", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaPhong", selectedMaPhong);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Phòng đã được xoá thành công!");

                    // Tải lại dữ liệu vào DataGridView sau khi xoá phòng
                    LoadDataGridViewPhong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string maPhong = txt_maPhong.Text;
            string loaiPhong = txt_loaiPhong.Text;
            string maToa = txt_maToa.Text;
            int soNguoiDaO;

            // Kiểm tra nếu các trường dữ liệu rỗng
            if (string.IsNullOrEmpty(maPhong) || string.IsNullOrEmpty(loaiPhong) || string.IsNullOrEmpty(maToa) || !int.TryParse(txt_soNguoiDaO.Text, out soNguoiDaO))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phòng và đảm bảo số người đã ở là một số hợp lệ.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("AddPhong", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.Parameters.AddWithValue("@LoaiPhong", loaiPhong);
                    cmd.Parameters.AddWithValue("@MaToa", maToa);
                    cmd.Parameters.AddWithValue("@SoNguoiDaO", soNguoiDaO);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Phòng đã được thêm thành công!");

                    // Tải lại dữ liệu vào DataGridView sau khi thêm phòng
                    LoadDataGridViewPhong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void TimKiemPhong(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT * FROM dbo.SearchPhong(@Keyword)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtg_phong.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }
        private void txt_timKiem1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_timKiem1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi hàm tìm kiếm với từ khóa nhập vào
                TimKiemPhong(txt_timKiem1.Text);
            }

        }
    }
}
