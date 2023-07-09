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
    public partial class inventory : Form
    {
        private int userID;

        public inventory(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void iconBtnAddIngredient_Click(object sender, EventArgs e)
        {
            if (!panelInventory.Controls.ContainsKey("inveadd"))
            {
                inveadd inveAdd = new inveadd(this.userID);
                inveAdd.Dock = DockStyle.Fill;
                panelInventory.Controls.Add(inveAdd);
            }
            panelInventory.Controls["inveadd"].BringToFront();
        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            if (!panelInventory.Controls.ContainsKey("inveupdate"))
            {
                inveupdate inveUpdate = new inveupdate(this.userID);
                inveUpdate.Dock = DockStyle.Fill;
                panelInventory.Controls.Add(inveUpdate);
            }
            panelInventory.Controls["inveupdate"].BringToFront();
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            if (!panelInventory.Controls.ContainsKey("invedelete"))
            {
                invedelete inveDelete = new invedelete();
                inveDelete.Dock = DockStyle.Fill;
                panelInventory.Controls.Add(inveDelete);
            }
            panelInventory.Controls["invedelete"].BringToFront();
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (!panelInventory.Controls.ContainsKey("invesearch"))
            {
                invesearch inveSearch = new invesearch();
                inveSearch.Dock = DockStyle.Fill;
                panelInventory.Controls.Add(inveSearch);
            }
            panelInventory.Controls["invesearch"].BringToFront();
        }

        InventoryClass inve = new InventoryClass();

        private void inventory_Load(object sender, EventArgs e)
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
    }
}
