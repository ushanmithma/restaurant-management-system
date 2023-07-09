using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rms
{
    public partial class customer : Form
    {
        private int userID;

        public customer(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (!panelCustomer.Controls.ContainsKey("custupdate"))
            {
                custupdate custUpdate = new custupdate(this.userID);
                custUpdate.Dock = DockStyle.Fill;
                panelCustomer.Controls.Add(custUpdate);
            }
            panelCustomer.Controls["custupdate"].BringToFront();
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (!panelCustomer.Controls.ContainsKey("custsearch"))
            {
                custsearch custSearch = new custsearch();
                custSearch.Dock = DockStyle.Fill;
                panelCustomer.Controls.Add(custSearch);
            }
            panelCustomer.Controls["custsearch"].BringToFront();
        }

        // Add Customer Process

        CustomerClass cust = new CustomerClass();
        Common common = new Common();

        private void loadMeals()
        {
            cmbFoodItem.Items.Clear();

            DataTable meals = cust.getMeals();

            foreach (DataRow dr in meals.Rows)
            {
                cmbFoodItem.Items.Add(dr["name"].ToString());
            }
        }

        private void setCustID()
        {
            int custID = cust.getCustIDCount();
            txtCustID.Text = Convert.ToString(custID);
        }

        private void setOrderType(string orderType)
        {
            cmbOrderType.Text = orderType;
        }

        private void customer_Load(object sender, EventArgs e)
        {
            loadMeals();
        }

        private void dineInChecked()
        {
            cmbIniti.Enabled = false;
            txtName.Enabled = false;
            txtNIC.Enabled = false;
            cmbGender.Enabled = false;

            numUpDownTableNo.Enabled = true;
            
            txtAddress.Enabled = false;
            txtTelnoHome.Enabled = false;
            txtTelnoMobile.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void deliverChecked()
        {
            cmbIniti.Enabled = true;
            txtName.Enabled = true;
            txtNIC.Enabled = true;
            cmbGender.Enabled = true;

            numUpDownTableNo.Enabled = false;
            
            txtAddress.Enabled = true;
            txtTelnoHome.Enabled = true;
            txtTelnoMobile.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void radioBtnDineIn_CheckedChanged(object sender, EventArgs e)
        {
            dineInChecked();
        }

        private void radioBtnDeliver_CheckedChanged(object sender, EventArgs e)
        {
            deliverChecked();
        }

        string initi, name, nic, gender, address, telno, mobileno, email;
        int tableNo;

        private void iconBtnAddCustDetails_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (radioBtnDineIn.Checked || radioBtnDeliver.Checked)
                {
                    if (radioBtnDineIn.Checked)
                    {
                        tableNo = Convert.ToInt32(numUpDownTableNo.Value);

                        bool message = cust.addDineInCustomer(tableNo, userID);

                        if (message)
                        {
                            clearData();
                            MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            setCustID();
                            setOrderType("Dine-in");
                        }
                        else
                        {
                            MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (radioBtnDeliver.Checked)
                    {
                        initi = Convert.ToString(cmbIniti.SelectedItem);
                        name = Convert.ToString(txtName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                        nic = Convert.ToString(txtNIC.Text.Trim());
                        gender = Convert.ToString(cmbGender.SelectedItem);
                        address = Convert.ToString(txtAddress.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                        telno = Convert.ToString(txtTelnoHome.Text.Trim());
                        mobileno = Convert.ToString(txtTelnoMobile.Text.Trim());
                        email = Convert.ToString(txtEmail.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                        bool message = cust.addDeliverCustomer(initi + " " + name, nic, gender, address, telno, mobileno, email, userID);

                        if (message)
                        {
                            clearData();
                            MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            setCustID();
                            setOrderType("Deliver");
                        }
                        else
                        {
                            MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(radioBtnDeliver, "Please select order type !");
                }
            }
        }

        private void cmbIniti_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnDineIn.Checked && radioBtnDeliver.Checked)
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
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnDineIn.Checked && radioBtnDeliver.Checked)
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
        }

        private void txtNIC_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnDineIn.Checked && radioBtnDeliver.Checked)
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
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtNIC, null);
                }
            }
        }

        private void cmbGender_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnDineIn.Checked && radioBtnDeliver.Checked)
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
        }

        private void numUpDownTableNo_Validating(object sender, CancelEventArgs e)
        {
            if (radioBtnDineIn.Checked && !radioBtnDeliver.Checked)
            {
                if (numUpDownTableNo.Value == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(numUpDownTableNo, "Please enter table no !");
                }
                else if (numUpDownTableNo.Value > 100)
                {
                    e.Cancel = true;
                    errorProvider.SetError(numUpDownTableNo, "Invalid table no !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(numUpDownTableNo, null);
                }
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnDineIn.Checked && radioBtnDeliver.Checked)
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
        }

        private void txtTelnoHome_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnDineIn.Checked && radioBtnDeliver.Checked)
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
        }

        private void txtTelnoMobile_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnDineIn.Checked && radioBtnDeliver.Checked)
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
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnDineIn.Checked && radioBtnDeliver.Checked)
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
                else if (common.checkAlreadyExists("email", "customer", Convert.ToString(txtEmail.Text.Trim())))
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
        }

        private void clearData()
        {
            radioBtnDineIn.Checked = false;
            radioBtnDeliver.Checked = false;
            cmbIniti.SelectedIndex = -1;
            txtName.Text = "";
            txtNIC.Text = "";
            cmbGender.SelectedIndex = -1;
            numUpDownTableNo.Value = 0;
            txtAddress.Text = "";
            txtTelnoHome.Text = "";
            txtTelnoMobile.Text = "";
            txtEmail.Text = "";
        }

        private void clearOrderDetails()
        {
            txtCustID.Text = "";
            cmbOrderType.SelectedIndex = -1;
            radioBtnODToday.Checked = false;
            radioBtnOrderDate.Checked = false;
            dtpOrderDate.Value = DateTime.Now;
            dtpDeliverDate.Value = DateTime.Now;
        }

        // Order Details

        private void radioBtnODToday_CheckedChanged(object sender, EventArgs e)
        {
            dtpOrderDate.Enabled = false;
        }

        private void radioBtnOrderDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpOrderDate.Enabled = true;
        }

        string orderType, orderDate, deliverDate;
        int custID, foodItemCount;

        private void iconBtnAddOrderDetails_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!string.IsNullOrEmpty(txtCustID.Text.Trim()))
                {
                    if (Convert.ToString(cmbOrderType.SelectedItem) == "Dine-in")
                    {
                        custID = Convert.ToInt32(txtCustID.Text.Trim());
                        orderType = Convert.ToString(cmbOrderType.SelectedItem);
                        if (radioBtnODToday.Checked)
                            orderDate = DateTime.Now.ToString("yyyy-MM-dd");
                        else if (radioBtnOrderDate.Checked)
                            orderDate = dtpOrderDate.Value.ToString("yyyy-MM-dd");
                        foodItemCount = listBoxFoodItems.Items.Count;

                        bool isOrderAdded = cust.addDineInOrder(orderType, orderDate, custID);
                        bool isFoodItemsAdded = false;

                        for (int i = 0; i < foodItemCount; i++)
                        {
                            isFoodItemsAdded = cust.addOrderDetails(Convert.ToString(listBoxFoodItems.Items[i]));
                        }

                        if (isOrderAdded && isFoodItemsAdded)
                        {
                            clearOrderDetails();
                            clearLiistBoxItems();
                            MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (Convert.ToString(cmbOrderType.SelectedItem) == "Deliver")
                    {
                        custID = Convert.ToInt32(txtCustID.Text.Trim());
                        orderType = Convert.ToString(cmbOrderType.SelectedItem);
                        if (radioBtnODToday.Checked)
                            orderDate = DateTime.Now.ToString("yyyy-MM-dd");
                        else if (radioBtnOrderDate.Checked)
                            orderDate = dtpOrderDate.Value.ToString("yyyy-MM-dd");
                        foodItemCount = listBoxFoodItems.Items.Count;
                        deliverDate = dtpDeliverDate.Value.ToString("yyyy-MM-dd");

                        bool isOrderAdded = cust.addDeliverOrder(orderType, orderDate, deliverDate, custID);
                        bool isFoodItemsAdded = false;

                        for (int i = 0; i < foodItemCount; i++)
                        {
                            isFoodItemsAdded = cust.addOrderDetails(Convert.ToString(listBoxFoodItems.Items[i]));
                        }

                        if (isOrderAdded && isFoodItemsAdded)
                        {
                            clearOrderDetails();
                            clearLiistBoxItems();
                            MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(txtCustID, "Please select customer id !");
                }
            }
        }

        private void cmbOrderType_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustID.Text.Trim()))
            {
                if (cmbOrderType.SelectedIndex == -1)
                {
                    e.Cancel = true;
                    errorProvider.SetError(cmbOrderType, "Please select order type !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(cmbOrderType, null);
                }
            }
        }

        private void radioBtnODToday_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustID.Text.Trim()))
            {
                if (!radioBtnODToday.Checked && !radioBtnOrderDate.Checked)
                {
                    e.Cancel = true;
                    errorProvider.SetError(dtpOrderDate, "Please select order date !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(radioBtnODToday, null);
                }
            }
        }

        private void radioBtnOrderDate_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustID.Text.Trim()))
            {
                if (!radioBtnODToday.Checked && !radioBtnOrderDate.Checked)
                {
                    e.Cancel = true;
                    errorProvider.SetError(dtpOrderDate, "Please select order date !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(radioBtnOrderDate, null);
                }
            }
        }

        private void dtpOrderDate_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustID.Text.Trim()))
            {
                if (radioBtnOrderDate.Checked)
                {
                    if (dtpOrderDate.Value > DateTime.Now)
                    {
                        e.Cancel = true;
                        errorProvider.SetError(dtpOrderDate, "Invalid date !");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider.SetError(dtpOrderDate, null);
                    }
                }
            }
        }

        private void listBoxFoodItems_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustID.Text.Trim()))
            {
                if (listBoxFoodItems.Items.Count == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(listBoxFoodItems, "Please add food items !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(listBoxFoodItems, null);
                }
            }
        }

        private void dtpDeliverDate_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustID.Text.Trim()))
            {
                if (Convert.ToString(cmbOrderType.SelectedItem) == "Deliver")
                {
                    if (dtpDeliverDate.Value < DateTime.Now)
                    {
                        e.Cancel = true;
                        errorProvider.SetError(dtpDeliverDate, "Invalid date !");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider.SetError(dtpDeliverDate, null);
                    }
                }
            }
        }

        // Adding Removing Food Items to ListBox

        private void clearLiistBoxItems()
        {
            listBoxFoodItems.Items.Clear();
        }

        private void iconBtnAddFoodItem_Click(object sender, EventArgs e)
        {
            if (cmbFoodItem.SelectedIndex != -1 && numUpDownFoodItemQuantity.Value != 0)
            {
                int itemCount = listBoxFoodItems.Items.Count;
                bool exist = false;

                if (itemCount != 0)
                {
                    for (int i = 0; i < itemCount; i++)
                    {
                        string[] spearator = { " -> " };
                        string item = Convert.ToString(listBoxFoodItems.Items[i]);
                        String[] foodArr = item.Split(spearator, StringSplitOptions.None);
                        string food = foodArr[0];
                        string quantity = foodArr[1];

                        if (Convert.ToString(cmbFoodItem.SelectedItem) == food)
                        {
                            exist = true;
                        }
                    }
                }

                if (exist == false)
                {
                    string selectedItem = Convert.ToString(cmbFoodItem.SelectedItem);
                    string itemQuantity = Convert.ToString(numUpDownFoodItemQuantity.Value);

                    listBoxFoodItems.Items.Add(selectedItem + " -> " + itemQuantity);
                    cmbFoodItem.SelectedIndex = -1;
                    numUpDownFoodItemQuantity.Value = 1;
                }
            }
        }

        private void iconBtnRemoveFoodItem_Click(object sender, EventArgs e)
        {
            if (listBoxFoodItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listBoxFoodItems.SelectedIndex > -1)
            {
                listBoxFoodItems.Items.RemoveAt(listBoxFoodItems.SelectedIndex);
            }
        }

        private void iconBtnClearFoodItem_Click(object sender, EventArgs e)
        {
            clearLiistBoxItems();
        }
    }
}
