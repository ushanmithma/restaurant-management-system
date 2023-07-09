using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        UserClass uc = new UserClass();
        Common common = new Common();

        home main;

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Please enter username !");
            }
            else if (txtUsername.Text.Trim().Length < 3 || txtUsername.Text.Trim().Length > 255)
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Invalid username !");
            }
            else if (txtUsername.Text.Trim().Contains(' ') || txtUsername.Text.Trim().Contains('\'') || txtUsername.Text.Trim().Contains('"') || txtUsername.Text.Trim().Contains('\\'))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Invalid username !");
            }
            else if (common.checkIfNotExists("username", "[user]", txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Check your username again !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "Please enter password !");
            }
            else if (txtPassword.Text.Trim().Length < 3 || txtPassword.Text.Trim().Length > 255)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "Wrong password !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, null);
            }
        }

        private string username, encpwd;
        private int userID;

        private void iconBtnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                username = Convert.ToString(txtUsername.Text.Trim());
                encpwd = common.encryptPassword(Convert.ToString(txtPassword.Text.Trim()));

                bool isAvailable = uc.isUserAvailable(username, encpwd);

                if (isAvailable)
                {
                    bool isUpdatedLastLogin = uc.updateLastLogin(username);
                    userID = uc.getUserID(username);

                    if (isUpdatedLastLogin)
                    {
                        main = new home(userID);
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
