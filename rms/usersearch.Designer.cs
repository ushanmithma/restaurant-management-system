namespace rms
{
    partial class usersearch
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
            this.iconBtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSUsername = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblSLastLogin = new System.Windows.Forms.Label();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSecondName = new System.Windows.Forms.Label();
            this.listViewUserDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
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
            this.iconBackBtn.TabIndex = 59;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(127, 25);
            this.lblFormTitle.TabIndex = 60;
            this.lblFormTitle.Text = "Search User";
            // 
            // iconBtnSearch
            // 
            this.iconBtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.iconBtnSearch.FlatAppearance.BorderSize = 0;
            this.iconBtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.iconBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSearch.ForeColor = System.Drawing.Color.White;
            this.iconBtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearch.IconColor = System.Drawing.Color.White;
            this.iconBtnSearch.IconSize = 16;
            this.iconBtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSearch.Location = new System.Drawing.Point(907, 25);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(75, 23);
            this.iconBtnSearch.TabIndex = 67;
            this.iconBtnSearch.Text = "Search";
            this.iconBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSearch.UseVisualStyleBackColor = false;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(753, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(134, 20);
            this.txtUsername.TabIndex = 66;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblSUsername
            // 
            this.lblSUsername.AutoSize = true;
            this.lblSUsername.Location = new System.Drawing.Point(669, 30);
            this.lblSUsername.Name = "lblSUsername";
            this.lblSUsername.Size = new System.Drawing.Size(58, 13);
            this.lblSUsername.TabIndex = 65;
            this.lblSUsername.Text = "Username:";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 225;
            this.iconPictureBox1.Location = new System.Drawing.Point(134, 94);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(225, 226);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 69;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblSLastLogin
            // 
            this.lblSLastLogin.AutoSize = true;
            this.lblSLastLogin.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLastLogin.Location = new System.Drawing.Point(199, 552);
            this.lblSLastLogin.Name = "lblSLastLogin";
            this.lblSLastLogin.Size = new System.Drawing.Size(92, 25);
            this.lblSLastLogin.TabIndex = 74;
            this.lblSLastLogin.Text = "----------";
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLogin.Location = new System.Drawing.Point(65, 552);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(114, 25);
            this.lblLastLogin.TabIndex = 73;
            this.lblLastLogin.Text = "Last Login:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(64, 481);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(115, 33);
            this.lblType.TabIndex = 72;
            this.lblType.Text = "----------";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(65, 405);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 29);
            this.lblUsername.TabIndex = 71;
            this.lblUsername.Text = "----------";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(63, 323);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 38);
            this.lblName.TabIndex = 70;
            this.lblName.Text = "----------";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(63, 361);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(85, 33);
            this.lblSecondName.TabIndex = 75;
            this.lblSecondName.Text = "----------";
            this.lblSecondName.Visible = false;
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
            this.listViewUserDetails.Location = new System.Drawing.Point(539, 94);
            this.listViewUserDetails.MultiSelect = false;
            this.listViewUserDetails.Name = "listViewUserDetails";
            this.listViewUserDetails.Size = new System.Drawing.Size(443, 483);
            this.listViewUserDetails.TabIndex = 76;
            this.listViewUserDetails.UseCompatibleStateImageBehavior = false;
            this.listViewUserDetails.View = System.Windows.Forms.View.Details;
            this.listViewUserDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewUserDetails_MouseDoubleClick);
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
            this.columnHeader6.Width = 150;
            // 
            // usersearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewUserDetails);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lblSLastLogin);
            this.Controls.Add(this.lblLastLogin);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconBtnSearch);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSUsername);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "usersearch";
            this.Size = new System.Drawing.Size(1014, 604);
            this.Load += new System.EventHandler(this.usersearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSUsername;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblSLastLogin;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.ListView listViewUserDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
