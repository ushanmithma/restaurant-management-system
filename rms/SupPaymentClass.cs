using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class SupPaymentClass : Connection
    {
        public DataTable getPaymentList()
        {
            openConnection();
            string mysql = "SELECT * FROM supplier, suppayment WHERE supplier.id = suppayment.sup_id ORDER BY suppayment.id DESC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable getBrands()
        {
            openConnection();
            string mysql = "SELECT brand FROM supplier WHERE is_deleted = 0 ORDER BY brand ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public int getSupID(string brand)
        {
            int id = 1;
            openConnection();
            string mysql = "SELECT id FROM supplier WHERE brand = '" + brand + "'";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            try
            {
                SqlCeDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"].ToString());
                }
                closeConnection();

                if (id > 0)
                    return id;
                else
                    return id;
            }
            catch (SqlCeException e)
            {
                return id;
            }
        }

        private int supID;

        public DataTable getIngredients(string brand)
        {
            supID = getSupID(brand);

            openConnection();
            string mysql = "SELECT ingredient.name AS ingr FROM supplier_ingredient, ingredient WHERE supplier_ingredient.ingr_id = ingredient.id AND sup_id = " + supID + " ORDER BY ingredient.name ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        private decimal itemPrice, amount, balance;
        private int qty;
        
        public decimal calculateAmount(string ingredient)
        {
            string[] spearator = { " -> " };
            String[] ingrArr = ingredient.Split(spearator, StringSplitOptions.None);
            string ingr = ingrArr[0];
            string quantity = ingrArr[1];

            bool isUpdated = updateInventory(ingr, quantity);

            if (isUpdated)
            {
                itemPrice = getIngrPrice(ingr);
                qty = Convert.ToInt32(quantity);

                amount = itemPrice * qty;

                return amount;
            }
            else
            {
                return amount;
            }
        }

        private bool updateInventory(string ingr, string qty)
        {
            openConnection();
            string mysql = "UPDATE ingredient SET quantity = quantity + @qty WHERE name = @ingr";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@ingr", ingr);

            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                closeConnection();
                if (affectedRows > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlCeException e)
            {
                return false;
            }
        }

        private decimal getIngrPrice(string ingredient)
        {
            decimal price = 0;

            openConnection();
            string mysql = "SELECT price FROM ingredient WHERE name = '" + ingredient + "'";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            try
            {
                SqlCeDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    price = Convert.ToDecimal(dr["price"].ToString());
                }
                closeConnection();

                if (price > 0)
                    return price;
                else
                    return price;
            }
            catch (SqlCeException e)
            {
                return price;
            }
        }

        public decimal calculatePaidAmount(decimal amount, decimal paidAmount)
        {
            balance = paidAmount - amount;
            return balance;
        }

        public bool addSupPayment(decimal amount, decimal paidAmount, decimal balance, int supID, int userID)
        {
            openConnection();
            string mysql = "INSERT INTO suppayment (amount, paid, balance, sup_id, created_by, created_date) VALUES (@amount, @paid, @balance, @supID, @createdBy, GETDATE())";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@paid", paidAmount);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@supID", supID);
            cmd.Parameters.AddWithValue("@createdBy", userID);

            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                closeConnection();
                if (affectedRows > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlCeException e)
            {
                return false;
            }
        }
    }
}
