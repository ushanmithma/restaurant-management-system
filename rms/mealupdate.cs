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
    public partial class mealupdate : UserControl
    {
        private int userID;

        public mealupdate(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Update Process

        MealClass meals = new MealClass();
        Common common = new Common();

        private void loadMealData()
        {
            listViewMealDetails.Items.Clear();

            DataTable mealDataList = meals.getMealList();

            foreach (DataRow dr in mealDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["price"].ToString());
                item.SubItems.Add(dr["type"].ToString());
                item.SubItems.Add(dr["time"].ToString());
                item.SubItems.Add(dr["description"].ToString());

                listViewMealDetails.Items.Add(item);
            }
        }

        private void searchMealIngredients(string clickedMealID)
        {
            listViewIngredientsDetails.Items.Clear();

            DataTable mealIngrDataList = meals.getMealIngredientsList(clickedMealID);

            foreach (DataRow dr in mealIngrDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["meal_id"].ToString());
                item.SubItems.Add(dr["ingr_id"].ToString());
                string ingredientName = meals.getIngredientName(dr["ingr_id"].ToString());
                item.SubItems.Add(ingredientName);
                item.SubItems.Add(dr["quantity"].ToString());

                listViewIngredientsDetails.Items.Add(item);
            }
        }

        private void listViewMealDetails_MouseClick(object sender, MouseEventArgs e)
        {
            string clickedMealID = listViewMealDetails.SelectedItems[0].SubItems[0].Text;
            searchMealIngredients(clickedMealID);
        }

        private void loadIngredients()
        {
            cmbIngredient.Items.Clear();

            DataTable ingredients = meals.getIngredients();

            foreach (DataRow dr in ingredients.Rows)
            {
                cmbIngredient.Items.Add(dr["name"].ToString());
            }
        }

        private void mealupdate_Load(object sender, EventArgs e)
        {
            int[] mealIDs = meals.getMealsID();

            cmbUpdateKey.Items.Clear();

            for (int id = 0; id < mealIDs.Length; id++)
            {
                if (mealIDs[id] == 0)
                    break;
                cmbUpdateKey.Items.Add(mealIDs[id]);
            }

            loadMealData();
            loadIngredients();
        }

        private void cmbUpdateKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> mealData = meals.getMealData("id", Convert.ToString(cmbUpdateKey.SelectedItem));
            string itemName, itemQuantity;

            foreach (KeyValuePair<string, string> mealKeyValuePair in mealData)
            {
                switch (mealKeyValuePair.Key)
                {
                    case "name":
                        txtName.Text = mealKeyValuePair.Value;
                        break;
                    case "price":
                        txtPrice.Text = mealKeyValuePair.Value;
                        break;
                    case "type":
                        cmbType.Text = mealKeyValuePair.Value;
                        break;
                    case "time":
                        txtPrepareTime.Text = mealKeyValuePair.Value;
                        break;
                    case "description":
                        txtDescription.Text = mealKeyValuePair.Value;
                        break;
                    case "mealID":
                        txtMealID.Text = mealKeyValuePair.Value;

                        clearListBoxItems();
                        DataTable ingredientsList = meals.getIngredientsList(Convert.ToInt32(mealKeyValuePair.Value));

                        foreach (DataRow dr in ingredientsList.Rows)
                        {
                            itemName = meals.getIngredientName(dr["ingr_id"].ToString());
                            itemQuantity = dr["quantity"].ToString();
                            listBoxIngredients.Items.Add(itemName + " -> " + itemQuantity);
                        }

                        break;
                    default:
                        break;
                }
            }
        }

        private void cmbUpdateKey_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMealID.Text.Trim()))
            {
                if (cmbUpdateKey.SelectedIndex == -1)
                {
                    e.Cancel = true;
                    errorProvider.SetError(cmbUpdateKey, "Please select meal id !");
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
                if (string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtName, "Please enter meal name !");
                }
                else if (txtName.Text.Trim().Length < 3)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtName, "Invalid name !");
                }
                else if (common.checkAlreadyExistsOthers(Convert.ToInt32(cmbUpdateKey.SelectedItem), "name", "meal", Convert.ToString(txtName.Text.Trim()), "id"))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtName, "Meal is already exists !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtName, null);
                }
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtPrice, "Please enter meal price !");
                }
                else if (common.isNotDigitOnly(Convert.ToString(txtPrice.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtPrice, "Invalid price !");
                }
                else if (Convert.ToDecimal(txtPrice.Text.Trim()) <= 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtPrice, "Invalid price !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtPrice, null);
                }
            }
        }

        private void cmbType_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex > -1)
            {
                if (cmbType.SelectedIndex == -1)
                {
                    e.Cancel = true;
                    errorProvider.SetError(cmbType, "Please select meal type !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(cmbType, null);
                }
            }
        }

        private void txtPrepareTime_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(txtPrepareTime.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtPrepareTime, "Please enter preparation time !");
                }
                else if (common.isNotDigitOnly(Convert.ToString(txtPrepareTime.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtPrepareTime, "Invalid preparation time !");
                }
                else if (Convert.ToInt32(txtPrepareTime.Text.Trim()) <= 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtPrepareTime, "Invalid preparation time !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtPrepareTime, null);
                }
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUpdateKey.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtDescription, "Please enter description !");
                }
                else if (txtDescription.Text.Trim().Length < 3)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtDescription, "Invalid description !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtDescription, null);
                }
            }
        }

        private void listBoxIngredients_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(txtMealID.Text.Trim())) && cmbUpdateKey.SelectedIndex == -1)
            {
                if (listBoxIngredients.Items.Count == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(listBoxIngredients, "Please list the ingredients !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(listBoxIngredients, null);
                }
            }
        }

        string name, type, description;
        int time, ingredientsCount, mealID;
        decimal price;

        private void iconBtnMealUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                mealID = Convert.ToInt32(cmbUpdateKey.SelectedItem);
                name = Convert.ToString(txtName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                price = Convert.ToDecimal(txtPrice.Text.Trim());
                type = Convert.ToString(cmbType.SelectedItem);
                time = Convert.ToInt32(txtPrepareTime.Text.Trim());
                description = Convert.ToString(txtDescription.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                bool message = meals.updateMeal(name, price, type, time, description, mealID, userID);

                if (message)
                {
                    clearData();
                    MessageBox.Show("Record update successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMealData();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconBtnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbIngredient.SelectedIndex != -1 && !string.IsNullOrEmpty(txtQuantity.Text.Trim()))
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

                        if (Convert.ToString(cmbIngredient.SelectedItem) == ingr)
                        {
                            exist = true;
                        }
                    }
                }

                if (exist == false)
                {
                    string selectedItem = Convert.ToString(cmbIngredient.SelectedItem);
                    string itemQuantity = Convert.ToString(txtQuantity.Text.Trim());

                    listBoxIngredients.Items.Add(selectedItem + " -> " + itemQuantity);
                    cmbIngredient.SelectedIndex = -1;
                    txtQuantity.Text = "";
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

        private void clearListBoxItems()
        {
            listBoxIngredients.Items.Clear();
        }

        private void clearData()
        {
            cmbUpdateKey.SelectedIndex = -1;
            txtName.Text = "";
            txtPrice.Text = "";
            cmbType.SelectedIndex = -1;
            txtPrepareTime.Text = "";
            txtDescription.Text = "";
        }

        private void iconBtnIngrUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                mealID = Convert.ToInt32(txtMealID.Text.Trim());
                ingredientsCount = listBoxIngredients.Items.Count;
                bool isDeletedCurrentIngredients = meals.deleteIngredientsCurrentMeal(mealID);
                bool isMealIngredientsAdded = false;

                if (isDeletedCurrentIngredients)
                {
                    for (int i = 0; i < ingredientsCount; i++)
                    {
                        isMealIngredientsAdded = meals.addIngredients(mealID, Convert.ToString(listBoxIngredients.Items[i]));
                    }
                }

                if (isMealIngredientsAdded)
                {
                    clearListBoxItems();
                    clearData();
                    txtMealID.Text = "";
                    MessageBox.Show("Record updated successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
