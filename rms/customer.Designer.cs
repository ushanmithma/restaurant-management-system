namespace rms
{
    partial class customer
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
            this.components = new System.ComponentModel.Container();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.grBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.numUpDownFoodItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.iconBtnClearFoodItem = new FontAwesome.Sharp.IconButton();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.lblSelectedOrderType = new System.Windows.Forms.Label();
            this.radioBtnOrderDate = new System.Windows.Forms.RadioButton();
            this.iconBtnRemoveFoodItem = new FontAwesome.Sharp.IconButton();
            this.iconBtnAddFoodItem = new FontAwesome.Sharp.IconButton();
            this.listBoxFoodItems = new System.Windows.Forms.ListBox();
            this.cmbFoodItem = new System.Windows.Forms.ComboBox();
            this.radioBtnODToday = new System.Windows.Forms.RadioButton();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.radioBtnDeliver = new System.Windows.Forms.RadioButton();
            this.grBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.numUpDownTableNo = new System.Windows.Forms.NumericUpDown();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbIniti = new System.Windows.Forms.ComboBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.grBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.iconBtnAddCustDetails = new FontAwesome.Sharp.IconButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelnoMobile = new System.Windows.Forms.TextBox();
            this.lblTelnoMobile = new System.Windows.Forms.Label();
            this.txtTelnoHome = new System.Windows.Forms.TextBox();
            this.lblTelnoHome = new System.Windows.Forms.Label();
            this.lblTelno = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grBoxDeliveryDetails = new System.Windows.Forms.GroupBox();
            this.lblDeliverDate = new System.Windows.Forms.Label();
            this.dtpDeliverDate = new System.Windows.Forms.DateTimePicker();
            this.iconBtnAddOrderDetails = new FontAwesome.Sharp.IconButton();
            this.radioBtnDineIn = new System.Windows.Forms.RadioButton();
            this.iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.iconBtnSearch = new FontAwesome.Sharp.IconButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCustomer.SuspendLayout();
            this.grBoxOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFoodItemQuantity)).BeginInit();
            this.grBoxCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTableNo)).BeginInit();
            this.grBoxContactDetails.SuspendLayout();
            this.grBoxDeliveryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.grBoxOrderDetails);
            this.panelCustomer.Controls.Add(this.lblFormTitle);
            this.panelCustomer.Controls.Add(this.radioBtnDeliver);
            this.panelCustomer.Controls.Add(this.grBoxCustomerDetails);
            this.panelCustomer.Controls.Add(this.lblOrderType);
            this.panelCustomer.Controls.Add(this.grBoxContactDetails);
            this.panelCustomer.Controls.Add(this.grBoxDeliveryDetails);
            this.panelCustomer.Controls.Add(this.radioBtnDineIn);
            this.panelCustomer.Controls.Add(this.iconBtnUpdate);
            this.panelCustomer.Controls.Add(this.iconBtnSearch);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(1054, 542);
            this.panelCustomer.TabIndex = 0;
            // 
            // grBoxOrderDetails
            // 
            this.grBoxOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxOrderDetails.Controls.Add(this.txtCustID);
            this.grBoxOrderDetails.Controls.Add(this.numUpDownFoodItemQuantity);
            this.grBoxOrderDetails.Controls.Add(this.iconBtnClearFoodItem);
            this.grBoxOrderDetails.Controls.Add(this.cmbOrderType);
            this.grBoxOrderDetails.Controls.Add(this.lblSelectedOrderType);
            this.grBoxOrderDetails.Controls.Add(this.radioBtnOrderDate);
            this.grBoxOrderDetails.Controls.Add(this.iconBtnRemoveFoodItem);
            this.grBoxOrderDetails.Controls.Add(this.iconBtnAddFoodItem);
            this.grBoxOrderDetails.Controls.Add(this.listBoxFoodItems);
            this.grBoxOrderDetails.Controls.Add(this.cmbFoodItem);
            this.grBoxOrderDetails.Controls.Add(this.radioBtnODToday);
            this.grBoxOrderDetails.Controls.Add(this.lblCustID);
            this.grBoxOrderDetails.Controls.Add(this.lblItems);
            this.grBoxOrderDetails.Controls.Add(this.dtpOrderDate);
            this.grBoxOrderDetails.Controls.Add(this.lblOrderDate);
            this.grBoxOrderDetails.Location = new System.Drawing.Point(565, 69);
            this.grBoxOrderDetails.Name = "grBoxOrderDetails";
            this.grBoxOrderDetails.Size = new System.Drawing.Size(464, 325);
            this.grBoxOrderDetails.TabIndex = 36;
            this.grBoxOrderDetails.TabStop = false;
            this.grBoxOrderDetails.Text = "Order Details";
            // 
            // txtCustID
            // 
            this.txtCustID.Enabled = false;
            this.txtCustID.Location = new System.Drawing.Point(122, 28);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(121, 20);
            this.txtCustID.TabIndex = 56;
            // 
            // numUpDownFoodItemQuantity
            // 
            this.numUpDownFoodItemQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownFoodItemQuantity.Location = new System.Drawing.Point(312, 144);
            this.numUpDownFoodItemQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownFoodItemQuantity.Name = "numUpDownFoodItemQuantity";
            this.numUpDownFoodItemQuantity.Size = new System.Drawing.Size(91, 20);
            this.numUpDownFoodItemQuantity.TabIndex = 56;
            // 
            // iconBtnClearFoodItem
            // 
            this.iconBtnClearFoodItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnClearFoodItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.iconBtnClearFoodItem.FlatAppearance.BorderSize = 0;
            this.iconBtnClearFoodItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.iconBtnClearFoodItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClearFoodItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClearFoodItem.ForeColor = System.Drawing.Color.White;
            this.iconBtnClearFoodItem.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconBtnClearFoodItem.IconColor = System.Drawing.Color.White;
            this.iconBtnClearFoodItem.IconSize = 16;
            this.iconBtnClearFoodItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnClearFoodItem.Location = new System.Drawing.Point(418, 229);
            this.iconBtnClearFoodItem.Name = "iconBtnClearFoodItem";
            this.iconBtnClearFoodItem.Rotation = 0D;
            this.iconBtnClearFoodItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnClearFoodItem.TabIndex = 47;
            this.iconBtnClearFoodItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClearFoodItem.UseVisualStyleBackColor = false;
            this.iconBtnClearFoodItem.Click += new System.EventHandler(this.iconBtnClearFoodItem_Click);
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.Enabled = false;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "Dine-in",
            "Deliver"});
            this.cmbOrderType.Location = new System.Drawing.Point(122, 65);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(121, 21);
            this.cmbOrderType.TabIndex = 46;
            this.cmbOrderType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbOrderType_Validating);
            // 
            // lblSelectedOrderType
            // 
            this.lblSelectedOrderType.AutoSize = true;
            this.lblSelectedOrderType.Location = new System.Drawing.Point(21, 70);
            this.lblSelectedOrderType.Name = "lblSelectedOrderType";
            this.lblSelectedOrderType.Size = new System.Drawing.Size(63, 13);
            this.lblSelectedOrderType.TabIndex = 45;
            this.lblSelectedOrderType.Text = "Order Type:";
            // 
            // radioBtnOrderDate
            // 
            this.radioBtnOrderDate.AutoSize = true;
            this.radioBtnOrderDate.Location = new System.Drawing.Point(221, 112);
            this.radioBtnOrderDate.Name = "radioBtnOrderDate";
            this.radioBtnOrderDate.Size = new System.Drawing.Size(14, 13);
            this.radioBtnOrderDate.TabIndex = 44;
            this.radioBtnOrderDate.TabStop = true;
            this.radioBtnOrderDate.UseVisualStyleBackColor = true;
            this.radioBtnOrderDate.CheckedChanged += new System.EventHandler(this.radioBtnOrderDate_CheckedChanged);
            this.radioBtnOrderDate.Validating += new System.ComponentModel.CancelEventHandler(this.radioBtnOrderDate_Validating);
            // 
            // iconBtnRemoveFoodItem
            // 
            this.iconBtnRemoveFoodItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnRemoveFoodItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.iconBtnRemoveFoodItem.FlatAppearance.BorderSize = 0;
            this.iconBtnRemoveFoodItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.iconBtnRemoveFoodItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnRemoveFoodItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnRemoveFoodItem.ForeColor = System.Drawing.Color.White;
            this.iconBtnRemoveFoodItem.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconBtnRemoveFoodItem.IconColor = System.Drawing.Color.White;
            this.iconBtnRemoveFoodItem.IconSize = 16;
            this.iconBtnRemoveFoodItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnRemoveFoodItem.Location = new System.Drawing.Point(418, 184);
            this.iconBtnRemoveFoodItem.Name = "iconBtnRemoveFoodItem";
            this.iconBtnRemoveFoodItem.Rotation = 0D;
            this.iconBtnRemoveFoodItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnRemoveFoodItem.TabIndex = 42;
            this.iconBtnRemoveFoodItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnRemoveFoodItem.UseVisualStyleBackColor = false;
            this.iconBtnRemoveFoodItem.Click += new System.EventHandler(this.iconBtnRemoveFoodItem_Click);
            // 
            // iconBtnAddFoodItem
            // 
            this.iconBtnAddFoodItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnAddFoodItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnAddFoodItem.FlatAppearance.BorderSize = 0;
            this.iconBtnAddFoodItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnAddFoodItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAddFoodItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnAddFoodItem.ForeColor = System.Drawing.Color.White;
            this.iconBtnAddFoodItem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAddFoodItem.IconColor = System.Drawing.Color.White;
            this.iconBtnAddFoodItem.IconSize = 16;
            this.iconBtnAddFoodItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnAddFoodItem.Location = new System.Drawing.Point(418, 140);
            this.iconBtnAddFoodItem.Name = "iconBtnAddFoodItem";
            this.iconBtnAddFoodItem.Rotation = 0D;
            this.iconBtnAddFoodItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnAddFoodItem.TabIndex = 32;
            this.iconBtnAddFoodItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddFoodItem.UseVisualStyleBackColor = false;
            this.iconBtnAddFoodItem.Click += new System.EventHandler(this.iconBtnAddFoodItem_Click);
            // 
            // listBoxFoodItems
            // 
            this.listBoxFoodItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFoodItems.FormattingEnabled = true;
            this.listBoxFoodItems.Location = new System.Drawing.Point(122, 184);
            this.listBoxFoodItems.Name = "listBoxFoodItems";
            this.listBoxFoodItems.Size = new System.Drawing.Size(281, 108);
            this.listBoxFoodItems.TabIndex = 39;
            this.listBoxFoodItems.Validating += new System.ComponentModel.CancelEventHandler(this.listBoxFoodItems_Validating);
            // 
            // cmbFoodItem
            // 
            this.cmbFoodItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFoodItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodItem.FormattingEnabled = true;
            this.cmbFoodItem.Location = new System.Drawing.Point(122, 143);
            this.cmbFoodItem.Name = "cmbFoodItem";
            this.cmbFoodItem.Size = new System.Drawing.Size(184, 21);
            this.cmbFoodItem.TabIndex = 38;
            // 
            // radioBtnODToday
            // 
            this.radioBtnODToday.AutoSize = true;
            this.radioBtnODToday.Location = new System.Drawing.Point(122, 110);
            this.radioBtnODToday.Name = "radioBtnODToday";
            this.radioBtnODToday.Size = new System.Drawing.Size(55, 17);
            this.radioBtnODToday.TabIndex = 24;
            this.radioBtnODToday.Text = "Today";
            this.radioBtnODToday.UseVisualStyleBackColor = true;
            this.radioBtnODToday.CheckedChanged += new System.EventHandler(this.radioBtnODToday_CheckedChanged);
            this.radioBtnODToday.Validating += new System.ComponentModel.CancelEventHandler(this.radioBtnODToday_Validating);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(21, 31);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(68, 13);
            this.lblCustID.TabIndex = 9;
            this.lblCustID.Text = "Customer ID:";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(22, 145);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(33, 13);
            this.lblItems.TabIndex = 22;
            this.lblItems.Text = "Meal:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Location = new System.Drawing.Point(241, 108);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 23;
            this.dtpOrderDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpOrderDate_Validating);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(21, 112);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 22;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(105, 25);
            this.lblFormTitle.TabIndex = 41;
            this.lblFormTitle.Text = "Customer";
            // 
            // radioBtnDeliver
            // 
            this.radioBtnDeliver.AutoSize = true;
            this.radioBtnDeliver.Location = new System.Drawing.Point(460, 31);
            this.radioBtnDeliver.Name = "radioBtnDeliver";
            this.radioBtnDeliver.Size = new System.Drawing.Size(58, 17);
            this.radioBtnDeliver.TabIndex = 51;
            this.radioBtnDeliver.TabStop = true;
            this.radioBtnDeliver.Text = "Deliver";
            this.radioBtnDeliver.UseVisualStyleBackColor = true;
            this.radioBtnDeliver.CheckedChanged += new System.EventHandler(this.radioBtnDeliver_CheckedChanged);
            // 
            // grBoxCustomerDetails
            // 
            this.grBoxCustomerDetails.Controls.Add(this.cmbGender);
            this.grBoxCustomerDetails.Controls.Add(this.lblGender);
            this.grBoxCustomerDetails.Controls.Add(this.numUpDownTableNo);
            this.grBoxCustomerDetails.Controls.Add(this.lblTableNo);
            this.grBoxCustomerDetails.Controls.Add(this.txtName);
            this.grBoxCustomerDetails.Controls.Add(this.cmbIniti);
            this.grBoxCustomerDetails.Controls.Add(this.txtNIC);
            this.grBoxCustomerDetails.Controls.Add(this.lblNIC);
            this.grBoxCustomerDetails.Controls.Add(this.lblName);
            this.grBoxCustomerDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxCustomerDetails.Name = "grBoxCustomerDetails";
            this.grBoxCustomerDetails.Size = new System.Drawing.Size(516, 184);
            this.grBoxCustomerDetails.TabIndex = 39;
            this.grBoxCustomerDetails.TabStop = false;
            this.grBoxCustomerDetails.Text = "Customer Details";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(101, 107);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(135, 21);
            this.cmbGender.TabIndex = 55;
            this.cmbGender.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGender_Validating);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(16, 108);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 54;
            this.lblGender.Text = "Gender:";
            // 
            // numUpDownTableNo
            // 
            this.numUpDownTableNo.Location = new System.Drawing.Point(101, 146);
            this.numUpDownTableNo.Name = "numUpDownTableNo";
            this.numUpDownTableNo.Size = new System.Drawing.Size(91, 20);
            this.numUpDownTableNo.TabIndex = 49;
            this.numUpDownTableNo.Validating += new System.ComponentModel.CancelEventHandler(this.numUpDownTableNo_Validating);
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Location = new System.Drawing.Point(16, 150);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(54, 13);
            this.lblTableNo.TabIndex = 9;
            this.lblTableNo.Text = "Table No:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 20);
            this.txtName.TabIndex = 6;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // cmbIniti
            // 
            this.cmbIniti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIniti.FormattingEnabled = true;
            this.cmbIniti.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss."});
            this.cmbIniti.Location = new System.Drawing.Point(102, 31);
            this.cmbIniti.Name = "cmbIniti";
            this.cmbIniti.Size = new System.Drawing.Size(90, 21);
            this.cmbIniti.TabIndex = 3;
            this.cmbIniti.Validating += new System.ComponentModel.CancelEventHandler(this.cmbIniti_Validating);
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(102, 70);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(393, 20);
            this.txtNIC.TabIndex = 8;
            this.txtNIC.Validating += new System.ComponentModel.CancelEventHandler(this.txtNIC_Validating);
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(17, 73);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(45, 13);
            this.lblNIC.TabIndex = 7;
            this.lblNIC.Text = "NIC No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(310, 33);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(63, 13);
            this.lblOrderType.TabIndex = 49;
            this.lblOrderType.Text = "Order Type:";
            // 
            // grBoxContactDetails
            // 
            this.grBoxContactDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxContactDetails.Controls.Add(this.iconBtnAddCustDetails);
            this.grBoxContactDetails.Controls.Add(this.lblEmail);
            this.grBoxContactDetails.Controls.Add(this.txtEmail);
            this.grBoxContactDetails.Controls.Add(this.txtTelnoMobile);
            this.grBoxContactDetails.Controls.Add(this.lblTelnoMobile);
            this.grBoxContactDetails.Controls.Add(this.txtTelnoHome);
            this.grBoxContactDetails.Controls.Add(this.lblTelnoHome);
            this.grBoxContactDetails.Controls.Add(this.lblTelno);
            this.grBoxContactDetails.Controls.Add(this.txtAddress);
            this.grBoxContactDetails.Controls.Add(this.lblAddress);
            this.grBoxContactDetails.Location = new System.Drawing.Point(23, 270);
            this.grBoxContactDetails.Name = "grBoxContactDetails";
            this.grBoxContactDetails.Size = new System.Drawing.Size(516, 255);
            this.grBoxContactDetails.TabIndex = 40;
            this.grBoxContactDetails.TabStop = false;
            this.grBoxContactDetails.Text = "Contact Details";
            // 
            // iconBtnAddCustDetails
            // 
            this.iconBtnAddCustDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnAddCustDetails.FlatAppearance.BorderSize = 0;
            this.iconBtnAddCustDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnAddCustDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAddCustDetails.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnAddCustDetails.ForeColor = System.Drawing.Color.White;
            this.iconBtnAddCustDetails.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAddCustDetails.IconColor = System.Drawing.Color.White;
            this.iconBtnAddCustDetails.IconSize = 16;
            this.iconBtnAddCustDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAddCustDetails.Location = new System.Drawing.Point(420, 145);
            this.iconBtnAddCustDetails.Name = "iconBtnAddCustDetails";
            this.iconBtnAddCustDetails.Rotation = 0D;
            this.iconBtnAddCustDetails.Size = new System.Drawing.Size(75, 23);
            this.iconBtnAddCustDetails.TabIndex = 31;
            this.iconBtnAddCustDetails.Text = "Add";
            this.iconBtnAddCustDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddCustDetails.UseVisualStyleBackColor = false;
            this.iconBtnAddCustDetails.Click += new System.EventHandler(this.iconBtnAddCustDetails_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 20);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtTelnoMobile
            // 
            this.txtTelnoMobile.Location = new System.Drawing.Point(356, 71);
            this.txtTelnoMobile.Name = "txtTelnoMobile";
            this.txtTelnoMobile.Size = new System.Drawing.Size(139, 20);
            this.txtTelnoMobile.TabIndex = 17;
            this.txtTelnoMobile.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelnoMobile_Validating);
            // 
            // lblTelnoMobile
            // 
            this.lblTelnoMobile.AutoSize = true;
            this.lblTelnoMobile.Location = new System.Drawing.Point(309, 74);
            this.lblTelnoMobile.Name = "lblTelnoMobile";
            this.lblTelnoMobile.Size = new System.Drawing.Size(41, 13);
            this.lblTelnoMobile.TabIndex = 15;
            this.lblTelnoMobile.Text = "Mobile:";
            // 
            // txtTelnoHome
            // 
            this.txtTelnoHome.Location = new System.Drawing.Point(143, 71);
            this.txtTelnoHome.Name = "txtTelnoHome";
            this.txtTelnoHome.Size = new System.Drawing.Size(139, 20);
            this.txtTelnoHome.TabIndex = 16;
            this.txtTelnoHome.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelnoHome_Validating);
            // 
            // lblTelnoHome
            // 
            this.lblTelnoHome.AutoSize = true;
            this.lblTelnoHome.Location = new System.Drawing.Point(99, 74);
            this.lblTelnoHome.Name = "lblTelnoHome";
            this.lblTelnoHome.Size = new System.Drawing.Size(38, 13);
            this.lblTelnoHome.TabIndex = 14;
            this.lblTelnoHome.Text = "Home:";
            // 
            // lblTelno
            // 
            this.lblTelno.AutoSize = true;
            this.lblTelno.Location = new System.Drawing.Point(17, 74);
            this.lblTelno.Name = "lblTelno";
            this.lblTelno.Size = new System.Drawing.Size(42, 13);
            this.lblTelno.TabIndex = 13;
            this.lblTelno.Text = "Tel No:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 35);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(393, 20);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 38);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address:";
            // 
            // grBoxDeliveryDetails
            // 
            this.grBoxDeliveryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxDeliveryDetails.Controls.Add(this.lblDeliverDate);
            this.grBoxDeliveryDetails.Controls.Add(this.dtpDeliverDate);
            this.grBoxDeliveryDetails.Controls.Add(this.iconBtnAddOrderDetails);
            this.grBoxDeliveryDetails.Location = new System.Drawing.Point(565, 409);
            this.grBoxDeliveryDetails.Name = "grBoxDeliveryDetails";
            this.grBoxDeliveryDetails.Size = new System.Drawing.Size(463, 116);
            this.grBoxDeliveryDetails.TabIndex = 0;
            this.grBoxDeliveryDetails.TabStop = false;
            this.grBoxDeliveryDetails.Text = "Delivery Details";
            // 
            // lblDeliverDate
            // 
            this.lblDeliverDate.AutoSize = true;
            this.lblDeliverDate.Location = new System.Drawing.Point(22, 33);
            this.lblDeliverDate.Name = "lblDeliverDate";
            this.lblDeliverDate.Size = new System.Drawing.Size(69, 13);
            this.lblDeliverDate.TabIndex = 52;
            this.lblDeliverDate.Text = "Deliver Date:";
            // 
            // dtpDeliverDate
            // 
            this.dtpDeliverDate.Location = new System.Drawing.Point(122, 27);
            this.dtpDeliverDate.Name = "dtpDeliverDate";
            this.dtpDeliverDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliverDate.TabIndex = 53;
            this.dtpDeliverDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDeliverDate_Validating);
            // 
            // iconBtnAddOrderDetails
            // 
            this.iconBtnAddOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnAddOrderDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnAddOrderDetails.FlatAppearance.BorderSize = 0;
            this.iconBtnAddOrderDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnAddOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAddOrderDetails.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnAddOrderDetails.ForeColor = System.Drawing.Color.White;
            this.iconBtnAddOrderDetails.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAddOrderDetails.IconColor = System.Drawing.Color.White;
            this.iconBtnAddOrderDetails.IconSize = 16;
            this.iconBtnAddOrderDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAddOrderDetails.Location = new System.Drawing.Point(366, 68);
            this.iconBtnAddOrderDetails.Name = "iconBtnAddOrderDetails";
            this.iconBtnAddOrderDetails.Rotation = 0D;
            this.iconBtnAddOrderDetails.Size = new System.Drawing.Size(75, 23);
            this.iconBtnAddOrderDetails.TabIndex = 32;
            this.iconBtnAddOrderDetails.Text = "Add";
            this.iconBtnAddOrderDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddOrderDetails.UseVisualStyleBackColor = false;
            this.iconBtnAddOrderDetails.Click += new System.EventHandler(this.iconBtnAddOrderDetails_Click);
            // 
            // radioBtnDineIn
            // 
            this.radioBtnDineIn.AutoSize = true;
            this.radioBtnDineIn.Location = new System.Drawing.Point(379, 31);
            this.radioBtnDineIn.Name = "radioBtnDineIn";
            this.radioBtnDineIn.Size = new System.Drawing.Size(59, 17);
            this.radioBtnDineIn.TabIndex = 50;
            this.radioBtnDineIn.TabStop = true;
            this.radioBtnDineIn.Text = "Dine-In";
            this.radioBtnDineIn.UseVisualStyleBackColor = true;
            this.radioBtnDineIn.CheckedChanged += new System.EventHandler(this.radioBtnDineIn_CheckedChanged);
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
            this.iconBtnUpdate.Location = new System.Drawing.Point(565, 25);
            this.iconBtnUpdate.Name = "iconBtnUpdate";
            this.iconBtnUpdate.Rotation = 0D;
            this.iconBtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.iconBtnUpdate.TabIndex = 32;
            this.iconBtnUpdate.Text = "Update";
            this.iconBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnUpdate.UseVisualStyleBackColor = false;
            this.iconBtnUpdate.Click += new System.EventHandler(this.iconBtnUpdate_Click);
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
            this.iconBtnSearch.Location = new System.Drawing.Point(671, 25);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(75, 23);
            this.iconBtnSearch.TabIndex = 34;
            this.iconBtnSearch.Text = "Search";
            this.iconBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSearch.UseVisualStyleBackColor = false;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 542);
            this.Controls.Add(this.panelCustomer);
            this.Name = "customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.customer_Load);
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.grBoxOrderDetails.ResumeLayout(false);
            this.grBoxOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFoodItemQuantity)).EndInit();
            this.grBoxCustomerDetails.ResumeLayout(false);
            this.grBoxCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTableNo)).EndInit();
            this.grBoxContactDetails.ResumeLayout(false);
            this.grBoxContactDetails.PerformLayout();
            this.grBoxDeliveryDetails.ResumeLayout(false);
            this.grBoxDeliveryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCustomer;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private FontAwesome.Sharp.IconButton iconBtnUpdate;
        private FontAwesome.Sharp.IconButton iconBtnAddOrderDetails;
        private System.Windows.Forms.DateTimePicker dtpDeliverDate;
        private System.Windows.Forms.Label lblDeliverDate;
        private System.Windows.Forms.RadioButton radioBtnDeliver;
        private System.Windows.Forms.RadioButton radioBtnDineIn;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.GroupBox grBoxDeliveryDetails;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grBoxCustomerDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbIniti;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grBoxContactDetails;
        private FontAwesome.Sharp.IconButton iconBtnAddCustDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelnoMobile;
        private System.Windows.Forms.Label lblTelnoMobile;
        private System.Windows.Forms.TextBox txtTelnoHome;
        private System.Windows.Forms.Label lblTelnoHome;
        private System.Windows.Forms.Label lblTelno;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.RadioButton radioBtnODToday;
        private System.Windows.Forms.GroupBox grBoxOrderDetails;
        private System.Windows.Forms.NumericUpDown numUpDownTableNo;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.ComboBox cmbFoodItem;
        private System.Windows.Forms.ListBox listBoxFoodItems;
        private FontAwesome.Sharp.IconButton iconBtnAddFoodItem;
        private FontAwesome.Sharp.IconButton iconBtnRemoveFoodItem;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton radioBtnOrderDate;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label lblSelectedOrderType;
        private FontAwesome.Sharp.IconButton iconBtnClearFoodItem;
        private System.Windows.Forms.NumericUpDown numUpDownFoodItemQuantity;
        private System.Windows.Forms.TextBox txtCustID;

    }
}