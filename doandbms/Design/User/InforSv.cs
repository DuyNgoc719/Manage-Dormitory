using doandbms.Dbs;
using doandbms.Design;
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

namespace doandbms.User
{
    public partial class InforSv : Form
    {
        private SinhVien sinhVien = new SinhVien();
        AccountRepository accountRepository = new AccountRepository();
        private Account account;
        public InforSv(Account acc)
        {   
            this.account = acc;
            InitializeComponent();
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {     
            if (checkFill())
            {
                sinhVien = getInforSv();
                MessageBox.Show(sinhVien.MaSv.ToString());
                accountRepository.AddSv(sinhVien.MaSv,sinhVien.HoTen,sinhVien.MaToa,sinhVien.Cccd,sinhVien.MaPhong,sinhVien.Sdt,account.Username);
                signIn signIn = new signIn();
                signIn.Show();
                this.Close();
            }
        }

        private Boolean checkFill()
        {
            if (txt_MaSv.Text == "" || txt_Cccd.Text == "" || txt_Name.Text == "")
            {
                return false;
            }
            return true;
        }
        private SinhVien getInforSv()
        {
            SinhVien val = new SinhVien();
            val.MaSv = txt_MaSv.Text;
            val.HoTen = txt_Name.Text;
            val.MaToa = txt_MaToa.Text;
            val.Cccd = txt_Cccd.Text;
            val.MaPhong = txt_MaPhong.Text;
            val.Sdt=txt_phone.Text;
            val.NgaySinh = DateTime.Today;
            return val;
        }

        private void InforQly_Load(object sender, EventArgs e)
        {

        }
    }
}
