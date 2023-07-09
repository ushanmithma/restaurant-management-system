namespace rms
{
    partial class custpaysearch
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
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.listViewDeliver = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblDineIn = new System.Windows.Forms.Label();
            this.listViewDineIn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
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
            this.iconBackBtn.TabIndex = 57;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(276, 25);
            this.lblFormTitle.TabIndex = 60;
            this.lblFormTitle.Text = "Search Customer Payments";
            // 
            // listViewDeliver
            // 
            this.listViewDeliver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDeliver.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewDeliver.FullRowSelect = true;
            this.listViewDeliver.GridLines = true;
            this.listViewDeliver.Location = new System.Drawing.Point(471, 114);
            this.listViewDeliver.MultiSelect = false;
            this.listViewDeliver.Name = "listViewDeliver";
            this.listViewDeliver.Size = new System.Drawing.Size(419, 393);
            this.listViewDeliver.TabIndex = 64;
            this.listViewDeliver.UseCompatibleStateImageBehavior = false;
            this.listViewDeliver.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order ID";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Amount";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Paid";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Balance";
            this.columnHeader10.Width = 80;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(503, 85);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(45, 13);
            this.lblDelivery.TabIndex = 63;
            this.lblDelivery.Text = "Delivery";
            // 
            // lblDineIn
            // 
            this.lblDineIn.AutoSize = true;
            this.lblDineIn.Location = new System.Drawing.Point(55, 85);
            this.lblDineIn.Name = "lblDineIn";
            this.lblDineIn.Size = new System.Drawing.Size(41, 13);
            this.lblDineIn.TabIndex = 62;
            this.lblDineIn.Text = "Dine-In";
            // 
            // listViewDineIn
            // 
            this.listViewDineIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewDineIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewDineIn.FullRowSelect = true;
            this.listViewDineIn.GridLines = true;
            this.listViewDineIn.Location = new System.Drawing.Point(23, 114);
            this.listViewDineIn.MultiSelect = false;
            this.listViewDineIn.Name = "listViewDineIn";
            this.listViewDineIn.Size = new System.Drawing.Size(424, 393);
            this.listViewDineIn.TabIndex = 61;
            this.listViewDineIn.UseCompatibleStateImageBehavior = false;
            this.listViewDineIn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order ID";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Paid";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Balance";
            this.columnHeader7.Width = 80;
            // 
            // custpaysearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewDeliver);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblDineIn);
            this.Controls.Add(this.listViewDineIn);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "custpaysearch";
            this.Size = new System.Drawing.Size(915, 530);
            this.Load += new System.EventHandler(this.custpaysearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ListView listViewDeliver;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblDineIn;
        private System.Windows.Forms.ListView listViewDineIn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
