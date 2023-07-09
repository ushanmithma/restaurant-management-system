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
    public partial class delivery : Form
    {
        private int userID;

        public delivery(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        DeliveryClass deli = new DeliveryClass();

        custpayments custpay;

        private void loadDeliverOrdersData()
        {
            listViewDeliver.Items.Clear();

            DataTable deliverOrdersDataList = deli.getDeliverOrdersList();

            foreach (DataRow dr in deliverOrdersDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["name"].ToString());
                item.SubItems.Add(dr["address"].ToString());
                item.SubItems.Add(dr["telno"].ToString());
                item.SubItems.Add(dr["mobileno"].ToString());
                item.SubItems.Add(dr["deliver_date"].ToString());
                item.SubItems.Add(dr["order_id"].ToString());

                listViewDeliver.Items.Add(item);
            }
        }

        private void searchOrderDetails(string clickedOrderID)
        {
            listViewOrderDetails.Items.Clear();

            DataTable orderDetailsList = deli.getOrderDetailsList(clickedOrderID);

            foreach (DataRow dr in orderDetailsList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["order_id"].ToString());
                item.SubItems.Add(dr["food_item"].ToString());
                item.SubItems.Add(dr["quantity"].ToString());

                listViewOrderDetails.Items.Add(item);
            }
        }

        private void delivery_Load(object sender, EventArgs e)
        {
            loadDeliverOrdersData();
        }

        private void listViewDeliver_MouseClick(object sender, MouseEventArgs e)
        {
            string clickedOrderID = listViewDeliver.SelectedItems[0].SubItems[5].Text;
            searchOrderDetails(clickedOrderID);
        }

        private void iconBtnCompeleted_Click(object sender, EventArgs e)
        {
            if (listViewDeliver.SelectedItems.Count > 0)
            {
                string selectedOrderID = listViewDeliver.SelectedItems[0].SubItems[5].Text;
                bool message = deli.orderCompeleted(selectedOrderID);

                if (message)
                {
                    loadDeliverOrdersData();
                    listViewOrderDetails.Items.Clear();
                    custpay = new custpayments(userID, Convert.ToInt32(selectedOrderID));
                    custpay.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
