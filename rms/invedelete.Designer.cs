namespace rms
{
    partial class invedelete
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
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.txtIngredientID = new System.Windows.Forms.TextBox();
            this.lblIngredientID = new System.Windows.Forms.Label();
            this.listViewIngredientDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
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
            this.iconBackBtn.TabIndex = 58;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(174, 25);
            this.lblFormTitle.TabIndex = 59;
            this.lblFormTitle.Text = "Delete Ingredient";
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
            this.iconBtnDelete.TabIndex = 62;
            this.iconBtnDelete.Text = "Delete";
            this.iconBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
            // 
            // txtIngredientID
            // 
            this.txtIngredientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIngredientID.Location = new System.Drawing.Point(792, 23);
            this.txtIngredientID.Name = "txtIngredientID";
            this.txtIngredientID.Size = new System.Drawing.Size(100, 20);
            this.txtIngredientID.TabIndex = 61;
            this.txtIngredientID.Validating += new System.ComponentModel.CancelEventHandler(this.txtIngredientID_Validating);
            // 
            // lblIngredientID
            // 
            this.lblIngredientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngredientID.AutoSize = true;
            this.lblIngredientID.Location = new System.Drawing.Point(706, 26);
            this.lblIngredientID.Name = "lblIngredientID";
            this.lblIngredientID.Size = new System.Drawing.Size(71, 13);
            this.lblIngredientID.TabIndex = 60;
            this.lblIngredientID.Text = "Ingredient ID:";
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
            this.listViewIngredientDetails.Location = new System.Drawing.Point(23, 69);
            this.listViewIngredientDetails.MultiSelect = false;
            this.listViewIngredientDetails.Name = "listViewIngredientDetails";
            this.listViewIngredientDetails.Size = new System.Drawing.Size(964, 513);
            this.listViewIngredientDetails.TabIndex = 63;
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // invedelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.listViewIngredientDetails);
            this.Controls.Add(this.iconBtnDelete);
            this.Controls.Add(this.txtIngredientID);
            this.Controls.Add(this.lblIngredientID);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "invedelete";
            this.Size = new System.Drawing.Size(1014, 604);
            this.Load += new System.EventHandler(this.invedelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private System.Windows.Forms.TextBox txtIngredientID;
        private System.Windows.Forms.Label lblIngredientID;
        private System.Windows.Forms.ListView listViewIngredientDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
