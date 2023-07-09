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
    public partial class userdelete : UserControl
    {
        private int userID;

        public userdelete(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        UserClass uc = new UserClass();

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

        private void userdelete_Load(object sender, EventArgs e)
        {
            loadUsersData();
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            if (listViewUserDetails.SelectedItems.Count > 0)
            {
                if (Convert.ToInt32(listViewUserDetails.SelectedItems[0].SubItems[0].Text) == userID)
                {
                    MessageBox.Show("Cannot delete current logged user !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Do you want to delete this record?", "Confirm deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string selectedUserID = listViewUserDetails.SelectedItems[0].SubItems[0].Text;
                    bool message = uc.deleteUser(selectedUserID);

                    if (message)
                    {
                        MessageBox.Show("Record detete successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
