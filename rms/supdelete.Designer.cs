namespace rms
{
    partial class supdelete
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
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
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
            this.lblFormTitle.Size = new System.Drawing.Size(157, 25);
            this.lblFormTitle.TabIndex = 52;
            this.lblFormTitle.Text = "Delete Supplier";
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
            // txtSupplierID
            // 
            this.txtSupplierID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplierID.Location = new System.Drawing.Point(782, 23);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 50;
            this.txtSupplierID.Validating += new System.ComponentModel.CancelEventHandler(this.txtSupplierID_Validating);
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(706, 26);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(62, 13);
            this.lblSupplierID.TabIndex = 49;
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
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listViewIngredientsDetails.FullRowSelect = true;
            this.listViewIngredientsDetails.GridLines = true;
            this.listViewIngredientsDetails.Location = new System.Drawing.Point(663, 69);
            this.listViewIngredientsDetails.MultiSelect = false;
            this.listViewIngredientsDetails.Name = "listViewIngredientsDetails";
            this.listViewIngredientsDetails.Size = new System.Drawing.Size(325, 489);
            this.listViewIngredientsDetails.TabIndex = 72;
            this.listViewIngredientsDetails.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientsDetails.View = System.Windows.Forms.View.Details;
            this.listViewIngredientsDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewIngredientsDetails_MouseDoubleClick);
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
            this.listViewSupplierDetails.Location = new System.Drawing.Point(23, 69);
            this.listViewSupplierDetails.MultiSelect = false;
            this.listViewSupplierDetails.Name = "listViewSupplierDetails";
            this.listViewSupplierDetails.Size = new System.Drawing.Size(616, 489);
            this.listViewSupplierDetails.TabIndex = 71;
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // supdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewIngredientsDetails);
            this.Controls.Add(this.listViewSupplierDetails);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.iconBtnDelete);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "supdelete";
            this.Size = new System.Drawing.Size(1009, 579);
            this.Load += new System.EventHandler(this.supdelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label lblSupplierID;
        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
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
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
