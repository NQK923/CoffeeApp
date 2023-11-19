using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        private UserBLL userBLL = new UserBLL();
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;
        }

        //Xử lý sự kiện đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserNameLogin.Text;
            string password = txtPasswordLogin.Text;

            int userId = userBLL.getId(username, password);
            System.Console.WriteLine(userId);
            if (userId != -1 && userId != null)
            {
                var userRoles = new List<string>();
                userRoles = userBLL.getUserRoles(userId);
                //Nếu là cửa hàng thì hiển thị Submenu Form
                if (userRoles.Contains("Branch stores"))
                {

                    SubMenu subMenu1 = new SubMenu();
                    subMenu1.SetDataFromLogin(userBLL.getUserByUsernameAndPassword(username, password));
                    subMenu1.Show();
                }
                //Nếu là Admin thì hiển thị ManagementAll form
                else if (userRoles.Contains("Manager"))
                {
                    ManagementAll managementAll = new ManagementAll();
                    managementAll.Show();
                }
                else
                {
                    MessageBox.Show("User does not have a valid role.");
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        //Quên mật khẩu
        private void btnForgotPwrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPwrdForm form = new ForgotPwrdForm();
            form.Show();
        }

        //Đổi mật khẩu
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(null);
            changePasswordForm.Show();
        }
    }
}
