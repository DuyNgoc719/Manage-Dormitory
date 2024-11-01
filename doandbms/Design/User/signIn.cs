using doandbms.Dbs;
using doandbms.Design;
using doandbms.Entity;

namespace doandbms.User
{
    public partial class signIn : Form
    {
        AccountRepository accountRepository = new AccountRepository();
        public signIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp SignUp = new signUp();
            SignUp.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass forgotPass = new ForgotPass();
            forgotPass.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (checkFill())
            {
                string username = txt_Username.Text;
                string password = txt_Password.Text;
                string id = accountRepository.CheckLogin(username, password);
                MessageBox.Show(id);
                if (id!=null)
                {
                    
                    if (accountRepository.GetSinhVienById(id) != null)
                    {
                        SinhVien sinhVien = new SinhVien();
                        sinhVien = accountRepository.GetSinhVienById(id);
                        GiaoDienSinhVien giaoDienSinhVien = new GiaoDienSinhVien(sinhVien);
                        this.Hide();
                        giaoDienSinhVien.Show();
                        
                    } else
                    {
                        this.Hide();
                        QuanLy quanLy = new QuanLy();
                        quanLy = accountRepository.GetQuanLyById(id);
                        GiaoDienQuanLi giaoDienQuanLi = new GiaoDienQuanLi(quanLy);
                        giaoDienQuanLi.Show();
                    }
                }
            }
        }

        private bool checkFill()
        {
            if (txt_Password.Text == "" || txt_Username.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}