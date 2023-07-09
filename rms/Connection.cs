using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class Connection
    {
        // Data Source=D:\R\ratatouille.sdf;Password=***********
        private string connectionString = "Data Source=C:/Users/Isuru Morathote/Documents/Visual Studio 2012/Projects/rms/ratatouille.sdf;Password='ratatouille'";
        protected SqlCeConnection conn;

        protected void openConnection()
        {
            conn = new SqlCeConnection(connectionString);
            conn.Open();
        }

        protected void closeConnection()
        {
            conn.Close();
            conn.Dispose();
        }

        protected int getRowCount(string tbl)
        {
            int rowCount = 1;
            openConnection();
            string mysql = "SELECT COUNT(*) AS row_count FROM "+ tbl +"";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            try
            {
                SqlCeDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    rowCount = Convert.ToInt32(dr["row_count"].ToString());
                }
                closeConnection();
                
                if (rowCount > 0)
                    return rowCount;
                else
                    return rowCount;
            }
            catch (SqlCeException e)
            {
                return rowCount;
            }
        }

        protected bool ifRecordExists(string col, string tbl, string val)
        {
            openConnection();
            val = val.Replace("'", "''").Replace('"', '\"');
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM "+ tbl +" WHERE "+ col +" = '"+ val +"'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
                return true;
            else
                return false;
        }

        protected bool ifRecordIsNotExists(string col, string tbl, string val)
        {
            openConnection();
            val = val.Replace("'", "''").Replace('"', '\"');
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM " + tbl + " WHERE " + col + " = '" + val + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
                return true;
            else
                return false;
        }

        protected bool ifRecordExistsOthers(int id, string col, string tbl, string val, string uniCol)
        {
            openConnection();
            val = val.Replace("'", "''").Replace('"', '\"');
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM " + tbl + " WHERE " + col + " = '" + val + "' AND " + uniCol + " NOT IN (" + id + ")", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
                return true;
            else
                return false;
        }

        protected int[] getKeyList(string col, string tbl)
        {
            int[] keyList = new int[999999];
            string query = "SELECT "+ col +" FROM "+ tbl +"";
            openConnection();
            SqlCeCommand cmd = new SqlCeCommand(query, conn);
            SqlCeDataReader dr = cmd.ExecuteReader();
            int x = 0;

            while (dr.Read())
            {
                keyList[x] = Int32.Parse(dr[col].ToString());
                x++;
            }

            closeConnection();
            return keyList;
        }

        protected bool deleteRecord(string tbl, string col, string key)
        {
            openConnection();
            string mysql = "DELETE FROM "+ tbl +" WHERE "+ col +" = '"+ key +"'";
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
