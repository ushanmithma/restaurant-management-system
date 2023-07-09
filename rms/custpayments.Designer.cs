namespace rms
{
    partial class custpayments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblRsBalance = new System.Windows.Forms.Label();
            this.iconPicBoxBalance = new FontAwesome.Sharp.IconPictureBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRsAmount = new System.Windows.Forms.Label();
            this.iconBtnBalance = new FontAwesome.Sharp.IconButton();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.iconBtnCustPaid = new FontAwesome.Sharp.IconButton();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.iconPicBoxAmount = new FontAwesome.Sharp.IconPictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.iconBtnCustCalc = new FontAwesome.Sharp.IconButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.lblRsBalance);
            this.panel1.Controls.Add(this.iconPicBoxBalance);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblRsAmount);
            this.panel1.Controls.Add(this.iconBtnBalance);
            this.panel1.Controls.Add(this.lblAmountPaid);
            this.panel1.Controls.Add(this.txtPaidAmount);
            this.panel1.Controls.Add(this.iconBtnCustPaid);
            this.panel1.Controls.Add(this.txtOrderID);
            this.panel1.Controls.Add(this.iconPicBoxAmount);
            this.panel1.Controls.Add(this.lblFormTitle);
            this.panel1.Controls.Add(this.lblOrderID);
            this.panel1.Controls.Add(this.iconBtnCustCalc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 461);
            this.panel1.TabIndex = 0;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblBalance.Location = new System.Drawing.Point(238, 269);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(70, 77);
            this.lblBalance.TabIndex = 62;
            this.lblBalance.Text = "0";
            // 
            // lblRsBalance
            // 
            this.lblRsBalance.AutoSize = true;
            this.lblRsBalance.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRsBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblRsBalance.Location = new System.Drawing.Point(129, 269);
            this.lblRsBalance.Name = "lblRsBalance";
            this.lblRsBalance.Size = new System.Drawing.Size(142, 77);
            this.lblRsBalance.TabIndex = 64;
            this.lblRsBalance.Text = "Rs. ";
            // 
            // iconPicBoxBalance
            // 
            this.iconPicBoxBalance.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBoxBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.iconPicBoxBalance.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.iconPicBoxBalance.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.iconPicBoxBalance.IconSize = 111;
            this.iconPicBoxBalance.Location = new System.Drawing.Point(23, 258);
            this.iconPicBoxBalance.Name = "iconPicBoxBalance";
            this.iconPicBoxBalance.Size = new System.Drawing.Size(114, 111);
            this.iconPicBoxBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicBoxBalance.TabIndex = 63;
            this.iconPicBoxBalance.TabStop = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.lblAmount.Location = new System.Drawing.Point(238, 80);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(70, 77);
            this.lblAmount.TabIndex = 32;
            this.lblAmount.Text = "0";
            // 
            // lblRsAmount
            // 
            this.lblRsAmount.AutoSize = true;
            this.lblRsAmount.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRsAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.lblRsAmount.Location = new System.Drawing.Point(129, 80);
            this.lblRsAmount.Name = "lblRsAmount";
            this.lblRsAmount.Size = new System.Drawing.Size(142, 77);
            this.lblRsAmount.TabIndex = 61;
            this.lblRsAmount.Text = "Rs. ";
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
            this.iconBtnBalance.Location = new System.Drawing.Point(450, 209);
            this.iconBtnBalance.Name = "iconBtnBalance";
            this.iconBtnBalance.Rotation = 0D;
            this.iconBtnBalance.Size = new System.Drawing.Size(72, 23);
            this.iconBtnBalance.TabIndex = 58;
            this.iconBtnBalance.Text = "Balance";
            this.iconBtnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnBalance.UseVisualStyleBackColor = false;
            this.iconBtnBalance.Click += new System.EventHandler(this.iconBtnBalance_Click);
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(188, 214);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(31, 13);
            this.lblAmountPaid.TabIndex = 57;
            this.lblAmountPaid.Text = "Paid:";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(238, 211);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(193, 20);
            this.txtPaidAmount.TabIndex = 56;
            this.txtPaidAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaidAmount_Validating);
            // 
            // iconBtnCustPaid
            // 
            this.iconBtnCustPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCustPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.iconBtnCustPaid.Enabled = false;
            this.iconBtnCustPaid.FlatAppearance.BorderSize = 0;
            this.iconBtnCustPaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(193)))), ((int)(((byte)(71)))));
            this.iconBtnCustPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCustPaid.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCustPaid.ForeColor = System.Drawing.Color.White;
            this.iconBtnCustPaid.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconBtnCustPaid.IconColor = System.Drawing.Color.White;
            this.iconBtnCustPaid.IconSize = 16;
            this.iconBtnCustPaid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCustPaid.Location = new System.Drawing.Point(637, 421);
            this.iconBtnCustPaid.Name = "iconBtnCustPaid";
            this.iconBtnCustPaid.Rotation = 0D;
            this.iconBtnCustPaid.Size = new System.Drawing.Size(75, 23);
            this.iconBtnCustPaid.TabIndex = 49;
            this.iconBtnCustPaid.Text = "Paid";
            this.iconBtnCustPaid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCustPaid.UseVisualStyleBackColor = false;
            this.iconBtnCustPaid.Click += new System.EventHandler(this.iconBtnCustPaid_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(500, 23);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 55;
            // 
            // iconPicBoxAmount
            // 
            this.iconPicBoxAmount.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBoxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.iconPicBoxAmount.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconPicBoxAmount.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.iconPicBoxAmount.IconSize = 111;
            this.iconPicBoxAmount.Location = new System.Drawing.Point(23, 69);
            this.iconPicBoxAmount.Name = "iconPicBoxAmount";
            this.iconPicBoxAmount.Size = new System.Drawing.Size(114, 111);
            this.iconPicBoxAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicBoxAmount.TabIndex = 47;
            this.iconPicBoxAmount.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(107, 25);
            this.lblFormTitle.TabIndex = 54;
            this.lblFormTitle.Text = "Payments";
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(430, 26);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(50, 13);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID:";
            // 
            // iconBtnCustCalc
            // 
            this.iconBtnCustCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCustCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.iconBtnCustCalc.FlatAppearance.BorderSize = 0;
            this.iconBtnCustCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.iconBtnCustCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCustCalc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCustCalc.ForeColor = System.Drawing.Color.White;
            this.iconBtnCustCalc.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.iconBtnCustCalc.IconColor = System.Drawing.Color.White;
            this.iconBtnCustCalc.IconSize = 16;
            this.iconBtnCustCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCustCalc.Location = new System.Drawing.Point(615, 21);
            this.iconBtnCustCalc.Name = "iconBtnCustCalc";
            this.iconBtnCustCalc.Rotation = 0D;
            this.iconBtnCustCalc.Size = new System.Drawing.Size(97, 23);
            this.iconBtnCustCalc.TabIndex = 46;
            this.iconBtnCustCalc.Text = "Show Amount";
            this.iconBtnCustCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCustCalc.UseVisualStyleBackColor = false;
            this.iconBtnCustCalc.Click += new System.EventHandler(this.iconBtnCustCalc_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // custpayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.Name = "custpayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay for Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnCustPaid;
        private System.Windows.Forms.Label lblAmount;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxAmount;
        private FontAwesome.Sharp.IconButton iconBtnCustCalc;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblFormTitle;
        private FontAwesome.Sharp.IconButton iconBtnBalance;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblRsAmount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblRsBalance;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxBalance;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}