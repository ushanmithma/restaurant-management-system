using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class DeliveryClass : Connection
    {
        public DataTable getDeliverOrdersList()
        {
            openConnection();
            string mysql = "SELECT name, address, telno, mobileno, deliver_date, orders.id AS order_id FROM customer, orders WHERE customer.id = orders.cust_id AND orders.order_type = 'Deliver' AND is_completed = 0 ORDER BY customer.id ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable getOrderDetailsList(string orderID)
        {
            openConnection();
            string mysql = "SELECT * FROM order_details WHERE order_id = '" + orderID + "' ORDER BY food_item ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public bool orderCompeleted(string orderID)
        {
            openConnection();
            string mysql = "UPDATE orders SET is_completed = 1 WHERE id = '" + orderID + "'";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
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
