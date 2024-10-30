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

namespace doandbms.Design
{
    public partial class UserQuanLi : UserControl
    {
        QuanLy quanLy = new QuanLy();
        public UserQuanLi(QuanLy quanLy)
        {
            this.quanLy = quanLy;
            InitializeComponent();
        }

        private void UserQuanLi_Load(object sender, EventArgs e)
        {
            getInforQuanLy();
        }

        private void getInforQuanLy()
        {
            txt_chucVu.Text =quanLy.ChucVu.ToString();
            txt_maQl.Text = quanLy.MaQl.ToString();
            txt_maToaQl.Text = quanLy.MaToaQl.ToString();
            txt_name.Text = quanLy.Name.ToString();
        }
    }
}
