namespace rms
{
    partial class custsearch
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
            this.iconBtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.grBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.lblSearchDeliverDate = new System.Windows.Forms.Label();
            this.lblDeliverDate = new System.Windows.Forms.Label();
            this.lblSearchOrderType = new System.Windows.Forms.Label();
            this.lblSearchOrderDate = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.listBoxFoodItems = new System.Windows.Forms.ListBox();
            this.lblSearchOrderID = new System.Windows.Forms.Label();
            this.lblFoodItems = new System.Windows.Forms.Label();
            this.lblOrderIDod = new System.Windows.Forms.Label();
            this.grBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblSearchGender = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSearchTableNo = new System.Windows.Forms.Label();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.lblSearchEmail = new System.Windows.Forms.Label();
            this.lblSearchTelnoMobile = new System.Windows.Forms.Label();
            this.lblSearchAddr = new System.Windows.Forms.Label();
            this.lblSearchNIC = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblSearchCustID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelno = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.listViewCustOrders = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewOrderDetails = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            this.grBoxOrderDetails.SuspendLayout();
            this.grBoxCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(176, 25);
            this.lblFormTitle.TabIndex = 51;
            this.lblFormTitle.Text = "Search Customer";
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
            this.iconBtnSearch.Location = new System.Drawing.Point(614, 21);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(75, 23);
            this.iconBtnSearch.TabIndex = 50;
            this.iconBtnSearch.Text = "Search";
            this.iconBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSearch.UseVisualStyleBackColor = false;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(494, 23);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 49;
            this.txtCustomerID.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerID_Validating);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(418, 26);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(68, 13);
            this.lblCustID.TabIndex = 48;
            this.lblCustID.Text = "Customer ID:";
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
            this.iconBackBtn.TabIndex = 47;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // grBoxOrderDetails
            // 
            this.grBoxOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxOrderDetails.Controls.Add(this.lblSearchDeliverDate);
            this.grBoxOrderDetails.Controls.Add(this.lblDeliverDate);
            this.grBoxOrderDetails.Controls.Add(this.lblSearchOrderType);
            this.grBoxOrderDetails.Controls.Add(this.lblSearchOrderDate);
            this.grBoxOrderDetails.Controls.Add(this.lblOrderType);
            this.grBoxOrderDetails.Controls.Add(this.lblOrderDate);
            this.grBoxOrderDetails.Controls.Add(this.listBoxFoodItems);
            this.grBoxOrderDetails.Controls.Add(this.lblSearchOrderID);
            this.grBoxOrderDetails.Controls.Add(this.lblFoodItems);
            this.grBoxOrderDetails.Controls.Add(this.lblOrderIDod);
            this.grBoxOrderDetails.Location = new System.Drawing.Point(565, 69);
            this.grBoxOrderDetails.Name = "grBoxOrderDetails";
            this.grBoxOrderDetails.Size = new System.Drawing.Size(440, 300);
            this.grBoxOrderDetails.TabIndex = 44;
            this.grBoxOrderDetails.TabStop = false;
            this.grBoxOrderDetails.Text = "Order Details";
            // 
            // lblSearchDeliverDate
            // 
            this.lblSearchDeliverDate.AutoSize = true;
            this.lblSearchDeliverDate.Location = new System.Drawing.Point(111, 270);
            this.lblSearchDeliverDate.Name = "lblSearchDeliverDate";
            this.lblSearchDeliverDate.Size = new System.Drawing.Size(37, 13);
            this.lblSearchDeliverDate.TabIndex = 59;
            this.lblSearchDeliverDate.Text = "----------";
            // 
            // lblDeliverDate
            // 
            this.lblDeliverDate.AutoSize = true;
            this.lblDeliverDate.Location = new System.Drawing.Point(21, 268);
            this.lblDeliverDate.Name = "lblDeliverDate";
            this.lblDeliverDate.Size = new System.Drawing.Size(69, 13);
            this.lblDeliverDate.TabIndex = 58;
            this.lblDeliverDate.Text = "Deliver Date:";
            // 
            // lblSearchOrderType
            // 
            this.lblSearchOrderType.AutoSize = true;
            this.lblSearchOrderType.Location = new System.Drawing.Point(111, 232);
            this.lblSearchOrderType.Name = "lblSearchOrderType";
            this.lblSearchOrderType.Size = new System.Drawing.Size(37, 13);
            this.lblSearchOrderType.TabIndex = 57;
            this.lblSearchOrderType.Text = "----------";
            // 
            // lblSearchOrderDate
            // 
            this.lblSearchOrderDate.AutoSize = true;
            this.lblSearchOrderDate.Location = new System.Drawing.Point(111, 74);
            this.lblSearchOrderDate.Name = "lblSearchOrderDate";
            this.lblSearchOrderDate.Size = new System.Drawing.Size(37, 13);
            this.lblSearchOrderDate.TabIndex = 44;
            this.lblSearchOrderDate.Text = "----------";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(21, 232);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(63, 13);
            this.lblOrderType.TabIndex = 56;
            this.lblOrderType.Text = "Order Type:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(21, 74);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 43;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // listBoxFoodItems
            // 
            this.listBoxFoodItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFoodItems.FormattingEnabled = true;
            this.listBoxFoodItems.Location = new System.Drawing.Point(114, 112);
            this.listBoxFoodItems.Name = "listBoxFoodItems";
            this.listBoxFoodItems.ScrollAlwaysVisible = true;
            this.listBoxFoodItems.Size = new System.Drawing.Size(306, 95);
            this.listBoxFoodItems.Sorted = true;
            this.listBoxFoodItems.TabIndex = 42;
            // 
            // lblSearchOrderID
            // 
            this.lblSearchOrderID.AutoSize = true;
            this.lblSearchOrderID.Location = new System.Drawing.Point(111, 36);
            this.lblSearchOrderID.Name = "lblSearchOrderID";
            this.lblSearchOrderID.Size = new System.Drawing.Size(37, 13);
            this.lblSearchOrderID.TabIndex = 29;
            this.lblSearchOrderID.Text = "----------";
            // 
            // lblFoodItems
            // 
            this.lblFoodItems.AutoSize = true;
            this.lblFoodItems.Location = new System.Drawing.Point(21, 112);
            this.lblFoodItems.Name = "lblFoodItems";
            this.lblFoodItems.Size = new System.Drawing.Size(38, 13);
            this.lblFoodItems.TabIndex = 24;
            this.lblFoodItems.Text = "Meals:";
            // 
            // lblOrderIDod
            // 
            this.lblOrderIDod.AutoSize = true;
            this.lblOrderIDod.Location = new System.Drawing.Point(21, 36);
            this.lblOrderIDod.Name = "lblOrderIDod";
            this.lblOrderIDod.Size = new System.Drawing.Size(50, 13);
            this.lblOrderIDod.TabIndex = 22;
            this.lblOrderIDod.Text = "Order ID:";
            // 
            // grBoxCustomerDetails
            // 
            this.grBoxCustomerDetails.Controls.Add(this.lblSearchGender);
            this.grBoxCustomerDetails.Controls.Add(this.lblGender);
            this.grBoxCustomerDetails.Controls.Add(this.lblSearchTableNo);
            this.grBoxCustomerDetails.Controls.Add(this.lblTableNo);
            this.grBoxCustomerDetails.Controls.Add(this.lblSearchEmail);
            this.grBoxCustomerDetails.Controls.Add(this.lblSearchTelnoMobile);
            this.grBoxCustomerDetails.Controls.Add(this.lblSearchAddr);
            this.grBoxCustomerDetails.Controls.Add(this.lblSearchNIC);
            this.grBoxCustomerDetails.Controls.Add(this.lblSearchName);
            this.grBoxCustomerDetails.Controls.Add(this.lblSearchCustID);
            this.grBoxCustomerDetails.Controls.Add(this.lblEmail);
            this.grBoxCustomerDetails.Controls.Add(this.lblTelno);
            this.grBoxCustomerDetails.Controls.Add(this.lblAddress);
            this.grBoxCustomerDetails.Controls.Add(this.lblNIC);
            this.grBoxCustomerDetails.Controls.Add(this.lblName);
            this.grBoxCustomerDetails.Controls.Add(this.lblCustomerID);
            this.grBoxCustomerDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxCustomerDetails.Name = "grBoxCustomerDetails";
            this.grBoxCustomerDetails.Size = new System.Drawing.Size(516, 335);
            this.grBoxCustomerDetails.TabIndex = 42;
            this.grBoxCustomerDetails.TabStop = false;
            this.grBoxCustomerDetails.Text = "Customer Details";
            // 
            // lblSearchGender
            // 
            this.lblSearchGender.AutoSize = true;
            this.lblSearchGender.Location = new System.Drawing.Point(135, 148);
            this.lblSearchGender.Name = "lblSearchGender";
            this.lblSearchGender.Size = new System.Drawing.Size(37, 13);
            this.lblSearchGender.TabIndex = 31;
            this.lblSearchGender.Text = "----------";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 148);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender:";
            // 
            // lblSearchTableNo
            // 
            this.lblSearchTableNo.AutoSize = true;
            this.lblSearchTableNo.Location = new System.Drawing.Point(135, 182);
            this.lblSearchTableNo.Name = "lblSearchTableNo";
            this.lblSearchTableNo.Size = new System.Drawing.Size(37, 13);
            this.lblSearchTableNo.TabIndex = 29;
            this.lblSearchTableNo.Text = "----------";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Location = new System.Drawing.Point(17, 182);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(54, 13);
            this.lblTableNo.TabIndex = 28;
            this.lblTableNo.Text = "Table No:";
            // 
            // lblSearchEmail
            // 
            this.lblSearchEmail.AutoSize = true;
            this.lblSearchEmail.Location = new System.Drawing.Point(135, 299);
            this.lblSearchEmail.Name = "lblSearchEmail";
            this.lblSearchEmail.Size = new System.Drawing.Size(37, 13);
            this.lblSearchEmail.TabIndex = 27;
            this.lblSearchEmail.Text = "----------";
            // 
            // lblSearchTelnoMobile
            // 
            this.lblSearchTelnoMobile.AutoSize = true;
            this.lblSearchTelnoMobile.Location = new System.Drawing.Point(135, 259);
            this.lblSearchTelnoMobile.Name = "lblSearchTelnoMobile";
            this.lblSearchTelnoMobile.Size = new System.Drawing.Size(37, 13);
            this.lblSearchTelnoMobile.TabIndex = 26;
            this.lblSearchTelnoMobile.Text = "----------";
            // 
            // lblSearchAddr
            // 
            this.lblSearchAddr.AutoSize = true;
            this.lblSearchAddr.Location = new System.Drawing.Point(135, 219);
            this.lblSearchAddr.Name = "lblSearchAddr";
            this.lblSearchAddr.Size = new System.Drawing.Size(37, 13);
            this.lblSearchAddr.TabIndex = 25;
            this.lblSearchAddr.Text = "----------";
            // 
            // lblSearchNIC
            // 
            this.lblSearchNIC.AutoSize = true;
            this.lblSearchNIC.Location = new System.Drawing.Point(135, 110);
            this.lblSearchNIC.Name = "lblSearchNIC";
            this.lblSearchNIC.Size = new System.Drawing.Size(37, 13);
            this.lblSearchNIC.TabIndex = 23;
            this.lblSearchNIC.Text = "----------";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(135, 70);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(37, 13);
            this.lblSearchName.TabIndex = 22;
            this.lblSearchName.Text = "----------";
            // 
            // lblSearchCustID
            // 
            this.lblSearchCustID.AutoSize = true;
            this.lblSearchCustID.Location = new System.Drawing.Point(135, 30);
            this.lblSearchCustID.Name = "lblSearchCustID";
            this.lblSearchCustID.Size = new System.Drawing.Size(37, 13);
            this.lblSearchCustID.TabIndex = 21;
            this.lblSearchCustID.Text = "----------";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 299);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelno
            // 
            this.lblTelno.AutoSize = true;
            this.lblTelno.Location = new System.Drawing.Point(17, 259);
            this.lblTelno.Name = "lblTelno";
            this.lblTelno.Size = new System.Drawing.Size(42, 13);
            this.lblTelno.TabIndex = 13;
            this.lblTelno.Text = "Tel No:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 219);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address:";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(17, 110);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(45, 13);
            this.lblNIC.TabIndex = 7;
            this.lblNIC.Text = "NIC No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(17, 30);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // listViewCustOrders
            // 
            this.listViewCustOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewCustOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.listViewCustOrders.FullRowSelect = true;
            this.listViewCustOrders.GridLines = true;
            this.listViewCustOrders.Location = new System.Drawing.Point(23, 426);
            this.listViewCustOrders.MultiSelect = false;
            this.listViewCustOrders.Name = "listViewCustOrders";
            this.listViewCustOrders.Size = new System.Drawing.Size(516, 214);
            this.listViewCustOrders.TabIndex = 57;
            this.listViewCustOrders.UseCompatibleStateImageBehavior = false;
            this.listViewCustOrders.View = System.Windows.Forms.View.Details;
            this.listViewCustOrders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewCustOrders_MouseClick);
            this.listViewCustOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewCustOrders_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Order Type";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Table No";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Address";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Order ID";
            this.columnHeader19.Width = 80;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Order Date";
            this.columnHeader20.Width = 80;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Deliver Date";
            this.columnHeader21.Width = 80;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Completed";
            this.columnHeader22.Width = 50;
            // 
            // listViewOrderDetails
            // 
            this.listViewOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewOrderDetails.FullRowSelect = true;
            this.listViewOrderDetails.GridLines = true;
            this.listViewOrderDetails.Location = new System.Drawing.Point(565, 390);
            this.listViewOrderDetails.MultiSelect = false;
            this.listViewOrderDetails.Name = "listViewOrderDetails";
            this.listViewOrderDetails.Size = new System.Drawing.Size(440, 250);
            this.listViewOrderDetails.TabIndex = 58;
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
            this.columnHeader11.Text = "Food Item";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Quantity";
            this.columnHeader12.Width = 80;
            // 
            // custsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewOrderDetails);
            this.Controls.Add(this.listViewCustOrders);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBtnSearch);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.iconBackBtn);
            this.Controls.Add(this.grBoxOrderDetails);
            this.Controls.Add(this.grBoxCustomerDetails);
            this.Name = "custsearch";
            this.Size = new System.Drawing.Size(1025, 660);
            this.Load += new System.EventHandler(this.custsearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            this.grBoxOrderDetails.ResumeLayout(false);
            this.grBoxOrderDetails.PerformLayout();
            this.grBoxCustomerDetails.ResumeLayout(false);
            this.grBoxCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustID;
        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.GroupBox grBoxOrderDetails;
        private System.Windows.Forms.Label lblSearchOrderID;
        private System.Windows.Forms.Label lblFoodItems;
        private System.Windows.Forms.Label lblOrderIDod;
        private System.Windows.Forms.GroupBox grBoxCustomerDetails;
        private System.Windows.Forms.Label lblSearchEmail;
        private System.Windows.Forms.Label lblSearchTelnoMobile;
        private System.Windows.Forms.Label lblSearchAddr;
        private System.Windows.Forms.Label lblSearchNIC;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblSearchCustID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelno;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ListBox listBoxFoodItems;
        private System.Windows.Forms.Label lblSearchOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblSearchDeliverDate;
        private System.Windows.Forms.Label lblDeliverDate;
        private System.Windows.Forms.Label lblSearchOrderType;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblSearchTableNo;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label lblSearchGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListView listViewCustOrders;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ListView listViewOrderDetails;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}
