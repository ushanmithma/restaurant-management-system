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
    public partial class invesearch : UserControl
    {
        public invesearch()
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

        private void txtIngrID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIngrID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIngrID, "Please enter ingredient id !");
            }
            else if (common.isNotDigitOnly(Convert.ToString(txtIngrID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIngrID, "Invalid ingredient id !");
            }
            else if (Convert.ToInt32(txtIngrID.Text.Trim()) > 999999)
            {
                e.Cancel = true;
                errorProvider.SetError(txtIngrID, "Invalid ingredient id !");
            }
            else if (common.checkIfNotExists("id", "ingredient", Convert.ToString(txtIngrID.Text.Trim())))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIngrID, "This ingredient id is not in the database !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtIngrID, null);
            }
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string ingrID = Convert.ToString(txtIngrID.Text.Trim());
                searchIngrData(ingrID);
            }
        }

        private void searchIngrData(string ingrID)
        {
            Dictionary<string, string> ingrData = inve.getIngrData("id", ingrID);

            foreach (KeyValuePair<string, string> ingrKeyValuePair in ingrData)
            {
                switch (ingrKeyValuePair.Key)
                {
                    case "name":
                        lblSearchName.Text = ingrKeyValuePair.Value;
                        break;
                    case "unit":
                        lblSearchUnit.Text = ingrKeyValuePair.Value;
                        break;
                    case "price":
                        lblSearchPrice.Text = "Rs. " + ingrKeyValuePair.Value;
                        break;
                    default:
                        break;
                }
            }
        }

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

        private void listViewIngredientDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string clickedIngrID = listViewIngredientDetails.SelectedItems[0].SubItems[0].Text;
            searchIngrData(clickedIngrID);
        }

        private void invesearch_Load(object sender, EventArgs e)
        {
            loadIngrData();
        }
    }
}
