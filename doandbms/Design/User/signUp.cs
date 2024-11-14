using doandbms.Dbs;
using doandbms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doandbms.User
{
    public partial class signUp : Form
    {
        AccountRepository accountRepository = new AccountRepository();
        private Account acc = new Account();

        public signUp()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        private void signUp_Load(object sender, EventArgs e)
        {
        }
        private void btn_Reg_Click(object sender, EventArgs e)
        {
            if (!checkFill())
            {
                MessageBox.Show("Please fill all");
            }
            else
            {
                acc = getAccount();
                accountRepository.AddAccount(acc.Username, acc.Password, acc.Email, acc.Role);
            }
            InforSv inforSv = new InforSv(acc);
            this.Hide();
            inforSv.Show();
            
        }
        private Account getAccount()
        {
            Account val = new Account();
            val.Username = txt_Username.Text;
            val.Password = txt_Password.Text;
            val.Email = txt_Email.Text;
            val.Role = "ROLE_SV";
            return val;
        }

        private bool checkFill()
        {
            if (txt_Username.Text == "" || txt_Password.Text == ""
                || txt_Email.Text == "" || txt_RePassword.Text == "")
            {
                return false;
            }
            return true;

        }

        private void txt_RePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
