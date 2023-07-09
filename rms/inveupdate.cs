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
    public partial class inveupdate : UserControl
    {
        private int userID;

        public inveupdate(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Update Process

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

        private void inveupdate_Load(object sender, EventArgs e)
        {
            int[] ingrIDs = inve.getIngrID();

            cmbUpdateKey.Items.Clear();

            for (int id = 0; id < ingrIDs.Length; id++)
            {
                if (ingrIDs[id] == 0)
                    break;
                cmbUpdateKey.Items.Add(ingrIDs[id]);
            }

            loadIngrData();
        }

        private void cmbUpdateKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> ingrData = inve.getIngrData("id", Convert.ToString(cmbUpdateKey.SelectedItem));

            foreach (KeyValuePair<string, string> ingrKeyValuePair in ingrData)
            {
                switch (ingrKeyValuePair.Key)
                {
                    case "name":
                        txtName.Text = ingrKeyValuePair.Value;
                        break;
                    case "unit":

                        if (ingrKeyValuePair.Value == "Liters")
                        {
                            radioBtnLiquid.Checked = true;
                            radioBtnMass.Checked = false;
                            radioBtnQuantity.Checked = false;
                        }
                        else if (ingrKeyValuePair.Value == "Kilograms")
                        {
                            radioBtnMass.Checked = true;
                            radioBtnLiquid.Checked = false;
                            radioBtnQuantity.Checked = false;
                        }
                        else if (ingrKeyValuePair.Value == "")
                        {
                            radioBtnQuantity.Checked = true;
                            radioBtnMass.Checked = false;
                            radioBtnLiquid.Checked = false;
                        }

                        break;
                    case "price":
                        numUpDownPrice.Value = Convert.ToDecimal(ingrKeyValuePair.Value);
                        break;
                    default:
                        break;
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Please enter ingredient name !");
            }
            else if (txtName.Text.Trim().Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Invalid ingredient name !");
            }
            else if (!txtName.Text.Trim().All(c => char.IsWhiteSpace(c) || char.IsLetter(c)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Invalid ingredient name !");
            }
            else if (common.checkAlreadyExistsOthers(Convert.ToInt32(cmbUpdateKey.SelectedItem), "name", "ingredient", Convert.ToString(txtName.Text.Trim()), "id"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Ingredient is already exists !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtName, null);
            }
        }

        private void radioBtnUnit_Validating(object sender, CancelEventArgs e)
        {
            if (!radioBtnLiquid.Checked && !radioBtnMass.Checked && !radioBtnQuantity.Checked)
            {
                e.Cancel = true;
                errorProvider.SetError(radioBtnQuantity, "Please select unit !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(radioBtnQuantity, null);
            }
        }

        private void numUpDownPrice_Validating(object sender, CancelEventArgs e)
        {
            if (numUpDownPrice.Value <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(numUpDownPrice, "Invalid price !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(numUpDownPrice, null);
            }
        }

        string name, unit;
        decimal price;
        int ingrID;

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                ingrID = Convert.ToInt32(cmbUpdateKey.SelectedItem);
                name = Convert.ToString(txtName.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                if (radioBtnLiquid.Checked)
                    unit = "Liters";
                else if (radioBtnMass.Checked)
                    unit = "Kilograms";
                else if (radioBtnQuantity.Checked)
                    unit = "";

                price = Convert.ToDecimal(numUpDownPrice.Value);

                bool message = inve.updateIngr(name, unit, price, ingrID, userID);

                if (message)
                {
                    clearData();
                    MessageBox.Show("Record update successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadIngrData();
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
            txtName.Text = "";
            radioBtnLiquid.Checked = false;
            radioBtnMass.Checked = false;
            radioBtnQuantity.Checked = false;
            numUpDownPrice.Value = 10;
        }
    }
}
