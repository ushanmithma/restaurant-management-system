using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class MealClass : Connection
    {
        // meal form

        public DataTable getIngredients()
        {
            openConnection();
            string mysql = "SELECT name FROM ingredient WHERE is_deleted = 0 ORDER BY name ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        
        public bool addMeal(string name, decimal price, string type, int time, string description, int userID)
        {
            openConnection();
            string mysql = "INSERT INTO meal (name, price, type, time, description, is_deleted, created_by, created_date) VALUES (@name, @price, @type, @time, @description, @isDeleted, @createdBy, GETDATE())";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@description", description);
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

        public int getMealIDCount()
        {
            int mealCount = getRowCount("meal");
            return mealCount;
        }

        public bool addIngredients(int mealID, string ingredient)
        {
            string[] spearator = { " -> " };
            String[] ingrArr = ingredient.Split(spearator, StringSplitOptions.None);
            string item = ingrArr[0];
            string quantity = ingrArr[1];

            int ingredientID = getIngredientID(item);

            openConnection();
            string mysql = "INSERT INTO meal_ingredient (meal_id, ingr_id, quantity) VALUES (@mealID, @ingrID, @quantity)";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@mealID", mealID);
            cmd.Parameters.AddWithValue("@ingrID", ingredientID);
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

        // mealupdate form

        public int[] getMealsID()
        {
            int[] mealIDs = getKeyList("id", "meal");
            return mealIDs;
        }

        Dictionary<string, string> mealData = new Dictionary<string, string>();

        public Dictionary<string, string> getMealData(string col, string unique)
        {
            openConnection();
            string mysql = "SELECT * FROM meal WHERE " + col + " = '" + unique + "' AND is_deleted = 0";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);

            SqlCeDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                mealData.Clear();

                // Adding meal data to dictionary
                mealData.Add("mealID", dr["id"].ToString());
                mealData.Add("name", dr["name"].ToString());
                mealData.Add("price", dr["price"].ToString());
                mealData.Add("type", dr["type"].ToString());
                mealData.Add("time", dr["time"].ToString());
                mealData.Add("description", dr["description"].ToString());
            }

            return mealData;
        }

        public DataTable getIngredientsList(int mealID)
        {
            openConnection();
            string mysql = "SELECT ingr_id, quantity FROM meal_ingredient WHERE meal_id = " + mealID + "";
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

        public bool updateMeal(string name, decimal price, string type, int time, string description, int mealID, int userID)
        {
            openConnection();
            string mysql = "UPDATE meal SET name = @name, price = @price, type = @type, time = @time, description = @description, edited_by = @editedBy, edited_date = GETDATE() WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@editedBy", userID);
            cmd.Parameters.AddWithValue("@id", mealID);

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

        public bool deleteIngredientsCurrentMeal(int mealID)
        {
            bool ifIngreExists = ifRecordExists("meal_id", "meal_ingredient", Convert.ToString(mealID));

            if (ifIngreExists)
            {
                bool isDeleted = deleteRecord("meal_ingredient", "meal_id", Convert.ToString(mealID));
                return isDeleted;
            }
            else
            {
                return true;
            }
        }

        public DataTable getMealList()
        {
            openConnection();
            string mysql = "SELECT * FROM meal WHERE is_deleted = 0 ORDER BY id ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable getMealIngredientsList(string clickedMealID)
        {
            openConnection();
            string mysql = "SELECT * FROM meal_ingredient WHERE meal_id = '" + clickedMealID + "' ORDER BY meal_id ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // mealdelete form

        public bool deleteMeal(string mealID)
        {
            openConnection();
            string mysql = "UPDATE meal SET is_deleted = 1 WHERE id = '" + mealID + "'";
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

        public bool deleteMealIngredient(string mealID, string ingrID)
        {
            openConnection();
            string mysql = "DELETE FROM meal_ingredient WHERE meal_id = '" + mealID + "' AND ingr_id = '" + ingrID + "'";
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
