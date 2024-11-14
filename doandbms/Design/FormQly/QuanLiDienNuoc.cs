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
    public partial class QuanLiDienNuoc : UserControl
    {
        QuanLy quanLy = new QuanLy();
        string connectionString = "Data Source=C_NORMAL\\CNORMAL;Initial Catalog=QLSV;Integrated Security=True";

        public QuanLiDienNuoc(QuanLy quanLy)
        {
            this.quanLy = quanLy;
            InitializeComponent();
        }
        private void LoadDataGridViewTienDien()
        {
            try
            {
                // Mở kết nối đến SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Lấy dữ liệu từ bảng TienDien
                    string query = "SELECT * FROM TienDien";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Gán nguồn dữ liệu cho DataGridView
                        dtg_tienDien.DataSource = dt;
                        dtg_tienDien.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu trong bảng TienDien.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu xảy ra lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void LoadDataGridViewTienNuoc()
        {
            try
            {
                // Mở kết nối tới cơ sở dữ liệu SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Mở kết nối

                    // Câu truy vấn SQL để lấy dữ liệu từ bảng TienNuoc
                    string query = "SELECT * FROM TienNuoc";  // Thay đổi TienNuoc nếu tên bảng của bạn khác
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dt = new DataTable(); // Tạo DataTable để chứa dữ liệu
                    adapter.Fill(dt); // Điền dữ liệu từ SQL vào DataTable

                    // Kiểm tra nếu DataTable có dữ liệu
                    if (dt.Rows.Count > 0)
                    {
                        // Gán dữ liệu vào DataGridView
                        dtg_tienNuoc.DataSource = dt;
                        dtg_tienNuoc.Refresh(); // Làm mới DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị trong bảng TienNuoc.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có sự cố xảy ra khi tải dữ liệu
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu từ SQL: " + ex.Message);
            }
        }
        private void LoadDataGridViewHD()
        {
            try
            {
                // Mở kết nối tới cơ sở dữ liệu SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Mở kết nối


                    string query = "SELECT * FROM HoaDonDN";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dt = new DataTable(); // Tạo DataTable để chứa dữ liệu
                    adapter.Fill(dt); // Điền dữ liệu từ SQL vào DataTable

                    // Kiểm tra nếu DataTable có dữ liệu
                    if (dt.Rows.Count > 0)
                    {
                        // Gán dữ liệu vào DataGridView
                        dtg_hoaDon.DataSource = dt;
                        dtg_hoaDon.Refresh(); // Làm mới DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị trong bảng TienNuoc.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có sự cố xảy ra khi tải dữ liệu
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu từ SQL: " + ex.Message);
            }
        }
        private void QuanLiDienNuoc_Load_1(object sender, EventArgs e)
        {
            LoadDataGridViewTienDien();
            LoadDataGridViewTienNuoc();
            LoadDataGridViewHD();
        }
        private string selectedMaPhong;
        private void dtg_tienDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// Kiểm tra nếu hàng được click là hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_tienDien.Rows[e.RowIndex];
                selectedMaPhong = row.Cells["MaPhong"].Value.ToString();
            }
        }
        private void dtg_tienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu hàng được click là hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_tienNuoc.Rows[e.RowIndex];
                selectedMaPhong = row.Cells["MaPhong"].Value.ToString();
            }
        }
        private void dtg_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// Kiểm tra nếu hàng được click là hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_hoaDon.Rows[e.RowIndex];
                selectedMaPhong = row.Cells["MaPhong"].Value.ToString();
            }
        }
        private void dtg_tienDien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_tienDien.Rows[e.RowIndex];

                // Gán giá trị của từng cột vào các TextBox tương ứng
                txt_maPhongD.Text = row.Cells["MaPhong"].Value.ToString();
                txt_soDienDauThang.Text = row.Cells["SoDienDauThang"].Value.ToString();
                txt_soDienCuoiThang.Text = row.Cells["SoDienCuoiThang"].Value.ToString();
                txt_tienDien.Text = row.Cells["TienDien"].Value?.ToString();
                txt_thangD.Text = row.Cells["Thang"].Value.ToString();
            }
        }
        private void dtg_tienNuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_tienNuoc.Rows[e.RowIndex];

                // Gán giá trị của từng cột vào các TextBox tương ứng
                txt_maPhongN.Text = row.Cells["MaPhong"].Value.ToString();
                txt_soNuocDauThang.Text = row.Cells["SoNuocDauThang"].Value.ToString(); // Kiểm tra tên cột
                txt_soNuocCuoiThang.Text = row.Cells["SoNuocCuoiThang"].Value.ToString(); // Kiểm tra tên cột
                txt_tienNuoc.Text = row.Cells["TienNuoc"].Value?.ToString(); // Kiểm tra tên cột
                txt_thangN.Text = row.Cells["Thang"].Value.ToString(); // Kiểm tra tên cột
            }
        }
        private void dtg_hoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_hoaDon.Rows[e.RowIndex];

                // Gán giá trị của từng cột vào các TextBox tương ứng
                txt_maHD.Text = row.Cells["MaHD"].Value.ToString();
                txt_maPhong.Text = row.Cells["MaPhong"].Value.ToString();
                txt_thang.Text = row.Cells["Thang"].Value.ToString();
                txt_tongTien.Text = row.Cells["TongTien"].Value?.ToString();
                cbx_trangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtg_tienDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_thangD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addTienDien_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string maPhong = txt_maPhongD.Text;
            int thang;
            int soDienDauThang;
            int soDienCuoiThang;
            float tienDien;

            // Kiểm tra giá trị nhập vào các TextBox
            if (string.IsNullOrEmpty(maPhong) ||
                !int.TryParse(txt_thangD.Text, out thang) ||
                !int.TryParse(txt_soDienDauThang.Text, out soDienDauThang) ||
                !int.TryParse(txt_soDienCuoiThang.Text, out soDienCuoiThang) ||
                !float.TryParse(txt_tienDien.Text, out tienDien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng các trường thông tin.");
                return;
            }

            // Kết nối và gọi thủ tục AddTienDien
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("AddTienDien", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Thêm các tham số cho thủ tục
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.Parameters.AddWithValue("@Thang", thang);
                        cmd.Parameters.AddWithValue("@SoDienDauThang", soDienDauThang);
                        cmd.Parameters.AddWithValue("@SoDienCuoiThang", soDienCuoiThang);
                        cmd.Parameters.AddWithValue("@TienDien", tienDien);

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thông tin tiền điện thành công.");
                    }
                }

                // Tải lại dữ liệu vào DataGridView sau khi thêm bản ghi mới
                LoadDataGridViewTienDien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_xoaTienDien_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string maPhong = txt_maPhongD.Text;
            int thang;

            // Kiểm tra giá trị nhập vào các TextBox
            if (string.IsNullOrEmpty(maPhong) || !int.TryParse(txt_thangD.Text, out thang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng các trường thông tin.");
                return;
            }

            // Kết nối và gọi thủ tục DeleteTienDien
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteTienDien", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Thêm các tham số cho thủ tục
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.Parameters.AddWithValue("@Thang", thang);

                        // Thực thi thủ tục
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thông tin tiền điện thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để xóa.");
                        }
                    }
                }

                // Tải lại dữ liệu vào DataGridView sau khi xóa bản ghi
                LoadDataGridViewTienDien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void dtg_tienNuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addTienNuoc_Click(object sender, EventArgs e)
        {
            string maPhong = txt_maPhongN.Text;
            int thang;
            int soNuocDauThang;
            int soNuocCuoiThang;
            float tienNuoc;

            // Kiểm tra giá trị nhập vào các TextBox
            if (string.IsNullOrEmpty(maPhong) ||
                !int.TryParse(txt_thangN.Text, out thang) ||
                !int.TryParse(txt_soNuocDauThang.Text, out soNuocDauThang) ||
                !int.TryParse(txt_soNuocCuoiThang.Text, out soNuocCuoiThang) ||
                !float.TryParse(txt_tienNuoc.Text, out tienNuoc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng các trường thông tin.");
                return;
            }

            // Kết nối và gọi thủ tục AddTienNuoc
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("AddTienNuoc", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Thêm các tham số cho thủ tục
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.Parameters.AddWithValue("@Thang", thang);
                        cmd.Parameters.AddWithValue("@SoNuocDauThang", soNuocDauThang);
                        cmd.Parameters.AddWithValue("@SoNuocCuoiThang", soNuocCuoiThang);
                        cmd.Parameters.AddWithValue("@TienNuoc", tienNuoc);

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thông tin tiền nước thành công.");
                    }
                }

                // Tải lại dữ liệu vào DataGridView sau khi thêm bản ghi mới
                LoadDataGridViewTienNuoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_xoaTienNuoc_Click(object sender, EventArgs e)
        {
            string maPhong = txt_maPhongN.Text;
            int thang;

            // Kiểm tra giá trị nhập vào các TextBox
            if (string.IsNullOrEmpty(maPhong) || !int.TryParse(txt_thangN.Text, out thang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng các trường thông tin.");
                return;
            }

            // Kết nối và gọi thủ tục DeleteTienNuoc
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteTienNuoc", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Thêm các tham số cho thủ tục
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.Parameters.AddWithValue("@Thang", thang);

                        // Thực thi thủ tục
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thông tin tiền nước thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để xóa.");
                        }
                    }
                }

                // Tải lại dữ liệu vào DataGridView sau khi xóa bản ghi
                LoadDataGridViewTienNuoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string maPhong = txt_maPhong.Text.Trim();
            int thang;
            float tongTien;
            bool trangThai;

            // Kiểm tra giá trị nhập vào các TextBox và ComboBox
            if (string.IsNullOrEmpty(maPhong) ||
                !int.TryParse(txt_thang.Text.Trim(), out thang) ||
                !float.TryParse(txt_tongTien.Text.Trim(), out tongTien) ||
                !bool.TryParse(cbx_trangThai.SelectedItem?.ToString(), out trangThai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng các trường thông tin.");
                return;
            }

            // Kiểm tra lại các giá trị hợp lý (ví dụ, tháng từ 1-12, số tiền lớn hơn 0, trạng thái hợp lệ)
            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Tháng không hợp lệ. Vui lòng nhập tháng từ 1 đến 12.");
                return;
            }

            if (tongTien <= 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn 0.");
                return;
            }

            // Kết nối và gọi thủ tục AddHopDong
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Sử dụng SqlCommand với tham số an toàn
                    using (SqlCommand cmd = new SqlCommand("AddHopDong", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Thêm các tham số cho thủ tục với kiểu dữ liệu rõ ràng
                        cmd.Parameters.Add(new SqlParameter("@MaPhong", SqlDbType.NVarChar) { Value = maPhong });
                        cmd.Parameters.Add(new SqlParameter("@Thang", SqlDbType.Int) { Value = thang });
                        cmd.Parameters.Add(new SqlParameter("@TongTien", SqlDbType.Float) { Value = tongTien });
                        cmd.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.Bit) { Value = trangThai });

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm hợp đồng thành công.");
                    }
                }

                // Tải lại dữ liệu vào DataGridView sau khi thêm bản ghi mới
                LoadDataGridViewHD();

                // Làm sạch các TextBox và ComboBox sau khi thêm thành công
                txt_maPhong.Clear();
                txt_thang.Clear();
                txt_tongTien.Clear();
                cbx_trangThai.SelectedIndex = -1;  // Đặt lại lựa chọn của ComboBox
            }
            catch (SqlException sqlEx)
            {
                // Xử lý lỗi SQL riêng biệt để cung cấp thông tin chi tiết hơn
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chung
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_xoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các textbox
                string maPhong = txt_maPhong.Text;
                int thang = int.Parse(txt_thang.Text);

                // Kết nối tới cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo đối tượng Command để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("DeleteHopDong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số vào Command
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.Parameters.AddWithValue("@Thang", thang);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Hợp đồng đã được xóa thành công!");
                        LoadDataGridViewTienNuoc();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Bắt lỗi SQL và hiển thị thông báo
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Bắt lỗi chung và hiển thị thông báo
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string maPhong = txt_maPhong.Text.Trim();
                int thang;

                if (int.TryParse(txt_thang.Text.Trim(), out thang))
                {
                    try
                    {
                        // Kết nối tới cơ sở dữ liệu
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.SearchHoaDonDN(@MaPhong, @Thang)", conn);
                            cmd.Parameters.AddWithValue("@MaPhong", string.IsNullOrEmpty(maPhong) ? (object)DBNull.Value : maPhong);
                            cmd.Parameters.AddWithValue("@Thang", thang);

                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            // Hiển thị kết quả
                            while (reader.Read())
                            {

                                MessageBox.Show($"MaHD: {reader["MaHD"]}, MaPhong: {reader["MaPhong"]}, Thang: {reader["Thang"]}, TongTien: {reader["TongTien"]}, TrangThai: {reader["TrangThai"]}");
                            }

                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu có
                        MessageBox.Show($"Lỗi: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Tháng không hợp lệ!");
                }
            }
        }
    }
}
