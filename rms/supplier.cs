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
    public partial class supplier : Form
    {    
        private int userID;

        public supplier(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (!panelSupplier.Controls.ContainsKey("supupdate"))
            {
                supupdate supUpdate = new supupdate(this.userID);
                supUpdate.Dock = DockStyle.Fill;
                panelSupplier.Controls.Add(supUpdate);
            }
            panelSupplier.Controls["supupdate"].BringToFront();
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            if (!panelSupplier.Controls.ContainsKey("supdelete"))
            {
                supdelete supDelete = new supdelete();
                supDelete.Dock = DockStyle.Fill;
                panelSupplier.Controls.Add(supDelete);
            }
            panelSupplier.Controls["supdelete"].BringToFront();
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (!panelSupplier.Controls.ContainsKey("supsearch"))
            {
                supsearch supSearch = new supsearch();
                supSearch.Dock = DockStyle.Fill;
                panelSupplier.Controls.Add(supSearch);
            }
            panelSupplier.Controls["supsearch"].BringToFront();
        }

        // Supplier adding process

        SupplierClass sup = new SupplierClass();
        Common common = new Common();

        private void loadIngredients()
        {
            cmbItem.Items.Clear();

            DataTable ingredients = sup.getIngredients();

            foreach (DataRow dr in ingredients.Rows)
            {
                cmbItem.Items.Add(dr["name"].ToString());
            }
        }

        private void loadSupIDs()
        {
            int[] supplierIDs = sup.getSupplierID();

            cmbSupID.Items.Clear();

            for (int id = 0; id < supplierIDs.Length; id++)
            {
                if (supplierIDs[id] == 0)
                    break;
                cmbSupID.Items.Add(supplierIDs[id]);
            }
        }

        private void setSupID()
        {
            int supID = sup.getSupIDCount();
            cmbSupID.Text = supID.ToString();
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            loadSupIDs();
            loadIngredients();
        }

        string registedDate, initi, name, nic, brand, country, address, telno, email;

        private void iconBtnAddCustDetails_Click(object sender, EventArgs e)
        {
            if (cmbSupID.SelectedIndex == -1)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    registedDate = dtpRegistedDate.Value.ToString("yyyy-MM-dd");
                    initi = Convert.ToString(cmbIniti.SelectedItem);
                    name = Convert.ToString(txtName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                    nic = Convert.ToString(txtNIC.Text.Trim());
                    brand = Convert.ToString(txtBrandName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                    country = Convert.ToString(cmbCountry.SelectedItem);
                    address = Convert.ToString(txtAddress.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                    telno = Convert.ToString(txtTelnoHome.Text.Trim());
                    email = Convert.ToString(txtEmail.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                    bool message = sup.addSupplierDetails(initi + " " + name, nic, brand, country, address, telno, email, registedDate, userID);

                    if (message)
                    {
                        clearData();
                        MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadSupIDs();
                        setSupID();
                    }
                    else
                    {
                        MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtpRegistedDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpRegistedDate.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpRegistedDate, "Invalid date !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dtpRegistedDate, null);
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text.Trim()) && txtName.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Invalid name !");
            }
            else if (!string.IsNullOrEmpty(txtName.Text.Trim()) && !txtName.Text.Trim().All(c => char.IsWhiteSpace(c) || char.IsLetter(c)))
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

        private void txtNIC_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNIC.Text.Trim()) && txtNIC.Text.Trim().Length > 12)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNIC, "Invalid NIC !");
            }
            else if (!string.IsNullOrEmpty(txtNIC.Text.Trim()) && common.checkAlreadyExists("nic", "supplier", Convert.ToString(txtNIC.Text.Trim())))
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

        private void txtBrandName_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSupID.SelectedIndex == -1)
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
                else if (common.checkAlreadyExists("brand", "supplier", Convert.ToString(txtBrandName.Text.Trim())))
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

        private void cmbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSupID.SelectedIndex == -1)
            {
                if (cmbCountry.SelectedIndex == -1)
                {
                    e.Cancel = true;
                    errorProvider.SetError(cmbCountry, "Please select country !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(cmbCountry, null);
                }
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSupID.SelectedIndex == -1)
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
            if (cmbSupID.SelectedIndex == -1)
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
            if (cmbSupID.SelectedIndex == -1)
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
                else if (common.checkAlreadyExists("email", "supplier", Convert.ToString(txtEmail.Text.Trim())))
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

        private void clearData()
        {
            dtpRegistedDate.Value = DateTime.Now;
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
            if (cmbSupID.SelectedIndex > -1)
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
            else if (listBoxIngredients.SelectedIndex > -1)
            {
                listBoxIngredients.Items.RemoveAt(listBoxIngredients.SelectedIndex);
            }
        }

        private void iconBtnClearItem_Click(object sender, EventArgs e)
        {
            clearListBoxItems();
        }

        int supplierID, ingredientsCount;

        private void iconBtnAddItemDetails_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (cmbSupID.SelectedIndex != -1)
                {
                    supplierID = Convert.ToInt32(cmbSupID.SelectedItem);
                    ingredientsCount = listBoxIngredients.Items.Count;
                    bool isSupplierIngredientsAdded = false;

                    for (int i = 0; i < ingredientsCount; i++)
                    {
                        isSupplierIngredientsAdded = sup.addSupplierIngredients(supplierID, Convert.ToString(listBoxIngredients.Items[i]));
                    }

                    if (isSupplierIngredientsAdded)
                    {
                        clearListBoxItems();
                        cmbSupID.SelectedIndex = -1;
                        MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
