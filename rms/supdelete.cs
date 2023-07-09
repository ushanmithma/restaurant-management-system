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
    public partial class supdelete : UserControl
    {
        public supdelete()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Supplier deleting process

        SupplierClass sup = new SupplierClass();
        Common common = new Common();

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

        private void supdelete_Load(object sender, EventArgs e)
        {
            loadSupplierData();
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
                errorProvider.SetError(txtSupplierID, "Invalid customer id !");
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

        private void confirmDeleting(string supID)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Confirm deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool message = sup.deleteSupplier(supID);

                if (message)
                {
                    MessageBox.Show("Record detete successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSupplierData();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void confirmDeletingIngredient(string supID, string ingrID)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Confirm deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool message = sup.deleteSupplierIngredient(supID, ingrID);

                if (message)
                {
                    MessageBox.Show("Record detete successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSupplierData();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string supID = Convert.ToString(txtSupplierID.Text.Trim());
                confirmDeleting(supID);
            }
        }

        private void listViewSupplierDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedSupID = listViewSupplierDetails.SelectedItems[0].SubItems[0].Text;
            confirmDeleting(clickedSupID);
        }

        private void listViewIngredientsDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedSupID = listViewIngredientsDetails.SelectedItems[0].SubItems[0].Text;
            string clickedIngrID = listViewIngredientsDetails.SelectedItems[0].SubItems[1].Text;
            confirmDeletingIngredient(clickedSupID, clickedIngrID);
        }

        private void listViewSupplierDetails_MouseClick(object sender, MouseEventArgs e)
        {
            string clickedSupID = listViewSupplierDetails.SelectedItems[0].SubItems[0].Text;
            searchSupplierIngredients(clickedSupID);
        }
    }
}
