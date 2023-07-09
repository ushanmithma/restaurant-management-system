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
    public partial class empsearch : UserControl
    {
        public empsearch()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Search Process

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

        private void empsearch_Load(object sender, EventArgs e)
        {
            loadEmployeeData();
        }

        private void searchEmployeeData(string searchKey)
        {
            Dictionary<string, string> employeeData = emp.getEmployeeData("nic", searchKey);

            foreach (KeyValuePair<string, string> empKeyValuePair in employeeData)
            {
                switch (empKeyValuePair.Key)
                {
                    case "nameWithIniti":
                        lblSearchName.Text = empKeyValuePair.Value;
                        break;
                    case "fullName":
                        lblSearchFullName.Text = empKeyValuePair.Value;
                        break;
                    case "nic":
                        lblSearchNIC.Text = empKeyValuePair.Value;
                        break;
                    case "gender":
                        lblSearchGender.Text = empKeyValuePair.Value;
                        break;
                    case "birthdate":
                        lblSearchBdate.Text = Convert.ToDateTime(empKeyValuePair.Value).ToString("dddd, dd MMMM yyyy");
                        break;
                    case "address":
                        lblSearchAddr.Text = empKeyValuePair.Value;
                        break;
                    case "telno":
                        lblSearchTelno.Text = empKeyValuePair.Value;
                        break;
                    case "mobileno":
                        lblSearchMobileNo.Text = empKeyValuePair.Value;
                        break;
                    case "email":
                        lblSearchEmail.Text = empKeyValuePair.Value;
                        break;
                    case "description":
                        txtSearchDescription.Text = empKeyValuePair.Value;
                        break;
                    case "qualification":

                        ipbOL.Visible = false;
                        ipbAL.Visible = false;
                        ipbCertificate.Visible = false;
                        ipbDiploma.Visible = false;
                        ipbHiDiploma.Visible = false;
                        ipbDegree.Visible = false;

                        if (empKeyValuePair.Value.Contains("OL"))
                            ipbOL.Visible = true;
                        if (empKeyValuePair.Value.Contains("AL"))
                            ipbAL.Visible = true;
                        if (empKeyValuePair.Value.Contains("Certificate"))
                            ipbCertificate.Visible = true;
                        if (empKeyValuePair.Value.Contains("Diploma"))
                            ipbDiploma.Visible = true;
                        if (empKeyValuePair.Value.Contains("Higher Diploma"))
                            ipbHiDiploma.Visible = true;
                        if (empKeyValuePair.Value.Contains("Degree"))
                            ipbDegree.Visible = true;
                        break;

                    case "eduDescription":
                        txtSearchEduDescription.Text = empKeyValuePair.Value;
                        break;
                    case "duration":
                        lblSearchDuration.Text = empKeyValuePair.Value;
                        break;
                    case "workDescription":
                        txtSearchWorkExpDescription.Text = empKeyValuePair.Value;
                        break;
                    case "epfetf":
                        lblSearchEPF.Text = empKeyValuePair.Value;
                        break;
                    case "appointmentDate":
                        lblSearchApoDate.Text = Convert.ToDateTime(empKeyValuePair.Value).ToString("dddd, dd MMMM yyyy");
                        break;
                    case "designation":
                        lblSearchDesignation.Text = empKeyValuePair.Value;
                        break;
                    case "status":
                        lblSearchStatus.Text = empKeyValuePair.Value;
                        break;
                    case "officialDescription":
                        txtOfficialDescription.Text = empKeyValuePair.Value;
                        break;
                    default:
                        break;
                }
            }
        }

        private void listViewEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedNIC = listViewEmployee.SelectedItems[0].SubItems[2].Text;
            searchEmployeeData(clickedNIC);
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string empNIC = Convert.ToString(txtEmployeeNIC.Text.Trim());
                searchEmployeeData(empNIC);
            }
        }

        private void txtEmployeeNIC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeNIC.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmployeeNIC, "Please enter your NIC no !");
            }
            else if (txtEmployeeNIC.Text.Trim().Length > 12)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmployeeNIC, "Invalid NIC !");
            }
            else if (common.checkIfNotExists("nic", "employee", Convert.ToString(txtEmployeeNIC.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmployeeNIC, "This NIC is not in the database !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmployeeNIC, null);
            }
        }
    }
}
