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
    public partial class usersearch : UserControl
    {
        public usersearch()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
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

        private void usersearch_Load(object sender, EventArgs e)
        {
            loadUsersData();
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
            else if (common.checkIfNotExists("username", "[user]", txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "This username is not in the database !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void searchUserData(string username)
        {
            Dictionary<string, string> userData = uc.getUserData("username", username);

            foreach (KeyValuePair<string, string> userKeyValuePair in userData)
            {
                switch (userKeyValuePair.Key)
                {
                    case "name":

                        if (userKeyValuePair.Value.Length > 18)
                        {
                            string[] spearator = { " " };
                            int count = 2;
                            String[] nameArr = userKeyValuePair.Value.Split(spearator, count, StringSplitOptions.None);
                            string firstPart = nameArr[0];
                            string otherParts = nameArr[1];

                            lblName.Text = firstPart;
                            lblSecondName.Visible = true;

                            if (otherParts.Length >= 24)
                            {
                                string otherName = otherParts.Substring(0, 24);
                                lblSecondName.Text = otherName + "...";
                            }
                            else
                            {
                                lblSecondName.Text = otherParts;
                            }
                        }
                        else
                        {
                            lblSecondName.Visible = false;
                            lblName.Text = userKeyValuePair.Value;
                        }

                        break;
                    case "username":
                        lblUsername.Text = userKeyValuePair.Value;
                        break;
                    case "type":
                        lblType.Text = userKeyValuePair.Value;
                        break;
                    case "lastLogin":
                        lblSLastLogin.Text = userKeyValuePair.Value;
                        break;
                    default:
                        break;
                }
            }
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string username = Convert.ToString(txtUsername.Text.Trim());
                searchUserData(username);
            }
        }

        private void listViewUserDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedUserID = listViewUserDetails.SelectedItems[0].SubItems[3].Text;
            searchUserData(clickedUserID);
        }
    }
}
