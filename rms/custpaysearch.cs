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
    public partial class custpaysearch : UserControl
    {
        public custpaysearch()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        CustPaymentClass custpay = new CustPaymentClass();

        private void loadCustDineInPayments()
        {
            listViewDineIn.Items.Clear();

            DataTable customerOrdersDataList = custpay.getPaymentList("Dine-in");

            foreach (DataRow dr in customerOrdersDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["order_id"].ToString());
                item.SubItems.Add(dr["amount"].ToString());
                item.SubItems.Add(dr["paid"].ToString());
                item.SubItems.Add(dr["balance"].ToString());

                listViewDineIn.Items.Add(item);
            }
        }

        private void loadCustDeliverPayments()
        {
            listViewDeliver.Items.Clear();

            DataTable customerOrdersDataList = custpay.getPaymentList("Deliver");

            foreach (DataRow dr in customerOrdersDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["order_id"].ToString());
                item.SubItems.Add(dr["amount"].ToString());
                item.SubItems.Add(dr["paid"].ToString());
                item.SubItems.Add(dr["balance"].ToString());

                listViewDeliver.Items.Add(item);
            }
        }

        private void custpaysearch_Load(object sender, EventArgs e)
        {
            loadCustDineInPayments();
            loadCustDeliverPayments();
        }
    }
}
