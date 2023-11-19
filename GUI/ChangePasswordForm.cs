using System;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class ChangePasswordForm : Form
    {
        private UserBLL userBLL = new UserBLL();
        private string username;
        public ChangePasswordForm(string name)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.username = name;
            setVisible(name);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtPW.Visible == true)
            {
                updatePassword();
            }
            else
            {
                createNewPassword();

            }
        }

        private void createNewPassword()
        {
            if (string.IsNullOrEmpty(txtConfirmPW.Text) || string.IsNullOrEmpty(txtNewPW.Text))
            {
                MessageBox.Show("Please complete all information!!!");
            }
            else 
            {
                if(txtConfirmPW.Text==txtNewPW.Text)
                {
                    userBLL.ChangePassword(username, txtConfirmPW.Text);
                    MessageBox.Show("New password created successfully!!!");
                }
                else
                {
                    MessageBox.Show("Password doesn't match!!!");
                }
            }
        }

        private bool checkInput()
        {
            
            if(string.IsNullOrEmpty(txtUserName.Text)||string.IsNullOrEmpty(txtPW.Text)|| string.IsNullOrEmpty(txtNewPW.Text) || string.IsNullOrEmpty(txtConfirmPW.Text)){
                MessageBox.Show("Please complete all information!!!");
                return false;
            }
            string oldPassword = userBLL.GetPasswordFromUserName(txtUserName.Text);
            if (!userBLL.CheckUsernameExists(txtUserName.Text)||oldPassword!=txtPW.Text) {
                MessageBox.Show("Wrong username or password!!!");
                return false;
            }
            else if(txtNewPW.Text==oldPassword)
            {
                MessageBox.Show("New and old passwords must not be the same!!!");
                return false;
            }
            else 
            { 
                return true; 
            }
        }
        private void updatePassword()
        {
            if (checkInput())
            {
                if (txtConfirmPW.Text == txtNewPW.Text)
                {
                    userBLL.ChangePassword(txtUserName.Text, txtConfirmPW.Text);
                    MessageBox.Show("New password created successfully!!!");
                }
                else
                {
                    MessageBox.Show("Password doesn't match!!!");
                }
            }
        }

        private void setVisible(string username)
        {
            if(username == null)
            {
                txtPW.Visible = true;
                labelPW.Visible = true;
            }
            else
            {
                txtUserName.Text = username;
                txtUserName.Enabled = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
