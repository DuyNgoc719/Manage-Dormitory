using doandbms.Dbs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doandbms
{
    public partial class ForgotPass : Form
    {
        AccountRepository accountRepository = new AccountRepository();
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != "")
            {
                bool emailExit = accountRepository.CheckEmailExists(txt_email.Text);
                if (emailExit)
                {
   
                    string newPassword = GenerateRandomPassword(8);

                    
                    accountRepository.UpdatePassword(txt_email.Text, newPassword);

                
                    SendEmail(txt_email.Text, newPassword);

                    MessageBox.Show("A new password has been sent to your email.");
                }
                else
                {
                    MessageBox.Show("Email does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please enter your email.");
            }
        }

        public void SendEmail(string toEmail, string password)
        {
            try
            {
                var fromEmail = "ngocdeptry719@gmail.com";
                var fromPassword = "wycg siiq mogi tcni"; 
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromEmail),
                    Subject = "Password Reset Request",
                    Body = $"Your new password is: {password}",
                    IsBodyHtml = true,
                };

                mailMessage.To.Add(toEmail);
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}");
            }
        }
        public string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(password);
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
