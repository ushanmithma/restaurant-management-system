namespace rms
{
    partial class userloggedupdate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.grBoxUserDetails = new System.Windows.Forms.GroupBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lblRetypePwd = new System.Windows.Forms.Label();
            this.iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.chkBoxShowHide = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            this.grBoxUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBackBtn
            // 
            this.iconBackBtn.BackColor = System.Drawing.SystemColors.Control;
            this.iconBackBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconBackBtn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconBackBtn.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBackBtn.Location = new System.Drawing.Point(23, 16);
            this.iconBackBtn.Name = "iconBackBtn";
            this.iconBackBtn.Size = new System.Drawing.Size(32, 32);
            this.iconBackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBackBtn.TabIndex = 64;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(128, 25);
            this.lblFormTitle.TabIndex = 65;
            this.lblFormTitle.Text = "Update User";
            // 
            // grBoxUserDetails
            // 
            this.grBoxUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxUserDetails.Controls.Add(this.txtUsername);
            this.grBoxUserDetails.Controls.Add(this.lblUsername);
            this.grBoxUserDetails.Controls.Add(this.chkBoxShowHide);
            this.grBoxUserDetails.Controls.Add(this.txtRePassword);
            this.grBoxUserDetails.Controls.Add(this.lblRetypePwd);
            this.grBoxUserDetails.Controls.Add(this.iconBtnUpdate);
            this.grBoxUserDetails.Controls.Add(this.txtPassword);
            this.grBoxUserDetails.Controls.Add(this.lblPassword);
            this.grBoxUserDetails.Controls.Add(this.txtLastName);
            this.grBoxUserDetails.Controls.Add(this.lblLastName);
            this.grBoxUserDetails.Controls.Add(this.txtFirstName);
            this.grBoxUserDetails.Controls.Add(this.lblFirstName);
            this.grBoxUserDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxUserDetails.Name = "grBoxUserDetails";
            this.grBoxUserDetails.Size = new System.Drawing.Size(537, 511);
            this.grBoxUserDetails.TabIndex = 66;
            this.grBoxUserDetails.TabStop = false;
            this.grBoxUserDetails.Text = "User Details";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(144, 248);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '●';
            this.txtRePassword.Size = new System.Drawing.Size(361, 20);
            this.txtRePassword.TabIndex = 62;
            // 
            // lblRetypePwd
            // 
            this.lblRetypePwd.AutoSize = true;
            this.lblRetypePwd.Location = new System.Drawing.Point(31, 251);
            this.lblRetypePwd.Name = "lblRetypePwd";
            this.lblRetypePwd.Size = new System.Drawing.Size(93, 13);
            this.lblRetypePwd.TabIndex = 61;
            this.lblRetypePwd.Text = "Retype Password:";
            // 
            // iconBtnUpdate
            // 
            this.iconBtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.iconBtnUpdate.FlatAppearance.BorderSize = 0;
            this.iconBtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.iconBtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnUpdate.ForeColor = System.Drawing.Color.White;
            this.iconBtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconBtnUpdate.IconColor = System.Drawing.Color.White;
            this.iconBtnUpdate.IconSize = 16;
            this.iconBtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnUpdate.Location = new System.Drawing.Point(430, 298);
            this.iconBtnUpdate.Name = "iconBtnUpdate";
            this.iconBtnUpdate.Rotation = 0D;
            this.iconBtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.iconBtnUpdate.TabIndex = 60;
            this.iconBtnUpdate.Text = "Update";
            this.iconBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnUpdate.UseVisualStyleBackColor = false;
            this.iconBtnUpdate.Click += new System.EventHandler(this.iconBtnUpdate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(361, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(31, 175);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(144, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(361, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(31, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(144, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(361, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(31, 39);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // chkBoxShowHide
            // 
            this.chkBoxShowHide.AutoSize = true;
            this.chkBoxShowHide.Location = new System.Drawing.Point(144, 212);
            this.chkBoxShowHide.Name = "chkBoxShowHide";
            this.chkBoxShowHide.Size = new System.Drawing.Size(80, 17);
            this.chkBoxShowHide.TabIndex = 67;
            this.chkBoxShowHide.Text = "Show/Hide";
            this.chkBoxShowHide.UseVisualStyleBackColor = true;
            this.chkBoxShowHide.CheckedChanged += new System.EventHandler(this.chkBoxShowHide_CheckedChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(144, 128);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(361, 20);
            this.txtUsername.TabIndex = 69;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(31, 131);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 68;
            this.lblUsername.Text = "Username:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // userloggedupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grBoxUserDetails);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "userloggedupdate";
            this.Size = new System.Drawing.Size(1014, 604);
            this.Load += new System.EventHandler(this.userloggedupdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            this.grBoxUserDetails.ResumeLayout(false);
            this.grBoxUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grBoxUserDetails;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lblRetypePwd;
        private FontAwesome.Sharp.IconButton iconBtnUpdate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox chkBoxShowHide;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
