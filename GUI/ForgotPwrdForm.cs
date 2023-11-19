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

        //Kiểm tra username nhập vào
        private void btnCheckUserName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                //Thông báo nếu chưa nhập username
                //Nếu đúng tiếp tục kiểm tra
                if (userBLL.CheckUsernameExists(txtUserName.Text))
                {
                    //Nếu username tồn tại trong CSDL, hiển thị chức năng nhận OTP
                    setVisible();
                }
                else
                {
                    //Nếu username không tồn tại, thông báo cho người dùng
                    MessageBox.Show("Wrong Username!!!");
                }
            }
            else
            {
                MessageBox.Show("Enter Username!!!");
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

        //Xử lý sự kiện nhận OTP
        private void btnGetOTP_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmail.Text)) 
            {
                //Nếu chưa nhập Email, hiển thị thông báo
                MessageBox.Show("Enter Email!!!");
            }
            else if(!IsValidEmail(txtEmail.Text))
            {
                //Nếu Email không ở dạng abc@def.xyz, hiển thị thông báo
                MessageBox.Show("Not valid Email!!!");
            }
            else if(!CheckEmail(txtEmail.Text)) 
            {
                //Nếu Email không khớp với Email liên kết với tài khoản trong CSDL, hiển thị thông báo
                MessageBox.Show("Wrong Email!!!");
            }
            else
            {
                //Nếu tất cả hợp lệ tiến hành gửi Email
                otp = SendOtpToEmail(txtEmail.Text);
            }
        }

        //Kiểm tra định dạng Email nhập vào
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        //Kiểm tra Email có khớp với Email liên kết với tài khoản trong CSDL hay không
        private bool CheckEmail(string inputEmail)
        {
            string email = userBLL.GetEmailFromUserName(txtUserName.Text);
            if(email == inputEmail)
            {
                return true;
            }
            return false;
        }


        //Gửi OTP qua Email
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
                btnConfirm.Visible = true;
                return otp;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Cant send Email. Error: " + ex.Message);
            }
            return -1;
        }

        //Kiểm tra OTP khi nhấn Confirm
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOTP.Text))
            {
                MessageBox.Show("Enter OTP!!!");
            }
            else if(txtOTP.Text != otp.ToString())
            {
                MessageBox.Show("Wrong OTP!!!");
            }
            else
            {
                //Nếu OTP hợp lệ tiến hành tọa form đổi mật khẩu cho người dùng
                this.Hide();
                ChangePasswordForm changePasswordForm = new ChangePasswordForm(txtUserName.Text);
                changePasswordForm.Show();

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(txtUserName.Text);
            changePasswordForm.Show();
        }
    }
}
