using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doandbms.Design.FormAdmin
{
    public partial class GiaoDienAdmin : Form
    {
        public GiaoDienAdmin()
        {
            InitializeComponent();
        }
        bool sidebarExpand;
        private UserControl currentControl;
        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
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

        private void btn_qlSv_Click(object sender, EventArgs e)
        {
            AdminQuanLiQuanLi quanLiQuanLi = new AdminQuanLiQuanLi();
            ShowUserControlInMainContent(quanLiQuanLi);
        }

        private void btn_qlDn_Click(object sender, EventArgs e)
        {
            AdminQuanLiDienNuoc quanLiDienNuoc = new AdminQuanLiDienNuoc();
            ShowUserControlInMainContent(quanLiDienNuoc);
        }

        private void btn_qlPhong_Click(object sender, EventArgs e)
        {
            AdminQuanLiPhong quanLiPhong= new AdminQuanLiPhong();
            ShowUserControlInMainContent(quanLiPhong);

        }

        private void btn_qlHd_Click(object sender, EventArgs e)
        {
            AdminQuanLiHopDong quanLiHopDong= new AdminQuanLiHopDong();
            ShowUserControlInMainContent(quanLiHopDong);
        }

        private void btn_inforQl_Click(object sender, EventArgs e)
        {
            AdminKyLuat adminKyLuat= new AdminKyLuat();
            ShowUserControlInMainContent(adminKyLuat);
        }
    }
}
