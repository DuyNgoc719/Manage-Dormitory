using doandbms.Dbs;
using doandbms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doandbms.Design.FormSv
{
    public partial class ThongTinSinhVien : UserControl
    {
        SVienRepository sVienRepository = new SVienRepository();
        SinhVien sv = new SinhVien();
        public ThongTinSinhVien(SinhVien sv)
        {
            this.sv = sv;
            InitializeComponent();

        }

        private void textBoxDuongDanHinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            GetInforSv();

        }

        private void pn_InforSv_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                GetSv();
                sVienRepository.UpdateSinhVien(sv);

            }
        }
        private void GetInforSv()
        {
            txt_cccd.Text = sv.Cccd.ToString();
            txt_diachi.Text = sv.DiaChi.ToString();
            txt_name.Text = sv.HoTen.ToString();
            txt_sdt.Text = sv.Sdt.ToString();
            txt_sex.Text = sv.Sex.ToString();
            txt_MaSv.Text = sv.MaSv.ToString();
            txt_maphong.Text = sv.MaPhong.ToString();
            txt_matoa.Text = sv.MaToa.ToString();
            mdf_ngaySinh.Text = sv.NgaySinh.ToString("dd/MM/yyyy").ToString();
            if (sv.Anh!=null)
            {
                picture_sv.Image = ConvertByteArrayToImage(sv.Anh);
            }
        }
        private void GetSv()
        {
            sv.MaSv = txt_MaSv.Text;
            sv.Cccd = txt_cccd.Text;
            sv.HoTen = txt_name.Text;
            sv.MaPhong = txt_maphong.Text;
            sv.MaToa = txt_matoa.Text;
            sv.Sex = txt_sex.Text;
            byte[] image = ConvertImageToByteArray(picture_sv.Image);
            sv.Anh = image;
            sv.Sdt = txt_sdt.Text;
            sv.DiaChi = txt_diachi.Text;
            sv.NgaySinh = DateTime.Parse(mdf_ngaySinh.Text);
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txt_MaSv.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã SV.");
                txt_MaSv.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_cccd.Text))
            {
                MessageBox.Show("Vui lòng nhập CCCD.");
                txt_cccd.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên.");
                txt_name.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_maphong.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phòng.");
                txt_maphong.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_matoa.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã tòa.");
                txt_matoa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_sex.Text))
            {
                MessageBox.Show("Vui lòng nhập Giới tính.");
                txt_sex.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_diachi.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ.");
                txt_diachi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(mdf_ngaySinh.Text))
            {
                MessageBox.Show("Vui lòng nhập Ngày sinh.");
                mdf_ngaySinh.Focus();
                return false;
            }

            if (picture_sv.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh.");
                return false;
            }

            return true;
        }

        public byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void picture_sv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Chọn ảnh sinh viên";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                picture_sv.Image = Image.FromFile(filePath);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
