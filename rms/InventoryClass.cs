using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class InventoryClass : Connection
    {
        public bool addIngredient(string name, string unit, decimal price, int userID)
        {
            openConnection();
            string mysql = "INSERT INTO ingredient (name, unit, price, quantity, is_deleted, created_by, created_date) VALUES (@name, @unit, @price, @quantity, @isDeleted, @createdBy, GETDATE())";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@quantity", 0);
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

        // inveupdate form

        public int[] getIngrID()
        {
            int[] ingrIDs = getKeyList("id", "ingredient");
            return ingrIDs;
        }

        Dictionary<string, string> ingrData = new Dictionary<string, string>();

        public Dictionary<string, string> getIngrData(string col, string unique)
        {
            openConnection();
            string mysql = "SELECT * FROM ingredient WHERE " + col + " = '" + unique + "' AND is_deleted = 0";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);

            SqlCeDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ingrData.Clear();

                // Adding ingredient data to dictionary
                ingrData.Add("name", dr["name"].ToString());
                ingrData.Add("unit", dr["unit"].ToString());
                ingrData.Add("price", dr["price"].ToString());
            }

            return ingrData;
        }

        public DataTable getIngrList()
        {
            openConnection();
            string mysql = "SELECT * FROM ingredient WHERE is_deleted = 0 ORDER BY name ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public bool updateIngr(string name, string unit, decimal price, int ingrID, int userID)
        {
            openConnection();
            string mysql = "UPDATE ingredient SET name = @name, unit = @unit, price = @price, edited_by = @editedBy, edited_date = GETDATE() WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@editedBy", userID);
            cmd.Parameters.AddWithValue("@id", ingrID);

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

        // invedelete form

        public bool deleteIngr(string ingrID)
        {
            openConnection();
            string mysql = "UPDATE ingredient SET is_deleted = 1 WHERE id = '" + ingrID + "'";
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
