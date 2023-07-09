namespace rms
{
    partial class meal
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
            this.panelMeal = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.grBoxFoodDetails = new System.Windows.Forms.GroupBox();
            this.iconBtnAdd = new FontAwesome.Sharp.IconButton();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtPrepareTime = new System.Windows.Forms.TextBox();
            this.lblPrepareTime = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.iconBtnSearch = new FontAwesome.Sharp.IconButton();
            this.grBoxIngredients = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtMealID = new System.Windows.Forms.TextBox();
            this.lblMealID = new System.Windows.Forms.Label();
            this.iconBtnClearItem = new FontAwesome.Sharp.IconButton();
            this.iconBtnAddIngredients = new FontAwesome.Sharp.IconButton();
            this.iconBtnRemoveItem = new FontAwesome.Sharp.IconButton();
            this.cmbIngredient = new System.Windows.Forms.ComboBox();
            this.iconBtnAddItem = new FontAwesome.Sharp.IconButton();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMeal.SuspendLayout();
            this.grBoxFoodDetails.SuspendLayout();
            this.grBoxIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMeal
            // 
            this.panelMeal.Controls.Add(this.lblFormTitle);
            this.panelMeal.Controls.Add(this.iconBtnDelete);
            this.panelMeal.Controls.Add(this.grBoxFoodDetails);
            this.panelMeal.Controls.Add(this.iconBtnSearch);
            this.panelMeal.Controls.Add(this.grBoxIngredients);
            this.panelMeal.Controls.Add(this.iconBtnUpdate);
            this.panelMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMeal.Location = new System.Drawing.Point(0, 0);
            this.panelMeal.Name = "panelMeal";
            this.panelMeal.Size = new System.Drawing.Size(1052, 579);
            this.panelMeal.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(58, 25);
            this.lblFormTitle.TabIndex = 49;
            this.lblFormTitle.Text = "Meal";
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
            this.iconBtnDelete.TabIndex = 44;
            this.iconBtnDelete.Text = "Delete";
            this.iconBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
            // 
            // grBoxFoodDetails
            // 
            this.grBoxFoodDetails.Controls.Add(this.iconBtnAdd);
            this.grBoxFoodDetails.Controls.Add(this.lblMinutes);
            this.grBoxFoodDetails.Controls.Add(this.txtPrepareTime);
            this.grBoxFoodDetails.Controls.Add(this.lblPrepareTime);
            this.grBoxFoodDetails.Controls.Add(this.txtDescription);
            this.grBoxFoodDetails.Controls.Add(this.cmbType);
            this.grBoxFoodDetails.Controls.Add(this.lblType);
            this.grBoxFoodDetails.Controls.Add(this.txtName);
            this.grBoxFoodDetails.Controls.Add(this.txtPrice);
            this.grBoxFoodDetails.Controls.Add(this.lblDescription);
            this.grBoxFoodDetails.Controls.Add(this.lblPrice);
            this.grBoxFoodDetails.Controls.Add(this.lblName);
            this.grBoxFoodDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxFoodDetails.Name = "grBoxFoodDetails";
            this.grBoxFoodDetails.Size = new System.Drawing.Size(516, 338);
            this.grBoxFoodDetails.TabIndex = 47;
            this.grBoxFoodDetails.TabStop = false;
            this.grBoxFoodDetails.Text = "Meal Details";
            // 
            // iconBtnAdd
            // 
            this.iconBtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnAdd.FlatAppearance.BorderSize = 0;
            this.iconBtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnAdd.ForeColor = System.Drawing.Color.White;
            this.iconBtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAdd.IconColor = System.Drawing.Color.White;
            this.iconBtnAdd.IconSize = 16;
            this.iconBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAdd.Location = new System.Drawing.Point(420, 295);
            this.iconBtnAdd.Name = "iconBtnAdd";
            this.iconBtnAdd.Rotation = 0D;
            this.iconBtnAdd.Size = new System.Drawing.Size(75, 23);
            this.iconBtnAdd.TabIndex = 57;
            this.iconBtnAdd.Text = "Add";
            this.iconBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAdd.UseVisualStyleBackColor = false;
            this.iconBtnAdd.Click += new System.EventHandler(this.iconBtnAdd_Click);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(266, 150);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 56;
            this.lblMinutes.Text = "Minutes";
            // 
            // txtPrepareTime
            // 
            this.txtPrepareTime.Location = new System.Drawing.Point(113, 149);
            this.txtPrepareTime.Name = "txtPrepareTime";
            this.txtPrepareTime.Size = new System.Drawing.Size(147, 20);
            this.txtPrepareTime.TabIndex = 55;
            this.txtPrepareTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrepareTime_Validating);
            // 
            // lblPrepareTime
            // 
            this.lblPrepareTime.AutoSize = true;
            this.lblPrepareTime.Location = new System.Drawing.Point(17, 152);
            this.lblPrepareTime.Name = "lblPrepareTime";
            this.lblPrepareTime.Size = new System.Drawing.Size(90, 13);
            this.lblPrepareTime.TabIndex = 54;
            this.lblPrepareTime.Text = "Preparation Time:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(113, 192);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(382, 82);
            this.txtDescription.TabIndex = 53;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
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
            this.cmbType.Location = new System.Drawing.Point(113, 107);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(303, 21);
            this.cmbType.TabIndex = 52;
            this.cmbType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbType_Validating);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(17, 110);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 51;
            this.lblType.Text = "Type:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 26);
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
            this.lblDescription.Location = new System.Drawing.Point(17, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(17, 70);
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
            this.iconBtnSearch.TabIndex = 45;
            this.iconBtnSearch.Text = "Search";
            this.iconBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSearch.UseVisualStyleBackColor = false;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // grBoxIngredients
            // 
            this.grBoxIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxIngredients.Controls.Add(this.txtQuantity);
            this.grBoxIngredients.Controls.Add(this.txtMealID);
            this.grBoxIngredients.Controls.Add(this.lblMealID);
            this.grBoxIngredients.Controls.Add(this.iconBtnClearItem);
            this.grBoxIngredients.Controls.Add(this.iconBtnAddIngredients);
            this.grBoxIngredients.Controls.Add(this.iconBtnRemoveItem);
            this.grBoxIngredients.Controls.Add(this.cmbIngredient);
            this.grBoxIngredients.Controls.Add(this.iconBtnAddItem);
            this.grBoxIngredients.Controls.Add(this.lblIngredient);
            this.grBoxIngredients.Controls.Add(this.listBoxIngredients);
            this.grBoxIngredients.Location = new System.Drawing.Point(565, 69);
            this.grBoxIngredients.Name = "grBoxIngredients";
            this.grBoxIngredients.Size = new System.Drawing.Size(463, 304);
            this.grBoxIngredients.TabIndex = 48;
            this.grBoxIngredients.TabStop = false;
            this.grBoxIngredients.Text = "Ingredients Details";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(319, 67);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(75, 20);
            this.txtQuantity.TabIndex = 60;
            // 
            // txtMealID
            // 
            this.txtMealID.Enabled = false;
            this.txtMealID.Location = new System.Drawing.Point(106, 26);
            this.txtMealID.Name = "txtMealID";
            this.txtMealID.Size = new System.Drawing.Size(147, 20);
            this.txtMealID.TabIndex = 59;
            // 
            // lblMealID
            // 
            this.lblMealID.AutoSize = true;
            this.lblMealID.Location = new System.Drawing.Point(21, 29);
            this.lblMealID.Name = "lblMealID";
            this.lblMealID.Size = new System.Drawing.Size(47, 13);
            this.lblMealID.TabIndex = 58;
            this.lblMealID.Text = "Meal ID:";
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
            this.iconBtnClearItem.Location = new System.Drawing.Point(413, 156);
            this.iconBtnClearItem.Name = "iconBtnClearItem";
            this.iconBtnClearItem.Rotation = 0D;
            this.iconBtnClearItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnClearItem.TabIndex = 56;
            this.iconBtnClearItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnClearItem.UseVisualStyleBackColor = false;
            this.iconBtnClearItem.Click += new System.EventHandler(this.iconBtnClearItem_Click);
            // 
            // iconBtnAddIngredients
            // 
            this.iconBtnAddIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnAddIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnAddIngredients.FlatAppearance.BorderSize = 0;
            this.iconBtnAddIngredients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnAddIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAddIngredients.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnAddIngredients.ForeColor = System.Drawing.Color.White;
            this.iconBtnAddIngredients.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAddIngredients.IconColor = System.Drawing.Color.White;
            this.iconBtnAddIngredients.IconSize = 16;
            this.iconBtnAddIngredients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAddIngredients.Location = new System.Drawing.Point(361, 230);
            this.iconBtnAddIngredients.Name = "iconBtnAddIngredients";
            this.iconBtnAddIngredients.Rotation = 0D;
            this.iconBtnAddIngredients.Size = new System.Drawing.Size(75, 23);
            this.iconBtnAddIngredients.TabIndex = 31;
            this.iconBtnAddIngredients.Text = "Add";
            this.iconBtnAddIngredients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddIngredients.UseVisualStyleBackColor = false;
            this.iconBtnAddIngredients.Click += new System.EventHandler(this.iconBtnAddIngredients_Click);
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
            this.iconBtnRemoveItem.Location = new System.Drawing.Point(413, 111);
            this.iconBtnRemoveItem.Name = "iconBtnRemoveItem";
            this.iconBtnRemoveItem.Rotation = 0D;
            this.iconBtnRemoveItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnRemoveItem.TabIndex = 55;
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
            this.cmbIngredient.Location = new System.Drawing.Point(106, 67);
            this.cmbIngredient.Name = "cmbIngredient";
            this.cmbIngredient.Size = new System.Drawing.Size(207, 21);
            this.cmbIngredient.TabIndex = 51;
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
            this.iconBtnAddItem.Location = new System.Drawing.Point(413, 67);
            this.iconBtnAddItem.Name = "iconBtnAddItem";
            this.iconBtnAddItem.Rotation = 0D;
            this.iconBtnAddItem.Size = new System.Drawing.Size(23, 23);
            this.iconBtnAddItem.TabIndex = 54;
            this.iconBtnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddItem.UseVisualStyleBackColor = false;
            this.iconBtnAddItem.Click += new System.EventHandler(this.iconBtnAddItem_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(21, 70);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(57, 13);
            this.lblIngredient.TabIndex = 52;
            this.lblIngredient.Text = "Ingredient:";
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(106, 109);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(288, 95);
            this.listBoxIngredients.TabIndex = 53;
            this.listBoxIngredients.Validating += new System.ComponentModel.CancelEventHandler(this.listBoxIngredients_Validating);
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
            this.iconBtnUpdate.TabIndex = 43;
            this.iconBtnUpdate.Text = "Update";
            this.iconBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnUpdate.UseVisualStyleBackColor = false;
            this.iconBtnUpdate.Click += new System.EventHandler(this.iconBtnUpdate_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 579);
            this.Controls.Add(this.panelMeal);
            this.Name = "meal";
            this.Text = "Meals";
            this.Load += new System.EventHandler(this.meal_Load);
            this.panelMeal.ResumeLayout(false);
            this.panelMeal.PerformLayout();
            this.grBoxFoodDetails.ResumeLayout(false);
            this.grBoxFoodDetails.PerformLayout();
            this.grBoxIngredients.ResumeLayout(false);
            this.grBoxIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeal;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grBoxFoodDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grBoxIngredients;
        private FontAwesome.Sharp.IconButton iconBtnAddIngredients;
        private FontAwesome.Sharp.IconButton iconBtnUpdate;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtPrepareTime;
        private System.Windows.Forms.Label lblPrepareTime;
        private FontAwesome.Sharp.IconButton iconBtnClearItem;
        private FontAwesome.Sharp.IconButton iconBtnRemoveItem;
        private System.Windows.Forms.ComboBox cmbIngredient;
        private FontAwesome.Sharp.IconButton iconBtnAddItem;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private FontAwesome.Sharp.IconButton iconBtnAdd;
        private System.Windows.Forms.TextBox txtMealID;
        private System.Windows.Forms.Label lblMealID;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}