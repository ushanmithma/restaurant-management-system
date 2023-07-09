namespace rms
{
    partial class inveupdate
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
            this.grBoxAddIngredient = new System.Windows.Forms.GroupBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.radioBtnQuantity = new System.Windows.Forms.RadioButton();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.numUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.radioBtnMass = new System.Windows.Forms.RadioButton();
            this.radioBtnLiquid = new System.Windows.Forms.RadioButton();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.cmbUpdateKey = new System.Windows.Forms.ComboBox();
            this.lblIngredientID = new System.Windows.Forms.Label();
            this.listViewIngredientDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            this.grBoxAddIngredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).BeginInit();
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
            this.iconBackBtn.TabIndex = 57;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(181, 25);
            this.lblFormTitle.TabIndex = 56;
            this.lblFormTitle.Text = "Update Ingredient";
            // 
            // grBoxAddIngredient
            // 
            this.grBoxAddIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxAddIngredient.Controls.Add(this.lblRs);
            this.grBoxAddIngredient.Controls.Add(this.radioBtnQuantity);
            this.grBoxAddIngredient.Controls.Add(this.lblUnitPrice);
            this.grBoxAddIngredient.Controls.Add(this.numUpDownPrice);
            this.grBoxAddIngredient.Controls.Add(this.radioBtnMass);
            this.grBoxAddIngredient.Controls.Add(this.radioBtnLiquid);
            this.grBoxAddIngredient.Controls.Add(this.lblUnit);
            this.grBoxAddIngredient.Controls.Add(this.txtName);
            this.grBoxAddIngredient.Controls.Add(this.lblName);
            this.grBoxAddIngredient.Controls.Add(this.iconBtnUpdate);
            this.grBoxAddIngredient.Location = new System.Drawing.Point(23, 69);
            this.grBoxAddIngredient.Name = "grBoxAddIngredient";
            this.grBoxAddIngredient.Size = new System.Drawing.Size(433, 503);
            this.grBoxAddIngredient.TabIndex = 58;
            this.grBoxAddIngredient.TabStop = false;
            this.grBoxAddIngredient.Text = "Add Ingredient";
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Location = new System.Drawing.Point(102, 122);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(23, 13);
            this.lblRs.TabIndex = 72;
            this.lblRs.Text = "Rs.";
            // 
            // radioBtnQuantity
            // 
            this.radioBtnQuantity.AutoSize = true;
            this.radioBtnQuantity.Location = new System.Drawing.Point(343, 76);
            this.radioBtnQuantity.Name = "radioBtnQuantity";
            this.radioBtnQuantity.Size = new System.Drawing.Size(64, 17);
            this.radioBtnQuantity.TabIndex = 71;
            this.radioBtnQuantity.TabStop = true;
            this.radioBtnQuantity.Text = "Quantity";
            this.radioBtnQuantity.UseVisualStyleBackColor = true;
            this.radioBtnQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.radioBtnUnit_Validating);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(24, 121);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 70;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // numUpDownPrice
            // 
            this.numUpDownPrice.Location = new System.Drawing.Point(133, 119);
            this.numUpDownPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownPrice.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownPrice.Name = "numUpDownPrice";
            this.numUpDownPrice.Size = new System.Drawing.Size(120, 20);
            this.numUpDownPrice.TabIndex = 69;
            this.numUpDownPrice.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownPrice.Validating += new System.ComponentModel.CancelEventHandler(this.numUpDownPrice_Validating);
            // 
            // radioBtnMass
            // 
            this.radioBtnMass.AutoSize = true;
            this.radioBtnMass.Location = new System.Drawing.Point(220, 76);
            this.radioBtnMass.Name = "radioBtnMass";
            this.radioBtnMass.Size = new System.Drawing.Size(72, 17);
            this.radioBtnMass.TabIndex = 68;
            this.radioBtnMass.TabStop = true;
            this.radioBtnMass.Text = "Mass (Kg)";
            this.radioBtnMass.UseVisualStyleBackColor = true;
            this.radioBtnMass.Validating += new System.ComponentModel.CancelEventHandler(this.radioBtnUnit_Validating);
            // 
            // radioBtnLiquid
            // 
            this.radioBtnLiquid.AutoSize = true;
            this.radioBtnLiquid.Location = new System.Drawing.Point(101, 76);
            this.radioBtnLiquid.Name = "radioBtnLiquid";
            this.radioBtnLiquid.Size = new System.Drawing.Size(68, 17);
            this.radioBtnLiquid.TabIndex = 67;
            this.radioBtnLiquid.TabStop = true;
            this.radioBtnLiquid.Text = "Liquid (L)";
            this.radioBtnLiquid.UseVisualStyleBackColor = true;
            this.radioBtnLiquid.Validating += new System.ComponentModel.CancelEventHandler(this.radioBtnUnit_Validating);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(24, 78);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 13);
            this.lblUnit.TabIndex = 66;
            this.lblUnit.Text = "Unit:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 20);
            this.txtName.TabIndex = 65;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 64;
            this.lblName.Text = "Name:";
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
            this.iconBtnUpdate.Location = new System.Drawing.Point(333, 159);
            this.iconBtnUpdate.Name = "iconBtnUpdate";
            this.iconBtnUpdate.Rotation = 0D;
            this.iconBtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.iconBtnUpdate.TabIndex = 59;
            this.iconBtnUpdate.Text = "Update";
            this.iconBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnUpdate.UseVisualStyleBackColor = false;
            this.iconBtnUpdate.Click += new System.EventHandler(this.iconBtnUpdate_Click);
            // 
            // cmbUpdateKey
            // 
            this.cmbUpdateKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateKey.FormattingEnabled = true;
            this.cmbUpdateKey.Location = new System.Drawing.Point(480, 23);
            this.cmbUpdateKey.Name = "cmbUpdateKey";
            this.cmbUpdateKey.Size = new System.Drawing.Size(120, 21);
            this.cmbUpdateKey.TabIndex = 60;
            this.cmbUpdateKey.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateKey_SelectedIndexChanged);
            // 
            // lblIngredientID
            // 
            this.lblIngredientID.AutoSize = true;
            this.lblIngredientID.Location = new System.Drawing.Point(403, 26);
            this.lblIngredientID.Name = "lblIngredientID";
            this.lblIngredientID.Size = new System.Drawing.Size(71, 13);
            this.lblIngredientID.TabIndex = 59;
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
            this.listViewIngredientDetails.Location = new System.Drawing.Point(480, 69);
            this.listViewIngredientDetails.MultiSelect = false;
            this.listViewIngredientDetails.Name = "listViewIngredientDetails";
            this.listViewIngredientDetails.Size = new System.Drawing.Size(486, 503);
            this.listViewIngredientDetails.TabIndex = 59;
            this.listViewIngredientDetails.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientDetails.View = System.Windows.Forms.View.Details;
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
            // inveupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewIngredientDetails);
            this.Controls.Add(this.cmbUpdateKey);
            this.Controls.Add(this.lblIngredientID);
            this.Controls.Add(this.grBoxAddIngredient);
            this.Controls.Add(this.iconBackBtn);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "inveupdate";
            this.Size = new System.Drawing.Size(993, 593);
            this.Load += new System.EventHandler(this.inveupdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            this.grBoxAddIngredient.ResumeLayout(false);
            this.grBoxAddIngredient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grBoxAddIngredient;
        private System.Windows.Forms.ComboBox cmbUpdateKey;
        private System.Windows.Forms.Label lblIngredientID;
        private FontAwesome.Sharp.IconButton iconBtnUpdate;
        private System.Windows.Forms.ListView listViewIngredientDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.RadioButton radioBtnQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.NumericUpDown numUpDownPrice;
        private System.Windows.Forms.RadioButton radioBtnMass;
        private System.Windows.Forms.RadioButton radioBtnLiquid;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
