using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doandbms.Entity
{
    public class QuanLy
    {
        private string _maQl;
        private string _maToaQl;
        private string _name;
        private string _chucVu;
            
        public QuanLy() { }

        public QuanLy(string maQl, string maToaQl, string name, string chucVu)
        {
            _maQl = maQl;
            _maToaQl = maToaQl;
            _name = name;
            _chucVu = chucVu;
        }

        public string MaQl { get => _maQl; set => _maQl = value; }
        public string MaToaQl { get => _maToaQl; set => _maToaQl = value; }
        public string Name { get => _name; set => _name = value; }
        public string ChucVu { get => _chucVu; set => _chucVu = value; }
    }
}
