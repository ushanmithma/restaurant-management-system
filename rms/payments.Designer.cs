namespace rms
{
    partial class payments
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
            this.panelPayments = new System.Windows.Forms.Panel();
            this.listViewSupPayments = new System.Windows.Forms.ListView();
            this.iconBtnShowCustPayments = new FontAwesome.Sharp.IconButton();
            this.grBoxSupPayments = new System.Windows.Forms.GroupBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.iconBtnBalance = new FontAwesome.Sharp.IconButton();
            this.lblRsBalance = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.iconPicBoxBalance = new FontAwesome.Sharp.IconPictureBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.iconBtnSupPaid = new FontAwesome.Sharp.IconButton();
            this.lblRsAmount = new System.Windows.Forms.Label();
            this.iconBtnSupCalc = new FontAwesome.Sharp.IconButton();
            this.iconPicBoxAmount = new FontAwesome.Sharp.IconPictureBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.numUpDownIngredientQuantity = new System.Windows.Forms.NumericUpDown();
            this.iconBtnClearIngredient = new FontAwesome.Sharp.IconButton();
            this.iconBtnRemoveIngredient = new FontAwesome.Sharp.IconButton();
            this.iconBtnAddIngredient = new FontAwesome.Sharp.IconButton();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.cmbBrandName = new System.Windows.Forms.ComboBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelPayments.SuspendLayout();
            this.grBoxSupPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownIngredientQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPayments
            // 
            this.panelPayments.Controls.Add(this.listViewSupPayments);
            this.panelPayments.Controls.Add(this.iconBtnShowCustPayments);
            this.panelPayments.Controls.Add(this.grBoxSupPayments);
            this.panelPayments.Controls.Add(this.lblFormTitle);
            this.panelPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayments.Location = new System.Drawing.Point(0, 0);
            this.panelPayments.Name = "panelPayments";
            this.panelPayments.Size = new System.Drawing.Size(1078, 731);
            this.panelPayments.TabIndex = 0;
            // 
            // listViewSupPayments
            // 
            this.listViewSupPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSupPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewSupPayments.FullRowSelect = true;
            this.listViewSupPayments.GridLines = true;
            this.listViewSupPayments.Location = new System.Drawing.Point(662, 69);
            this.listViewSupPayments.MultiSelect = false;
            this.listViewSupPayments.Name = "listViewSupPayments";
            this.listViewSupPayments.Size = new System.Drawing.Size(393, 640);
            this.listViewSupPayments.TabIndex = 55;
            this.listViewSupPayments.UseCompatibleStateImageBehavior = false;
            this.listViewSupPayments.View = System.Windows.Forms.View.Details;
            // 
            // iconBtnShowCustPayments
            // 
            this.iconBtnShowCustPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnShowCustPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.iconBtnShowCustPayments.FlatAppearance.BorderSize = 0;
            this.iconBtnShowCustPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.iconBtnShowCustPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnShowCustPayments.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnShowCustPayments.ForeColor = System.Drawing.Color.White;
            this.iconBtnShowCustPayments.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnShowCustPayments.IconColor = System.Drawing.Color.White;
            this.iconBtnShowCustPayments.IconSize = 16;
            this.iconBtnShowCustPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnShowCustPayments.Location = new System.Drawing.Point(898, 21);
            this.iconBtnShowCustPayments.Name = "iconBtnShowCustPayments";
            this.iconBtnShowCustPayments.Rotation = 0D;
            this.iconBtnShowCustPayments.Size = new System.Drawing.Size(157, 23);
            this.iconBtnShowCustPayments.TabIndex = 54;
            this.iconBtnShowCustPayments.Text = "Show Customer Payments";
            this.iconBtnShowCustPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnShowCustPayments.UseVisualStyleBackColor = false;
            this.iconBtnShowCustPayments.Click += new System.EventHandler(this.iconBtnShowCustPayments_Click);
            // 
            // grBoxSupPayments
            // 
            this.grBoxSupPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxSupPayments.Controls.Add(this.lblBrand);
            this.grBoxSupPayments.Controls.Add(this.lblBalance);
            this.grBoxSupPayments.Controls.Add(this.iconBtnBalance);
            this.grBoxSupPayments.Controls.Add(this.lblRsBalance);
            this.grBoxSupPayments.Controls.Add(this.lblAmountPaid);
            this.grBoxSupPayments.Controls.Add(this.iconPicBoxBalance);
            this.grBoxSupPayments.Controls.Add(this.txtPaidAmount);
            this.grBoxSupPayments.Controls.Add(this.lblAmount);
            this.grBoxSupPayments.Controls.Add(this.iconBtnSupPaid);
            this.grBoxSupPayments.Controls.Add(this.lblRsAmount);
            this.grBoxSupPayments.Controls.Add(this.iconBtnSupCalc);
            this.grBoxSupPayments.Controls.Add(this.iconPicBoxAmount);
            this.grBoxSupPayments.Controls.Add(this.cmbItem);
            this.grBoxSupPayments.Controls.Add(this.numUpDownIngredientQuantity);
            this.grBoxSupPayments.Controls.Add(this.iconBtnClearIngredient);
            this.grBoxSupPayments.Controls.Add(this.iconBtnRemoveIngredient);
            this.grBoxSupPayments.Controls.Add(this.iconBtnAddIngredient);
            this.grBoxSupPayments.Controls.Add(this.lblIngredient);
            this.grBoxSupPayments.Controls.Add(this.listBoxIngredients);
            this.grBoxSupPayments.Controls.Add(this.cmbBrandName);
            this.grBoxSupPayments.Controls.Add(this.lblBrandName);
            this.grBoxSupPayments.Location = new System.Drawing.Point(23, 69);
            this.grBoxSupPayments.Name = "grBoxSupPayments";
            this.grBoxSupPayments.Size = new System.Drawing.Size(617, 640);
            this.grBoxSupPayments.TabIndex = 54;
            this.grBoxSupPayments.TabStop = false;
            this.grBoxSupPayments.Text = "Supplier Payments";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(32, 592);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(37, 13);
            this.lblBrand.TabIndex = 72;
            this.lblBrand.Text = "----------";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblBalance.Location = new System.Drawing.Point(250, 465);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(70, 77);
            this.lblBalance.TabIndex = 68;
            this.lblBalance.Text = "0";
            // 
            // iconBtnBalance
            // 
            this.iconBtnBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.iconBtnBalance.FlatAppearance.BorderSize = 0;
            this.iconBtnBalance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.iconBtnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnBalance.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnBalance.ForeColor = System.Drawing.Color.White;
            this.iconBtnBalance.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.iconBtnBalance.IconColor = System.Drawing.Color.White;
            this.iconBtnBalance.IconSize = 16;
            this.iconBtnBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnBalance.Location = new System.Drawing.Point(412, 406);
            this.iconBtnBalance.Name = "iconBtnBalance";
            this.iconBtnBalance.Rotation = 0D;
            this.iconBtnBalance.Size = new System.Drawing.Size(72, 23);
            this.iconBtnBalance.TabIndex = 61;
            this.iconBtnBalance.Text = "Balance";
            this.iconBtnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnBalance.UseVisualStyleBackColor = false;
            this.iconBtnBalance.Click += new System.EventHandler(this.iconBtnBalance_Click);
            // 
            // lblRsBalance
            // 
            this.lblRsBalance.AutoSize = true;
            this.lblRsBalance.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRsBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblRsBalance.Location = new System.Drawing.Point(141, 465);
            this.lblRsBalance.Name = "lblRsBalance";
            this.lblRsBalance.Size = new System.Drawing.Size(142, 77);
            this.lblRsBalance.TabIndex = 70;
            this.lblRsBalance.Text = "Rs. ";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(150, 411);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(31, 13);
            this.lblAmountPaid.TabIndex = 60;
            this.lblAmountPaid.Text = "Paid:";
            // 
            // iconPicBoxBalance
            // 
            this.iconPicBoxBalance.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBoxBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.iconPicBoxBalance.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.iconPicBoxBalance.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.iconPicBoxBalance.IconSize = 111;
            this.iconPicBoxBalance.Location = new System.Drawing.Point(35, 454);
            this.iconPicBoxBalance.Name = "iconPicBoxBalance";
            this.iconPicBoxBalance.Size = new System.Drawing.Size(114, 111);
            this.iconPicBoxBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicBoxBalance.TabIndex = 69;
            this.iconPicBoxBalance.TabStop = false;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(200, 408);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(193, 20);
            this.txtPaidAmount.TabIndex = 59;
            this.txtPaidAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaidAmount_Validating);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.lblAmount.Location = new System.Drawing.Point(250, 276);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(70, 77);
            this.lblAmount.TabIndex = 65;
            this.lblAmount.Text = "0";
            // 
            // iconBtnSupPaid
            // 
            this.iconBtnSupPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnSupPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnSupPaid.Enabled = false;
            this.iconBtnSupPaid.FlatAppearance.BorderSize = 0;
            this.iconBtnSupPaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnSupPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSupPaid.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSupPaid.ForeColor = System.Drawing.Color.White;
            this.iconBtnSupPaid.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconBtnSupPaid.IconColor = System.Drawing.Color.White;
            this.iconBtnSupPaid.IconSize = 16;
            this.iconBtnSupPaid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSupPaid.Location = new System.Drawing.Point(500, 587);
            this.iconBtnSupPaid.Name = "iconBtnSupPaid";
            this.iconBtnSupPaid.Rotation = 0D;
            this.iconBtnSupPaid.Size = new System.Drawing.Size(75, 23);
            this.iconBtnSupPaid.TabIndex = 50;
            this.iconBtnSupPaid.Text = "Paid";
            this.iconBtnSupPaid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSupPaid.UseVisualStyleBackColor = false;
            this.iconBtnSupPaid.Click += new System.EventHandler(this.iconBtnSupPaid_Click);
            // 
            // lblRsAmount
            // 
            this.lblRsAmount.AutoSize = true;
            this.lblRsAmount.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRsAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.lblRsAmount.Location = new System.Drawing.Point(141, 276);
            this.lblRsAmount.Name = "lblRsAmount";
            this.lblRsAmount.Size = new System.Drawing.Size(142, 77);
            this.lblRsAmount.TabIndex = 67;
            this.lblRsAmount.Text = "Rs. ";
            // 
            // iconBtnSupCalc
            // 
            this.iconBtnSupCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnSupCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.iconBtnSupCalc.FlatAppearance.BorderSize = 0;
            this.iconBtnSupCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.iconBtnSupCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSupCalc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSupCalc.ForeColor = System.Drawing.Color.White;
            this.iconBtnSupCalc.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.iconBtnSupCalc.IconColor = System.Drawing.Color.White;
            this.iconBtnSupCalc.IconSize = 16;
            this.iconBtnSupCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSupCalc.Location = new System.Drawing.Point(478, 258);
            this.iconBtnSupCalc.Name = "iconBtnSupCalc";
            this.iconBtnSupCalc.Rotation = 0D;
            this.iconBtnSupCalc.Size = new System.Drawing.Size(97, 23);
            this.iconBtnSupCalc.TabIndex = 50;
            this.iconBtnSupCalc.Text = "Show Amount";
            this.iconBtnSupCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSupCalc.UseVisualStyleBackColor = false;
            this.iconBtnSupCalc.Click += new System.EventHandler(this.iconBtnSupCalc_Click);
            // 
            // iconPicBoxAmount
            // 
            this.iconPicBoxAmount.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBoxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.iconPicBoxAmount.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconPicBoxAmount.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.iconPicBoxAmount.IconSize = 111;
            this.iconPicBoxAmount.Location = new System.Drawing.Point(35, 265);
            this.iconPicBoxAmount.Name = "iconPicBoxAmount";
            this.iconPicBoxAmount.Size = new System.Drawing.Size(114, 111);
            this.iconPicBoxAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicBoxAmount.TabIndex = 66;
            this.iconPicBoxAmount.TabStop = false;
            // 
            // cmbItem
            // 
            this.cmbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(127, 90);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(313, 21);
            this.cmbItem.TabIndex = 71;
            // 
            // numUpDownIngredientQuantity
            // 
            this.numUpDownIngredientQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownIngredientQuantity.Location = new System.Drawing.Point(446, 91);
            this.numUpDownIngredientQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownIngredientQuantity.Name = "numUpDownIngredientQuantity";
            this.numUpDownIngredientQuantity.Size = new System.Drawing.Size(91, 20);
            this.numUpDownIngredientQuantity.TabIndex = 70;
            // 
            // iconBtnClearIngredient
            // 
            this.iconBtnClearIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnClearIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.iconBtnClearIngredient.FlatAppearance.BorderSize = 0;
            this.iconBtnClearIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.iconBtnClearIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClearIngredient.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClearIngredient.ForeColor = System.Drawing.Color.White;
            this.iconBtnClearIngredient.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconBtnClearIngredient.IconColor = System.Drawing.Color.White;
            this.iconBtnClearIngredient.IconSize = 16;
            this.iconBtnClearIngredient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnClearIngredient.Location = new System.Drawing.Point(552, 176);
            this.iconBtnClearIngredient.Name = "iconBtnClearIngredient";
            this.iconBtnClearIngredient.Rotation = 0D;
            this.iconBtnClearIngredient.Size = new System.Drawing.Size(23, 23);
            this.iconBtnClearIngredient.TabIndex = 69;
            this.iconBtnClearIngredient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClearIngredient.UseVisualStyleBackColor = false;
            this.iconBtnClearIngredient.Click += new System.EventHandler(this.iconBtnClearIngredient_Click);
            // 
            // iconBtnRemoveIngredient
            // 
            this.iconBtnRemoveIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnRemoveIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.iconBtnRemoveIngredient.FlatAppearance.BorderSize = 0;
            this.iconBtnRemoveIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.iconBtnRemoveIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnRemoveIngredient.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnRemoveIngredient.ForeColor = System.Drawing.Color.White;
            this.iconBtnRemoveIngredient.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconBtnRemoveIngredient.IconColor = System.Drawing.Color.White;
            this.iconBtnRemoveIngredient.IconSize = 16;
            this.iconBtnRemoveIngredient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnRemoveIngredient.Location = new System.Drawing.Point(552, 131);
            this.iconBtnRemoveIngredient.Name = "iconBtnRemoveIngredient";
            this.iconBtnRemoveIngredient.Rotation = 0D;
            this.iconBtnRemoveIngredient.Size = new System.Drawing.Size(23, 23);
            this.iconBtnRemoveIngredient.TabIndex = 68;
            this.iconBtnRemoveIngredient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnRemoveIngredient.UseVisualStyleBackColor = false;
            this.iconBtnRemoveIngredient.Click += new System.EventHandler(this.iconBtnRemoveIngredient_Click);
            // 
            // iconBtnAddIngredient
            // 
            this.iconBtnAddIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnAddIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnAddIngredient.FlatAppearance.BorderSize = 0;
            this.iconBtnAddIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAddIngredient.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnAddIngredient.ForeColor = System.Drawing.Color.White;
            this.iconBtnAddIngredient.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAddIngredient.IconColor = System.Drawing.Color.White;
            this.iconBtnAddIngredient.IconSize = 16;
            this.iconBtnAddIngredient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnAddIngredient.Location = new System.Drawing.Point(552, 87);
            this.iconBtnAddIngredient.Name = "iconBtnAddIngredient";
            this.iconBtnAddIngredient.Rotation = 0D;
            this.iconBtnAddIngredient.Size = new System.Drawing.Size(23, 23);
            this.iconBtnAddIngredient.TabIndex = 65;
            this.iconBtnAddIngredient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddIngredient.UseVisualStyleBackColor = false;
            this.iconBtnAddIngredient.Click += new System.EventHandler(this.iconBtnAddIngredient_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(32, 92);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(57, 13);
            this.lblIngredient.TabIndex = 64;
            this.lblIngredient.Text = "Ingredient:";
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(127, 131);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(410, 108);
            this.listBoxIngredients.TabIndex = 67;
            // 
            // cmbBrandName
            // 
            this.cmbBrandName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBrandName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrandName.FormattingEnabled = true;
            this.cmbBrandName.Location = new System.Drawing.Point(127, 39);
            this.cmbBrandName.Name = "cmbBrandName";
            this.cmbBrandName.Size = new System.Drawing.Size(410, 21);
            this.cmbBrandName.TabIndex = 51;
            this.cmbBrandName.SelectedIndexChanged += new System.EventHandler(this.cmbBrandName_SelectedIndexChanged);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(32, 42);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(69, 13);
            this.lblBrandName.TabIndex = 50;
            this.lblBrandName.Text = "Brand Name:";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(107, 25);
            this.lblFormTitle.TabIndex = 30;
            this.lblFormTitle.Text = "Payments";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Brand";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paid";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Balance";
            this.columnHeader5.Width = 80;
            // 
            // payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 731);
            this.Controls.Add(this.panelPayments);
            this.Name = "payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.payments_Load);
            this.panelPayments.ResumeLayout(false);
            this.panelPayments.PerformLayout();
            this.grBoxSupPayments.ResumeLayout(false);
            this.grBoxSupPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownIngredientQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPayments;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grBoxSupPayments;
        private System.Windows.Forms.ComboBox cmbBrandName;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.NumericUpDown numUpDownIngredientQuantity;
        private FontAwesome.Sharp.IconButton iconBtnClearIngredient;
        private FontAwesome.Sharp.IconButton iconBtnRemoveIngredient;
        private FontAwesome.Sharp.IconButton iconBtnAddIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.ComboBox cmbItem;
        private FontAwesome.Sharp.IconButton iconBtnSupCalc;
        private FontAwesome.Sharp.IconButton iconBtnSupPaid;
        private FontAwesome.Sharp.IconButton iconBtnShowCustPayments;
        private System.Windows.Forms.ListView listViewSupPayments;
        private FontAwesome.Sharp.IconButton iconBtnBalance;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblRsBalance;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxBalance;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRsAmount;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxAmount;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}