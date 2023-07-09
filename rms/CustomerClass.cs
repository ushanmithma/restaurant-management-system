using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class CustomerClass : Connection
    {
        public bool addDineInCustomer(int tableNo, int userID)
        {
            openConnection();
            string mysql = "INSERT INTO customer (table_no, is_deleted, created_by, created_date) VALUES (@tblNo, @isDeleted, @createdBy, GETDATE())";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@tblNo", tableNo);
            cmd.Parameters.AddWithValue("@isDeleted", "False");
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

        public bool addDeliverCustomer(string name, string nic, string gender, string address, string telno, string mobileno, string email, int userID)
        {
            openConnection();
            string mysql = "INSERT INTO customer (name, nic, gender, address, telno, mobileno, email, is_deleted, created_by, created_date) VALUES (@name, @nic, @gender, @address, @telno, @mobileno, @email, @isDeleted, @createdBy, GETDATE())";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@telno", telno);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@isDeleted", "False");
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

        public int getCustIDCount()
        {
            int custCount = getRowCount("customer");
            return custCount;
        }

        public int[] getCustomerID()
        {
            int[] custIDList = new int[999999];
            string mysql = "SELECT customer.id AS cust_id FROM customer, orders WHERE customer.id = orders.cust_id AND is_completed = 0";
            openConnection();
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            SqlCeDataReader dr = cmd.ExecuteReader();
            int x = 0;

            while (dr.Read())
            {
                custIDList[x] = Int32.Parse(dr["cust_id"].ToString());
                x++;
            }

            closeConnection();
            return custIDList;
        }

        public DataTable getMeals()
        {
            openConnection();
            string mysql = "SELECT name FROM meal WHERE is_deleted = 0 ORDER BY name ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // Add orders

        private int getOrderIDCount()
        {
            int orderCount = getRowCount("orders");
            return orderCount;
        }

        public string getOrderType(int custID)
        {
            openConnection();
            string tblNo = "";
            string mysql = "SELECT table_no FROM customer WHERE id = "+ custID +"";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            try
            {
                SqlCeDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tblNo = Convert.ToString(dr["table_no"]);
                }
                closeConnection();

                if (tblNo != "")
                    return "Dine-in";
                else
                    return "Deliver";
            }
            catch (SqlCeException e)
            {
                return "";
            }
        }

        public bool addOrderDetails(string foodItem)
        {
            string[] spearator = { " -> " };
            String[] foodArr = foodItem.Split(spearator, StringSplitOptions.None);
            string item = foodArr[0];
            string quantity = foodArr[1];
            int orderID = getOrderIDCount();

            openConnection();
            string mysql = "INSERT INTO order_details (order_id, food_item, quantity) VALUES (@orderID, @foodItem, @quantity)";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@foodItem", item);
            cmd.Parameters.AddWithValue("@quantity", quantity);

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

        public bool addDineInOrder(string orderType, string orderDate, int custID)
        {
            openConnection();
            string mysql = "INSERT INTO orders (order_type, order_date, is_completed, cust_id) VALUES (@orderType, @orderDate, @isCompleted, @custID)";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@orderType", orderType);
            cmd.Parameters.AddWithValue("@orderDate", orderDate);
            cmd.Parameters.AddWithValue("@isCompleted", "False");
            cmd.Parameters.AddWithValue("@custID", custID);

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

        public bool addDeliverOrder(string orderType, string orderDate, string deliverDate, int custID)
        {
            openConnection();
            string mysql = "INSERT INTO orders (order_type, order_date, deliver_date, is_completed, cust_id) VALUES (@orderType, @orderDate, @deliverDate, @isCompleted, @custID)";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@orderType", orderType);
            cmd.Parameters.AddWithValue("@orderDate", orderDate);
            cmd.Parameters.AddWithValue("@deliverDate", deliverDate);
            cmd.Parameters.AddWithValue("@isCompleted", "False");
            cmd.Parameters.AddWithValue("@custID", custID);

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

        // Customer Update Process

        public DataTable getCustomerOrdersList()
        {
            openConnection();
            string mysql = "SELECT customer.id AS cust_id, table_no, address, orders.id AS order_id, order_type, order_date, deliver_date, is_completed FROM customer, orders WHERE customer.id = orders.cust_id AND is_completed = 0 ORDER BY customer.id ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable getOrderDetailsList(string clickedOrderID)
        {
            openConnection();
            string mysql = "SELECT * FROM order_details WHERE order_id = '" + clickedOrderID + "' ORDER BY food_item ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        Dictionary<string, string> customerData = new Dictionary<string, string>();

        public Dictionary<string, string> getCustomerData(string col, string unique)
        {
            openConnection();
            string mysql = "SELECT  customer.id AS cCust_id, name, nic, gender, table_no, address, telno, mobileno, email, orders.id AS order_id, order_type, order_date, deliver_date, is_completed, cust_id FROM customer, orders WHERE customer." + col + " = @cCustID AND orders.cust_id = @oCustID";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@cCustID", unique);
            cmd.Parameters.AddWithValue("@oCustID", unique);

            SqlCeDataReader dr = cmd.ExecuteReader();
            char[] space = { ' ' };

            while (dr.Read())
            {
                // Get name initi
                string splitName = dr["name"].ToString();
                string[] dividedName = splitName.Split(space);

                customerData.Clear();

                // Adding customer & order data to dictionary
                customerData.Add("custID", dr["cCust_id"].ToString());
                customerData.Add("initi", dividedName[0]);
                customerData.Add("nameWithIniti", dr["name"].ToString());
                customerData.Add("name", dr["name"].ToString().TrimStart(' ', '.', 'M', 'r', 's', 'i'));
                customerData.Add("nic", dr["nic"].ToString());
                customerData.Add("gender", dr["gender"].ToString());
                customerData.Add("tableno", dr["table_no"].ToString());
                customerData.Add("address", dr["address"].ToString());
                customerData.Add("telno", dr["telno"].ToString());
                customerData.Add("mobileno", dr["mobileno"].ToString());
                customerData.Add("email", dr["email"].ToString());
                customerData.Add("orderType", dr["order_type"].ToString());
                customerData.Add("orderDate", dr["order_date"].ToString());
                customerData.Add("deliverDate", dr["deliver_date"].ToString());
                customerData.Add("orderID", dr["order_id"].ToString());
            }

            return customerData;
        }

        public DataTable getFoodItemsList(int orderID)
        {
            openConnection();
            string mysql = "SELECT * FROM order_details WHERE order_id = " + orderID + "";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public bool updateDineInCustomer(int tableNo, int custID, int userID)
        {
            openConnection();
            string mysql = "UPDATE customer SET name = @name, nic = @nic, gender = @gender, table_no = @tblNo, address = @address, telno = @telno, mobileno = @mobileno, email = @email, edited_by = @editedBy, edited_date = GETDATE() WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", DBNull.Value);
            cmd.Parameters.AddWithValue("@nic", DBNull.Value);
            cmd.Parameters.AddWithValue("@gender", DBNull.Value);
            cmd.Parameters.AddWithValue("@tblNo", tableNo);
            cmd.Parameters.AddWithValue("@address", DBNull.Value);
            cmd.Parameters.AddWithValue("@telno", DBNull.Value);
            cmd.Parameters.AddWithValue("@mobileno", DBNull.Value);
            cmd.Parameters.AddWithValue("@email", DBNull.Value);
            cmd.Parameters.AddWithValue("@editedBy", userID);
            cmd.Parameters.AddWithValue("@id", custID);

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

        public bool updateDeliverCustomer(string name, string nic, string gender, string address, string telno, string mobileno, string email, int custID, int userID)
        {
            openConnection();
            string mysql = "UPDATE customer SET name = @name, nic = @nic, gender = @gender, table_no = @tblNo, address = @address, telno = @telno, mobileno = @mobileno, email = @email, edited_by = @editedBy, edited_date = GETDATE() WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@tblNo", DBNull.Value);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@telno", telno);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@editedBy", userID);
            cmd.Parameters.AddWithValue("@id", custID);

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

        public bool deleteFoodItems(int orderID)
        {
            bool isDeleted = deleteRecord("order_details", "order_id", Convert.ToString(orderID));
            return isDeleted;
        }

        public bool updateDineInOrder(string orderDate, int custID, int orderID)
        {
            openConnection();
            string mysql = "UPDATE orders SET order_type = @orderType, order_date = @orderDate, deliver_date = @deliverDate, cust_id = @custID WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@orderType", "Dine-in");
            cmd.Parameters.AddWithValue("@orderDate", orderDate);
            cmd.Parameters.AddWithValue("@deliverDate", DBNull.Value);
            cmd.Parameters.AddWithValue("@custID", custID);
            cmd.Parameters.AddWithValue("@id", orderID);

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

        public bool updateDeliverOrder(string orderDate, string deliverDate, int custID, int orderID)
        {
            openConnection();
            string mysql = "UPDATE orders SET order_type = @orderType, order_date = @orderDate, deliver_date = @deliverDate, cust_id = @custID WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@orderType", "Deliver");
            cmd.Parameters.AddWithValue("@orderDate", orderDate);
            cmd.Parameters.AddWithValue("@deliverDate", deliverDate);
            cmd.Parameters.AddWithValue("@custID", custID);
            cmd.Parameters.AddWithValue("@id", orderID);

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

        public bool updateOrderDetails(string foodItem, int orderID)
        {
            string[] spearator = { " -> " };
            String[] foodArr = foodItem.Split(spearator, StringSplitOptions.None);
            string item = foodArr[0];
            string quantity = foodArr[1];

            openConnection();
            string mysql = "INSERT INTO order_details (food_item, quantity, order_id) VALUES (@foodItem, @quantity, @orderID)";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@foodItem", item);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@orderID", orderID);

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
