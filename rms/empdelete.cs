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
    public partial class empdelete : UserControl
    {
        public empdelete()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Delete Process

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

        private void empdelete_Load(object sender, EventArgs e)
        {
            loadEmployeeData();
        }

        private void confirmDeleting(string empNIC)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Confirm deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool message = emp.deleteEmployee(empNIC);

                if (message)
                {
                    MessageBox.Show("Record detete successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listViewEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedNIC = listViewEmployee.SelectedItems[0].SubItems[2].Text;
            confirmDeleting(clickedNIC);
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string empNIC = Convert.ToString(txtEmployeeNIC.Text.Trim());
                confirmDeleting(empNIC);
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
