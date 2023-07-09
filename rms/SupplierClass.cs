using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class SupplierClass : Connection
    {
        public int[] getSupplierID()
        {
            int[] supplierIDs = getKeyList("id", "supplier");
            return supplierIDs;
        }

        public DataTable getIngredients()
        {
            openConnection();
            string mysql = "SELECT name FROM ingredient WHERE is_deleted = 0 ORDER BY name ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public int getSupIDCount()
        {
            int supCount = getRowCount("supplier");
            return supCount;
        }

        public bool addSupplierDetails(string name, string nic, string brand, string country, string address, string telno, string email, string registedDate, int userID)
        {
            openConnection();
            string mysql = "INSERT INTO supplier (name, nic, brand, country, address, telno, email, registed_date, is_deleted, created_by, created_date) VALUES (@name, @nic, @brand, @country, @address, @telno, @email, @registedDate, @isDeleted, @createdBy, GETDATE())";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@brand", brand);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@telno", telno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@registedDate", registedDate);
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

        private int getIngredientID(string ingredient)
        {
            int ingredientID = 1;
            openConnection();
            string mysql = "SELECT id FROM ingredient WHERE name = @ingredient AND is_deleted = 0";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@ingredient", ingredient);

            try
            {
                SqlCeDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ingredientID = Convert.ToInt32(dr["id"].ToString());
                }
                closeConnection();

                if (ingredientID > 0)
                    return ingredientID;
                else
                    return ingredientID;
            }
            catch (SqlCeException e)
            {
                return ingredientID;
            }
        }

        public bool addSupplierIngredients(int supplierID, string ingredient)
        {
            int ingredientID = getIngredientID(ingredient);

            openConnection();
            string mysql = "INSERT INTO supplier_ingredient (sup_id, ingr_id) VALUES (@supID, @ingrID)";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@supID", supplierID);
            cmd.Parameters.AddWithValue("@ingrID", ingredientID);

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

        // Update Process

        Dictionary<string, string> supplierData = new Dictionary<string, string>();

        public Dictionary<string, string> getSupplierData(string col, string unique)
        {
            openConnection();
            string mysql = "SELECT * FROM supplier WHERE " + col + " = '" + unique + "' AND is_deleted = 0";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);

            SqlCeDataReader dr = cmd.ExecuteReader();
            char[] space = { ' ' };

            while (dr.Read())
            {
                // Get name initi
                string splitName = dr["name"].ToString();
                string[] dividedName = splitName.Split(space);

                supplierData.Clear();

                // Adding supplier data to dictionary
                supplierData.Add("supID", dr["id"].ToString());
                supplierData.Add("initi", dividedName[0]);
                supplierData.Add("nameWithIniti", dr["name"].ToString());
                supplierData.Add("name", dr["name"].ToString().TrimStart(' ', '.', 'M', 'r', 's', 'i'));
                supplierData.Add("nic", dr["nic"].ToString());
                supplierData.Add("brand", dr["brand"].ToString());
                supplierData.Add("country", dr["country"].ToString());
                supplierData.Add("address", dr["address"].ToString());
                supplierData.Add("telno", dr["telno"].ToString());
                supplierData.Add("email", dr["email"].ToString());
                supplierData.Add("registedDate", dr["registed_date"].ToString());
            }

            return supplierData;
        }

        internal DataTable getIngredientsList(int supID)
        {
            openConnection();
            string mysql = "SELECT ingr_id FROM supplier_ingredient WHERE sup_id = " + supID + "";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public string getIngredientName(string ingrID)
        {
            openConnection();
            string ingredientName = "";
            string mysql = "SELECT name FROM ingredient WHERE id = @ingredientID";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@ingredientID", ingrID);

            try
            {
                SqlCeDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ingredientName = Convert.ToString(dr["name"]);
                }
                closeConnection();

                if (!string.IsNullOrEmpty(ingredientName))
                    return ingredientName;
                else
                    return ingredientName;
            }
            catch (SqlCeException e)
            {
                return ingredientName;
            }
        }

        public bool updateSupplierDetails(string name, string nic, string brand, string country, string address, string telno, string email, int supID, int userID)
        {
            openConnection();
            string mysql = "UPDATE supplier SET name = @name, nic = @nic, brand = @brand, country = @country, address = @address, telno = @telno, email = @email, edited_by = @editedBy, edited_date = GETDATE() WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@brand", brand);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@telno", telno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@editedBy", userID);
            cmd.Parameters.AddWithValue("@id", supID);

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

        public bool deleteIngredientsCurrentSupplier(int supplierID)
        {
            bool ifIngreExists = ifRecordExists("sup_id", "supplier_ingredient", Convert.ToString(supplierID));

            if (ifIngreExists)
            {
                bool isDeleted = deleteRecord("supplier_ingredient", "sup_id", Convert.ToString(supplierID));
                return isDeleted;
            }
            else
            {
                return true;
            }
        }

        public DataTable getSupplierList()
        {
            openConnection();
            string mysql = "SELECT * FROM supplier WHERE is_deleted = 0 ORDER BY id ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable getSupplierIngredientsList(string clickedSupID)
        {
            openConnection();
            string mysql = "SELECT * FROM supplier_ingredient WHERE sup_id = '" + clickedSupID + "' ORDER BY sup_id ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public bool deleteSupplier(string supID)
        {
            openConnection();
            string mysql = "UPDATE supplier SET is_deleted = 1 WHERE id = '" + supID + "'";
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

        public bool deleteSupplierIngredient(string supID, string ingrID)
        {
            openConnection();
            string mysql = "DELETE FROM supplier_ingredient WHERE sup_id = '" + supID + "' AND ingr_id = '" + ingrID + "'";
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
