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
    public partial class inveadd : UserControl
    {
        private int userID;

        public inveadd(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        // Add ingredient

        InventoryClass inve = new InventoryClass();
        Common common = new Common();

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
            else if (common.checkAlreadyExists("name", "ingredient", Convert.ToString(txtName.Text.Trim())))
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

        private void iconBtnAddIngredientDetails_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                name = Convert.ToString(txtName.Text.Trim().Replace("'", "''").Replace('"', '\"'));

                if (radioBtnLiquid.Checked)
                    unit = "Liters";
                else if (radioBtnMass.Checked)
                    unit = "Kilograms";
                else if (radioBtnQuantity.Checked)
                    unit = "";

                price = Convert.ToDecimal(numUpDownPrice.Value);

                bool message = inve.addIngredient(name, unit, price, userID);

                if (message)
                {
                    clearData();
                    MessageBox.Show("Record added successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something wrong !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearData()
        {
            txtName.Text = "";
            radioBtnLiquid.Checked = false;
            radioBtnMass.Checked = false;
            radioBtnQuantity.Checked = false;
            numUpDownPrice.Value = 10;
        }
        
    }
}
