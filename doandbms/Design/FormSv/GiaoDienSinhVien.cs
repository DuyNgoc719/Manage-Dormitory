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

namespace doandbms
{
    public partial class GiaoDienSinhVien : Form
    {
        private SinhVien sinhVien = new SinhVien();
        public GiaoDienSinhVien(SinhVien sv)
        {
            InitializeComponent();
            this.sinhVien=sv;
        }
    }
}
