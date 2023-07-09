namespace rms
{
    partial class supplier
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
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.iconBtnSearch = new FontAwesome.Sharp.IconButton();
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.grBoxIngredientsDetails = new System.Windows.Forms.GroupBox();
            this.cmbSupID = new System.Windows.Forms.ComboBox();
            this.iconBtnClearItem = new FontAwesome.Sharp.IconButton();
            this.iconBtnRemoveItem = new FontAwesome.Sharp.IconButton();
            this.iconBtnAddItem = new FontAwesome.Sharp.IconButton();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.iconBtnAddItemDetails = new FontAwesome.Sharp.IconButton();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblSupplierIDid = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.grBoxSupplierDetails = new System.Windows.Forms.GroupBox();
            this.dtpRegistedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbIniti = new System.Windows.Forms.ComboBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRegistedDate = new System.Windows.Forms.Label();
            this.grBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.iconBtnAddCustDetails = new FontAwesome.Sharp.IconButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelnoHome = new System.Windows.Forms.TextBox();
            this.lblTelno = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSupplier.SuspendLayout();
            this.grBoxIngredientsDetails.SuspendLayout();
            this.grBoxSupplierDetails.SuspendLayout();
            this.grBoxContactDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSupplier
            // 
            this.panelSupplier.Controls.Add(this.iconBtnSearch);
            this.panelSupplier.Controls.Add(this.iconBtnDelete);
            this.panelSupplier.Controls.Add(this.iconBtnUpdate);
            this.panelSupplier.Controls.Add(this.grBoxIngredientsDetails);
            this.panelSupplier.Controls.Add(this.lblFormTitle);
            this.panelSupplier.Controls.Add(this.grBoxSupplierDetails);
            this.panelSupplier.Controls.Add(this.grBoxContactDetails);
            this.panelSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSupplier.Location = new System.Drawing.Point(0, 0);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(944, 496);
            this.panelSupplier.TabIndex = 0;
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
            this.iconBtnSearch.Location = new System.Drawing.Point(778, 25);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(75, 23);
            this.iconBtnSearch.TabIndex = 47;
            this.iconBtnSearch.Text = "Search";
            this.iconBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSearch.UseVisualStyleBackColor = false;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // iconBtnDelete
            // 
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
            this.iconBtnDelete.Location = new System.Drawing.Point(671, 25);
            this.iconBtnDelete.Name = "iconBtnDelete";
            this.iconBtnDelete.Rotation = 0D;
            this.iconBtnDelete.Size = new System.Drawing.Size(75, 23);
            this.iconBtnDelete.TabIndex = 46;
            this.iconBtnDelete.Text = "Delete";
            this.iconBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
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
            this.iconBtnUpdate.TabIndex = 45;
            this.iconBtnUpdate.Text = "Update";
            this.iconBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnUpdate.UseVisualStyleBackColor = false;
            this.iconBtnUpdate.Click += new System.EventHandler(this.iconBtnUpdate_Click);
            // 
            // grBoxIngredientsDetails
            // 
            this.grBoxIngredientsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxIngredientsDetails.Controls.Add(this.cmbSupID);
            this.grBoxIngredientsDetails.Controls.Add(this.iconBtnClearItem);
            this.grBoxIngredientsDetails.Controls.Add(this.iconBtnRemoveItem);
            this.grBoxIngredientsDetails.Controls.Add(this.iconBtnAddItem);
            this.grBoxIngredientsDetails.Controls.Add(this.listBoxIngredients);
            this.grBoxIngredientsDetails.Controls.Add(this.iconBtnAddItemDetails);
            this.grBoxIngredientsDetails.Controls.Add(this.cmbItem);
            this.grBoxIngredientsDetails.Controls.Add(this.lblItem);
            this.grBoxIngredientsDetails.Controls.Add(this.lblSupplierIDid);
            this.grBoxIngredientsDetails.Location = new System.Drawing.Point(565, 69);
            this.grBoxIngredientsDetails.Name = "grBoxIngredientsDetails";
            this.grBoxIngredientsDetails.Size = new System.Drawing.Size(355, 262);
            this.grBoxIngredientsDetails.TabIndex = 43;
            this.grBoxIngredientsDetails.TabStop = false;
            this.grBoxIngredientsDetails.Text = "Ingredients Details";
            // 
            // cmbSupID
            // 
            this.cmbSupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupID.Enabled = false;
            this.cmbSupID.FormattingEnabled = true;
            this.cmbSupID.Location = new System.Drawing.Point(102, 26);
            this.cmbSupID.Name = "cmbSupID";
            this.cmbSupID.Size = new System.Drawing.Size(121, 21);
            this.cmbSupID.TabIndex = 51;
            // 
            // iconBtnClearItem
            // 
            this.iconBtnClearItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnClearItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.iconBtnClearItem.FlatAppearance.BorderSize = 0;
            this.iconBtnClearItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.iconBtnClearItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClearItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClearItem.ForeColor = System.Drawing.Color.White;
            this.iconBtnClearItem.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconBtnClearItem.IconColor = System.Drawing.Color.White;
            this.iconBtnClearItem.IconSize = 16;
            this.iconBtnClearItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnClearItem.Location = new System.Drawing.Point(310, 150);
            this.iconBtnClearItem.Name = "iconBtnClearItem";
            this.iconBtnClearItem.Rotation = 0D;
            this.iconBtnClearItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnClearItem.TabIndex = 50;
            this.iconBtnClearItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClearItem.UseVisualStyleBackColor = false;
            this.iconBtnClearItem.Click += new System.EventHandler(this.iconBtnClearItem_Click);
            // 
            // iconBtnRemoveItem
            // 
            this.iconBtnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.iconBtnRemoveItem.FlatAppearance.BorderSize = 0;
            this.iconBtnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.iconBtnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnRemoveItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.iconBtnRemoveItem.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconBtnRemoveItem.IconColor = System.Drawing.Color.White;
            this.iconBtnRemoveItem.IconSize = 16;
            this.iconBtnRemoveItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnRemoveItem.Location = new System.Drawing.Point(310, 105);
            this.iconBtnRemoveItem.Name = "iconBtnRemoveItem";
            this.iconBtnRemoveItem.Rotation = 0D;
            this.iconBtnRemoveItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnRemoveItem.TabIndex = 49;
            this.iconBtnRemoveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnRemoveItem.UseVisualStyleBackColor = false;
            this.iconBtnRemoveItem.Click += new System.EventHandler(this.iconBtnRemoveItem_Click);
            // 
            // iconBtnAddItem
            // 
            this.iconBtnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnAddItem.FlatAppearance.BorderSize = 0;
            this.iconBtnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAddItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnAddItem.ForeColor = System.Drawing.Color.White;
            this.iconBtnAddItem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAddItem.IconColor = System.Drawing.Color.White;
            this.iconBtnAddItem.IconSize = 16;
            this.iconBtnAddItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnAddItem.Location = new System.Drawing.Point(310, 61);
            this.iconBtnAddItem.Name = "iconBtnAddItem";
            this.iconBtnAddItem.Rotation = 0D;
            this.iconBtnAddItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnAddItem.TabIndex = 48;
            this.iconBtnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddItem.UseVisualStyleBackColor = false;
            this.iconBtnAddItem.Click += new System.EventHandler(this.iconBtnAddItem_Click);
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(102, 103);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(189, 95);
            this.listBoxIngredients.TabIndex = 35;
            this.listBoxIngredients.Validating += new System.ComponentModel.CancelEventHandler(this.listBoxIngredients_Validating);
            // 
            // iconBtnAddItemDetails
            // 
            this.iconBtnAddItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnAddItemDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnAddItemDetails.FlatAppearance.BorderSize = 0;
            this.iconBtnAddItemDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnAddItemDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAddItemDetails.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnAddItemDetails.ForeColor = System.Drawing.Color.White;
            this.iconBtnAddItemDetails.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAddItemDetails.IconColor = System.Drawing.Color.White;
            this.iconBtnAddItemDetails.IconSize = 16;
            this.iconBtnAddItemDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAddItemDetails.Location = new System.Drawing.Point(258, 218);
            this.iconBtnAddItemDetails.Name = "iconBtnAddItemDetails";
            this.iconBtnAddItemDetails.Rotation = 0D;
            this.iconBtnAddItemDetails.Size = new System.Drawing.Size(75, 23);
            this.iconBtnAddItemDetails.TabIndex = 32;
            this.iconBtnAddItemDetails.Text = "Add";
            this.iconBtnAddItemDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddItemDetails.UseVisualStyleBackColor = false;
            this.iconBtnAddItemDetails.Click += new System.EventHandler(this.iconBtnAddItemDetails_Click);
            // 
            // cmbItem
            // 
            this.cmbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(102, 61);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(190, 21);
            this.cmbItem.TabIndex = 3;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(17, 64);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(62, 13);
            this.lblItem.TabIndex = 5;
            this.lblItem.Text = "Ingredients:";
            // 
            // lblSupplierIDid
            // 
            this.lblSupplierIDid.AutoSize = true;
            this.lblSupplierIDid.Location = new System.Drawing.Point(17, 30);
            this.lblSupplierIDid.Name = "lblSupplierIDid";
            this.lblSupplierIDid.Size = new System.Drawing.Size(62, 13);
            this.lblSupplierIDid.TabIndex = 2;
            this.lblSupplierIDid.Text = "Supplier ID:";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(92, 25);
            this.lblFormTitle.TabIndex = 44;
            this.lblFormTitle.Text = "Supplier";
            // 
            // grBoxSupplierDetails
            // 
            this.grBoxSupplierDetails.Controls.Add(this.dtpRegistedDate);
            this.grBoxSupplierDetails.Controls.Add(this.cmbCountry);
            this.grBoxSupplierDetails.Controls.Add(this.lblCountry);
            this.grBoxSupplierDetails.Controls.Add(this.txtBrandName);
            this.grBoxSupplierDetails.Controls.Add(this.lblBrandName);
            this.grBoxSupplierDetails.Controls.Add(this.txtName);
            this.grBoxSupplierDetails.Controls.Add(this.cmbIniti);
            this.grBoxSupplierDetails.Controls.Add(this.txtNIC);
            this.grBoxSupplierDetails.Controls.Add(this.lblNIC);
            this.grBoxSupplierDetails.Controls.Add(this.lblName);
            this.grBoxSupplierDetails.Controls.Add(this.lblRegistedDate);
            this.grBoxSupplierDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxSupplierDetails.Name = "grBoxSupplierDetails";
            this.grBoxSupplierDetails.Size = new System.Drawing.Size(516, 206);
            this.grBoxSupplierDetails.TabIndex = 42;
            this.grBoxSupplierDetails.TabStop = false;
            this.grBoxSupplierDetails.Text = "Supplier Details";
            // 
            // dtpRegistedDate
            // 
            this.dtpRegistedDate.Location = new System.Drawing.Point(102, 27);
            this.dtpRegistedDate.Name = "dtpRegistedDate";
            this.dtpRegistedDate.Size = new System.Drawing.Size(200, 20);
            this.dtpRegistedDate.TabIndex = 48;
            this.dtpRegistedDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpRegistedDate_Validating);
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Sri Lanka",
            "Japan",
            "Chaina",
            "Australia",
            "New Zealand"});
            this.cmbCountry.Location = new System.Drawing.Point(102, 166);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(393, 21);
            this.cmbCountry.TabIndex = 52;
            this.cmbCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCountry_Validating);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(17, 169);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Country:";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(102, 131);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(393, 20);
            this.txtBrandName.TabIndex = 10;
            this.txtBrandName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrandName_Validating);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(17, 133);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(69, 13);
            this.lblBrandName.TabIndex = 9;
            this.lblBrandName.Text = "Brand Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 61);
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
            this.cmbIniti.Location = new System.Drawing.Point(102, 61);
            this.cmbIniti.Name = "cmbIniti";
            this.cmbIniti.Size = new System.Drawing.Size(90, 21);
            this.cmbIniti.TabIndex = 3;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(102, 96);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(393, 20);
            this.txtNIC.TabIndex = 8;
            this.txtNIC.Validating += new System.ComponentModel.CancelEventHandler(this.txtNIC_Validating);
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(17, 97);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(45, 13);
            this.lblNIC.TabIndex = 7;
            this.lblNIC.Text = "NIC No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblRegistedDate
            // 
            this.lblRegistedDate.AutoSize = true;
            this.lblRegistedDate.Location = new System.Drawing.Point(17, 30);
            this.lblRegistedDate.Name = "lblRegistedDate";
            this.lblRegistedDate.Size = new System.Drawing.Size(78, 13);
            this.lblRegistedDate.TabIndex = 2;
            this.lblRegistedDate.Text = "Registed Date:";
            // 
            // grBoxContactDetails
            // 
            this.grBoxContactDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxContactDetails.Controls.Add(this.iconBtnAddCustDetails);
            this.grBoxContactDetails.Controls.Add(this.lblEmail);
            this.grBoxContactDetails.Controls.Add(this.txtEmail);
            this.grBoxContactDetails.Controls.Add(this.txtTelnoHome);
            this.grBoxContactDetails.Controls.Add(this.lblTelno);
            this.grBoxContactDetails.Controls.Add(this.txtAddress);
            this.grBoxContactDetails.Controls.Add(this.lblAddress);
            this.grBoxContactDetails.Location = new System.Drawing.Point(23, 287);
            this.grBoxContactDetails.Name = "grBoxContactDetails";
            this.grBoxContactDetails.Size = new System.Drawing.Size(516, 186);
            this.grBoxContactDetails.TabIndex = 43;
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
            this.iconBtnAddCustDetails.Location = new System.Drawing.Point(420, 143);
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
            this.lblEmail.Location = new System.Drawing.Point(17, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 20);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtTelnoHome
            // 
            this.txtTelnoHome.Location = new System.Drawing.Point(102, 71);
            this.txtTelnoHome.Name = "txtTelnoHome";
            this.txtTelnoHome.Size = new System.Drawing.Size(393, 20);
            this.txtTelnoHome.TabIndex = 16;
            this.txtTelnoHome.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelnoHome_Validating);
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 496);
            this.Controls.Add(this.panelSupplier);
            this.Name = "supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.supplier_Load);
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            this.grBoxIngredientsDetails.ResumeLayout(false);
            this.grBoxIngredientsDetails.PerformLayout();
            this.grBoxSupplierDetails.ResumeLayout(false);
            this.grBoxSupplierDetails.PerformLayout();
            this.grBoxContactDetails.ResumeLayout(false);
            this.grBoxContactDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grBoxSupplierDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbIniti;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRegistedDate;
        private System.Windows.Forms.GroupBox grBoxContactDetails;
        private FontAwesome.Sharp.IconButton iconBtnAddCustDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelnoHome;
        private System.Windows.Forms.Label lblTelno;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.GroupBox grBoxIngredientsDetails;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblSupplierIDid;
        private FontAwesome.Sharp.IconButton iconBtnAddItemDetails;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private FontAwesome.Sharp.IconButton iconBtnUpdate;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private FontAwesome.Sharp.IconButton iconBtnClearItem;
        private FontAwesome.Sharp.IconButton iconBtnRemoveItem;
        private FontAwesome.Sharp.IconButton iconBtnAddItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbSupID;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.DateTimePicker dtpRegistedDate;
    }
}