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
    public partial class user : Form
    {
        private int userID;

        public user(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (!panelUser.Controls.ContainsKey("userupdate"))
            {
                userupdate userUpdate = new userupdate(this.userID);
                userUpdate.Dock = DockStyle.Fill;
                panelUser.Controls.Add(userUpdate);
            }
            panelUser.Controls["userupdate"].BringToFront();
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            if (!panelUser.Controls.ContainsKey("userdelete"))
            {
                userdelete userDelete = new userdelete(this.userID);
                userDelete.Dock = DockStyle.Fill;
                panelUser.Controls.Add(userDelete);
            }
            panelUser.Controls["userdelete"].BringToFront();
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (!panelUser.Controls.ContainsKey("usersearch"))
            {
                usersearch userSearch = new usersearch();
                userSearch.Dock = DockStyle.Fill;
                panelUser.Controls.Add(userSearch);
            }
            panelUser.Controls["usersearch"].BringToFront();
        }

        UserClass uc = new UserClass();
        Common common = new Common();

        private void loadUsersData()
        {
            listViewUserDetails.Items.Clear();

            DataTable usersDataList = uc.getUserList();

            foreach (DataRow dr in usersDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["first_name"].ToString());
                item.SubItems.Add(dr["last_name"].ToString());
                item.SubItems.Add(dr["username"].ToString());
                item.SubItems.Add(dr["type"].ToString());
                item.SubItems.Add(dr["last_login"].ToString());

                listViewUserDetails.Items.Add(item);
            }
        }

        private void user_Load(object sender, EventArgs e)
        {
            loadUsersData();
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
            else if (common.checkAlreadyExists("username", "[user]", Convert.ToString(txtUsername.Text.Trim())))
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

        private void cmbType_Validating(object sender, CancelEventArgs e)
        {
            if (cmbType.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbType, "Please select user type !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbType, null);
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
            cmbType.SelectedIndex = -1;
        }

        private string fname, lname, username, password, type, encpwd;

        private void iconBtnAddUser_Click(object sender, EventArgs e)
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
                        type = Convert.ToString(cmbType.SelectedItem);

                        encpwd = common.encryptPassword(password);

                        bool message = uc.addUser(fname, lname, username, encpwd, type, userID);

                        if (message)
                        {
                            clearData();
                            MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadUsersData();
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
