using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class UserClass : Connection
    {
        // loin form

        public bool isUserAvailable(string username, string encpwd)
        {
            openConnection();
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM [user] WHERE username = '" + username + "' AND password = '" + encpwd + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
                return true;
            else
                return false;
        }

        // user form

        public DataTable getUserList()
        {
            openConnection();
            string mysql = "SELECT * FROM [user] WHERE is_deleted = 0 ORDER BY last_login DESC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public bool addUser(string fname, string lname, string username, string password, string type, int userID)
        {
            openConnection();
            string mysql = "INSERT INTO [user] (first_name, last_name, username, password, type, is_deleted, created_by, created_date) VALUES (@fname, @lname, @username, @password, @type, @isDeleted, @createdBy, GETDATE())";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@type", type);
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

        // userupdate form

        public int[] getUsersID()
        {
            int[] keyList = new int[999999];
            string query = "SELECT id FROM [user] WHERE is_deleted = 0";
            openConnection();
            SqlCeCommand cmd = new SqlCeCommand(query, conn);
            SqlCeDataReader dr = cmd.ExecuteReader();
            int x = 0;

            while (dr.Read())
            {
                keyList[x] = Int32.Parse(dr["id"].ToString());
                x++;
            }

            closeConnection();
            return keyList;
        }

        Dictionary<string, string> userData = new Dictionary<string, string>();

        public Dictionary<string, string> getUserData(string col, string unique)
        {
            openConnection();
            string mysql = "SELECT * FROM [user] WHERE " + col + " = '" + unique + "' AND is_deleted = 0";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);

            SqlCeDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                userData.Clear();

                // Adding user data to dictionary
                userData.Add("id", dr["id"].ToString());
                userData.Add("fname", dr["first_name"].ToString());
                userData.Add("lname", dr["last_name"].ToString());
                userData.Add("name", dr["first_name"].ToString() + " " + dr["last_name"].ToString());
                userData.Add("username", dr["username"].ToString());
                userData.Add("password", dr["password"].ToString());
                userData.Add("type", dr["type"].ToString());
                userData.Add("lastLogin", dr["last_login"].ToString());
            }

            return userData;
        }

        public bool updateUser(string fname, string lname, string username, string encpwd, string type, int userID, int loggedUserID)
        {
            openConnection();
            string mysql = "UPDATE [user] SET first_name = @fname, last_name = @lname, username = @username, password = @password, type = @type, edited_by = @editedBy, edited_date = GETDATE() WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", encpwd);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@editedBy", loggedUserID);
            cmd.Parameters.AddWithValue("@id", userID);

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

        // userdelete form

        public bool deleteUser(string userID)
        {
            openConnection();
            string mysql = "UPDATE [user] SET is_deleted = 1 WHERE id = '" + userID + "'";
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

        // Update Last Login
        public bool updateLastLogin(string username)
        {
            openConnection();
            string mysql = "UPDATE [user] SET last_login = GETDATE() WHERE username = @username";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@username", username);

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

        // Logged User Update
        public bool updateLoggedUser(string fname, string lname, string username, string encpwd, int userID)
        {
            openConnection();
            string mysql = "UPDATE [user] SET first_name = @fname, last_name = @lname, username = @username, password = @password, edited_by = @editedBy, edited_date = GETDATE() WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", encpwd);
            cmd.Parameters.AddWithValue("@editedBy", userID);
            cmd.Parameters.AddWithValue("@id", userID);

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

        public int getUserID (string username)
        {
            int ingredientID = 1;
            openConnection();
            string mysql = "SELECT id FROM [user] WHERE username = @username AND is_deleted = 0";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@username", username);

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
    }
}
