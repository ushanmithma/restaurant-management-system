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
    public partial class meal : Form
    {
        private int userID;

        public meal(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (!panelMeal.Controls.ContainsKey("mealupdate"))
            {
                mealupdate mealUpdate = new mealupdate(this.userID);
                mealUpdate.Dock = DockStyle.Fill;
                panelMeal.Controls.Add(mealUpdate);
            }
            panelMeal.Controls["mealupdate"].BringToFront();
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (!panelMeal.Controls.ContainsKey("mealsearch"))
            {
                mealsearch mealSearch = new mealsearch();
                mealSearch.Dock = DockStyle.Fill;
                panelMeal.Controls.Add(mealSearch);
            }
            panelMeal.Controls["mealsearch"].BringToFront();
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            if (!panelMeal.Controls.ContainsKey("mealdelete"))
            {
                mealdelete mealDelete = new mealdelete();
                mealDelete.Dock = DockStyle.Fill;
                panelMeal.Controls.Add(mealDelete);
            }
            panelMeal.Controls["mealdelete"].BringToFront();
        }

        // Getting Meal Data

        string name, type, description;
        int time, ingredientsCount, mealID;
        decimal price;

        MealClass meals = new MealClass();
        Common common = new Common();

        private void loadIngredients()
        {
            cmbIngredient.Items.Clear();

            DataTable ingredients = meals.getIngredients();

            foreach (DataRow dr in ingredients.Rows)
            {
                cmbIngredient.Items.Add(dr["name"].ToString());
            }
        }

        private void meal_Load(object sender, EventArgs e)
        {
            loadIngredients();
        }

        private void iconBtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                name = Convert.ToString(txtName.Text.Trim().Replace("'", "''").Replace('"', '\"'));
                price = Convert.ToDecimal(txtPrice.Text.Trim());
                type = Convert.ToString(cmbType.SelectedItem);
                time = Convert.ToInt32(txtPrepareTime.Text.Trim());
                description = Convert.ToString(txtDescription.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                bool message = meals.addMeal(name, price, type, time, description, userID);

                if (message)
                {
                    clearData();
                    MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setMealID();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconBtnAddIngredients_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                mealID = Convert.ToInt32(txtMealID.Text.Trim());
                ingredientsCount = listBoxIngredients.Items.Count;

                bool isIngredientsAdded = false;

                for (int i = 0; i < ingredientsCount; i++)
                {
                    isIngredientsAdded = meals.addIngredients(mealID, Convert.ToString(listBoxIngredients.Items[i]));
                }

                if (isIngredientsAdded)
                {
                    clearListBoxItems();
                    txtMealID.Text = "";
                    MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMealID.Text.Trim()))
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
                else if (common.checkAlreadyExists("name", "meal", Convert.ToString(txtName.Text.Trim())))
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
            if (string.IsNullOrEmpty(txtMealID.Text.Trim()))
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
            if (string.IsNullOrEmpty(txtMealID.Text.Trim()))
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
            if (string.IsNullOrEmpty(txtMealID.Text.Trim()))
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
            if (string.IsNullOrEmpty(txtMealID.Text.Trim()))
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
            if (!string.IsNullOrEmpty(txtMealID.Text.Trim()))
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

        private void clearData()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            cmbType.SelectedIndex = -1;
            txtPrepareTime.Text = "";
            txtDescription.Text = "";
        }

        private void setMealID()
        {
            int mealID = meals.getMealIDCount();
            txtMealID.Text = mealID.ToString();
        }

        private void clearListBoxItems()
        {
            listBoxIngredients.Items.Clear();
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
    }
}
