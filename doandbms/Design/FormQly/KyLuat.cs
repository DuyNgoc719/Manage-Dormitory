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
    public partial class KyLuat : UserControl
    {
        QuanLy quanLy = new QuanLy();
        string connectionString = "Data Source=C_NORMAL\\CNORMAL;Initial Catalog=QLSV;Integrated Security=True";
        public KyLuat(QuanLy quanLy)
        {
            this.quanLy = quanLy;
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KyLuat";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Thêm cột trạng thái cảnh báo vào DataGridView
                dt.Columns.Add("TrangThaiCanhBao", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    string maSV = row["MaSV"].ToString();
                    string trangThai = (CheckTrangThaiCanhBao(maSV)) ? "Cảnh Báo" : "Không Cảnh Báo";
                    row["TrangThaiCanhBao"] = trangThai;
                }

                dtg_kyLuat.DataSource = dt;
            }
        }
        private void KyLuat_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            BtnCanhBaoViPham_Click(sender, e);
        }
        private string selectedMaKL;

        private void dtg_kyLuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtg_kyLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng được click là hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_kyLuat.Rows[e.RowIndex];
                selectedMaKL = row.Cells["MaKL"].Value.ToString();
            }
        }
        private void dtg_kyLuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng được double-click là hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_kyLuat.Rows[e.RowIndex];

                // Gán giá trị của từng cột vào các TextBox tương ứng
                txt_maKL.Text = row.Cells["MaKL"].Value.ToString();
                txt_maSV.Text = row.Cells["MaSV"].Value.ToString();
                txt_maToa.Text = row.Cells["MaToa"].Value.ToString();
                txt_loi.Text = row.Cells["LoaiViPham"].Value.ToString();
                if (row.Cells["NgayKL"].Value != null && DateTime.TryParse(row.Cells["NgayKL"].Value.ToString(), out DateTime ngayKL))
                {
                    dtp_ngay.Value = ngayKL;
                }
            }
        }
        private void AddKyLuatToDatabase(string maKL, string maSV, string maToa, string loaiViPham, DateTime ngayKL)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddKyLuat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKL", maKL);
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaToa", maToa);
                        cmd.Parameters.AddWithValue("@LoaiViPham", loaiViPham);
                        cmd.Parameters.Add("@NgayKL", SqlDbType.Date).Value = ngayKL;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm kỷ luật thành công!");
                        LoadDataGridView(); // Gọi lại để cập nhật DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }
        private void DeleteKyLuatFromDatabase(string maKL)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo đối tượng SqlCommand để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("DeleteKyLuat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@MaKL", maKL);

                        // Thực thi lệnh
                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Xóa kỷ luật thành công!");

                        // Gọi lại KyLuat_Load để làm mới DataGridView
                        KyLuat_Load(null, null);
                    }
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }
        private void SearchKyLuat(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT * FROM dbo.SearchKyLuat(@Keyword)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtg_kyLuat.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox và DateTimePicker
            string maKL = txt_maKL.Text;
            string maSV = txt_maSV.Text;
            string maToa = txt_maToa.Text;
            string loaiViPham = txt_loi.Text;
            DateTime ngayKL = dtp_ngay.Value;

            // Gọi hàm để thêm kỷ luật vào cơ sở dữ liệu
            AddKyLuatToDatabase(maKL, maSV, maToa, loaiViPham, ngayKL);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaKL))
            {
                // Xác nhận lại việc xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa kỷ luật này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Gọi hàm để xóa kỷ luật từ cơ sở dữ liệu
                    DeleteKyLuatFromDatabase(selectedMaKL);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một kỷ luật để xóa.");
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_timKiem_KeyDown(object sender, KeyEventArgs e)
        {
            // Thực hiện tìm kiếm khi nhấn phím Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi hàm tìm kiếm với từ khóa nhập vào
                SearchKyLuat(txt_timKiem.Text);
            }
        }
        private void BtnCanhBaoViPham_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("CanhBaoSV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cảnh báo sinh viên vi phạm nhiều lần đã được cập nhật.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi cập nhật cảnh báo: " + ex.Message);
                }
            }
        }
        private void btn_canhCao_Click(object sender, EventArgs e)
        {
            BtnCanhBaoViPham_Click(sender, e);
        }
        private bool CheckTrangThaiCanhBao(string maSV)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM KyLuat WHERE MaSV = @MaSV";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaSV", maSV);

                connection.Open();

                int soLanViPham = (int)cmd.ExecuteScalar();

                // Nếu số lần vi phạm >= 3, trả về true (Cảnh Báo), ngược lại false
                return soLanViPham >= 3;
            }
        }
    }
}
