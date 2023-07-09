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
    public partial class payments : Form
    {
        private int userID;

        public payments(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBtnShowCustPayments_Click(object sender, EventArgs e)
        {
            if (!panelPayments.Controls.ContainsKey("custpaysearch"))
            {
                custpaysearch custPayment = new custpaysearch();
                custPayment.Dock = DockStyle.Fill;
                panelPayments.Controls.Add(custPayment);
            }
            panelPayments.Controls["custpaysearch"].BringToFront();
        }

        SupPaymentClass suppay = new SupPaymentClass();
        Common common = new Common();

        private void loadSupPayments()
        {
            listViewSupPayments.Items.Clear();

            DataTable supPaymentDataList = suppay.getPaymentList();

            foreach (DataRow dr in supPaymentDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["brand"].ToString());
                item.SubItems.Add(dr["amount"].ToString());
                item.SubItems.Add(dr["paid"].ToString());
                item.SubItems.Add(dr["balance"].ToString());

                listViewSupPayments.Items.Add(item);
            }
        }

        private void loadBrands()
        {
            cmbBrandName.Items.Clear();

            DataTable brands = suppay.getBrands();

            foreach (DataRow dr in brands.Rows)
            {
                cmbBrandName.Items.Add(dr["brand"].ToString());
            }
        }

        private void payments_Load(object sender, EventArgs e)
        {
            loadBrands();
            loadSupPayments();
        }

        private void cmbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.Items.Clear();

            DataTable ingredients = suppay.getIngredients(Convert.ToString(cmbBrandName.SelectedItem));

            foreach (DataRow dr in ingredients.Rows)
            {
                cmbItem.Items.Add(dr["ingr"].ToString());
            }
        }

        private void clearListBoxItems()
        {
            listBoxIngredients.Items.Clear();
        }

        private void iconBtnAddIngredient_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedIndex != -1 && numUpDownIngredientQuantity.Value != 0)
            {
                int itemCount = listBoxIngredients.Items.Count;
                bool exist = false;

                if (itemCount != 0)
                {
                    for (int i = 0; i < itemCount; i++)
                    {
                        string[] spearator = { " -> " };
                        string item = Convert.ToString(listBoxIngredients.Items[i]);
                        String[] ingrArr = item.Split(spearator, StringSplitOptions.None);
                        string ingr = ingrArr[0];
                        string quantity = ingrArr[1];

                        if (Convert.ToString(cmbItem.SelectedItem) == ingr)
                        {
                            exist = true;
                        }
                    }
                }

                if (exist == false)
                {
                    string selectedItem = Convert.ToString(cmbItem.SelectedItem);
                    string itemQuantity = Convert.ToString(numUpDownIngredientQuantity.Value);

                    listBoxIngredients.Items.Add(selectedItem + " -> " + itemQuantity);
                    cmbItem.SelectedIndex = -1;
                    numUpDownIngredientQuantity.Value = 0;
                }
            }
        }

        private void iconBtnRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listBoxIngredients.SelectedIndex > -1)
            {
                listBoxIngredients.Items.RemoveAt(listBoxIngredients.SelectedIndex);
            }
        }

        private void iconBtnClearIngredient_Click(object sender, EventArgs e)
        {
            clearListBoxItems();
        }

        private int ingrCount;
        private decimal amount, paidAmount, balance;

        private void iconBtnSupCalc_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients.Items.Count == 0)
            {
                errorProvider.SetError(listBoxIngredients, "Please add ingredients !");
            }
            else
            {
                errorProvider.SetError(listBoxIngredients, null);
                ingrCount = listBoxIngredients.Items.Count;

                amount = 0;

                for (int i = 0; i < ingrCount; i++)
                {
                    amount += suppay.calculateAmount(Convert.ToString(listBoxIngredients.Items[i]));
                }

                lblAmount.Text = Convert.ToString(amount);
                lblBrand.Text = Convert.ToString(cmbBrandName.SelectedItem);
                clearData();
            }
        }

        private void clearData()
        {
            cmbBrandName.SelectedIndex = -1;
            cmbItem.Items.Clear();
            numUpDownIngredientQuantity.Value = 0;
            clearListBoxItems();
        }

        private void txtPaidAmount_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(lblAmount.Text) != 0)
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
        }

        private void iconBtnBalance_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                paidAmount = Convert.ToDecimal(txtPaidAmount.Text.Trim());
                balance = suppay.calculatePaidAmount(Convert.ToDecimal(lblAmount.Text), paidAmount);

                lblBalance.Text = Convert.ToString(balance);
                iconBtnSupPaid.Enabled = true;
            }
        }

        private int supID;

        private void iconBtnSupPaid_Click(object sender, EventArgs e)
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
                    supID = suppay.getSupID(Convert.ToString(lblBrand.Text.Trim()));

                    bool message = suppay.addSupPayment(amount, paidAmount, balance, supID, userID);

                    if (message)
                    {
                        MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearAmountsAndBrand();
                        loadSupPayments();
                    }
                    else
                    {
                        MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void clearAmountsAndBrand()
        {
            lblAmount.Text = "0";
            txtPaidAmount.Text = "";
            lblBalance.Text = "0";
            lblBrand.Text = "----------";
        }
    }
}
