namespace rms
{
    partial class mealsearch
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
            this.txtMealID = new System.Windows.Forms.TextBox();
            this.lblMID = new System.Windows.Forms.Label();
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.grBoxFoodDetails = new System.Windows.Forms.GroupBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblPrepareTime = new System.Windows.Forms.Label();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblSearchPrice = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblSearchMealID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMealID = new System.Windows.Forms.Label();
            this.listViewMealDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearchDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            this.grBoxFoodDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(129, 25);
            this.lblFormTitle.TabIndex = 62;
            this.lblFormTitle.Text = "Search Meal";
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
            this.iconBtnSearch.Location = new System.Drawing.Point(581, 24);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(75, 23);
            this.iconBtnSearch.TabIndex = 61;
            this.iconBtnSearch.Text = "Search";
            this.iconBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSearch.UseVisualStyleBackColor = false;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // txtMealID
            // 
            this.txtMealID.Location = new System.Drawing.Point(461, 26);
            this.txtMealID.Name = "txtMealID";
            this.txtMealID.Size = new System.Drawing.Size(100, 20);
            this.txtMealID.TabIndex = 60;
            this.txtMealID.Validating += new System.ComponentModel.CancelEventHandler(this.txtMealID_Validating);
            // 
            // lblMID
            // 
            this.lblMID.AutoSize = true;
            this.lblMID.Location = new System.Drawing.Point(404, 29);
            this.lblMID.Name = "lblMID";
            this.lblMID.Size = new System.Drawing.Size(47, 13);
            this.lblMID.TabIndex = 59;
            this.lblMID.Text = "Meal ID:";
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
            this.iconBackBtn.TabIndex = 58;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // grBoxFoodDetails
            // 
            this.grBoxFoodDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxFoodDetails.Controls.Add(this.txtSearchDescription);
            this.grBoxFoodDetails.Controls.Add(this.lblMinutes);
            this.grBoxFoodDetails.Controls.Add(this.lblPrepareTime);
            this.grBoxFoodDetails.Controls.Add(this.lblSearchType);
            this.grBoxFoodDetails.Controls.Add(this.lblType);
            this.grBoxFoodDetails.Controls.Add(this.listBoxIngredients);
            this.grBoxFoodDetails.Controls.Add(this.lblIngredients);
            this.grBoxFoodDetails.Controls.Add(this.lblSearchPrice);
            this.grBoxFoodDetails.Controls.Add(this.lblSearchName);
            this.grBoxFoodDetails.Controls.Add(this.lblSearchMealID);
            this.grBoxFoodDetails.Controls.Add(this.lblDescription);
            this.grBoxFoodDetails.Controls.Add(this.lblPrice);
            this.grBoxFoodDetails.Controls.Add(this.lblName);
            this.grBoxFoodDetails.Controls.Add(this.lblMealID);
            this.grBoxFoodDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxFoodDetails.Name = "grBoxFoodDetails";
            this.grBoxFoodDetails.Size = new System.Drawing.Size(466, 511);
            this.grBoxFoodDetails.TabIndex = 57;
            this.grBoxFoodDetails.TabStop = false;
            this.grBoxFoodDetails.Text = "Food Details";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(135, 189);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(37, 13);
            this.lblMinutes.TabIndex = 58;
            this.lblMinutes.Text = "----------";
            // 
            // lblPrepareTime
            // 
            this.lblPrepareTime.AutoSize = true;
            this.lblPrepareTime.Location = new System.Drawing.Point(15, 189);
            this.lblPrepareTime.Name = "lblPrepareTime";
            this.lblPrepareTime.Size = new System.Drawing.Size(90, 13);
            this.lblPrepareTime.TabIndex = 57;
            this.lblPrepareTime.Text = "Preparation Time:";
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(135, 149);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(37, 13);
            this.lblSearchType.TabIndex = 32;
            this.lblSearchType.Text = "----------";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(17, 149);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 31;
            this.lblType.Text = "Type:";
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(135, 307);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(307, 121);
            this.listBoxIngredients.TabIndex = 29;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(17, 307);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(62, 13);
            this.lblIngredients.TabIndex = 28;
            this.lblIngredients.Text = "Ingredients:";
            // 
            // lblSearchPrice
            // 
            this.lblSearchPrice.AutoSize = true;
            this.lblSearchPrice.Location = new System.Drawing.Point(135, 110);
            this.lblSearchPrice.Name = "lblSearchPrice";
            this.lblSearchPrice.Size = new System.Drawing.Size(37, 13);
            this.lblSearchPrice.TabIndex = 23;
            this.lblSearchPrice.Text = "----------";
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
            // lblSearchMealID
            // 
            this.lblSearchMealID.AutoSize = true;
            this.lblSearchMealID.Location = new System.Drawing.Point(135, 30);
            this.lblSearchMealID.Name = "lblSearchMealID";
            this.lblSearchMealID.Size = new System.Drawing.Size(37, 13);
            this.lblSearchMealID.TabIndex = 21;
            this.lblSearchMealID.Text = "----------";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 228);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(17, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
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
            // lblMealID
            // 
            this.lblMealID.AutoSize = true;
            this.lblMealID.Location = new System.Drawing.Point(17, 30);
            this.lblMealID.Name = "lblMealID";
            this.lblMealID.Size = new System.Drawing.Size(47, 13);
            this.lblMealID.TabIndex = 2;
            this.lblMealID.Text = "Meal ID:";
            // 
            // listViewMealDetails
            // 
            this.listViewMealDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMealDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMealDetails.FullRowSelect = true;
            this.listViewMealDetails.GridLines = true;
            this.listViewMealDetails.Location = new System.Drawing.Point(511, 69);
            this.listViewMealDetails.MultiSelect = false;
            this.listViewMealDetails.Name = "listViewMealDetails";
            this.listViewMealDetails.Size = new System.Drawing.Size(458, 511);
            this.listViewMealDetails.TabIndex = 63;
            this.listViewMealDetails.UseCompatibleStateImageBehavior = false;
            this.listViewMealDetails.View = System.Windows.Forms.View.Details;
            this.listViewMealDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMealDetails_MouseDoubleClick);
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtSearchDescription
            // 
            this.txtSearchDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchDescription.Location = new System.Drawing.Point(135, 228);
            this.txtSearchDescription.Multiline = true;
            this.txtSearchDescription.Name = "txtSearchDescription";
            this.txtSearchDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchDescription.Size = new System.Drawing.Size(307, 61);
            this.txtSearchDescription.TabIndex = 59;
            // 
            // mealsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewMealDetails);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBtnSearch);
            this.Controls.Add(this.txtMealID);
            this.Controls.Add(this.lblMID);
            this.Controls.Add(this.iconBackBtn);
            this.Controls.Add(this.grBoxFoodDetails);
            this.Name = "mealsearch";
            this.Size = new System.Drawing.Size(992, 599);
            this.Load += new System.EventHandler(this.mealsearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            this.grBoxFoodDetails.ResumeLayout(false);
            this.grBoxFoodDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private System.Windows.Forms.TextBox txtMealID;
        private System.Windows.Forms.Label lblMID;
        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.GroupBox grBoxFoodDetails;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblSearchPrice;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblSearchMealID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMealID;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblPrepareTime;
        private System.Windows.Forms.ListView listViewMealDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtSearchDescription;
    }
}
