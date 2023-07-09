using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rms
{
    public partial class empupdate : UserControl
    {
        private int userID;

        public empupdate(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Update Process

        EmployeeClass emp = new EmployeeClass();
        Common common = new Common();

        private void loadEmployeeData()
        {
            listViewEmployee.Items.Clear();

            DataTable employeeDataList = emp.getEmployeeList();

            foreach (DataRow dr in employeeDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["nic"].ToString());
                item.SubItems.Add(dr["gender"].ToString());
                item.SubItems.Add(dr["birthdate"].ToString());
                item.SubItems.Add(dr["telno"].ToString());
                item.SubItems.Add(dr["mobileno"].ToString());
                item.SubItems.Add(dr["email"].ToString());
                item.SubItems.Add(dr["designation"].ToString());
                item.SubItems.Add(dr["status"].ToString());

                listViewEmployee.Items.Add(item);
            }
        }

        private void empupdate_Load(object sender, EventArgs e)
        {
            int[] employeeIDs = emp.getEmployeeID();

            cmbUpdateKey.Items.Clear();

            for (int id = 0; id < employeeIDs.Length; id++)
            {
                if (employeeIDs[id] == 0)
                    break;
                cmbUpdateKey.Items.Add(employeeIDs[id]);
            }

            loadEmployeeData();
        }

        private void cmbUpdateKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> employeeData = emp.getEmployeeData("id", Convert.ToString(cmbUpdateKey.Text));

            foreach (KeyValuePair<string, string> empKeyValuePair in employeeData)
            {
                switch (empKeyValuePair.Key)
                {
                    case "initi":
                        cmbIniti.Text = empKeyValuePair.Value;
                        break;
                    case "name":
                        txtName.Text = empKeyValuePair.Value;
                        break;
                    case "fullName":
                        txtFullName.Text = empKeyValuePair.Value;
                        break;
                    case "nic":
                        txtNIC.Text = empKeyValuePair.Value;
                        break;
                    case "gender":
                        cmbGender.Text = empKeyValuePair.Value;
                        break;
                    case "birthdate":
                        dtpBirthdate.Value = Convert.ToDateTime(empKeyValuePair.Value);
                        break;
                    case "address":
                        txtAddress.Text = empKeyValuePair.Value;
                        break;
                    case "telno":
                        txtTelnoHome.Text = empKeyValuePair.Value;
                        break;
                    case "mobileno":
                        txtTelnoMobile.Text = empKeyValuePair.Value;
                        break;
                    case "email":
                        txtEmail.Text = empKeyValuePair.Value;
                        break;
                    case "description":
                        txtDescription.Text = empKeyValuePair.Value;
                        break;
                    case "qualification":

                        checkBoxOL.Checked = false;
                        checkBoxAL.Checked = false;
                        checkBoxCertificate.Checked = false;
                        checkBoxDiploma.Checked = false;
                        checkBoxHiDiploma.Checked = false;
                        checkBoxDegree.Checked = false;

                        if (empKeyValuePair.Value.Contains("OL"))
                            checkBoxOL.CheckState = CheckState.Checked;
                        if (empKeyValuePair.Value.Contains("AL"))
                            checkBoxAL.CheckState = CheckState.Checked;
                        if (empKeyValuePair.Value.Contains("Certificate"))
                            checkBoxCertificate.CheckState = CheckState.Checked;
                        if (empKeyValuePair.Value.Contains("Diploma"))
                            checkBoxDiploma.CheckState = CheckState.Checked;
                        if (empKeyValuePair.Value.Contains("Higher Diploma"))
                            checkBoxHiDiploma.CheckState = CheckState.Checked;
                        if (empKeyValuePair.Value.Contains("Degree"))
                            checkBoxDegree.CheckState = CheckState.Checked;
                        break;

                    case "eduDescription":
                        txtEduDescription.Text = empKeyValuePair.Value;
                        break;
                    case "duration":
                        txtDuration.Text = empKeyValuePair.Value;
                        break;
                    case "workDescription":
                        txtWorkExpDescription.Text = empKeyValuePair.Value;
                        break;
                    case "epfetf":
                        txtEPF.Text = empKeyValuePair.Value;
                        break;
                    case "appointmentDate":
                        dtpAppointment.Value = Convert.ToDateTime(empKeyValuePair.Value);
                        break;
                    case "designation":
                        cmbDesignation.Text = empKeyValuePair.Value;
                        break;
                    case "status":
                        cmbStatus.Text = empKeyValuePair.Value;
                        break;
                    case "officialDescription":
                        txtOffiDetailsDescription.Text = empKeyValuePair.Value;
                        break;
                    default:
                        break;
                }
            }
        }

        // Update process

        string initi, name, fullName, nic, gender, birthdate, address, telno, mobileno, email, description, eduDescription, workDescription, epfetf, designation, status, officialDescription;
        string qualification = "OL, AL";
        int empID, duration;
        DateTime appointmentDate;

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                empID = Convert.ToInt32(cmbUpdateKey.SelectedItem);
                initi = Convert.ToString(cmbIniti.SelectedItem);
                name = Convert.ToString(txtName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                fullName = Convert.ToString(txtFullName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                nic = Convert.ToString(txtNIC.Text.Trim());
                gender = Convert.ToString(cmbGender.SelectedItem);
                birthdate = dtpBirthdate.Value.ToString("yyyy-MM-dd");
                address = Convert.ToString(txtAddress.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                telno = Convert.ToString(txtTelnoHome.Text.Trim());
                mobileno = Convert.ToString(txtTelnoMobile.Text.Trim());
                email = Convert.ToString(txtEmail.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                description = Convert.ToString(txtDescription.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                if (checkBoxCertificate.CheckState == CheckState.Checked)
                    qualification += ", Certificate";
                if (checkBoxDiploma.CheckState == CheckState.Checked)
                    qualification += ", Diploma";
                if (checkBoxHiDiploma.CheckState == CheckState.Checked)
                    qualification += ", Higher Diploma";
                if (checkBoxDegree.CheckState == CheckState.Checked)
                    qualification += ", Degree";

                eduDescription = Convert.ToString(txtEduDescription.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                duration = 0;
                workDescription = "";
                epfetf = "";
                appointmentDate = DateTime.Now;
                designation = "";
                status = "";
                officialDescription = "";

                if (!string.IsNullOrEmpty(txtDuration.Text.Trim()))
                    duration = Int32.Parse(txtDuration.Text.Trim());

                if (!string.IsNullOrEmpty(txtWorkExpDescription.Text.Trim()))
                    workDescription = Convert.ToString(txtWorkExpDescription.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                if (!string.IsNullOrEmpty(txtEPF.Text.Trim()))
                    epfetf = Convert.ToString(txtEPF.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                if (dtpAppointment.Value != DateTime.Now)
                    appointmentDate = dtpAppointment.Value;

                if (cmbDesignation.SelectedIndex != -1)
                    designation = Convert.ToString(cmbDesignation.SelectedItem);

                if (cmbStatus.SelectedIndex != -1)
                    status = Convert.ToString(cmbStatus.SelectedItem);

                if (!string.IsNullOrEmpty(txtOffiDetailsDescription.Text.Trim()))
                    officialDescription = Convert.ToString(txtOffiDetailsDescription.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                bool message = emp.updateEmployee(empID, initi + " " + name, fullName, nic, gender, birthdate, address, telno, mobileno, email, description, qualification, eduDescription, duration, workDescription, epfetf, appointmentDate, designation, status, officialDescription, userID);

                if (message)
                {
                    clearData();
                    MessageBox.Show("Record update successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbUpdateKey_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbUpdateKey, "Please select employee id !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbUpdateKey, null);
            }
        }

        private void cmbIniti_Validating(object sender, CancelEventArgs e)
        {
            if (cmbIniti.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbIniti, "Please select initial !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbIniti, null);
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Please enter your name !");
            }
            else if (txtName.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Invalid name !");
            }
            else if (!txtName.Text.Trim().All(c => char.IsWhiteSpace(c) || char.IsLetter(c)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Invalid name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtName, null);
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtFullName, "Please enter your full name !");
            }
            else if (txtFullName.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtFullName, "Invalid name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtFullName, null);
            }
        }

        private void txtNIC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNIC.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNIC, "Please enter your NIC no !");
            }
            else if (txtNIC.Text.Trim().Length > 12)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNIC, "Invalid NIC !");
            }
            else if (common.checkAlreadyExistsOthers(Convert.ToInt32(cmbUpdateKey.SelectedItem), "nic", "employee", Convert.ToString(txtNIC.Text.Trim()), "id"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNIC, "NIC no is already exists !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNIC, null);
            }
        }

        private void cmbGender_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGender.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbGender, "Please select your gender !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbGender, null);
            }
        }

        private void dtpBirthdate_Validating(object sender, CancelEventArgs e)
        {
            DateTime today = DateTime.Now;

            if (dtpBirthdate.Value > today)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpBirthdate, "Invalid date !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dtpBirthdate, null);
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAddress, "Please enter your address !");
            }
            else if (txtAddress.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtAddress, "Invalid address !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtAddress, null);
            }
        }

        private void txtTelnoHome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelnoHome.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelnoHome, "Please enter your tel no !");
            }
            else if (common.isNotDigitOnly(Convert.ToString(txtTelnoHome.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelnoHome, "Invalid number !");
            }
            else if (txtTelnoHome.Text.Trim().Length > 15)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelnoHome, "Invalid number !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTelnoHome, null);
            }
        }

        private void txtTelnoMobile_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelnoMobile.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelnoMobile, "Please enter your mobile no !");
            }
            else if (common.isNotDigitOnly(Convert.ToString(txtTelnoMobile.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelnoMobile, "Invalid number !");
            }
            else if (txtTelnoMobile.Text.Trim().Length > 15)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelnoMobile, "Invalid number !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTelnoMobile, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Please enter your address !");
            }
            else if (common.isNotValidEmail(Convert.ToString(txtEmail.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Invalid email address !");
            }
            else if (common.checkAlreadyExistsOthers(Convert.ToInt32(cmbUpdateKey.SelectedItem), "email", "employee", Convert.ToString(txtEmail.Text.Trim()), "id"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Email address is already exists !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDescription, "Please enter description !");
            }
            else if (txtDescription.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDescription, "Invalid description !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDescription, null);
            }
        }

        private void checkBoxOL_Validating(object sender, CancelEventArgs e)
        {
            if (checkBoxOL.CheckState == CheckState.Unchecked)
            {
                e.Cancel = true;
                errorProvider.SetError(checkBoxOL, "At least you should passed O/L !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(checkBoxOL, null);
            }
        }

        private void checkBoxAL_Validating(object sender, CancelEventArgs e)
        {
            if (checkBoxAL.CheckState == CheckState.Unchecked)
            {
                e.Cancel = true;
                errorProvider.SetError(checkBoxAL, "At least you should passed A/L !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(checkBoxAL, null);
            }
        }

        private void txtEduDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEduDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEduDescription, "Please enter education description !");
            }
            else if (txtEduDescription.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEduDescription, "Invalid description !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEduDescription, null);
            }
        }

        private void txtDuration_Validating(object sender, CancelEventArgs e)
        {
            if (common.isNotDigitOnly(Convert.ToString(txtDuration.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDuration, "Invalid months !");
            }
            else if (txtDuration.Text.Trim().Length > 4)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDuration, "Invalid monoths !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDuration, null);
            }
        }

        private void txtWorkExpDescription_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWorkExpDescription.Text.Trim()) && txtWorkExpDescription.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtWorkExpDescription, "Invalid description !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtWorkExpDescription, null);
            }
        }

        private void txtEPF_Validating(object sender, CancelEventArgs e)
        {
            if (txtEPF.Text.Trim().Length > 7)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEPF, "Invalid EPF/ETF no !");
            }
            else if (common.checkAlreadyExistsOthers(Convert.ToInt32(cmbUpdateKey.SelectedItem), "epfetf", "employee", Convert.ToString(txtEPF.Text.Trim()), "id"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEPF, "EPF/ETF no is already exists !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEPF, null);
            }
        }

        private void dtpAppointment_Validating(object sender, CancelEventArgs e)
        {
            if (dtpAppointment.Value < DateTime.Now)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpAppointment, "Invalid date !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dtpAppointment, null);
            }
        }

        private void txtOffiDetailsDescription_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOffiDetailsDescription.Text.Trim()) && txtOffiDetailsDescription.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtOffiDetailsDescription, "Invalid description !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtOffiDetailsDescription, null);
            }
        }

        private void clearData()
        {
            cmbIniti.SelectedIndex = -1;
            txtName.Text = "";
            txtFullName.Text = "";
            txtNIC.Text = "";
            cmbGender.SelectedIndex = -1;
            dtpBirthdate.Value = DateTime.Now;
            txtAddress.Text = "";
            txtTelnoHome.Text = "";
            txtTelnoMobile.Text = "";
            txtEmail.Text = "";
            txtDescription.Text = "";
            checkBoxOL.Checked = false;
            checkBoxAL.Checked = false;
            checkBoxCertificate.Checked = false;
            checkBoxDiploma.Checked = false;
            checkBoxHiDiploma.Checked = false;
            checkBoxDegree.Checked = false;
            txtEduDescription.Text = "";
            txtDuration.Text = "";
            txtWorkExpDescription.Text = "";
            txtEPF.Text = "";
            dtpAppointment.Value = DateTime.Now;
            cmbDesignation.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtOffiDetailsDescription.Text = "";
        }
    }
}
