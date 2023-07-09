namespace rms
{
    partial class delivery
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnCompeleted = new FontAwesome.Sharp.IconButton();
            this.listViewOrderDetails = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDeliver = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconBtnCompeleted);
            this.panel1.Controls.Add(this.listViewOrderDetails);
            this.panel1.Controls.Add(this.listViewDeliver);
            this.panel1.Controls.Add(this.lblFormTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 589);
            this.panel1.TabIndex = 0;
            // 
            // iconBtnCompeleted
            // 
            this.iconBtnCompeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCompeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnCompeleted.FlatAppearance.BorderSize = 0;
            this.iconBtnCompeleted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnCompeleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCompeleted.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCompeleted.ForeColor = System.Drawing.Color.White;
            this.iconBtnCompeleted.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconBtnCompeleted.IconColor = System.Drawing.Color.White;
            this.iconBtnCompeleted.IconSize = 16;
            this.iconBtnCompeleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCompeleted.Location = new System.Drawing.Point(877, 21);
            this.iconBtnCompeleted.Name = "iconBtnCompeleted";
            this.iconBtnCompeleted.Rotation = 0D;
            this.iconBtnCompeleted.Size = new System.Drawing.Size(82, 23);
            this.iconBtnCompeleted.TabIndex = 58;
            this.iconBtnCompeleted.Text = "Compelete";
            this.iconBtnCompeleted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCompeleted.UseVisualStyleBackColor = false;
            this.iconBtnCompeleted.Click += new System.EventHandler(this.iconBtnCompeleted_Click);
            // 
            // listViewOrderDetails
            // 
            this.listViewOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader4});
            this.listViewOrderDetails.FullRowSelect = true;
            this.listViewOrderDetails.GridLines = true;
            this.listViewOrderDetails.Location = new System.Drawing.Point(703, 69);
            this.listViewOrderDetails.MultiSelect = false;
            this.listViewOrderDetails.Name = "listViewOrderDetails";
            this.listViewOrderDetails.Size = new System.Drawing.Size(256, 496);
            this.listViewOrderDetails.TabIndex = 57;
            this.listViewOrderDetails.UseCompatibleStateImageBehavior = false;
            this.listViewOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Order ID";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Foo Item";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 80;
            // 
            // listViewDeliver
            // 
            this.listViewDeliver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewDeliver.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader12,
            this.columnHeader16,
            this.columnHeader6});
            this.listViewDeliver.FullRowSelect = true;
            this.listViewDeliver.GridLines = true;
            this.listViewDeliver.Location = new System.Drawing.Point(23, 69);
            this.listViewDeliver.MultiSelect = false;
            this.listViewDeliver.Name = "listViewDeliver";
            this.listViewDeliver.Size = new System.Drawing.Size(657, 496);
            this.listViewDeliver.TabIndex = 52;
            this.listViewDeliver.UseCompatibleStateImageBehavior = false;
            this.listViewDeliver.View = System.Windows.Forms.View.Details;
            this.listViewDeliver.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewDeliver_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tel. No";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Mobile No";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Deliver Date";
            this.columnHeader16.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order ID";
            this.columnHeader6.Width = 50;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(160, 25);
            this.lblFormTitle.TabIndex = 51;
            this.lblFormTitle.Text = "Delivery Orders";
            // 
            // delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 589);
            this.Controls.Add(this.panel1);
            this.Name = "delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.delivery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ListView listViewDeliver;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ListView listViewOrderDetails;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private FontAwesome.Sharp.IconButton iconBtnCompeleted;
    }
}