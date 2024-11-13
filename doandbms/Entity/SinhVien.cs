using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doandbms.Entity
{
    public class SinhVien
    {
        private string _maSv;
        private string _hoTen;
        private DateTime _ngaySinh;
        private string _sex;
        private string _cccd;
        private string _diaChi;
        private string _sdt;
        private string _maPhong;
        private string _maToa;
        private Image _anh;
        private bool _duyet;

        public SinhVien() { }
        public SinhVien(string maSv, string hoTen, DateTime ngaySinh, string sex, string cccd, string diaChi, string sdt, string maPhong, string maToa, Image anh, bool duyet)
        {
            _maSv = maSv;
            _hoTen = hoTen;
            _ngaySinh = ngaySinh;
            _sex = sex;
            _cccd = cccd;
            _diaChi = diaChi;
            _sdt = sdt;
            _maPhong = maPhong;
            _maToa = maToa;
            _anh = anh;
            _duyet = duyet;
        }

        public string MaSv { get => _maSv; set => _maSv = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public string Cccd { get => _cccd; set => _cccd = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
        public string MaToa { get => _maToa; set => _maToa = value; }
        public Image Anh { get => _anh; set => _anh = value; }
        public bool Duyet { get => _duyet; set => _duyet = value; }
    }
}
