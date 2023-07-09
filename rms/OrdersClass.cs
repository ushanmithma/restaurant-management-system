using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class OrdersClass : Connection
    {
        public DataTable getOrdersList(string OrderType)
        {
            openConnection();
            string mysql = "SELECT food_item, SUM(quantity) as qty FROM orders, order_details WHERE orders.id = order_details.order_id AND orders.order_type = '" + OrderType + "' AND is_completed = 0 GROUP BY food_item";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
