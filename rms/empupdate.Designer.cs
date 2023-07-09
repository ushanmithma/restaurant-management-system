namespace rms
{
    partial class empupdate
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
            this.grBoxPersonalDetails = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelnoMobile = new System.Windows.Forms.TextBox();
            this.txtTelnoHome = new System.Windows.Forms.TextBox();
            this.lblTelnoMobile = new System.Windows.Forms.Label();
            this.lblTelnoHome = new System.Windows.Forms.Label();
            this.lblTelno = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbIniti = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grBoxEducationDetails = new System.Windows.Forms.GroupBox();
            this.txtEduDescription = new System.Windows.Forms.TextBox();
            this.lblEduDescription = new System.Windows.Forms.Label();
            this.checkBoxDegree = new System.Windows.Forms.CheckBox();
            this.checkBoxHiDiploma = new System.Windows.Forms.CheckBox();
            this.checkBoxDiploma = new System.Windows.Forms.CheckBox();
            this.checkBoxCertificate = new System.Windows.Forms.CheckBox();
            this.checkBoxAL = new System.Windows.Forms.CheckBox();
            this.checkBoxOL = new System.Windows.Forms.CheckBox();
            this.grBoxOfficialDetails = new System.Windows.Forms.GroupBox();
            this.txtOffiDetailsDescription = new System.Windows.Forms.TextBox();
            this.iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.lblOffiDetails = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtEPF = new System.Windows.Forms.TextBox();
            this.lblEPF = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.grBoxWorkExp = new System.Windows.Forms.GroupBox();
            this.txtWorkExpDescription = new System.Windows.Forms.TextBox();
            this.lblWorkExpDescription = new System.Windows.Forms.Label();
            this.lblDurationMon = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbUpdateKey = new System.Windows.Forms.ComboBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).BeginInit();
            this.grBoxPersonalDetails.SuspendLayout();
            this.grBoxEducationDetails.SuspendLayout();
            this.grBoxOfficialDetails.SuspendLayout();
            this.grBoxWorkExp.SuspendLayout();
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
            this.iconBackBtn.TabIndex = 0;
            this.iconBackBtn.TabStop = false;
            this.iconBackBtn.Click += new System.EventHandler(this.iconBackBtn_Click);
            // 
            // grBoxPersonalDetails
            // 
            this.grBoxPersonalDetails.Controls.Add(this.cmbGender);
            this.grBoxPersonalDetails.Controls.Add(this.lblGender);
            this.grBoxPersonalDetails.Controls.Add(this.txtDescription);
            this.grBoxPersonalDetails.Controls.Add(this.lblDescription);
            this.grBoxPersonalDetails.Controls.Add(this.txtEmail);
            this.grBoxPersonalDetails.Controls.Add(this.lblEmail);
            this.grBoxPersonalDetails.Controls.Add(this.txtTelnoMobile);
            this.grBoxPersonalDetails.Controls.Add(this.txtTelnoHome);
            this.grBoxPersonalDetails.Controls.Add(this.lblTelnoMobile);
            this.grBoxPersonalDetails.Controls.Add(this.lblTelnoHome);
            this.grBoxPersonalDetails.Controls.Add(this.lblTelno);
            this.grBoxPersonalDetails.Controls.Add(this.txtAddress);
            this.grBoxPersonalDetails.Controls.Add(this.lblAddress);
            this.grBoxPersonalDetails.Controls.Add(this.dtpBirthdate);
            this.grBoxPersonalDetails.Controls.Add(this.lblBirthdate);
            this.grBoxPersonalDetails.Controls.Add(this.txtNIC);
            this.grBoxPersonalDetails.Controls.Add(this.lblNIC);
            this.grBoxPersonalDetails.Controls.Add(this.txtFullName);
            this.grBoxPersonalDetails.Controls.Add(this.lblFullName);
            this.grBoxPersonalDetails.Controls.Add(this.txtName);
            this.grBoxPersonalDetails.Controls.Add(this.cmbIniti);
            this.grBoxPersonalDetails.Controls.Add(this.lblName);
            this.grBoxPersonalDetails.Location = new System.Drawing.Point(23, 69);
            this.grBoxPersonalDetails.Name = "grBoxPersonalDetails";
            this.grBoxPersonalDetails.Size = new System.Drawing.Size(516, 380);
            this.grBoxPersonalDetails.TabIndex = 1;
            this.grBoxPersonalDetails.TabStop = false;
            this.grBoxPersonalDetails.Text = "Personal Details";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(102, 126);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(135, 21);
            this.cmbGender.TabIndex = 25;
            this.cmbGender.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGender_Validating);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 130);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(102, 301);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(393, 56);
            this.txtDescription.TabIndex = 21;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 304);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 264);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 20);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 267);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelnoMobile
            // 
            this.txtTelnoMobile.Location = new System.Drawing.Point(356, 230);
            this.txtTelnoMobile.Name = "txtTelnoMobile";
            this.txtTelnoMobile.Size = new System.Drawing.Size(139, 20);
            this.txtTelnoMobile.TabIndex = 17;
            this.txtTelnoMobile.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelnoMobile_Validating);
            // 
            // txtTelnoHome
            // 
            this.txtTelnoHome.Location = new System.Drawing.Point(143, 230);
            this.txtTelnoHome.Name = "txtTelnoHome";
            this.txtTelnoHome.Size = new System.Drawing.Size(139, 20);
            this.txtTelnoHome.TabIndex = 16;
            this.txtTelnoHome.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelnoHome_Validating);
            // 
            // lblTelnoMobile
            // 
            this.lblTelnoMobile.AutoSize = true;
            this.lblTelnoMobile.Location = new System.Drawing.Point(309, 233);
            this.lblTelnoMobile.Name = "lblTelnoMobile";
            this.lblTelnoMobile.Size = new System.Drawing.Size(41, 13);
            this.lblTelnoMobile.TabIndex = 15;
            this.lblTelnoMobile.Text = "Mobile:";
            // 
            // lblTelnoHome
            // 
            this.lblTelnoHome.AutoSize = true;
            this.lblTelnoHome.Location = new System.Drawing.Point(99, 233);
            this.lblTelnoHome.Name = "lblTelnoHome";
            this.lblTelnoHome.Size = new System.Drawing.Size(38, 13);
            this.lblTelnoHome.TabIndex = 14;
            this.lblTelnoHome.Text = "Home:";
            // 
            // lblTelno
            // 
            this.lblTelno.AutoSize = true;
            this.lblTelno.Location = new System.Drawing.Point(17, 233);
            this.lblTelno.Name = "lblTelno";
            this.lblTelno.Size = new System.Drawing.Size(42, 13);
            this.lblTelno.TabIndex = 13;
            this.lblTelno.Text = "Tel No:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 196);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(393, 20);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 199);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(102, 160);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthdate.TabIndex = 10;
            this.dtpBirthdate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpBirthdate_Validating);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(17, 166);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(52, 13);
            this.lblBirthdate.TabIndex = 9;
            this.lblBirthdate.Text = "Birthdate:";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(102, 94);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(393, 20);
            this.txtNIC.TabIndex = 8;
            this.txtNIC.Validating += new System.ComponentModel.CancelEventHandler(this.txtNIC_Validating);
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(17, 97);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(45, 13);
            this.lblNIC.TabIndex = 7;
            this.lblNIC.Text = "NIC No:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(102, 61);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(393, 20);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFullName_Validating);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(17, 64);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // cmbIniti
            // 
            this.cmbIniti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIniti.FormattingEnabled = true;
            this.cmbIniti.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss."});
            this.cmbIniti.Location = new System.Drawing.Point(102, 26);
            this.cmbIniti.Name = "cmbIniti";
            this.cmbIniti.Size = new System.Drawing.Size(90, 21);
            this.cmbIniti.TabIndex = 3;
            this.cmbIniti.Validating += new System.ComponentModel.CancelEventHandler(this.cmbIniti_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name with Ini:";
            // 
            // grBoxEducationDetails
            // 
            this.grBoxEducationDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxEducationDetails.Controls.Add(this.txtEduDescription);
            this.grBoxEducationDetails.Controls.Add(this.lblEduDescription);
            this.grBoxEducationDetails.Controls.Add(this.checkBoxDegree);
            this.grBoxEducationDetails.Controls.Add(this.checkBoxHiDiploma);
            this.grBoxEducationDetails.Controls.Add(this.checkBoxDiploma);
            this.grBoxEducationDetails.Controls.Add(this.checkBoxCertificate);
            this.grBoxEducationDetails.Controls.Add(this.checkBoxAL);
            this.grBoxEducationDetails.Controls.Add(this.checkBoxOL);
            this.grBoxEducationDetails.Location = new System.Drawing.Point(23, 471);
            this.grBoxEducationDetails.Name = "grBoxEducationDetails";
            this.grBoxEducationDetails.Size = new System.Drawing.Size(516, 188);
            this.grBoxEducationDetails.TabIndex = 27;
            this.grBoxEducationDetails.TabStop = false;
            this.grBoxEducationDetails.Text = "Education Details";
            // 
            // txtEduDescription
            // 
            this.txtEduDescription.Location = new System.Drawing.Point(102, 100);
            this.txtEduDescription.Multiline = true;
            this.txtEduDescription.Name = "txtEduDescription";
            this.txtEduDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEduDescription.Size = new System.Drawing.Size(393, 56);
            this.txtEduDescription.TabIndex = 23;
            this.txtEduDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtEduDescription_Validating);
            // 
            // lblEduDescription
            // 
            this.lblEduDescription.AutoSize = true;
            this.lblEduDescription.Location = new System.Drawing.Point(17, 103);
            this.lblEduDescription.Name = "lblEduDescription";
            this.lblEduDescription.Size = new System.Drawing.Size(63, 13);
            this.lblEduDescription.TabIndex = 22;
            this.lblEduDescription.Text = "Description:";
            // 
            // checkBoxDegree
            // 
            this.checkBoxDegree.AutoSize = true;
            this.checkBoxDegree.Location = new System.Drawing.Point(148, 65);
            this.checkBoxDegree.Name = "checkBoxDegree";
            this.checkBoxDegree.Size = new System.Drawing.Size(61, 17);
            this.checkBoxDegree.TabIndex = 5;
            this.checkBoxDegree.Text = "Degree";
            this.checkBoxDegree.UseVisualStyleBackColor = true;
            // 
            // checkBoxHiDiploma
            // 
            this.checkBoxHiDiploma.AutoSize = true;
            this.checkBoxHiDiploma.Location = new System.Drawing.Point(20, 65);
            this.checkBoxHiDiploma.Name = "checkBoxHiDiploma";
            this.checkBoxHiDiploma.Size = new System.Drawing.Size(98, 17);
            this.checkBoxHiDiploma.TabIndex = 4;
            this.checkBoxHiDiploma.Text = "Higher Diploma";
            this.checkBoxHiDiploma.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiploma
            // 
            this.checkBoxDiploma.AutoSize = true;
            this.checkBoxDiploma.Location = new System.Drawing.Point(431, 29);
            this.checkBoxDiploma.Name = "checkBoxDiploma";
            this.checkBoxDiploma.Size = new System.Drawing.Size(64, 17);
            this.checkBoxDiploma.TabIndex = 3;
            this.checkBoxDiploma.Text = "Diploma";
            this.checkBoxDiploma.UseVisualStyleBackColor = true;
            // 
            // checkBoxCertificate
            // 
            this.checkBoxCertificate.AutoSize = true;
            this.checkBoxCertificate.Location = new System.Drawing.Point(275, 29);
            this.checkBoxCertificate.Name = "checkBoxCertificate";
            this.checkBoxCertificate.Size = new System.Drawing.Size(73, 17);
            this.checkBoxCertificate.TabIndex = 2;
            this.checkBoxCertificate.Text = "Certificate";
            this.checkBoxCertificate.UseVisualStyleBackColor = true;
            // 
            // checkBoxAL
            // 
            this.checkBoxAL.AutoSize = true;
            this.checkBoxAL.Location = new System.Drawing.Point(148, 29);
            this.checkBoxAL.Name = "checkBoxAL";
            this.checkBoxAL.Size = new System.Drawing.Size(44, 17);
            this.checkBoxAL.TabIndex = 1;
            this.checkBoxAL.Text = "A/L";
            this.checkBoxAL.UseVisualStyleBackColor = true;
            this.checkBoxAL.Validating += new System.ComponentModel.CancelEventHandler(this.checkBoxAL_Validating);
            // 
            // checkBoxOL
            // 
            this.checkBoxOL.AutoSize = true;
            this.checkBoxOL.Location = new System.Drawing.Point(20, 29);
            this.checkBoxOL.Name = "checkBoxOL";
            this.checkBoxOL.Size = new System.Drawing.Size(45, 17);
            this.checkBoxOL.TabIndex = 0;
            this.checkBoxOL.Text = "O/L";
            this.checkBoxOL.UseVisualStyleBackColor = true;
            this.checkBoxOL.Validating += new System.ComponentModel.CancelEventHandler(this.checkBoxOL_Validating);
            // 
            // grBoxOfficialDetails
            // 
            this.grBoxOfficialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxOfficialDetails.Controls.Add(this.txtOffiDetailsDescription);
            this.grBoxOfficialDetails.Controls.Add(this.iconBtnUpdate);
            this.grBoxOfficialDetails.Controls.Add(this.lblOffiDetails);
            this.grBoxOfficialDetails.Controls.Add(this.cmbStatus);
            this.grBoxOfficialDetails.Controls.Add(this.lblStatus);
            this.grBoxOfficialDetails.Controls.Add(this.txtEPF);
            this.grBoxOfficialDetails.Controls.Add(this.lblEPF);
            this.grBoxOfficialDetails.Controls.Add(this.cmbDesignation);
            this.grBoxOfficialDetails.Controls.Add(this.lblDesignation);
            this.grBoxOfficialDetails.Controls.Add(this.dtpAppointment);
            this.grBoxOfficialDetails.Controls.Add(this.lblAppointment);
            this.grBoxOfficialDetails.Location = new System.Drawing.Point(563, 195);
            this.grBoxOfficialDetails.Name = "grBoxOfficialDetails";
            this.grBoxOfficialDetails.Size = new System.Drawing.Size(474, 278);
            this.grBoxOfficialDetails.TabIndex = 30;
            this.grBoxOfficialDetails.TabStop = false;
            this.grBoxOfficialDetails.Text = "Official Details";
            // 
            // txtOffiDetailsDescription
            // 
            this.txtOffiDetailsDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOffiDetailsDescription.Location = new System.Drawing.Point(122, 176);
            this.txtOffiDetailsDescription.Multiline = true;
            this.txtOffiDetailsDescription.Name = "txtOffiDetailsDescription";
            this.txtOffiDetailsDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOffiDetailsDescription.Size = new System.Drawing.Size(337, 56);
            this.txtOffiDetailsDescription.TabIndex = 25;
            this.txtOffiDetailsDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtOffiDetailsDescription_Validating);
            // 
            // iconBtnUpdate
            // 
            this.iconBtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.iconBtnUpdate.Location = new System.Drawing.Point(384, 243);
            this.iconBtnUpdate.Name = "iconBtnUpdate";
            this.iconBtnUpdate.Rotation = 0D;
            this.iconBtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.iconBtnUpdate.TabIndex = 33;
            this.iconBtnUpdate.Text = "Update";
            this.iconBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnUpdate.UseVisualStyleBackColor = false;
            this.iconBtnUpdate.Click += new System.EventHandler(this.iconBtnUpdate_Click);
            // 
            // lblOffiDetails
            // 
            this.lblOffiDetails.AutoSize = true;
            this.lblOffiDetails.Location = new System.Drawing.Point(21, 179);
            this.lblOffiDetails.Name = "lblOffiDetails";
            this.lblOffiDetails.Size = new System.Drawing.Size(63, 13);
            this.lblOffiDetails.TabIndex = 24;
            this.lblOffiDetails.Text = "Description:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(123, 137);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 25;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status:";
            // 
            // txtEPF
            // 
            this.txtEPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEPF.Location = new System.Drawing.Point(122, 30);
            this.txtEPF.Name = "txtEPF";
            this.txtEPF.Size = new System.Drawing.Size(337, 20);
            this.txtEPF.TabIndex = 23;
            this.txtEPF.Validating += new System.ComponentModel.CancelEventHandler(this.txtEPF_Validating);
            // 
            // lblEPF
            // 
            this.lblEPF.AutoSize = true;
            this.lblEPF.Location = new System.Drawing.Point(21, 33);
            this.lblEPF.Name = "lblEPF";
            this.lblEPF.Size = new System.Drawing.Size(72, 13);
            this.lblEPF.TabIndex = 22;
            this.lblEPF.Text = "EPF/ETF No:";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Chef",
            "Inventory Keeper",
            "Rider",
            "Cashier",
            "Manager"});
            this.cmbDesignation.Location = new System.Drawing.Point(122, 100);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(200, 21);
            this.cmbDesignation.TabIndex = 23;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(21, 103);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(66, 13);
            this.lblDesignation.TabIndex = 22;
            this.lblDesignation.Text = "Designation:";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(122, 66);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointment.TabIndex = 23;
            this.dtpAppointment.Validating += new System.ComponentModel.CancelEventHandler(this.dtpAppointment_Validating);
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Location = new System.Drawing.Point(21, 71);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(95, 13);
            this.lblAppointment.TabIndex = 22;
            this.lblAppointment.Text = "Appointment Date:";
            // 
            // grBoxWorkExp
            // 
            this.grBoxWorkExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxWorkExp.Controls.Add(this.txtWorkExpDescription);
            this.grBoxWorkExp.Controls.Add(this.lblWorkExpDescription);
            this.grBoxWorkExp.Controls.Add(this.lblDurationMon);
            this.grBoxWorkExp.Controls.Add(this.txtDuration);
            this.grBoxWorkExp.Controls.Add(this.lblDuration);
            this.grBoxWorkExp.Location = new System.Drawing.Point(563, 22);
            this.grBoxWorkExp.Name = "grBoxWorkExp";
            this.grBoxWorkExp.Size = new System.Drawing.Size(474, 155);
            this.grBoxWorkExp.TabIndex = 29;
            this.grBoxWorkExp.TabStop = false;
            this.grBoxWorkExp.Text = "Working Experience Details";
            // 
            // txtWorkExpDescription
            // 
            this.txtWorkExpDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkExpDescription.Location = new System.Drawing.Point(106, 71);
            this.txtWorkExpDescription.Multiline = true;
            this.txtWorkExpDescription.Name = "txtWorkExpDescription";
            this.txtWorkExpDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWorkExpDescription.Size = new System.Drawing.Size(353, 56);
            this.txtWorkExpDescription.TabIndex = 25;
            this.txtWorkExpDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtWorkExpDescription_Validating);
            // 
            // lblWorkExpDescription
            // 
            this.lblWorkExpDescription.AutoSize = true;
            this.lblWorkExpDescription.Location = new System.Drawing.Point(21, 74);
            this.lblWorkExpDescription.Name = "lblWorkExpDescription";
            this.lblWorkExpDescription.Size = new System.Drawing.Size(63, 13);
            this.lblWorkExpDescription.TabIndex = 24;
            this.lblWorkExpDescription.Text = "Description:";
            // 
            // lblDurationMon
            // 
            this.lblDurationMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDurationMon.AutoSize = true;
            this.lblDurationMon.Location = new System.Drawing.Point(405, 36);
            this.lblDurationMon.Name = "lblDurationMon";
            this.lblDurationMon.Size = new System.Drawing.Size(48, 13);
            this.lblDurationMon.TabIndex = 24;
            this.lblDurationMon.Text = "(Months)";
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuration.Location = new System.Drawing.Point(106, 33);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(293, 20);
            this.txtDuration.TabIndex = 23;
            this.txtDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtDuration_Validating);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(21, 36);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 13);
            this.lblDuration.TabIndex = 22;
            this.lblDuration.Text = "Duration:";
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewEmployee.FullRowSelect = true;
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.Location = new System.Drawing.Point(563, 495);
            this.listViewEmployee.MultiSelect = false;
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(474, 164);
            this.listViewEmployee.TabIndex = 31;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Text = "NIC";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gender";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Birthdate";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tel. No";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mobile No";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Designation";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Status";
            this.columnHeader10.Width = 50;
            // 
            // cmbUpdateKey
            // 
            this.cmbUpdateKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateKey.FormattingEnabled = true;
            this.cmbUpdateKey.Location = new System.Drawing.Point(418, 27);
            this.cmbUpdateKey.Name = "cmbUpdateKey";
            this.cmbUpdateKey.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateKey.TabIndex = 32;
            this.cmbUpdateKey.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateKey_SelectedIndexChanged);
            this.cmbUpdateKey.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUpdateKey_Validating);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(342, 30);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(70, 13);
            this.lblEmpID.TabIndex = 22;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(65, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(177, 25);
            this.lblFormTitle.TabIndex = 34;
            this.lblFormTitle.Text = "Update Employee";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // empupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.cmbUpdateKey);
            this.Controls.Add(this.listViewEmployee);
            this.Controls.Add(this.grBoxOfficialDetails);
            this.Controls.Add(this.grBoxWorkExp);
            this.Controls.Add(this.grBoxEducationDetails);
            this.Controls.Add(this.grBoxPersonalDetails);
            this.Controls.Add(this.iconBackBtn);
            this.Name = "empupdate";
            this.Size = new System.Drawing.Size(1058, 680);
            this.Load += new System.EventHandler(this.empupdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBackBtn)).EndInit();
            this.grBoxPersonalDetails.ResumeLayout(false);
            this.grBoxPersonalDetails.PerformLayout();
            this.grBoxEducationDetails.ResumeLayout(false);
            this.grBoxEducationDetails.PerformLayout();
            this.grBoxOfficialDetails.ResumeLayout(false);
            this.grBoxOfficialDetails.PerformLayout();
            this.grBoxWorkExp.ResumeLayout(false);
            this.grBoxWorkExp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconBackBtn;
        private System.Windows.Forms.GroupBox grBoxPersonalDetails;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelnoMobile;
        private System.Windows.Forms.TextBox txtTelnoHome;
        private System.Windows.Forms.Label lblTelnoMobile;
        private System.Windows.Forms.Label lblTelnoHome;
        private System.Windows.Forms.Label lblTelno;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbIniti;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grBoxEducationDetails;
        private System.Windows.Forms.TextBox txtEduDescription;
        private System.Windows.Forms.Label lblEduDescription;
        private System.Windows.Forms.CheckBox checkBoxDegree;
        private System.Windows.Forms.CheckBox checkBoxHiDiploma;
        private System.Windows.Forms.CheckBox checkBoxDiploma;
        private System.Windows.Forms.CheckBox checkBoxCertificate;
        private System.Windows.Forms.CheckBox checkBoxAL;
        private System.Windows.Forms.CheckBox checkBoxOL;
        private System.Windows.Forms.GroupBox grBoxOfficialDetails;
        private System.Windows.Forms.TextBox txtOffiDetailsDescription;
        private System.Windows.Forms.Label lblOffiDetails;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtEPF;
        private System.Windows.Forms.Label lblEPF;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.GroupBox grBoxWorkExp;
        private System.Windows.Forms.TextBox txtWorkExpDescription;
        private System.Windows.Forms.Label lblWorkExpDescription;
        private System.Windows.Forms.Label lblDurationMon;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox cmbUpdateKey;
        private System.Windows.Forms.Label lblEmpID;
        private FontAwesome.Sharp.IconButton iconBtnUpdate;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}
