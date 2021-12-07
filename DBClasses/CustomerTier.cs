using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;


namespace Project2.DBClasses
//namespace CustomerDataTierExample.DBClasses
{
    public class CustomerTier
    {
        public string connectionString { get; set; }  //Attribute

        public CustomerTier()  //Constructor
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
        }

        public DataSet getCustomerDataSet()
        {
            DataSet ds;
            SqlDataAdapter da;
            string query = "SELECT * FROM CustomerInformation;";

            da = new SqlDataAdapter(query, connectionString);
            ds = new DataSet();

            try
            {
                da.Fill(ds, "CustomerInformation");
            }
            catch (SqlException ex)
            {
                throw new Exception("Error with filling DataSet " + ex.Message);
            }

            return ds;
        }

        public SqlDataReader getCustomerDataReader()  //For ASP .NET
        {
            SqlDataReader reader;
            SqlConnection conn;
            SqlCommand cmd;
            string query = "SELECT * FROM CustomerInformation;";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error filling reader " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return reader;
        }

        public bool insertCustomer(string firstName, string middleName, string lastName, string address, string address2, string city, string state, int zip)
        {
            int rows;
            bool success = false;
            string query;
            SqlConnection conn;
            SqlCommand cmd;

            query = "INSERT INTO CustomerInformation (FirstName, MiddleName, LastName, Address, Address2, City, State, Zip) " +
                    "VALUES (@firstName, @middleName, @lastName, @address, @address2, @city, @state, @zip);";
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 50).Value = firstName;

            //This if statement will check to see if the string is empty.  If the string is empty
            //a null value is inserted into the DB.
            if (string.IsNullOrEmpty(middleName))
            {
                cmd.Parameters.Add("@middleName", SqlDbType.VarChar, 50).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@middleName", SqlDbType.VarChar, 50).Value = middleName;
            }

            cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 50).Value = lastName;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = address;

            if (string.IsNullOrEmpty(address2))
            {
                cmd.Parameters.Add("@address2", SqlDbType.VarChar, 50).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@address2", SqlDbType.VarChar, 50).Value = address2;
            }

            cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = city;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 50).Value = state;
            cmd.Parameters.Add("@zip", SqlDbType.Int).Value = zip;

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error inserting record " + ex.Message);
            }
            finally { conn.Close(); }
            return success;
        }

        public bool updateCustomer(int custID, string firstName, string middleName, string lastName, string address, string address2, string city, string state, string zip)
        {
            int rows;
            bool success = false;
            string query;
            SqlConnection conn;
            SqlCommand cmd;

            query = "UPDATE CustomerInformation SET FirstName = @firstName, " +
                    "MiddleName = @middleName, LastName = @lastName, " +
                    "Address = @address, Address2 = @address2, City = @city, " +
                    "State = @state, Zip = @zip " +
                    "WHERE CustID = @custID;";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@custID", SqlDbType.Int).Value = custID;
            cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 50).Value = firstName;
            cmd.Parameters.Add("@middleName", SqlDbType.VarChar, 50).Value = middleName;
            cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 50).Value = lastName;
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = address;
            cmd.Parameters.Add("@address2", SqlDbType.VarChar, 50).Value = address2;
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = city;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 50).Value = state;
            cmd.Parameters.Add("@zip", SqlDbType.Int).Value = zip;

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error inserting record " + ex.Message);
            }
            finally { conn.Close(); }
            return success;
        }

        public bool deleteCustomer(int custID)
        {
            bool success = false;
            SqlConnection conn;
            SqlCommand cmd;
            string query;
            int row;

            query = "DELETE FROM CustomerInformation WHERE CustID = @custID;";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@custID", SqlDbType.Int).Value = custID;

            try
            {
                conn.Open();
                row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    success = true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error deleting customer " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }
    }
}