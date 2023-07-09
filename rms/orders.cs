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
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }

        OrdersClass order = new OrdersClass();

        private void loadOrders(string type)
        {
        }

        private void loadDineInOrdersData()
        {
            listViewDineIn.Items.Clear();

            DataTable dineInOrdersDataList = order.getOrdersList("Dine-in");

            foreach (DataRow dr in dineInOrdersDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["food_item"].ToString());
                item.SubItems.Add(dr["qty"].ToString());

                listViewDineIn.Items.Add(item);
            }
        }

        private void loadDeliverOrdersData()
        {
            listViewDeliver.Items.Clear();

            DataTable deliverOrdersDataList = order.getOrdersList("Deliver");

            foreach (DataRow dr in deliverOrdersDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["food_item"].ToString());
                item.SubItems.Add(dr["qty"].ToString());

                listViewDeliver.Items.Add(item);
            }
        }

        private void orders_Load(object sender, EventArgs e)
        {
            loadDineInOrdersData();
            loadDeliverOrdersData();
        }
    }
}
