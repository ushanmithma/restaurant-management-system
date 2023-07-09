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
    public partial class dinein : Form
    {
        private int userID;

        public dinein(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        DineInClass dine = new DineInClass();

        custpayments custpay;

        private void loadDineInOrdersData()
        {
            listViewDineIn.Items.Clear();

            DataTable deliverOrdersDataList = dine.getDineInOrdersList();

            foreach (DataRow dr in deliverOrdersDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["table_no"].ToString());
                item.SubItems.Add(dr["order_id"].ToString());

                listViewDineIn.Items.Add(item);
            }
        }

        private void searchOrderDetails(string clickedOrderID)
        {
            listViewOrderDetails.Items.Clear();

            DataTable orderDetailsList = dine.getOrderDetailsList(clickedOrderID);

            foreach (DataRow dr in orderDetailsList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["order_id"].ToString());
                item.SubItems.Add(dr["food_item"].ToString());
                item.SubItems.Add(dr["quantity"].ToString());

                listViewOrderDetails.Items.Add(item);
            }
        }

        private void dinein_Load(object sender, EventArgs e)
        {
            loadDineInOrdersData();
        }

        private void listViewDineIn_MouseClick(object sender, MouseEventArgs e)
        {
            string clickedOrderID = listViewDineIn.SelectedItems[0].SubItems[1].Text;
            searchOrderDetails(clickedOrderID);
        }

        private void iconBtnCompeleted_Click(object sender, EventArgs e)
        {
            if (listViewDineIn.SelectedItems.Count > 0)
            {
                string selectedOrderID = listViewDineIn.SelectedItems[0].SubItems[1].Text;
                bool message = dine.orderCompeleted(selectedOrderID);

                if (message)
                {
                    loadDineInOrdersData();
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
