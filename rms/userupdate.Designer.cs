namespace rms
{
    partial class userupdate
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.grBoxUserDetails = new System.Windows.Forms.GroupBox();
            this.chkBoxShowHide = new System.Windows.Forms.CheckBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lblRetypePwd = new System.Windows.Forms.Label();
            this.iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.listViewUserDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbUpdateKey = new System.Windows.Forms.ComboBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.grBoxUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(128, 25);
            this.lblFormTitle.TabIndex = 32;
            this.lblFormTitle.Text = "Update User";
            // 
            // grBoxUserDetails
            // 
            this.grBoxUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxUserDetails.Controls.Add(this.txtUsername);
            this.grBoxUserDetails.Controls.Add(this.lblUsername);
            this.grBoxUserDetails.Controls.Add(this.chkBoxShowHide);
            this.grBoxUserDetails.Controls.Add(this.cmbType);
            this.grBoxUserDetails.Controls.Add(this.lblType);
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
            this.grBoxUserDetails.TabIndex = 31;
            this.grBoxUserDetails.TabStop = false;
            this.grBoxUserDetails.Text = "User Details";
            // 
            // chkBoxShowHide
            // 
            this.chkBoxShowHide.AutoSize = true;
            this.chkBoxShowHide.Location = new System.Drawing.Point(144, 219);
            this.chkBoxShowHide.Name = "chkBoxShowHide";
            this.chkBoxShowHide.Size = new System.Drawing.Size(80, 17);
            this.chkBoxShowHide.TabIndex = 66;
            this.chkBoxShowHide.Text = "Show/Hide";
            this.chkBoxShowHide.UseVisualStyleBackColor = true;
            this.chkBoxShowHide.CheckedChanged += new System.EventHandler(this.chkBoxShowHide_CheckedChanged);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Administrator",
            "Chef",
            "Inventory Keeper",
            "Rider",
            "Cashier",
            "Manager"});
            this.cmbType.Location = new System.Drawing.Point(144, 300);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(361, 21);
            this.cmbType.TabIndex = 65;
            this.cmbType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbType_Validating);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(31, 303);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 64;
            this.lblType.Text = "Type:";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(144, 255);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '●';
            this.txtRePassword.Size = new System.Drawing.Size(361, 20);
            this.txtRePassword.TabIndex = 62;
            // 
            // lblRetypePwd
            // 
            this.lblRetypePwd.AutoSize = true;
            this.lblRetypePwd.Location = new System.Drawing.Point(31, 258);
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
            this.iconBtnUpdate.Location = new System.Drawing.Point(430, 346);
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
            this.txtPassword.Location = new System.Drawing.Point(144, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(361, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(31, 180);
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
            this.iconBackBtn.TabIndex = 63;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // listViewUserDetails
            // 
            this.listViewUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUserDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewUserDetails.FullRowSelect = true;
            this.listViewUserDetails.GridLines = true;
            this.listViewUserDetails.Location = new System.Drawing.Point(586, 69);
            this.listViewUserDetails.MultiSelect = false;
            this.listViewUserDetails.Name = "listViewUserDetails";
            this.listViewUserDetails.Size = new System.Drawing.Size(402, 511);
            this.listViewUserDetails.TabIndex = 65;
            this.listViewUserDetails.UseCompatibleStateImageBehavior = false;
            this.listViewUserDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Username";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Last Login";
            this.columnHeader6.Width = 100;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(144, 129);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(361, 20);
            this.txtUsername.TabIndex = 68;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(31, 132);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 67;
            this.lblUsername.Text = "Username:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbUpdateKey
            // 
            this.cmbUpdateKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateKey.FormattingEnabled = true;
            this.cmbUpdateKey.Location = new System.Drawing.Point(538, 23);
            this.cmbUpdateKey.Name = "cmbUpdateKey";
            this.cmbUpdateKey.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateKey.TabIndex = 66;
            this.cmbUpdateKey.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateKey_SelectedIndexChanged);
            this.cmbUpdateKey.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUpdateKey_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(474, 26);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(46, 13);
            this.lblUserID.TabIndex = 69;
            this.lblUserID.Text = "User ID:";
            // 
            // userupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.cmbUpdateKey);
            this.Controls.Add(this.listViewUserDetails);
            this.Controls.Add(this.iconBackBtn);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.grBoxUserDetails);
            this.Name = "userupdate";
            this.Size = new System.Drawing.Size(1014, 604);
            this.Load += new System.EventHandler(this.userupdate_Load);
            this.grBoxUserDetails.ResumeLayout(false);
            this.grBoxUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ListView listViewUserDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox chkBoxShowHide;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.ComboBox cmbUpdateKey;
    }
}
