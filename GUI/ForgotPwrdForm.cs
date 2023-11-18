using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class ForgotPwrdForm : Form
    {
        public int otp;
        private UserBLL userBLL = new UserBLL();
        public ForgotPwrdForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (userBLL.CheckUsernameExists(txtUserName.Text))
                {
                    setVisible();
                }
            }
            else
            {
                MessageBox.Show("Enter user name!!!");
            }
        }

        private void setVisible()
        {
            btnGetOTP.Visible = true;
            txtEmail.Visible = true;
            labelEmail.Visible = true;
            labelMess.Visible = true;
            labelOTP.Visible = true;
            txtOTP.Visible = true;
        }

        private void btnForgotPwrd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmail.Text)) 
            {
                MessageBox.Show("Enter Email!!!");
            }
            else if(!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Not valid Email!!!");
            }
            else if(!CheckEmail(txtEmail.Text)) 
            {
                MessageBox.Show("Wrong Email!!!");
            }
            else
            {
                otp = SendOtpToEmail(txtEmail.Text);
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private bool CheckEmail(string inputEmail)
        {
            string email = userBLL.GetEmailFromUserName(txtUserName.Text);
            if(email == inputEmail)
            {
                return true;
            }
            return false;
        }

        private int SendOtpToEmail(string toEmailAddress)
        {
            try
            {
                // Tạo mã OTP 6 số ngẫu nhiên
                Random random = new Random();
                int otp = random.Next(100000, 999999);

                // Tạo email
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); // Sử dụng SMTP server của Gmail

                mail.From = new MailAddress("coffeemanageotp@gmail.com");
                mail.To.Add(toEmailAddress);
                mail.Subject = "Coffee App OTP";
                mail.Body = "Mã OTP của bạn là: " + otp + " .Đây là tin nhắn tự dộng, vui long không trả lời!";

                // Cấu hình SMTP server
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("coffeemanageotp@gmail.com", "kyll bdmp swvq hisg");
                SmtpServer.EnableSsl = true;

                // Gửi email
                SmtpServer.Send(mail);

                MessageBox.Show("Email has been sent successfully!!!");
                return otp;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Cant send Email. Error: " + ex.Message);
                
            }
            return -1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }
    }
}
