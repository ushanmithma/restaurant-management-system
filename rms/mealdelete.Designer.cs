namespace rms
{
    partial class mealdelete
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
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.txtMealID = new System.Windows.Forms.TextBox();
            this.lblMealID = new System.Windows.Forms.Label();
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.listViewIngredientsDetails = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMealDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.lblFormTitle.Size = new System.Drawing.Size(123, 25);
            this.lblFormTitle.TabIndex = 52;
            this.lblFormTitle.Text = "Delete Meal";
            // 
            // iconBtnDelete
            // 
            this.iconBtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.iconBtnDelete.Location = new System.Drawing.Point(912, 21);
            this.iconBtnDelete.Name = "iconBtnDelete";
            this.iconBtnDelete.Rotation = 0D;
            this.iconBtnDelete.Size = new System.Drawing.Size(75, 23);
            this.iconBtnDelete.TabIndex = 51;
            this.iconBtnDelete.Text = "Delete";
            this.iconBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
            // 
            // txtMealID
            // 
            this.txtMealID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealID.Location = new System.Drawing.Point(782, 23);
            this.txtMealID.Name = "txtMealID";
            this.txtMealID.Size = new System.Drawing.Size(100, 20);
            this.txtMealID.TabIndex = 50;
            this.txtMealID.Validating += new System.ComponentModel.CancelEventHandler(this.txtMealID_Validating);
            // 
            // lblMealID
            // 
            this.lblMealID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMealID.AutoSize = true;
            this.lblMealID.Location = new System.Drawing.Point(706, 26);
            this.lblMealID.Name = "lblMealID";
            this.lblMealID.Size = new System.Drawing.Size(47, 13);
            this.lblMealID.TabIndex = 49;
            this.lblMealID.Text = "Meal ID:";
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
            this.iconBackBtn.TabIndex = 48;
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
            this.listViewIngredientsDetails.Location = new System.Drawing.Point(661, 69);
            this.listViewIngredientsDetails.MultiSelect = false;
            this.listViewIngredientsDetails.Name = "listViewIngredientsDetails";
            this.listViewIngredientsDetails.Size = new System.Drawing.Size(326, 512);
            this.listViewIngredientsDetails.TabIndex = 65;
            this.listViewIngredientsDetails.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientsDetails.View = System.Windows.Forms.View.Details;
            this.listViewIngredientsDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewIngredientsDetails_MouseDoubleClick);
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
            this.listViewMealDetails.Location = new System.Drawing.Point(23, 69);
            this.listViewMealDetails.MultiSelect = false;
            this.listViewMealDetails.Name = "listViewMealDetails";
            this.listViewMealDetails.Size = new System.Drawing.Size(615, 512);
            this.listViewMealDetails.TabIndex = 66;
            this.listViewMealDetails.UseCompatibleStateImageBehavior = false;
            this.listViewMealDetails.View = System.Windows.Forms.View.Details;
            this.listViewMealDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewMealDetails_MouseClick);
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
            // mealdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewMealDetails);
            this.Controls.Add(this.listViewIngredientsDetails);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBtnDelete);
            this.Controls.Add(this.txtMealID);
            this.Controls.Add(this.lblMealID);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "mealdelete";
            this.Size = new System.Drawing.Size(1014, 604);
            this.Load += new System.EventHandler(this.mealdelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private System.Windows.Forms.TextBox txtMealID;
        private System.Windows.Forms.Label lblMealID;
        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.ListView listViewIngredientsDetails;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView listViewMealDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}
