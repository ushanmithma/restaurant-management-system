namespace rms
{
    partial class inveadd
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
            this.grBoxAddIngredient = new System.Windows.Forms.GroupBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.radioBtnQuantity = new System.Windows.Forms.RadioButton();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.numUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.radioBtnMass = new System.Windows.Forms.RadioButton();
            this.radioBtnLiquid = new System.Windows.Forms.RadioButton();
            this.lblUnit = new System.Windows.Forms.Label();
            this.iconBtnAddIngredientDetails = new FontAwesome.Sharp.IconButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.iconBackBtn = new FontAwesome.Sharp.IconPictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grBoxAddIngredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).BeginInit();
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
            this.lblFormTitle.Size = new System.Drawing.Size(152, 25);
            this.lblFormTitle.TabIndex = 52;
            this.lblFormTitle.Text = "Add Ingredient";
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
            this.grBoxAddIngredient.Controls.Add(this.iconBtnAddIngredientDetails);
            this.grBoxAddIngredient.Controls.Add(this.txtName);
            this.grBoxAddIngredient.Controls.Add(this.lblName);
            this.grBoxAddIngredient.Location = new System.Drawing.Point(23, 69);
            this.grBoxAddIngredient.Name = "grBoxAddIngredient";
            this.grBoxAddIngredient.Size = new System.Drawing.Size(433, 487);
            this.grBoxAddIngredient.TabIndex = 53;
            this.grBoxAddIngredient.TabStop = false;
            this.grBoxAddIngredient.Text = "Add Ingredient";
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Location = new System.Drawing.Point(102, 125);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(23, 13);
            this.lblRs.TabIndex = 63;
            this.lblRs.Text = "Rs.";
            // 
            // radioBtnQuantity
            // 
            this.radioBtnQuantity.AutoSize = true;
            this.radioBtnQuantity.Location = new System.Drawing.Point(343, 79);
            this.radioBtnQuantity.Name = "radioBtnQuantity";
            this.radioBtnQuantity.Size = new System.Drawing.Size(64, 17);
            this.radioBtnQuantity.TabIndex = 62;
            this.radioBtnQuantity.TabStop = true;
            this.radioBtnQuantity.Text = "Quantity";
            this.radioBtnQuantity.UseVisualStyleBackColor = true;
            this.radioBtnQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.radioBtnUnit_Validating);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(24, 124);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 61;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // numUpDownPrice
            // 
            this.numUpDownPrice.Location = new System.Drawing.Point(133, 122);
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
            this.numUpDownPrice.TabIndex = 60;
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
            this.radioBtnMass.Location = new System.Drawing.Point(220, 79);
            this.radioBtnMass.Name = "radioBtnMass";
            this.radioBtnMass.Size = new System.Drawing.Size(72, 17);
            this.radioBtnMass.TabIndex = 59;
            this.radioBtnMass.TabStop = true;
            this.radioBtnMass.Text = "Mass (Kg)";
            this.radioBtnMass.UseVisualStyleBackColor = true;
            this.radioBtnMass.Validating += new System.ComponentModel.CancelEventHandler(this.radioBtnUnit_Validating);
            // 
            // radioBtnLiquid
            // 
            this.radioBtnLiquid.AutoSize = true;
            this.radioBtnLiquid.Location = new System.Drawing.Point(101, 79);
            this.radioBtnLiquid.Name = "radioBtnLiquid";
            this.radioBtnLiquid.Size = new System.Drawing.Size(68, 17);
            this.radioBtnLiquid.TabIndex = 58;
            this.radioBtnLiquid.TabStop = true;
            this.radioBtnLiquid.Text = "Liquid (L)";
            this.radioBtnLiquid.UseVisualStyleBackColor = true;
            this.radioBtnLiquid.Validating += new System.ComponentModel.CancelEventHandler(this.radioBtnUnit_Validating);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(24, 81);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 13);
            this.lblUnit.TabIndex = 57;
            this.lblUnit.Text = "Unit:";
            // 
            // iconBtnAddIngredientDetails
            // 
            this.iconBtnAddIngredientDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnAddIngredientDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnAddIngredientDetails.FlatAppearance.BorderSize = 0;
            this.iconBtnAddIngredientDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnAddIngredientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAddIngredientDetails.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnAddIngredientDetails.ForeColor = System.Drawing.Color.White;
            this.iconBtnAddIngredientDetails.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAddIngredientDetails.IconColor = System.Drawing.Color.White;
            this.iconBtnAddIngredientDetails.IconSize = 16;
            this.iconBtnAddIngredientDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAddIngredientDetails.Location = new System.Drawing.Point(333, 160);
            this.iconBtnAddIngredientDetails.Name = "iconBtnAddIngredientDetails";
            this.iconBtnAddIngredientDetails.Rotation = 0D;
            this.iconBtnAddIngredientDetails.Size = new System.Drawing.Size(75, 23);
            this.iconBtnAddIngredientDetails.TabIndex = 56;
            this.iconBtnAddIngredientDetails.Text = "Add";
            this.iconBtnAddIngredientDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAddIngredientDetails.UseVisualStyleBackColor = false;
            this.iconBtnAddIngredientDetails.Click += new System.EventHandler(this.iconBtnAddIngredientDetails_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
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
            this.iconBackBtn.TabIndex = 54;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // inveadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconBackBtn);
            this.Controls.Add(this.grBoxAddIngredient);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "inveadd";
            this.Size = new System.Drawing.Size(994, 578);
            this.grBoxAddIngredient.ResumeLayout(false);
            this.grBoxAddIngredient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grBoxAddIngredient;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private FontAwesome.Sharp.IconButton iconBtnAddIngredientDetails;
        private System.Windows.Forms.Label lblUnit;
        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.RadioButton radioBtnMass;
        private System.Windows.Forms.RadioButton radioBtnLiquid;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.NumericUpDown numUpDownPrice;
        private System.Windows.Forms.RadioButton radioBtnQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblRs;

    }
}
