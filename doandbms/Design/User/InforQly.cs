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
    public partial class InforQly : Form
    {
        private QuanLy qLi = new QuanLy();
        AccountRepository accountRepository = new AccountRepository();
        private Account account;
        public InforQly(Account acc)
        {   
            this.account = acc;
            InitializeComponent();
        }

        public QuanLy QLi { get => qLi; set => qLi = value; }

        private void btn_Update_Click(object sender, EventArgs e)
        {     
            if (checkFill())
            {
                qLi = getInforQly();
                qLi.ChucVu=account.Role;
                accountRepository.AddQly(qLi.MaQl,qLi.Name,qLi.MaToaQl,qLi.ChucVu,account.Username);
                GiaoDienQuanLi giaoQl = new GiaoDienQuanLi(qLi);
                giaoQl.Show();
                this.Close();
                
            }
        }

        private Boolean checkFill()
        {
            if (txt_MaQl.Text == "" || txt_MaToaQl.Text == "" || txt_Name.Text == "")
            {
                return false;
            }
            return true;
        }
        private QuanLy getInforQly()
        {
            QuanLy val = new QuanLy();
            val.MaQl = txt_MaQl.Text;
            val.Name = txt_Name.Text;
            val.MaToaQl = txt_MaToaQl.Text;
            return val;
        }

        private void InforQly_Load(object sender, EventArgs e)
        {

        }
    }
}
