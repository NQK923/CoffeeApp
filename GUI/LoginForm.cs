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
        }

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

                if (userRoles.Contains("Branch stores"))
                {

                    SubMenu subMenu1 = new SubMenu();
                    subMenu1.SetDataFromLogin(userBLL.getUserByUsernameAndPassword(username, password));
                    subMenu1.Show();
                }
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
    }
}
