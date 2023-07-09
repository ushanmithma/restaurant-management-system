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
    public partial class invedelete : UserControl
    {
        public invedelete()
        {
            InitializeComponent();
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Delete Process

        InventoryClass inve = new InventoryClass();
        Common common = new Common();

        private void loadIngrData()
        {
            listViewIngredientDetails.Items.Clear();

            DataTable ingrDataList = inve.getIngrList();

            foreach (DataRow dr in ingrDataList.Rows)
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["unit"].ToString());
                item.SubItems.Add(dr["price"].ToString());
                item.SubItems.Add(dr["quantity"].ToString());

                listViewIngredientDetails.Items.Add(item);
            }
        }

        private void invedelete_Load(object sender, EventArgs e)
        {
            loadIngrData();
        }

        private void txtIngredientID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIngredientID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIngredientID, "Please enter ingredient id !");
            }
            else if (common.isNotDigitOnly(Convert.ToString(txtIngredientID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIngredientID, "Invalid ingredient id !");
            }
            else if (Convert.ToInt32(txtIngredientID.Text.Trim()) > 999999)
            {
                e.Cancel = true;
                errorProvider.SetError(txtIngredientID, "Invalid ingredient id !");
            }
            else if (common.checkIfNotExists("id", "ingredient", Convert.ToString(txtIngredientID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIngredientID, "This ingredient id is not in the database !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtIngredientID, null);
            }
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string ingrID = Convert.ToString(txtIngredientID.Text.Trim());
                confirmDeleting(ingrID);
            }
        }

        private void confirmDeleting(string ingrID)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Confirm deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool message = inve.deleteIngr(ingrID);

                if (message)
                {
                    MessageBox.Show("Record detete successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadIngrData();
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listViewIngredientDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedIngrID = listViewIngredientDetails.SelectedItems[0].SubItems[0].Text;
            confirmDeleting(clickedIngrID);
        }
    }
}
