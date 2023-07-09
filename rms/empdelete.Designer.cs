namespace rms
{
    partial class empdelete
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
            this.lblEmpNIC = new System.Windows.Forms.Label();
            this.txtEmployeeNIC = new System.Windows.Forms.TextBox();
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
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
            this.iconBackBtn.TabIndex = 33;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // lblEmpNIC
            // 
            this.lblEmpNIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpNIC.AutoSize = true;
            this.lblEmpNIC.Location = new System.Drawing.Point(699, 31);
            this.lblEmpNIC.Name = "lblEmpNIC";
            this.lblEmpNIC.Size = new System.Drawing.Size(77, 13);
            this.lblEmpNIC.TabIndex = 34;
            this.lblEmpNIC.Text = "Employee NIC:";
            // 
            // txtEmployeeNIC
            // 
            this.txtEmployeeNIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeNIC.Location = new System.Drawing.Point(784, 28);
            this.txtEmployeeNIC.Name = "txtEmployeeNIC";
            this.txtEmployeeNIC.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeNIC.TabIndex = 35;
            this.txtEmployeeNIC.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeNIC_Validating);
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
            this.iconBtnDelete.Location = new System.Drawing.Point(905, 26);
            this.iconBtnDelete.Name = "iconBtnDelete";
            this.iconBtnDelete.Rotation = 0D;
            this.iconBtnDelete.Size = new System.Drawing.Size(75, 23);
            this.iconBtnDelete.TabIndex = 36;
            this.iconBtnDelete.Text = "Delete";
            this.iconBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(170, 25);
            this.lblFormTitle.TabIndex = 37;
            this.lblFormTitle.Text = "Delete Employee";
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewEmployee.FullRowSelect = true;
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.Location = new System.Drawing.Point(23, 69);
            this.listViewEmployee.MultiSelect = false;
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(957, 521);
            this.listViewEmployee.TabIndex = 43;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            this.listViewEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewEmployee_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NIC";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gender";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Birthdate";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tel. No";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mobile No";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Designation";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Status";
            this.columnHeader10.Width = 50;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // empdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewEmployee);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBtnDelete);
            this.Controls.Add(this.txtEmployeeNIC);
            this.Controls.Add(this.lblEmpNIC);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "empdelete";
            this.Size = new System.Drawing.Size(1008, 611);
            this.Load += new System.EventHandler(this.empdelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.Label lblEmpNIC;
        private System.Windows.Forms.TextBox txtEmployeeNIC;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
