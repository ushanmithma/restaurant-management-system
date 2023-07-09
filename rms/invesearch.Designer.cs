namespace rms
{
    partial class invesearch
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
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.grBoxSearchIngredientDetails = new System.Windows.Forms.GroupBox();
            this.lblSearchPrice = new System.Windows.Forms.Label();
            this.lblSearchUnit = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.listViewIngredientDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconBtnSearch = new FontAwesome.Sharp.IconButton();
            this.txtIngrID = new System.Windows.Forms.TextBox();
            this.lblIngrID = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            this.grBoxSearchIngredientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.iconBackBtn.TabIndex = 55;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(180, 25);
            this.lblFormTitle.TabIndex = 56;
            this.lblFormTitle.Text = "Search Ingredient";
            // 
            // grBoxSearchIngredientDetails
            // 
            this.grBoxSearchIngredientDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxSearchIngredientDetails.Controls.Add(this.lblSearchPrice);
            this.grBoxSearchIngredientDetails.Controls.Add(this.lblSearchUnit);
            this.grBoxSearchIngredientDetails.Controls.Add(this.lblSearchName);
            this.grBoxSearchIngredientDetails.Controls.Add(this.lblPrice);
            this.grBoxSearchIngredientDetails.Controls.Add(this.lblUnit);
            this.grBoxSearchIngredientDetails.Controls.Add(this.lblName);
            this.grBoxSearchIngredientDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxSearchIngredientDetails.Name = "grBoxSearchIngredientDetails";
            this.grBoxSearchIngredientDetails.Size = new System.Drawing.Size(395, 486);
            this.grBoxSearchIngredientDetails.TabIndex = 57;
            this.grBoxSearchIngredientDetails.TabStop = false;
            this.grBoxSearchIngredientDetails.Text = "Search Ingredient";
            // 
            // lblSearchPrice
            // 
            this.lblSearchPrice.AutoSize = true;
            this.lblSearchPrice.Location = new System.Drawing.Point(102, 123);
            this.lblSearchPrice.Name = "lblSearchPrice";
            this.lblSearchPrice.Size = new System.Drawing.Size(37, 13);
            this.lblSearchPrice.TabIndex = 60;
            this.lblSearchPrice.Text = "----------";
            // 
            // lblSearchUnit
            // 
            this.lblSearchUnit.AutoSize = true;
            this.lblSearchUnit.Location = new System.Drawing.Point(102, 81);
            this.lblSearchUnit.Name = "lblSearchUnit";
            this.lblSearchUnit.Size = new System.Drawing.Size(37, 13);
            this.lblSearchUnit.TabIndex = 59;
            this.lblSearchUnit.Text = "----------";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(102, 39);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(37, 13);
            this.lblSearchName.TabIndex = 58;
            this.lblSearchName.Text = "----------";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(24, 123);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Unit Price:";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(24, 81);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 13);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "Unit:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // listViewIngredientDetails
            // 
            this.listViewIngredientDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIngredientDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewIngredientDetails.FullRowSelect = true;
            this.listViewIngredientDetails.GridLines = true;
            this.listViewIngredientDetails.Location = new System.Drawing.Point(442, 69);
            this.listViewIngredientDetails.MultiSelect = false;
            this.listViewIngredientDetails.Name = "listViewIngredientDetails";
            this.listViewIngredientDetails.Size = new System.Drawing.Size(524, 486);
            this.listViewIngredientDetails.TabIndex = 60;
            this.listViewIngredientDetails.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientDetails.View = System.Windows.Forms.View.Details;
            this.listViewIngredientDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewIngredientDetails_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit Price";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 80;
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
            this.iconBtnSearch.Location = new System.Drawing.Point(618, 21);
            this.iconBtnSearch.Name = "iconBtnSearch";
            this.iconBtnSearch.Rotation = 0D;
            this.iconBtnSearch.Size = new System.Drawing.Size(75, 23);
            this.iconBtnSearch.TabIndex = 64;
            this.iconBtnSearch.Text = "Search";
            this.iconBtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSearch.UseVisualStyleBackColor = false;
            this.iconBtnSearch.Click += new System.EventHandler(this.iconBtnSearch_Click);
            // 
            // txtIngrID
            // 
            this.txtIngrID.Location = new System.Drawing.Point(498, 23);
            this.txtIngrID.Name = "txtIngrID";
            this.txtIngrID.Size = new System.Drawing.Size(100, 20);
            this.txtIngrID.TabIndex = 63;
            this.txtIngrID.Validating += new System.ComponentModel.CancelEventHandler(this.txtIngrID_Validating);
            // 
            // lblIngrID
            // 
            this.lblIngrID.AutoSize = true;
            this.lblIngrID.Location = new System.Drawing.Point(417, 26);
            this.lblIngrID.Name = "lblIngrID";
            this.lblIngrID.Size = new System.Drawing.Size(71, 13);
            this.lblIngrID.TabIndex = 62;
            this.lblIngrID.Text = "Ingredient ID:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // invesearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconBtnSearch);
            this.Controls.Add(this.txtIngrID);
            this.Controls.Add(this.lblIngrID);
            this.Controls.Add(this.listViewIngredientDetails);
            this.Controls.Add(this.grBoxSearchIngredientDetails);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "invesearch";
            this.Size = new System.Drawing.Size(994, 578);
            this.Load += new System.EventHandler(this.invesearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            this.grBoxSearchIngredientDetails.ResumeLayout(false);
            this.grBoxSearchIngredientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grBoxSearchIngredientDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSearchPrice;
        private System.Windows.Forms.Label lblSearchUnit;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.ListView listViewIngredientDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private FontAwesome.Sharp.IconButton iconBtnSearch;
        private System.Windows.Forms.TextBox txtIngrID;
        private System.Windows.Forms.Label lblIngrID;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
