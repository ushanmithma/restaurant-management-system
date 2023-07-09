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
    public partial class supupdate : UserControl
    {
        private int userID;

        public supupdate(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Update Process

        SupplierClass sup = new SupplierClass();
        Common common = new Common();

        private void loadSupplierData()
        {
            listViewSupplierDetails.Items.Clear();

            DataTable supplierDataList = sup.getSupplierList();

            foreach (DataRow dr in supplierDataList.Rows)
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

        private void loadIngredients()
        {
            cmbItem.Items.Clear();

            DataTable ingredients = sup.getIngredients();

            foreach (DataRow dr in ingredients.Rows)
            {
                cmbItem.Items.Add(dr["name"].ToString());
            }
        }

        private void supupdate_Load(object sender, EventArgs e)
        {
            int[] supplierIDs = sup.getSupplierID();

            cmbUpdateKey.Items.Clear();

            for (int id = 0; id < supplierIDs.Length; id++)
            {
                if (supplierIDs[id] == 0)
                    break;
                cmbUpdateKey.Items.Add(supplierIDs[id]);
            }

            loadSupplierData();
            loadIngredients();
        }

        private void cmbUpdateKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> supplierData = sup.getSupplierData("id", Convert.ToString(cmbUpdateKey.SelectedItem));
            string itemName;

            foreach (KeyValuePair<string, string> supKeyValuePair in supplierData)
            {
                switch (supKeyValuePair.Key)
                {
                    case "initi":
                        cmbIniti.Text = supKeyValuePair.Value;
                        break;
                    case "name":
                        txtName.Text = supKeyValuePair.Value;
                        break;
                    case "nic":
                        txtNIC.Text = supKeyValuePair.Value;
                        break;
                    case "brand":
                        txtBrandName.Text = supKeyValuePair.Value;
                        break;
                    case "country":
                        cmbCountry.Text = supKeyValuePair.Value;
                        break;
                    case "address":
                        txtAddress.Text = supKeyValuePair.Value;
                        break;
                    case "telno":
                        txtTelnoHome.Text = supKeyValuePair.Value;
                        break;
                    case "email":
                        txtEmail.Text = supKeyValuePair.Value;
                        break;
                    case "supID":
                        txtSupplierIDid.Text = supKeyValuePair.Value;

                        clearListBoxItems();
                        DataTable ingredientsList = sup.getIngredientsList(Convert.ToInt32(supKeyValuePair.Value));

                        foreach (DataRow dr in ingredientsList.Rows)
                        {
                            itemName = sup.getIngredientName(dr["ingr_id"].ToString());
                            listBoxIngredients.Items.Add(itemName);
                        }

                        break;
                    default:
                        break;
                }
            }
        }

        // Adding Removing Ingredients to ListBox

        private void clearListBoxItems()
        {
            listBoxIngredients.Items.Clear();
        }

        private void iconBtnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedIndex != -1)
            {
                int itemCount = listBoxIngredients.Items.Count;
                bool exist = false;

                if (itemCount != 0)
                {
                    for (int i = 0; i < itemCount; i++)
                    {
                        string ingr = Convert.ToString(listBoxIngredients.Items[i]);

                        if (Convert.ToString(cmbItem.SelectedItem) == ingr)
                        {
                            exist = true;
                        }
                    }
                }

                if (exist == false)
                {
                    string selectedItem = Convert.ToString(cmbItem.SelectedItem);

                    listBoxIngredients.Items.Add(selectedItem);
                    cmbItem.SelectedIndex = -1;
                }
            }
        }

        private void iconBtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listBoxIngredients.SelectedIndex > -1)
            {
                listBoxIngredients.Items.RemoveAt(listBoxIngredients.SelectedIndex);
            }
        }

        private void iconBtnClearItem_Click(object sender, EventArgs e)
        {
            clearListBoxItems();
        }

        // Start Update process

        private void cmbUpdateKey_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierIDid.Text.Trim()))
            {
                if (cmbUpdateKey.SelectedIndex == -1)
                {
                    e.Cancel = true;
                    errorProvider.SetError(cmbUpdateKey, "Please select supplier id !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(cmbUpdateKey, null);
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(txtName.Text.Trim()) && txtName.Text.Trim().Length < 3)
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
            if (cmbUpdateKey.SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(txtNIC.Text.Trim()) && txtNIC.Text.Trim().Length > 12)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtNIC, "Invalid NIC !");
                }
                else if (!string.IsNullOrEmpty(txtNIC.Text.Trim()) && common.checkAlreadyExistsOthers(Convert.ToInt32(cmbUpdateKey.SelectedItem), "nic", "supplier", Convert.ToString(txtNIC.Text.Trim()), "id"))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtNIC, "NIC no is already exists !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtNIC, null);
                }
            }
        }

        private void txtBrandName_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(txtBrandName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtBrandName, "Please enter your brand name !");
                }
                else if (txtBrandName.Text.Trim().Length < 3)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtBrandName, "Invalid brand name !");
                }
                else if (common.checkAlreadyExistsOthers(Convert.ToInt32(cmbUpdateKey.SelectedItem), "brand", "supplier", Convert.ToString(txtBrandName.Text.Trim()), "id"))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtBrandName, "Brand name is already exists !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtBrandName, null);
                }
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex > -1)
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
            if (cmbUpdateKey.SelectedIndex > -1)
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex > -1)
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
                else if (common.checkAlreadyExistsOthers(Convert.ToInt32(cmbUpdateKey.SelectedItem), "email", "supplier", Convert.ToString(txtNIC.Text.Trim()), "id"))
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

        string initi, name, nic, brand, country, address, telno, email;
        int supID;

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                supID = Convert.ToInt32(cmbUpdateKey.SelectedItem);
                initi = Convert.ToString(cmbIniti.SelectedItem);
                name = Convert.ToString(txtName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                nic = Convert.ToString(txtNIC.Text.Trim());
                brand = Convert.ToString(txtBrandName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                country = Convert.ToString(cmbCountry.SelectedItem);
                address = Convert.ToString(txtAddress.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                telno = Convert.ToString(txtTelnoHome.Text.Trim());
                email = Convert.ToString(txtEmail.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                bool message = sup.updateSupplierDetails(initi + " " + name, nic, brand, country, address, telno, email, supID, userID);

                if (message)
                {
                    clearData();
                    MessageBox.Show("Record update successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSupplierData();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearData()
        {
            cmbUpdateKey.SelectedIndex = -1;
            cmbIniti.SelectedIndex = -1;
            txtName.Text = "";
            txtNIC.Text = "";
            txtBrandName.Text = "";
            cmbCountry.SelectedIndex = -1;
            txtAddress.Text = "";
            txtTelnoHome.Text = "";
            txtEmail.Text = "";
        }

        private void listBoxIngredients_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(txtSupplierIDid.Text.Trim())) && cmbUpdateKey.SelectedIndex == -1)
            {
                if (listBoxIngredients.Items.Count == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(listBoxIngredients, "Please add food items !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(listBoxIngredients, null);
                }
            }
        }

        // Ingredients update process

        int supplierID, ingredientsCount;

        private void iconBtnItemUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!string.IsNullOrEmpty(Convert.ToString(txtSupplierIDid.Text.Trim())))
                {
                    supplierID = Convert.ToInt32(txtSupplierIDid.Text.Trim());
                    ingredientsCount = listBoxIngredients.Items.Count;
                    bool isDeletedCurrentIngredients = sup.deleteIngredientsCurrentSupplier(supplierID);
                    bool isSupplierIngredientsAdded = false;

                    if (isDeletedCurrentIngredients)
                    {
                        for (int i = 0; i < ingredientsCount; i++)
                        {
                            isSupplierIngredientsAdded = sup.addSupplierIngredients(supplierID, Convert.ToString(listBoxIngredients.Items[i]));
                        }
                    }

                    if (isSupplierIngredientsAdded)
                    {
                        clearListBoxItems();
                        clearData();
                        txtSupplierIDid.Text = "";
                        MessageBox.Show("Record updated successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadSupplierData();
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
