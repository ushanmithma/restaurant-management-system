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
    public partial class userlogged : Form
    {
        private int userID;

        public userlogged(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (!panelUser.Controls.ContainsKey("userloggedupdate"))
            {
                userloggedupdate userLoggedUpdate = new userloggedupdate(this.userID);
                userLoggedUpdate.Dock = DockStyle.Fill;
                panelUser.Controls.Add(userLoggedUpdate);
            }
            panelUser.Controls["userloggedupdate"].BringToFront();
        }

        UserClass uc = new UserClass();

        private void userlogged_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> userData = uc.getUserData("id", Convert.ToString(userID));

            foreach (KeyValuePair<string, string> userKeyValuePair in userData)
            {
                switch (userKeyValuePair.Key)
                {
                    case "id":
                        lblUserID.Text = userKeyValuePair.Value;
                        break;
                    case "name":
                        lblName.Text = userKeyValuePair.Value;
                        break;
                    case "username":
                        lblUsername.Text = userKeyValuePair.Value;
                        break;
                    case "type":
                        lblType.Text = userKeyValuePair.Value;
                        break;
                    case "lastLogin":
                        lblUserLastLogin.Text = userKeyValuePair.Value;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
