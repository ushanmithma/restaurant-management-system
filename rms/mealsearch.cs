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
    public partial class mealsearch : UserControl
    {
        public mealsearch()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Search Process

        MealClass meals = new MealClass();
        Common common = new Common();

        private void txtMealID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMealID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMealID, "Please enter meal id !");
            }
            else if (common.isNotDigitOnly(Convert.ToString(txtMealID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMealID, "Invalid meal id !");
            }
            else if (Convert.ToInt32(txtMealID.Text.Trim()) > 999999)
            {
                e.Cancel = true;
                errorProvider.SetError(txtMealID, "Invalid meal id !");
            }
            else if (common.checkIfNotExists("id", "meal", Convert.ToString(txtMealID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMealID, "This meal id is not in the database !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMealID, null);
            }
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string mealID = Convert.ToString(txtMealID.Text.Trim());
                searchMealData(mealID);
            }
        }

        private void searchMealData(string mealID)
        {
            Dictionary<string, string> mealData = meals.getMealData("id", mealID);
            string itemName, itemQuantity;

            foreach (KeyValuePair<string, string> mealKeyValuePair in mealData)
            {
                switch (mealKeyValuePair.Key)
                {
                    case "mealID":
                        lblSearchMealID.Text = mealKeyValuePair.Value;

                        clearListBoxItems();
                        DataTable ingredientsList = meals.getIngredientsList(Convert.ToInt32(mealKeyValuePair.Value));

                        foreach (DataRow dr in ingredientsList.Rows)
                        {
                            itemName = meals.getIngredientName(dr["ingr_id"].ToString());
                            itemQuantity = dr["quantity"].ToString();
                            listBoxIngredients.Items.Add(itemName + " -> " + itemQuantity);
                        }

                        break;
                    case "name":
                        lblSearchName.Text = mealKeyValuePair.Value;
                        break;
                    case "price":
                        lblSearchPrice.Text = "Rs. " + mealKeyValuePair.Value;
                        break;
                    case "type":
                        lblSearchType.Text = mealKeyValuePair.Value;
                        break;
                    case "time":
                        lblMinutes.Text = mealKeyValuePair.Value + " Minutes";
                        break;
                    case "description":
                        txtSearchDescription.Text = mealKeyValuePair.Value;
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

        private void listViewMealDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedMealID = listViewMealDetails.SelectedItems[0].SubItems[0].Text;
            searchMealData(clickedMealID);
        }

        private void mealsearch_Load(object sender, EventArgs e)
        {
            loadMealData();
        }
    }
}
