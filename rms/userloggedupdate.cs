using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rms
{
    public partial class userloggedupdate : UserControl
    {
        private int userID;

        public userloggedupdate(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        UserClass uc = new UserClass();
        Common common = new Common();

        private void userloggedupdate_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> userData = uc.getUserData("id", Convert.ToString(this.userID));
            string decrpwd;

            foreach (KeyValuePair<string, string> userKeyValuePair in userData)
            {
                switch (userKeyValuePair.Key)
                {
                    case "fname":
                        txtFirstName.Text = userKeyValuePair.Value;
                        break;
                    case "lname":
                        txtLastName.Text = userKeyValuePair.Value;
                        break;
                    case "username":
                        txtUsername.Text = userKeyValuePair.Value;
                        break;
                    case "password":

                        decrpwd = common.decryptPassword(userKeyValuePair.Value);
                        txtPassword.Text = decrpwd;

                        break;
                    default:
                        break;
                }
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFirstName, "Please enter your first name !");
            }
            else if (txtFirstName.Text.Trim().Length < 3 || txtFirstName.Text.Trim().Length > 255)
            {
                e.Cancel = true;
                errorProvider.SetError(txtFirstName, "Invalid name !");
            }
            else if (!txtFirstName.Text.Trim().All(c => char.IsWhiteSpace(c) || char.IsLetter(c)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFirstName, "Invalid name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtFirstName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLastName, "Please enter your first name !");
            }
            else if (txtLastName.Text.Trim().Length < 3 || txtLastName.Text.Trim().Length > 255)
            {
                e.Cancel = true;
                errorProvider.SetError(txtFirstName, "Invalid name !");
            }
            else if (!txtLastName.Text.Trim().All(c => char.IsWhiteSpace(c) || char.IsLetter(c)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLastName, "Invalid name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLastName, null);
            }
        }

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
            else if (common.checkAlreadyExistsOthers(userID, "username", "[user]", Convert.ToString(txtUsername.Text.Trim()), "id"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Username is already exists !");
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
            else if (txtPassword.Text.Trim().Length < 4 || txtPassword.Text.Trim().Length > 255)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "Password must be between 4 and 255 characters !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void chkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowHide.CheckState == CheckState.Checked)
            {
                txtPassword.PasswordChar = new char();
            }
            else if (chkBoxShowHide.CheckState == CheckState.Unchecked)
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void clearData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtRePassword.Text = "";
        }

        string fname, lname, username, password, encpwd;

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    if (string.IsNullOrEmpty(txtRePassword.Text.Trim()))
                    {
                        errorProvider.SetError(txtRePassword, "Please enter password !");
                    }
                    else if (txtPassword.Text.Trim() != txtRePassword.Text.Trim())
                    {
                        errorProvider.SetError(txtRePassword, "Password isn't match !");
                    }
                    else
                    {
                        errorProvider.SetError(txtRePassword, null);

                        fname = Convert.ToString(txtFirstName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                        lname = Convert.ToString(txtLastName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                        username = Convert.ToString(txtUsername.Text.Trim());
                        password = Convert.ToString(txtPassword.Text.Trim());

                        encpwd = common.encryptPassword(password);

                        bool message = uc.updateLoggedUser(fname, lname, username, encpwd, userID);

                        if (message)
                        {
                            //clearData();
                            //MessageBox.Show("Record update successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ((Form)this.TopLevelControl).Close();
                            login log = new login();
                            log.Show();
                        }
                        else
                        {
                            MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
