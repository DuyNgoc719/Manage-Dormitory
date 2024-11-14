using doandbms.Design;
using doandbms.Design.FormSv;
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
        SinhVien sinhvien = new SinhVien();
        public GiaoDienSinhVien(SinhVien sv)
        {
            this.sinhvien = sv;
            InitializeComponent();
            
        }
        bool sidebarExpand;
        private UserControl currentControl;
        private void CloseProductInfo()
        {
            foreach (Control control in mainForm.Controls)
            {
                if (control is UserQuanLi)
                {
                    control.Dispose();
                    return;
                }
            }
        }
        private void ShowUserControlInMainContent(UserControl userControl)
        {
            CloseProductInfo();
            if (currentControl is UserQuanLi)
            {
                currentControl.Dispose();
            }
            mainForm.Controls.Clear();
            mainForm.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            currentControl = userControl;
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void GiaoDienSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_qlSv_Click(object sender, EventArgs e)
        {
            ThongTinSinhVien thongTinSinhVien = new ThongTinSinhVien(sinhvien);
            ShowUserControlInMainContent(thongTinSinhVien);
        }

        private void btn_qlDn_Click(object sender, EventArgs e)
        {
            GiaHanHopDong giaHanHopDong = new GiaHanHopDong(sinhvien);
            ShowUserControlInMainContent(giaHanHopDong);
        }

    }
}
