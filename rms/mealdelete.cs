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
    public partial class mealdelete : UserControl
    {
        public mealdelete()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Meal deleting process

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

        private void mealdelete_Load(object sender, EventArgs e)
        {
            loadMealData();
        }

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

        private void confirmDeleting(string mealID)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Confirm deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool message = meals.deleteMeal(mealID);

                if (message)
                {
                    MessageBox.Show("Record detete successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMealData();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void confirmDeletingIngredient(string mealID, string ingrID)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Confirm deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool message = meals.deleteMealIngredient(mealID, ingrID);

                if (message)
                {
                    MessageBox.Show("Record detete successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMealData();
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
                string mealID = Convert.ToString(txtMealID.Text.Trim());
                confirmDeleting(mealID);
            }
        }

        private void listViewMealDetails_MouseClick(object sender, MouseEventArgs e)
        {
            string clickedMealID = listViewMealDetails.SelectedItems[0].SubItems[0].Text;
            searchMealIngredients(clickedMealID);
        }

        private void listViewMealDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedMealID = listViewMealDetails.SelectedItems[0].SubItems[0].Text;
            confirmDeleting(clickedMealID);
        }

        private void listViewIngredientsDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedMealID = listViewIngredientsDetails.SelectedItems[0].SubItems[0].Text;
            string clickedIngrID = listViewIngredientsDetails.SelectedItems[0].SubItems[1].Text;
            confirmDeletingIngredient(clickedMealID, clickedIngrID);
        }
    }
}
