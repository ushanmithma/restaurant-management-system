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
    public partial class custupdate : UserControl
    {
        private int userID;

        public custupdate(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Update Process

        CustomerClass cust = new CustomerClass();
        Common common = new Common();

        private void loadCustomerOrdersData()
        {
            listViewCustOrders.Items.Clear();

            DataTable customerOrdersDataList = cust.getCustomerOrdersList();

            foreach (DataRow dr in customerOrdersDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["cust_id"].ToString());
                item.SubItems.Add(dr["order_type"].ToString());
                item.SubItems.Add(dr["table_no"].ToString());
                item.SubItems.Add(dr["address"].ToString());
                item.SubItems.Add(dr["order_id"].ToString());
                item.SubItems.Add(dr["order_date"].ToString());
                item.SubItems.Add(dr["deliver_date"].ToString());
                item.SubItems.Add(dr["is_completed"].ToString());

                listViewCustOrders.Items.Add(item);
            }
        }

        private void searchOrderDetails(string clickedOrderID)
        {
            listViewOrderDetails.Items.Clear();

            DataTable orderDetailsList = cust.getOrderDetailsList(clickedOrderID);

            foreach (DataRow dr in orderDetailsList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["order_id"].ToString());
                item.SubItems.Add(dr["food_item"].ToString());
                item.SubItems.Add(dr["quantity"].ToString());

                listViewOrderDetails.Items.Add(item);
            }
        }

        private void loadMeals()
        {
            cmbFoodItem.Items.Clear();

            DataTable meals = cust.getMeals();

            foreach (DataRow dr in meals.Rows)
            {
                cmbFoodItem.Items.Add(dr["name"].ToString());
            }
        }

        private void custupdate_Load(object sender, EventArgs e)
        {
            int[] customerIDs = cust.getCustomerID();

            cmbUpdateKey.Items.Clear();

            for (int id = 0; id < customerIDs.Length; id++)
            {
                if (customerIDs[id] == 0)
                    break;
                cmbUpdateKey.Items.Add(customerIDs[id]);
            }

            loadMeals();
            loadCustomerOrdersData();
        }

        private void listViewCustOrders_MouseClick(object sender, MouseEventArgs e)
        {
            string clickedOrderID = listViewCustOrders.SelectedItems[0].SubItems[4].Text;
            searchOrderDetails(clickedOrderID);
        }

        private void cmbUpdateKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> customerData = cust.getCustomerData("id", Convert.ToString(cmbUpdateKey.SelectedItem));

            foreach (KeyValuePair<string, string> custKeyValuePair in customerData)
            {
                switch (custKeyValuePair.Key)
                {
                    case "initi":
                        cmbIniti.Text = custKeyValuePair.Value;
                        break;
                    case "name":
                        txtName.Text = custKeyValuePair.Value;
                        break;
                    case "nic":
                        txtNIC.Text = custKeyValuePair.Value;
                        break;
                    case "gender":
                        cmbGender.Text = custKeyValuePair.Value;
                        break;
                    case "tableno":
                        if (custKeyValuePair.Value != "")
                        {
                            numUpDownTableNo.Value = Convert.ToInt32(custKeyValuePair.Value);
                        }
                        break;
                    case "address":
                        txtAddress.Text = custKeyValuePair.Value;
                        break;
                    case "telno":
                        txtTelnoHome.Text = custKeyValuePair.Value;
                        break;
                    case "mobileno":
                        txtTelnoMobile.Text = custKeyValuePair.Value;
                        break;
                    case "email":
                        txtEmail.Text = custKeyValuePair.Value;
                        break;
                    case "orderID":
                        txtOrderID.Text = custKeyValuePair.Value;

                        clearListBoxItems();
                        DataTable foodItemsList = cust.getFoodItemsList(Convert.ToInt32(custKeyValuePair.Value));

                        foreach (DataRow dr in foodItemsList.Rows)
                        {
                            listBoxFoodItems.Items.Add(dr["food_item"].ToString() + " -> " + dr["quantity"].ToString());
                        }

                        break;
                    case "orderDate":

                        dtpOrderDate.Value = Convert.ToDateTime(custKeyValuePair.Value);

                        break;
                    case "orderType":

                        radioBtnDineIn.Checked = false;
                        radioBtnDeliver.Checked = false;

                        if (custKeyValuePair.Value == "Dine-in")
                        {
                            radioBtnDineIn.Checked = true;
                            dineInChecked();
                        }
                        else if (custKeyValuePair.Value == "Deliver")
                        {
                            radioBtnDeliver.Checked = true;
                            deliverChecked();
                        }

                        break;
                    case "deliverDate":
                        if (custKeyValuePair.Value != "")
                        {
                            dtpDeliverDate.Value = Convert.ToDateTime(custKeyValuePair.Value);
                        }
                        break;
                    default:
                        break;
                }
            }
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

        string initi, name, nic, gender, address, telno, mobileno, email;
        int tableNo, custID, orderID;

        private void iconBtnUpdateCust_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (radioBtnDineIn.Checked || radioBtnDeliver.Checked)
                {
                    if (radioBtnDineIn.Checked)
                    {
                        custID = Convert.ToInt32(cmbUpdateKey.SelectedItem);
                        tableNo = Convert.ToInt32(numUpDownTableNo.Value);

                        bool message = cust.updateDineInCustomer(tableNo, custID, userID);

                        if (message)
                        {
                            clearData();
                            MessageBox.Show("Record update successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadCustomerOrdersData();
                        }
                        else
                        {
                            MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (radioBtnDeliver.Checked)
                    {
                        custID = Convert.ToInt32(cmbUpdateKey.SelectedItem);
                        initi = Convert.ToString(cmbIniti.SelectedItem);
                        name = Convert.ToString(txtName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                        nic = Convert.ToString(txtNIC.Text.Trim());
                        gender = Convert.ToString(cmbGender.SelectedItem);
                        address = Convert.ToString(txtAddress.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                        telno = Convert.ToString(txtTelnoHome.Text.Trim());
                        mobileno = Convert.ToString(txtTelnoMobile.Text.Trim());
                        email = Convert.ToString(txtEmail.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                        bool message = cust.updateDeliverCustomer(initi + " " + name, nic, gender, address, telno, mobileno, email, custID, userID);

                        if (message)
                        {
                            clearData();
                            MessageBox.Show("Record update successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadCustomerOrdersData();
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

        private void cmbUpdateKey_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbUpdateKey, "Please select customer id !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbUpdateKey, null);
            }
        }

        private void cmbIniti_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnDineIn.Checked && radioBtnDineIn.Checked)
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
                else if (common.checkAlreadyExistsOthers(Convert.ToInt32(cmbUpdateKey.SelectedItem), "email", "customer", Convert.ToString(txtNIC.Text.Trim()), "id"))
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

        private void radioBtnDineIn_CheckedChanged(object sender, EventArgs e)
        {
            dineInChecked();
        }

        private void radioBtnDeliver_CheckedChanged(object sender, EventArgs e)
        {
            deliverChecked();
        }

        private void clearData()
        {
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
            txtOrderID.Text = "";
            dtpOrderDate.Value = DateTime.Now;
            radioBtnDineIn.Checked = false;
            radioBtnDeliver.Checked = false;
            dtpDeliverDate.Value = DateTime.Now;
        }

        private void clearListBoxItems()
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
            clearListBoxItems();
        }

        string orderDate, deliverDate;
        int foodItemCount;

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (radioBtnDineIn.Checked || radioBtnDeliver.Checked)
            {
                if (radioBtnDineIn.Checked)
                {
                    custID = Convert.ToInt32(cmbUpdateKey.SelectedItem);
                    orderID = Convert.ToInt32(txtOrderID.Text.Trim());

                    if (dtpOrderDate.Value <= DateTime.Now)
                    {
                        errorProvider.SetError(dtpOrderDate, null);
                        orderDate = dtpOrderDate.Value.ToString("yyyy-MM-dd");

                        if (listBoxFoodItems.Items.Count > 0)
                        {
                            errorProvider.SetError(listBoxFoodItems, null);
                            foodItemCount = listBoxFoodItems.Items.Count;

                            bool isOrderAdded = cust.updateDineInOrder(orderDate, custID, orderID);
                            bool isDeletedCurrentFoodItem = cust.deleteFoodItems(orderID);
                            bool isFoodItemsAdded = false;

                            if (isDeletedCurrentFoodItem)
                            {
                                for (int i = 0; i < foodItemCount; i++)
                                {
                                    isFoodItemsAdded = cust.updateOrderDetails(Convert.ToString(listBoxFoodItems.Items[i]), orderID);
                                }
                            }

                            if (isOrderAdded && isFoodItemsAdded)
                            {
                                clearOrderDetails();
                                clearListBoxItems();
                                MessageBox.Show("Record update successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadCustomerOrdersData();
                                listViewOrderDetails.Items.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            errorProvider.SetError(listBoxFoodItems, "Please add food items !");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(dtpOrderDate, "Invalid date !");
                    }
                }
                else if (radioBtnDeliver.Checked)
                {
                    custID = Convert.ToInt32(cmbUpdateKey.SelectedItem);
                    orderID = Convert.ToInt32(txtOrderID.Text.Trim());

                    if (dtpOrderDate.Value <= DateTime.Now)
                    {
                        errorProvider.SetError(dtpOrderDate, null);
                        orderDate = dtpOrderDate.Value.ToString("yyyy-MM-dd");

                        if (listBoxFoodItems.Items.Count > 0)
                        {
                            errorProvider.SetError(listBoxFoodItems, null);
                            foodItemCount = listBoxFoodItems.Items.Count;

                            if (dtpDeliverDate.Value > DateTime.Now)
                            {
                                errorProvider.SetError(dtpDeliverDate, null);
                                deliverDate = dtpDeliverDate.Value.ToString("yyyy-MM-dd");

                                bool isOrderAdded = cust.updateDeliverOrder(orderDate, deliverDate, custID, orderID);
                                bool isDeletedCurrentFoodItem = cust.deleteFoodItems(orderID);
                                bool isFoodItemsAdded = false;

                                if (isDeletedCurrentFoodItem)
                                {
                                    for (int i = 0; i < foodItemCount; i++)
                                    {
                                        isFoodItemsAdded = cust.updateOrderDetails(Convert.ToString(listBoxFoodItems.Items[i]), orderID);
                                    }
                                }

                                if (isOrderAdded && isFoodItemsAdded)
                                {
                                    clearOrderDetails();
                                    clearListBoxItems();
                                    MessageBox.Show("Record update successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadCustomerOrdersData();
                                    listViewOrderDetails.Items.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                errorProvider.SetError(dtpDeliverDate, "Invalid date !");
                            }
                        }
                        else
                        {
                            errorProvider.SetError(listBoxFoodItems, "Please add food items !");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(dtpOrderDate, "Invalid date !");
                    }
                }
            }
        }
    }
}