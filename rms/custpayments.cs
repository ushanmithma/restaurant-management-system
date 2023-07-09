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
    public partial class custpayments : Form
    {
        private int userID;

        public custpayments(int id, int orderID)
        {
            InitializeComponent();
            this.userID = id;
            txtOrderID.Text = Convert.ToString(orderID);
        }

        CustPaymentClass custpay = new CustPaymentClass();
        Common common = new Common();

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private decimal amount, paidAmount, balance;
        private int orderID;

        private void iconBtnCustCalc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOrderID.Text.Trim()))
            {
                orderID = Convert.ToInt32(txtOrderID.Text);
                amount = custpay.calculateAmount(orderID);

                lblAmount.Text = Convert.ToString(amount);
            }
        }

        private void txtPaidAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaidAmount.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPaidAmount, "Please enter paid amount !");
            }
            else if (common.isNotDigitOnly(Convert.ToString(txtPaidAmount.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPaidAmount, "Invalid amount !");
            }
            else if (Convert.ToDecimal(txtPaidAmount.Text.Trim()) <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPaidAmount, "Invalid amount !");
            }
            else if (Convert.ToDecimal(txtPaidAmount.Text.Trim()) < Convert.ToDecimal(lblAmount.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPaidAmount, "Invalid amount !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPaidAmount, null);
            }
        }

        private void iconBtnBalance_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                paidAmount = Convert.ToDecimal(txtPaidAmount.Text.Trim());
                balance = custpay.calculatePaidAmount(Convert.ToDecimal(lblAmount.Text), paidAmount);

                lblBalance.Text = Convert.ToString(balance);
                iconBtnCustPaid.Enabled = true;
            }
        }

        private void iconBtnCustPaid_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Convert.ToDecimal(txtPaidAmount.Text.Trim()) - Convert.ToDecimal(lblAmount.Text) != Convert.ToDecimal(lblBalance.Text))
                {
                    errorProvider.SetError(txtPaidAmount, "Invalid amount !");
                }
                else
                {
                    amount = Convert.ToDecimal(lblAmount.Text);
                    paidAmount = Convert.ToDecimal(txtPaidAmount.Text.Trim());
                    balance = Convert.ToDecimal(lblBalance.Text);
                    orderID = Convert.ToInt32(txtOrderID.Text.Trim());

                    bool message = custpay.addCustPayment(amount, paidAmount, balance, orderID, userID);

                    if (message)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
