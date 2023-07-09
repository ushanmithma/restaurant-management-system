namespace rms
{
    partial class orders
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
            this.panelOrders = new System.Windows.Forms.Panel();
            this.listViewDeliver = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblDineIn = new System.Windows.Forms.Label();
            this.listViewDineIn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panelOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.listViewDeliver);
            this.panelOrders.Controls.Add(this.lblDelivery);
            this.panelOrders.Controls.Add(this.lblDineIn);
            this.panelOrders.Controls.Add(this.listViewDineIn);
            this.panelOrders.Controls.Add(this.lblFormTitle);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(914, 530);
            this.panelOrders.TabIndex = 0;
            // 
            // listViewDeliver
            // 
            this.listViewDeliver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDeliver.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDeliver.FullRowSelect = true;
            this.listViewDeliver.GridLines = true;
            this.listViewDeliver.Location = new System.Drawing.Point(471, 114);
            this.listViewDeliver.MultiSelect = false;
            this.listViewDeliver.Name = "listViewDeliver";
            this.listViewDeliver.Size = new System.Drawing.Size(419, 393);
            this.listViewDeliver.TabIndex = 49;
            this.listViewDeliver.UseCompatibleStateImageBehavior = false;
            this.listViewDeliver.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(503, 85);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(45, 13);
            this.lblDelivery.TabIndex = 48;
            this.lblDelivery.Text = "Delivery";
            // 
            // lblDineIn
            // 
            this.lblDineIn.AutoSize = true;
            this.lblDineIn.Location = new System.Drawing.Point(55, 85);
            this.lblDineIn.Name = "lblDineIn";
            this.lblDineIn.Size = new System.Drawing.Size(41, 13);
            this.lblDineIn.TabIndex = 47;
            this.lblDineIn.Text = "Dine-In";
            // 
            // listViewDineIn
            // 
            this.listViewDineIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewDineIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDineIn.FullRowSelect = true;
            this.listViewDineIn.GridLines = true;
            this.listViewDineIn.Location = new System.Drawing.Point(23, 114);
            this.listViewDineIn.MultiSelect = false;
            this.listViewDineIn.Name = "listViewDineIn";
            this.listViewDineIn.Size = new System.Drawing.Size(424, 393);
            this.listViewDineIn.TabIndex = 46;
            this.listViewDineIn.UseCompatibleStateImageBehavior = false;
            this.listViewDineIn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Food Item";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 80;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(77, 25);
            this.lblFormTitle.TabIndex = 45;
            this.lblFormTitle.Text = "Orders";
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.panelOrders);
            this.Name = "orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.orders_Load);
            this.panelOrders.ResumeLayout(false);
            this.panelOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ListView listViewDineIn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblDineIn;
        private System.Windows.Forms.ListView listViewDeliver;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}