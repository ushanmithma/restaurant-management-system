namespace rms
{
    partial class supsearch
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
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.grBoxIngredientsDetails = new System.Windows.Forms.GroupBox();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.lblSearchIngredientID = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.grBoxSupplierDetails = new System.Windows.Forms.GroupBox();
            this.lblSearchCountry = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblSearchBrandName = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
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
            this.listViewIngredientsDetails = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSupplierDetails = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            this.grBoxIngredientsDetails.SuspendLayout();
            this.grBoxSupplierDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(163, 25);
            this.lblFormTitle.TabIndex = 63;
            this.lblFormTitle.Text = "Search Supplier";
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
            this.iconBtnSearch.Location = new System.Drawing.Point(627, 26);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(75, 23);
            this.iconBtnSearch.TabIndex = 62;
            this.iconBtnSearch.Text = "Search";
            this.iconBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSearch.UseVisualStyleBackColor = false;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(507, 28);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 61;
            this.txtSupplierID.Validating += new System.ComponentModel.CancelEventHandler(this.txtSupplierID_Validating);
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(431, 31);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(62, 13);
            this.lblSupplierID.TabIndex = 60;
            this.lblSupplierID.Text = "Supplier ID:";
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
            // grBoxIngredientsDetails
            // 
            this.grBoxIngredientsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxIngredientsDetails.Controls.Add(this.listBoxIngredients);
            this.grBoxIngredientsDetails.Controls.Add(this.lblSearchIngredientID);
            this.grBoxIngredientsDetails.Controls.Add(this.lblItem);
            this.grBoxIngredientsDetails.Location = new System.Drawing.Point(565, 69);
            this.grBoxIngredientsDetails.Name = "grBoxIngredientsDetails";
            this.grBoxIngredientsDetails.Size = new System.Drawing.Size(444, 178);
            this.grBoxIngredientsDetails.TabIndex = 58;
            this.grBoxIngredientsDetails.TabStop = false;
            this.grBoxIngredientsDetails.Text = "Ingredients Details";
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(113, 30);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(274, 121);
            this.listBoxIngredients.TabIndex = 72;
            // 
            // lblSearchIngredientID
            // 
            this.lblSearchIngredientID.AutoSize = true;
            this.lblSearchIngredientID.Location = new System.Drawing.Point(110, 28);
            this.lblSearchIngredientID.Name = "lblSearchIngredientID";
            this.lblSearchIngredientID.Size = new System.Drawing.Size(0, 13);
            this.lblSearchIngredientID.TabIndex = 71;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(22, 30);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(68, 13);
            this.lblItem.TabIndex = 68;
            this.lblItem.Text = "Ingreadients:";
            // 
            // grBoxSupplierDetails
            // 
            this.grBoxSupplierDetails.Controls.Add(this.lblSearchCountry);
            this.grBoxSupplierDetails.Controls.Add(this.lblCountry);
            this.grBoxSupplierDetails.Controls.Add(this.lblSearchBrandName);
            this.grBoxSupplierDetails.Controls.Add(this.lblBrandName);
            this.grBoxSupplierDetails.Controls.Add(this.lblSearchEmail);
            this.grBoxSupplierDetails.Controls.Add(this.lblSearchTelnoMobile);
            this.grBoxSupplierDetails.Controls.Add(this.lblSearchAddr);
            this.grBoxSupplierDetails.Controls.Add(this.lblSearchNIC);
            this.grBoxSupplierDetails.Controls.Add(this.lblSearchName);
            this.grBoxSupplierDetails.Controls.Add(this.lblSearchCustID);
            this.grBoxSupplierDetails.Controls.Add(this.lblEmail);
            this.grBoxSupplierDetails.Controls.Add(this.lblTelno);
            this.grBoxSupplierDetails.Controls.Add(this.lblAddress);
            this.grBoxSupplierDetails.Controls.Add(this.lblNIC);
            this.grBoxSupplierDetails.Controls.Add(this.lblName);
            this.grBoxSupplierDetails.Controls.Add(this.lblCustomerID);
            this.grBoxSupplierDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxSupplierDetails.Name = "grBoxSupplierDetails";
            this.grBoxSupplierDetails.Size = new System.Drawing.Size(516, 360);
            this.grBoxSupplierDetails.TabIndex = 57;
            this.grBoxSupplierDetails.TabStop = false;
            this.grBoxSupplierDetails.Text = "Supplier Details";
            // 
            // lblSearchCountry
            // 
            this.lblSearchCountry.AutoSize = true;
            this.lblSearchCountry.Location = new System.Drawing.Point(135, 198);
            this.lblSearchCountry.Name = "lblSearchCountry";
            this.lblSearchCountry.Size = new System.Drawing.Size(37, 13);
            this.lblSearchCountry.TabIndex = 33;
            this.lblSearchCountry.Text = "----------";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(17, 198);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 32;
            this.lblCountry.Text = "Country:";
            // 
            // lblSearchBrandName
            // 
            this.lblSearchBrandName.AutoSize = true;
            this.lblSearchBrandName.Location = new System.Drawing.Point(135, 156);
            this.lblSearchBrandName.Name = "lblSearchBrandName";
            this.lblSearchBrandName.Size = new System.Drawing.Size(37, 13);
            this.lblSearchBrandName.TabIndex = 29;
            this.lblSearchBrandName.Text = "----------";
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(17, 156);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(69, 13);
            this.lblBrandName.TabIndex = 28;
            this.lblBrandName.Text = "Brand Name:";
            // 
            // lblSearchEmail
            // 
            this.lblSearchEmail.AutoSize = true;
            this.lblSearchEmail.Location = new System.Drawing.Point(135, 324);
            this.lblSearchEmail.Name = "lblSearchEmail";
            this.lblSearchEmail.Size = new System.Drawing.Size(37, 13);
            this.lblSearchEmail.TabIndex = 27;
            this.lblSearchEmail.Text = "----------";
            // 
            // lblSearchTelnoMobile
            // 
            this.lblSearchTelnoMobile.AutoSize = true;
            this.lblSearchTelnoMobile.Location = new System.Drawing.Point(135, 282);
            this.lblSearchTelnoMobile.Name = "lblSearchTelnoMobile";
            this.lblSearchTelnoMobile.Size = new System.Drawing.Size(37, 13);
            this.lblSearchTelnoMobile.TabIndex = 26;
            this.lblSearchTelnoMobile.Text = "----------";
            // 
            // lblSearchAddr
            // 
            this.lblSearchAddr.AutoSize = true;
            this.lblSearchAddr.Location = new System.Drawing.Point(135, 240);
            this.lblSearchAddr.Name = "lblSearchAddr";
            this.lblSearchAddr.Size = new System.Drawing.Size(37, 13);
            this.lblSearchAddr.TabIndex = 25;
            this.lblSearchAddr.Text = "----------";
            // 
            // lblSearchNIC
            // 
            this.lblSearchNIC.AutoSize = true;
            this.lblSearchNIC.Location = new System.Drawing.Point(135, 114);
            this.lblSearchNIC.Name = "lblSearchNIC";
            this.lblSearchNIC.Size = new System.Drawing.Size(37, 13);
            this.lblSearchNIC.TabIndex = 23;
            this.lblSearchNIC.Text = "----------";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(135, 72);
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
            this.lblEmail.Location = new System.Drawing.Point(17, 324);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelno
            // 
            this.lblTelno.AutoSize = true;
            this.lblTelno.Location = new System.Drawing.Point(17, 282);
            this.lblTelno.Name = "lblTelno";
            this.lblTelno.Size = new System.Drawing.Size(42, 13);
            this.lblTelno.TabIndex = 13;
            this.lblTelno.Text = "Tel No:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 240);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address:";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(17, 114);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(45, 13);
            this.lblNIC.TabIndex = 7;
            this.lblNIC.Text = "NIC No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 72);
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
            // listViewIngredientsDetails
            // 
            this.listViewIngredientsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIngredientsDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listViewIngredientsDetails.FullRowSelect = true;
            this.listViewIngredientsDetails.GridLines = true;
            this.listViewIngredientsDetails.Location = new System.Drawing.Point(565, 267);
            this.listViewIngredientsDetails.MultiSelect = false;
            this.listViewIngredientsDetails.Name = "listViewIngredientsDetails";
            this.listViewIngredientsDetails.Size = new System.Drawing.Size(444, 376);
            this.listViewIngredientsDetails.TabIndex = 70;
            this.listViewIngredientsDetails.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientsDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Supplier ID";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ingredient ID";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Ingredient";
            this.columnHeader15.Width = 200;
            // 
            // listViewSupplierDetails
            // 
            this.listViewSupplierDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewSupplierDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.listViewSupplierDetails.FullRowSelect = true;
            this.listViewSupplierDetails.GridLines = true;
            this.listViewSupplierDetails.Location = new System.Drawing.Point(23, 449);
            this.listViewSupplierDetails.MultiSelect = false;
            this.listViewSupplierDetails.Name = "listViewSupplierDetails";
            this.listViewSupplierDetails.Size = new System.Drawing.Size(516, 194);
            this.listViewSupplierDetails.TabIndex = 69;
            this.listViewSupplierDetails.UseCompatibleStateImageBehavior = false;
            this.listViewSupplierDetails.View = System.Windows.Forms.View.Details;
            this.listViewSupplierDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewSupplierDetails_MouseClick);
            this.listViewSupplierDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSupplierDetails_MouseDoubleClick);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ID";
            this.columnHeader16.Width = 40;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Name";
            this.columnHeader17.Width = 180;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Brand";
            this.columnHeader18.Width = 120;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Country";
            this.columnHeader19.Width = 80;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Address";
            this.columnHeader20.Width = 200;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Tel. No";
            this.columnHeader21.Width = 80;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Email";
            this.columnHeader22.Width = 100;
            // 
            // supsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewIngredientsDetails);
            this.Controls.Add(this.listViewSupplierDetails);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBtnSearch);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.iconBackBtn);
            this.Controls.Add(this.grBoxIngredientsDetails);
            this.Controls.Add(this.grBoxSupplierDetails);
            this.Name = "supsearch";
            this.Size = new System.Drawing.Size(1034, 663);
            this.Load += new System.EventHandler(this.supsearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            this.grBoxIngredientsDetails.ResumeLayout(false);
            this.grBoxIngredientsDetails.PerformLayout();
            this.grBoxSupplierDetails.ResumeLayout(false);
            this.grBoxSupplierDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label lblSupplierID;
        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.GroupBox grBoxIngredientsDetails;
        private System.Windows.Forms.GroupBox grBoxSupplierDetails;
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
        private System.Windows.Forms.Label lblSearchBrandName;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblSearchCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.Label lblSearchIngredientID;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListView listViewIngredientsDetails;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView listViewSupplierDetails;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
    }
}
