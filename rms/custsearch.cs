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
    public partial class custsearch : UserControl
    {
        public custsearch()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Search Process

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

        private void custsearch_Load(object sender, EventArgs e)
        {
            loadCustomerOrdersData();
        }

        private void listViewCustOrders_MouseClick(object sender, MouseEventArgs e)
        {
            string clickedOrderID = listViewCustOrders.SelectedItems[0].SubItems[4].Text;
            searchOrderDetails(clickedOrderID);
        }

        private void listViewCustOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedCustID = listViewCustOrders.SelectedItems[0].SubItems[0].Text;
            searchCustomerOrdersData(clickedCustID);
        }

        private void searchCustomerOrdersData(string custID)
        {
            Dictionary<string, string> customerData = cust.getCustomerData("id", custID);

            foreach (KeyValuePair<string, string> custKeyValuePair in customerData)
            {
                switch (custKeyValuePair.Key)
                {
                    case "custID":
                        lblSearchCustID.Text = custKeyValuePair.Value;
                        break;
                    case "nameWithIniti":
                        lblSearchName.Text = custKeyValuePair.Value;
                        break;
                    case "nic":
                        lblSearchNIC.Text = custKeyValuePair.Value;
                        break;
                    case "gender":
                        lblSearchGender.Text = custKeyValuePair.Value;
                        break;
                    case "tableno":
                        lblSearchTableNo.Text = custKeyValuePair.Value;
                        break;
                    case "address":
                        lblSearchAddr.Text = custKeyValuePair.Value;
                        break;
                    case "mobileno":
                        lblSearchTelnoMobile.Text = custKeyValuePair.Value;
                        break;
                    case "email":
                        lblSearchEmail.Text = custKeyValuePair.Value;
                        break;
                    case "orderID":
                        lblSearchOrderID.Text = custKeyValuePair.Value;

                        listBoxFoodItems.Items.Clear();
                        DataTable foodItemsList = cust.getFoodItemsList(Convert.ToInt32(custKeyValuePair.Value));

                        foreach (DataRow dr in foodItemsList.Rows)
                        {
                            listBoxFoodItems.Items.Add(dr["food_item"].ToString() + " -> " + dr["quantity"].ToString());
                        }

                        break;
                    case "orderDate":

                        lblSearchOrderDate.Text = Convert.ToDateTime(custKeyValuePair.Value).ToString("dddd, dd MMMM yyyy");

                        break;
                    case "orderType":
                        lblSearchOrderType.Text = custKeyValuePair.Value;
                        break;
                    case "deliverDate":
                        if (custKeyValuePair.Value != "")
                        {
                            lblSearchDeliverDate.Text = Convert.ToDateTime(custKeyValuePair.Value).ToString("dddd, dd MMMM yyyy");
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string custID = Convert.ToString(txtCustomerID.Text.Trim());
                searchCustomerOrdersData(custID);
            }
        }

        private void txtCustomerID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCustomerID, "Please enter customer id !");
            }
            else if (common.isNotDigitOnly(Convert.ToString(txtCustomerID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCustomerID, "Invalid customer id !");
            }
            else if (Convert.ToInt32(txtCustomerID.Text.Trim()) > 999999)
            {
                e.Cancel = true;
                errorProvider.SetError(txtCustomerID, "Invalid customer id !");
            }
            else if (common.checkIfNotExists("id", "customer", Convert.ToString(txtCustomerID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCustomerID, "This customer id is not in the database !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCustomerID, null);
            }
        }
    }
}
