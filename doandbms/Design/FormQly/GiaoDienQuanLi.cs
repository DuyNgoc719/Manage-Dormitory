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
    public partial class GiaoDienQuanLi : Form
    {
        QuanLy quanL = new QuanLy();
        public GiaoDienQuanLi(QuanLy ql)
        {
            InitializeComponent();
            this.quanL = ql;
        }

        bool sidebarExpand;
        private UserControl currentControl;

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
        private void sidebarTimer_Tick_1(object sender, EventArgs e)
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

        private void btn_inforQl_Click(object sender, EventArgs e)
        {
            UserQuanLi userQuanli = new UserQuanLi(quanL);
            ShowUserControlInMainContent(userQuanli);
        }

        private void GiaoDienQuanLi_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_qlSv_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien quanLiSinhVien = new QuanLiSinhVien(quanL);
            ShowUserControlInMainContent(quanLiSinhVien);
        }

        private void btn_qlDn_Click(object sender, EventArgs e)
        {
            QuanLiDienNuoc quanLiDienNuoc = new QuanLiDienNuoc(quanL);
            ShowUserControlInMainContent(quanLiDienNuoc);
        }

        private void btn_qlPhong_Click(object sender, EventArgs e)
        {
            QuanLiPhong quanLiPhong = new QuanLiPhong(quanL);
            ShowUserControlInMainContent(quanLiPhong);
        }

        private void btn_qlHd_Click(object sender, EventArgs e)
        {
            QuanLiHopDong quanLiHopDong = new QuanLiHopDong(quanL);
            ShowUserControlInMainContent(quanLiHopDong);
        }

        private void btn_Kl_Click(object sender, EventArgs e)
        {
            KyLuat kyLuat= new KyLuat(quanL);
            ShowUserControlInMainContent(kyLuat);
        }
    }
}
