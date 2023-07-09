namespace rms
{
    partial class mealupdate
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
            this.grBoxFoodDetails = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.iconBtnMealUpdate = new FontAwesome.Sharp.IconButton();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtPrepareTime = new System.Windows.Forms.TextBox();
            this.lblPrepareTime = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbUpdateKey = new System.Windows.Forms.ComboBox();
            this.lblMealID = new System.Windows.Forms.Label();
            this.grBoxIngredients = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtMealID = new System.Windows.Forms.TextBox();
            this.lblSelectedMealID = new System.Windows.Forms.Label();
            this.iconBtnClearItem = new FontAwesome.Sharp.IconButton();
            this.iconBtnIngrUpdate = new FontAwesome.Sharp.IconButton();
            this.iconBtnRemoveItem = new FontAwesome.Sharp.IconButton();
            this.cmbIngredient = new System.Windows.Forms.ComboBox();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.iconBtnAddItem = new FontAwesome.Sharp.IconButton();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.listViewMealDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.listViewIngredientsDetails = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grBoxFoodDetails.SuspendLayout();
            this.grBoxIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(130, 25);
            this.lblFormTitle.TabIndex = 55;
            this.lblFormTitle.Text = "Update Meal";
            // 
            // grBoxFoodDetails
            // 
            this.grBoxFoodDetails.Controls.Add(this.cmbType);
            this.grBoxFoodDetails.Controls.Add(this.iconBtnMealUpdate);
            this.grBoxFoodDetails.Controls.Add(this.lblMinutes);
            this.grBoxFoodDetails.Controls.Add(this.txtPrepareTime);
            this.grBoxFoodDetails.Controls.Add(this.lblPrepareTime);
            this.grBoxFoodDetails.Controls.Add(this.txtDescription);
            this.grBoxFoodDetails.Controls.Add(this.lblType);
            this.grBoxFoodDetails.Controls.Add(this.txtName);
            this.grBoxFoodDetails.Controls.Add(this.txtPrice);
            this.grBoxFoodDetails.Controls.Add(this.lblDescription);
            this.grBoxFoodDetails.Controls.Add(this.lblPrice);
            this.grBoxFoodDetails.Controls.Add(this.lblName);
            this.grBoxFoodDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxFoodDetails.Name = "grBoxFoodDetails";
            this.grBoxFoodDetails.Size = new System.Drawing.Size(516, 304);
            this.grBoxFoodDetails.TabIndex = 53;
            this.grBoxFoodDetails.TabStop = false;
            this.grBoxFoodDetails.Text = "Food Details";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Breads, Cereals, Rice, Pasta, Noodles and Other grains",
            "Vegetables and Legumes",
            "Fruit",
            "Milk, Yoghurt, Cheese and or alternatives",
            "Lean meat, Fish, Poultry, Eggs, Nuts and Legumes"});
            this.cmbType.Location = new System.Drawing.Point(113, 105);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(303, 21);
            this.cmbType.TabIndex = 65;
            this.cmbType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbType_Validating);
            // 
            // iconBtnMealUpdate
            // 
            this.iconBtnMealUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.iconBtnMealUpdate.FlatAppearance.BorderSize = 0;
            this.iconBtnMealUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.iconBtnMealUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMealUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMealUpdate.ForeColor = System.Drawing.Color.White;
            this.iconBtnMealUpdate.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconBtnMealUpdate.IconColor = System.Drawing.Color.White;
            this.iconBtnMealUpdate.IconSize = 16;
            this.iconBtnMealUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnMealUpdate.Location = new System.Drawing.Point(420, 261);
            this.iconBtnMealUpdate.Name = "iconBtnMealUpdate";
            this.iconBtnMealUpdate.Rotation = 0D;
            this.iconBtnMealUpdate.Size = new System.Drawing.Size(75, 23);
            this.iconBtnMealUpdate.TabIndex = 64;
            this.iconBtnMealUpdate.Text = "Update";
            this.iconBtnMealUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnMealUpdate.UseVisualStyleBackColor = false;
            this.iconBtnMealUpdate.Click += new System.EventHandler(this.iconBtnMealUpdate_Click);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(266, 149);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 59;
            this.lblMinutes.Text = "Minutes";
            // 
            // txtPrepareTime
            // 
            this.txtPrepareTime.Location = new System.Drawing.Point(113, 146);
            this.txtPrepareTime.Name = "txtPrepareTime";
            this.txtPrepareTime.Size = new System.Drawing.Size(147, 20);
            this.txtPrepareTime.TabIndex = 58;
            this.txtPrepareTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrepareTime_Validating);
            // 
            // lblPrepareTime
            // 
            this.lblPrepareTime.AutoSize = true;
            this.lblPrepareTime.Location = new System.Drawing.Point(17, 149);
            this.lblPrepareTime.Name = "lblPrepareTime";
            this.lblPrepareTime.Size = new System.Drawing.Size(90, 13);
            this.lblPrepareTime.TabIndex = 57;
            this.lblPrepareTime.Text = "Preparation Time:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(113, 185);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(382, 56);
            this.txtDescription.TabIndex = 55;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(17, 108);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 51;
            this.lblType.Text = "Type:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(382, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(113, 67);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(382, 20);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 185);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(17, 69);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // cmbUpdateKey
            // 
            this.cmbUpdateKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateKey.FormattingEnabled = true;
            this.cmbUpdateKey.Location = new System.Drawing.Point(527, 23);
            this.cmbUpdateKey.Name = "cmbUpdateKey";
            this.cmbUpdateKey.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateKey.TabIndex = 54;
            this.cmbUpdateKey.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateKey_SelectedIndexChanged);
            this.cmbUpdateKey.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUpdateKey_Validating);
            // 
            // lblMealID
            // 
            this.lblMealID.AutoSize = true;
            this.lblMealID.Location = new System.Drawing.Point(464, 26);
            this.lblMealID.Name = "lblMealID";
            this.lblMealID.Size = new System.Drawing.Size(47, 13);
            this.lblMealID.TabIndex = 53;
            this.lblMealID.Text = "Meal ID:";
            // 
            // grBoxIngredients
            // 
            this.grBoxIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxIngredients.Controls.Add(this.txtQuantity);
            this.grBoxIngredients.Controls.Add(this.txtMealID);
            this.grBoxIngredients.Controls.Add(this.lblSelectedMealID);
            this.grBoxIngredients.Controls.Add(this.iconBtnClearItem);
            this.grBoxIngredients.Controls.Add(this.iconBtnIngrUpdate);
            this.grBoxIngredients.Controls.Add(this.iconBtnRemoveItem);
            this.grBoxIngredients.Controls.Add(this.cmbIngredient);
            this.grBoxIngredients.Controls.Add(this.listBoxIngredients);
            this.grBoxIngredients.Controls.Add(this.iconBtnAddItem);
            this.grBoxIngredients.Controls.Add(this.lblIngredient);
            this.grBoxIngredients.Location = new System.Drawing.Point(564, 69);
            this.grBoxIngredients.Name = "grBoxIngredients";
            this.grBoxIngredients.Size = new System.Drawing.Size(516, 262);
            this.grBoxIngredients.TabIndex = 54;
            this.grBoxIngredients.TabStop = false;
            this.grBoxIngredients.Text = "Ingredients Details";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(365, 67);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(87, 20);
            this.txtQuantity.TabIndex = 61;
            // 
            // txtMealID
            // 
            this.txtMealID.Enabled = false;
            this.txtMealID.Location = new System.Drawing.Point(111, 28);
            this.txtMealID.Name = "txtMealID";
            this.txtMealID.Size = new System.Drawing.Size(165, 20);
            this.txtMealID.TabIndex = 66;
            // 
            // lblSelectedMealID
            // 
            this.lblSelectedMealID.AutoSize = true;
            this.lblSelectedMealID.Location = new System.Drawing.Point(15, 30);
            this.lblSelectedMealID.Name = "lblSelectedMealID";
            this.lblSelectedMealID.Size = new System.Drawing.Size(47, 13);
            this.lblSelectedMealID.TabIndex = 65;
            this.lblSelectedMealID.Text = "Meal ID:";
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
            this.iconBtnClearItem.Location = new System.Drawing.Point(470, 156);
            this.iconBtnClearItem.Name = "iconBtnClearItem";
            this.iconBtnClearItem.Rotation = 0D;
            this.iconBtnClearItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnClearItem.TabIndex = 63;
            this.iconBtnClearItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClearItem.UseVisualStyleBackColor = false;
            this.iconBtnClearItem.Click += new System.EventHandler(this.iconBtnClearItem_Click);
            // 
            // iconBtnIngrUpdate
            // 
            this.iconBtnIngrUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnIngrUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.iconBtnIngrUpdate.FlatAppearance.BorderSize = 0;
            this.iconBtnIngrUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.iconBtnIngrUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnIngrUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnIngrUpdate.ForeColor = System.Drawing.Color.White;
            this.iconBtnIngrUpdate.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconBtnIngrUpdate.IconColor = System.Drawing.Color.White;
            this.iconBtnIngrUpdate.IconSize = 16;
            this.iconBtnIngrUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnIngrUpdate.Location = new System.Drawing.Point(418, 220);
            this.iconBtnIngrUpdate.Name = "iconBtnIngrUpdate";
            this.iconBtnIngrUpdate.Rotation = 0D;
            this.iconBtnIngrUpdate.Size = new System.Drawing.Size(75, 23);
            this.iconBtnIngrUpdate.TabIndex = 50;
            this.iconBtnIngrUpdate.Text = "Update";
            this.iconBtnIngrUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnIngrUpdate.UseVisualStyleBackColor = false;
            this.iconBtnIngrUpdate.Click += new System.EventHandler(this.iconBtnIngrUpdate_Click);
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
            this.iconBtnRemoveItem.Location = new System.Drawing.Point(470, 111);
            this.iconBtnRemoveItem.Name = "iconBtnRemoveItem";
            this.iconBtnRemoveItem.Rotation = 0D;
            this.iconBtnRemoveItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnRemoveItem.TabIndex = 62;
            this.iconBtnRemoveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnRemoveItem.UseVisualStyleBackColor = false;
            this.iconBtnRemoveItem.Click += new System.EventHandler(this.iconBtnRemoveItem_Click);
            // 
            // cmbIngredient
            // 
            this.cmbIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngredient.FormattingEnabled = true;
            this.cmbIngredient.Location = new System.Drawing.Point(111, 67);
            this.cmbIngredient.Name = "cmbIngredient";
            this.cmbIngredient.Size = new System.Drawing.Size(248, 21);
            this.cmbIngredient.TabIndex = 58;
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(111, 109);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(341, 95);
            this.listBoxIngredients.TabIndex = 60;
            this.listBoxIngredients.Validating += new System.ComponentModel.CancelEventHandler(this.listBoxIngredients_Validating);
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
            this.iconBtnAddItem.Location = new System.Drawing.Point(470, 67);
            this.iconBtnAddItem.Name = "iconBtnAddItem";
            this.iconBtnAddItem.Rotation = 0D;
            this.iconBtnAddItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnAddItem.TabIndex = 61;
            this.iconBtnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddItem.UseVisualStyleBackColor = false;
            this.iconBtnAddItem.Click += new System.EventHandler(this.iconBtnAddItem_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(15, 70);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(57, 13);
            this.lblIngredient.TabIndex = 59;
            this.lblIngredient.Text = "Ingredient:";
            // 
            // listViewMealDetails
            // 
            this.listViewMealDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewMealDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMealDetails.FullRowSelect = true;
            this.listViewMealDetails.GridLines = true;
            this.listViewMealDetails.Location = new System.Drawing.Point(23, 393);
            this.listViewMealDetails.MultiSelect = false;
            this.listViewMealDetails.Name = "listViewMealDetails";
            this.listViewMealDetails.Size = new System.Drawing.Size(516, 223);
            this.listViewMealDetails.TabIndex = 56;
            this.listViewMealDetails.UseCompatibleStateImageBehavior = false;
            this.listViewMealDetails.View = System.Windows.Forms.View.Details;
            this.listViewMealDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewMealDetails_MouseClick);
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
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Preparation Time";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 200;
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
            // listViewIngredientsDetails
            // 
            this.listViewIngredientsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIngredientsDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewIngredientsDetails.FullRowSelect = true;
            this.listViewIngredientsDetails.GridLines = true;
            this.listViewIngredientsDetails.Location = new System.Drawing.Point(564, 352);
            this.listViewIngredientsDetails.MultiSelect = false;
            this.listViewIngredientsDetails.Name = "listViewIngredientsDetails";
            this.listViewIngredientsDetails.Size = new System.Drawing.Size(516, 264);
            this.listViewIngredientsDetails.TabIndex = 58;
            this.listViewIngredientsDetails.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientsDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Meal ID";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Quantity";
            this.columnHeader10.Width = 80;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // mealupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewIngredientsDetails);
            this.Controls.Add(this.iconBackBtn);
            this.Controls.Add(this.listViewMealDetails);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.grBoxFoodDetails);
            this.Controls.Add(this.cmbUpdateKey);
            this.Controls.Add(this.lblMealID);
            this.Controls.Add(this.grBoxIngredients);
            this.Name = "mealupdate";
            this.Size = new System.Drawing.Size(1105, 636);
            this.Load += new System.EventHandler(this.mealupdate_Load);
            this.grBoxFoodDetails.ResumeLayout(false);
            this.grBoxFoodDetails.PerformLayout();
            this.grBoxIngredients.ResumeLayout(false);
            this.grBoxIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grBoxFoodDetails;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grBoxIngredients;
        private FontAwesome.Sharp.IconButton iconBtnIngrUpdate;
        private System.Windows.Forms.ComboBox cmbUpdateKey;
        private System.Windows.Forms.Label lblMealID;
        private System.Windows.Forms.ListView listViewMealDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtPrepareTime;
        private System.Windows.Forms.Label lblPrepareTime;
        private FontAwesome.Sharp.IconButton iconBtnClearItem;
        private FontAwesome.Sharp.IconButton iconBtnRemoveItem;
        private System.Windows.Forms.ComboBox cmbIngredient;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private FontAwesome.Sharp.IconButton iconBtnAddItem;
        private System.Windows.Forms.Label lblIngredient;
        private FontAwesome.Sharp.IconButton iconBtnMealUpdate;
        private System.Windows.Forms.ListView listViewIngredientsDetails;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtMealID;
        private System.Windows.Forms.Label lblSelectedMealID;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}
