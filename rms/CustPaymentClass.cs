using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class CustPaymentClass : Connection
    {
        public DataTable getPaymentList(string orderType)
        {
            openConnection();
            string mysql = "SELECT * FROM orders, custpayment WHERE orders.id = custpayment.order_id AND order_type = '" + orderType + "' ORDER BY custpayment.id DESC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        private DataTable getFoodItems(int orderID)
        {
            openConnection();
            string mysql = "SELECT food_item, quantity FROM order_details WHERE order_id = " + orderID + "";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        private decimal getMealPrice(string meal)
        {
            decimal price = 0;

            openConnection();
            string mysql = "SELECT price FROM meal WHERE name = '" + meal + "'";
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

        private decimal amount, itemPrice, balance;
        private int quantity;

        public decimal calculateAmount(int orderID)
        {
            DataTable foodItems = getFoodItems(orderID);

            amount = 0;

            foreach (DataRow dr in foodItems.Rows)
            {
                itemPrice = getMealPrice(dr["food_item"].ToString());
                quantity = Convert.ToInt32(dr["quantity"].ToString());
                amount += itemPrice * quantity;
            }

            return amount;
        }

        public decimal calculatePaidAmount(decimal amount, decimal paidAmount)
        {
            balance = paidAmount - amount;
            return balance;
        }

        public bool addCustPayment(decimal amount, decimal paidAmount, decimal balance, int orderID, int userID)
        {
            openConnection();
            string mysql = "INSERT INTO custpayment (amount, paid, balance, order_id, created_by, created_date) VALUES (@amount, @paid, @balance, @orderID, @createdBy, GETDATE())";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@paid", paidAmount);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@orderID", orderID);
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
