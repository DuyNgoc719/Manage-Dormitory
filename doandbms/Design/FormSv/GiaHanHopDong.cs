using doandbms.Dbs;
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

namespace doandbms.Design.FormSv
{
    public partial class GiaHanHopDong : UserControl
    {
        SinhVien sv = new SinhVien();
        SVienRepository svienRepository = new SVienRepository();
        public GiaHanHopDong(SinhVien sv)
        {
            InitializeComponent();
            this.sv = sv;
        }


        private void btn_doitoa_Click(object sender, EventArgs e)
        {

        }

        private void GiaHanHopDong_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void btn_giahan_Click(object sender, EventArgs e)
        {
            bool isVaild = svienRepository.CheckNgayTraPhong(sv.MaSv);
            if (isVaild)
            {
                svienRepository.TaoSKDatPhong(sv.MaSv, sv.MaPhong, txt_soky.Text, mdf_startday.Text);
            } else
            {
                MessageBox.Show("Chưa đến ngày");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        void LoadInfor()
        {
            lbl_masv.Text = sv.MaSv;
        }
    }
}
