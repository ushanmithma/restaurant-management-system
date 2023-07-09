namespace rms
{
    partial class userdelete
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.listViewUserDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(121, 25);
            this.lblFormTitle.TabIndex = 61;
            this.lblFormTitle.Text = "Delete User";
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
            this.iconBackBtn.TabIndex = 60;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // iconBtnDelete
            // 
            this.iconBtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.iconBtnDelete.FlatAppearance.BorderSize = 0;
            this.iconBtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.iconBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnDelete.ForeColor = System.Drawing.Color.White;
            this.iconBtnDelete.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconBtnDelete.IconColor = System.Drawing.Color.White;
            this.iconBtnDelete.IconSize = 16;
            this.iconBtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDelete.Location = new System.Drawing.Point(859, 25);
            this.iconBtnDelete.Name = "iconBtnDelete";
            this.iconBtnDelete.Rotation = 0D;
            this.iconBtnDelete.Size = new System.Drawing.Size(75, 23);
            this.iconBtnDelete.TabIndex = 63;
            this.iconBtnDelete.Text = "Delete";
            this.iconBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
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
            this.listViewUserDetails.Location = new System.Drawing.Point(23, 69);
            this.listViewUserDetails.MultiSelect = false;
            this.listViewUserDetails.Name = "listViewUserDetails";
            this.listViewUserDetails.Size = new System.Drawing.Size(911, 492);
            this.listViewUserDetails.TabIndex = 66;
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
            this.columnHeader6.Width = 150;
            // 
            // userdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewUserDetails);
            this.Controls.Add(this.iconBtnDelete);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "userdelete";
            this.Size = new System.Drawing.Size(960, 584);
            this.Load += new System.EventHandler(this.userdelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private System.Windows.Forms.ListView listViewUserDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
