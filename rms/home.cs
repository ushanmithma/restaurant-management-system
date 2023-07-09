using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace rms
{
    public partial class home : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Color primaryColor = Color.FromArgb(255, 120, 0);
        private Form currentChildForm;

        // Variables
        private int userID;
        
        // Constructor
        public home(int id)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.userID = id;
        }

        // Methods
        private void ActivateButton(object senderBtn, Color color) {
            if (senderBtn != null) {

                DisableButton();

                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;

                // Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
            }
        }

        private void DisableButton() {
            if (currentBtn != null) {

                currentBtn.ForeColor = Color.Black;
                currentBtn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void iconBtnEmp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new employee(this.userID));
        }

        private void iconBtnCust_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new customer(this.userID));
        }

        private void iconBtnSup_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new supplier(this.userID));
        }

        private void iconBtnItems_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new orders());
        }

        private void iconBtnMeals_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new meal(this.userID));
        }

        private void iconBtnDineIn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new dinein(this.userID));
        }

        private void iconBtnDeli_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new delivery(this.userID));
        }

        private void iconBtnPay_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new payments(this.userID));
        }

        private void iconBtnInve_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new inventory(this.userID));
        }

        private void iconBtnUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
            OpenChildForm(new user(this.userID));
        }

        private void main_Load(object sender, EventArgs e)
        {
            setLoggedUser(this.userID);
            ActivateButton(this.iconBtnEmp, primaryColor);
            OpenChildForm(new employee(this.userID));
        }

        // Open logged user settings
        private void linkLblUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new userlogged(this.userID));
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.UserAlt;
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            login log = new login();
            log.Close();
        }

        private void setLoggedUser(int userID)
        {
            UserClass uc = new UserClass();

            Dictionary<string, string> userData = uc.getUserData("id", Convert.ToString(userID));

            foreach (KeyValuePair<string, string> userKeyValuePair in userData)
            {
                switch (userKeyValuePair.Key)
                {
                    case "fname":

                        if (userKeyValuePair.Value.Length > 13)
                        {
                            string fname = userKeyValuePair.Value.Substring(0, 13);
                            lblFirstName.Text = fname + "...";
                        }
                        else
                        {
                            lblFirstName.Text = userKeyValuePair.Value;
                        }

                        break;
                    case "username":

                        if (userKeyValuePair.Value.Length > 22)
                        {
                            string uname = userKeyValuePair.Value.Substring(0, 22);
                            linkLblUsername.Text = uname + "...";
                        }
                        else
                        {
                            linkLblUsername.Text = userKeyValuePair.Value;
                        }

                        break;
                    case "type":

                        if (userKeyValuePair.Value == "Administrator")
                        {
                            iconBtnUsers.Visible = true;
                        }

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
