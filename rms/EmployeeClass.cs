using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace rms
{
    class EmployeeClass : Connection
    {

        // employee form

        public bool addEmployee(string name, string fullName, string nic, string gender, string birthdate, string address, string telno, string mobileno, string email, string description, string qualification, string eduDescription, int duration, string workDescription, string epfetf, DateTime appointmentDate, string designation, string status, string officialDescription, int userID)
        {
            openConnection();
            string mysql = "INSERT INTO employee (name, full_name, nic, gender, birthdate, address, telno, mobileno, email, description, qualification, edu_description, duration, work_description, epfetf, appointment_date, designation, status, official_description, is_deleted, created_by, created_date) VALUES (@name, @fullName, @nic, @gender, @birthdate, @address, @telno, @mobileno, @email, @description, @qualification, @eduDescription, @duration, @workDescription, @epfetf, @appointmentDate, @designation, @status, @officialDescription, @isDeleted, @createdBy, GETDATE())";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@birthdate", birthdate);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@telno", telno);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@qualification", qualification);
            cmd.Parameters.AddWithValue("@eduDescription", eduDescription);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@workDescription", workDescription);
            cmd.Parameters.AddWithValue("@epfetf", epfetf);
            cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate);
            cmd.Parameters.AddWithValue("@designation", designation);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@officialDescription", officialDescription);
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

        // empupdate form

        public DataTable getEmployeeList()
        {
            openConnection();
            string mysql = "SELECT * FROM employee WHERE is_deleted = 0 ORDER BY id ASC";
            SqlCeDataAdapter da = new SqlCeDataAdapter(mysql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        Dictionary<string, string> employeeData = new Dictionary<string, string>();

        public int[] getEmployeeID()
        {
            int[] employeeIDs = getKeyList("id", "employee");
            return employeeIDs;
        }

        public Dictionary<string, string> getEmployeeData(string col, string unique)
        {
            openConnection();
            string mysql = "SELECT * FROM employee WHERE " + col + " = @unique";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@unique", unique);

            SqlCeDataReader dr = cmd.ExecuteReader();
            char[] space = {' '};
            string[] comma = {", "};

            while (dr.Read())
            {
                // Get name initi
                string splitName = dr["name"].ToString();
                string[] dividedName = splitName.Split(space);

                employeeData.Clear();

                // Adding employee data to dictionary
                employeeData.Add("initi", dividedName[0]);
                employeeData.Add("nameWithIniti", dr["name"].ToString());
                employeeData.Add("name", dr["name"].ToString().TrimStart(' ', '.', 'M', 'r', 's', 'i'));
                employeeData.Add("fullName", dr["full_name"].ToString());
                employeeData.Add("nic", dr["nic"].ToString());
                employeeData.Add("gender", dr["gender"].ToString());
                employeeData.Add("birthdate", dr["birthdate"].ToString());
                employeeData.Add("address", dr["address"].ToString());
                employeeData.Add("telno", dr["telno"].ToString());
                employeeData.Add("mobileno", dr["mobileno"].ToString());
                employeeData.Add("email", dr["email"].ToString());
                employeeData.Add("description", dr["description"].ToString());
                employeeData.Add("qualification", dr["qualification"].ToString());
                employeeData.Add("eduDescription", dr["edu_description"].ToString());
                employeeData.Add("duration", dr["duration"].ToString());
                employeeData.Add("workDescription", dr["work_description"].ToString());
                employeeData.Add("epfetf", dr["epfetf"].ToString());
                employeeData.Add("appointmentDate", dr["appointment_date"].ToString());
                employeeData.Add("designation", dr["designation"].ToString());
                employeeData.Add("status", dr["status"].ToString());
                employeeData.Add("officialDescription", dr["official_description"].ToString());
            }

            return employeeData;
        }

        public bool updateEmployee(int empID, string name, string fullName, string nic, string gender, string birthdate, string address, string telno, string mobileno, string email, string description, string qualification, string eduDescription, int duration, string workDescription, string epfetf, DateTime appointmentDate, string designation, string status, string officialDescription, int userID)
        {
            openConnection();
            string mysql = "UPDATE employee SET name = @name, full_name = @fullName, nic = @nic, gender = @gender, birthdate = @birthdate, address = @address, telno = @telno, mobileno = @mobileno, email = @email, description = @description, qualification = @qualification, edu_description = @eduDescription, duration = @duration, work_description = @workDescription, epfetf = @epfetf, appointment_date = @appointmentDate, designation = @designation, status = @status, official_description = @officialDescription, edited_by = @editedBy, edited_date = GETDATE() WHERE id = @id";
            SqlCeCommand cmd = new SqlCeCommand(mysql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@birthdate", birthdate);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@telno", telno);
            cmd.Parameters.AddWithValue("@mobileno", mobileno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@qualification", qualification);
            cmd.Parameters.AddWithValue("@eduDescription", eduDescription);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@workDescription", workDescription);
            cmd.Parameters.AddWithValue("@epfetf", epfetf);
            cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate);
            cmd.Parameters.AddWithValue("@designation", designation);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@officialDescription", officialDescription);
            cmd.Parameters.AddWithValue("@editedBy", userID);
            cmd.Parameters.AddWithValue("@id", empID);

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

        // empdelete form

        public bool deleteEmployee(string empNIC)
        {
            openConnection();
            string mysql = "UPDATE employee SET is_deleted = 1 WHERE nic = '" + empNIC + "'";
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
