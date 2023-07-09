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
    public partial class supsearch : UserControl
    {
        public supsearch()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Search process

        SupplierClass sup = new SupplierClass();
        Common common = new Common();

        private void searchSupplierData(string supID)
        {
            Dictionary<string, string> supplierData = sup.getSupplierData("id", supID);
            string itemName;

            foreach (KeyValuePair<string, string> supKeyValuePair in supplierData)
            {
                switch (supKeyValuePair.Key)
                {
                    case "supID":
                        lblSearchCustID.Text = supKeyValuePair.Value;

                        clearListBoxItems();
                        DataTable ingredientsList = sup.getIngredientsList(Convert.ToInt32(supKeyValuePair.Value));

                        foreach (DataRow dr in ingredientsList.Rows)
                        {
                            itemName = sup.getIngredientName(dr["ingr_id"].ToString());
                            listBoxIngredients.Items.Add(itemName);
                        }
                        break;
                    case "nameWithIniti":
                        lblSearchName.Text = supKeyValuePair.Value;
                        break;
                    case "nic":
                        lblSearchNIC.Text = supKeyValuePair.Value;
                        break;
                    case "brand":
                        lblSearchBrandName.Text = supKeyValuePair.Value;
                        break;
                    case "country":
                        lblSearchCountry.Text = supKeyValuePair.Value;
                        break;
                    case "address":
                        lblSearchAddr.Text = supKeyValuePair.Value;
                        break;
                    case "telno":
                        lblSearchTelnoMobile.Text = supKeyValuePair.Value;
                        break;
                    case "email":
                        lblSearchEmail.Text = supKeyValuePair.Value;
                        break;
                    default:
                        break;
                }
            }
        }

        private void clearListBoxItems()
        {
            listBoxIngredients.Items.Clear();
        }

        private void txtSupplierID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSupplierID, "Please enter supplier id !");
            }
            else if (common.isNotDigitOnly(Convert.ToString(txtSupplierID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSupplierID, "Invalid supplier id !");
            }
            else if (Convert.ToInt32(txtSupplierID.Text.Trim()) > 9999)
            {
                e.Cancel = true;
                errorProvider.SetError(txtSupplierID, "Invalid supplier id !");
            }
            else if (common.checkIfNotExists("id", "supplier", Convert.ToString(txtSupplierID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSupplierID, "This supplier id is not in the database !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSupplierID, null);
            }
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string supID = Convert.ToString(txtSupplierID.Text.Trim());
                searchSupplierData(supID);
            }
        }

        private void loadSupplierData()
        {
            listViewSupplierDetails.Items.Clear();

            DataTable customerOrdersDataList = sup.getSupplierList();

            foreach (DataRow dr in customerOrdersDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["brand"].ToString());
                item.SubItems.Add(dr["country"].ToString());
                item.SubItems.Add(dr["address"].ToString());
                item.SubItems.Add(dr["telno"].ToString());
                item.SubItems.Add(dr["email"].ToString());

                listViewSupplierDetails.Items.Add(item);
            }
        }

        private void searchSupplierIngredients(string clickedSupID)
        {
            listViewIngredientsDetails.Items.Clear();

            DataTable supplierIngrDataList = sup.getSupplierIngredientsList(clickedSupID);

            foreach (DataRow dr in supplierIngrDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["sup_id"].ToString());
                item.SubItems.Add(dr["ingr_id"].ToString());
                string ingredientName = sup.getIngredientName(dr["ingr_id"].ToString());
                item.SubItems.Add(ingredientName);

                listViewIngredientsDetails.Items.Add(item);
            }
        }

        private void listViewSupplierDetails_MouseClick(object sender, MouseEventArgs e)
        {
            string clickedSupID = listViewSupplierDetails.SelectedItems[0].SubItems[0].Text;
            searchSupplierIngredients(clickedSupID);
        }

        private void listViewSupplierDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedSupID = listViewSupplierDetails.SelectedItems[0].SubItems[0].Text;
            searchSupplierData(clickedSupID);
        }

        private void supsearch_Load(object sender, EventArgs e)
        {
            loadSupplierData();
        }
    }
}
