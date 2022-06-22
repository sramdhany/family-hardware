/*CustomerInformation.cs is from the Data Tier in ASP .NET file included in Lesson 6, which is basically CustomerTier.cs from
  Lesson 7 w/o the function getSqlDataReader()*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.ProviderBase;
using System.Configuration;

namespace Project2.DBClasses   
{
    public class CustomerInformation
    {
        private String _ConnectionString;

        public CustomerInformation()
        {
            this._ConnectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
        }

        public String ConnectionString
        {
            get
            {
                return this._ConnectionString;
            }
            set
            {
                this._ConnectionString = value;
            }
        }

        public DataSet getDataSet()  //Sends data from Data Tier to Presentation Tier
        {
            DataSet ds;
            SqlDataAdapter da;
            String Query;
            Query = "SELECT * FROM CustomerInformation;";

            da = new SqlDataAdapter(Query, this.ConnectionString);
            ds = new DataSet();
                
            try
            {
                da.Fill(ds);
            }
            catch(SqlException ex)  //i.e. Failed connection
            {
                throw new Exception("Error with filling DataSet " + ex.Message);
            }

            return ds;
        }

        public Boolean insertCustomer(String FirstName, String MiddleName, String LastName, String Address, String Address2, String City, String State, int Zip)
        {
            Boolean Success = false;
            int rows;
            String query;
            SqlConnection conn;
            SqlCommand cmd;

            query = "INSERT INTO CustomerInformation (FirstName, MiddleName, LastName, Address, Address2, State, City, Zip) VALUES(@FirstName, @MiddleName, @LastName, @Address, @Address2, @City, @State, @Zip);";

            //Create a connection and a commmand object
            conn = new SqlConnection(this.ConnectionString);
            cmd = new SqlCommand(query, conn);

            //Place the values passed into this function into the parameters of the query
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = FirstName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar, 50).Value = MiddleName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = LastName;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar, 50).Value = Address;
            cmd.Parameters.Add("@Address2", SqlDbType.VarChar, 50).Value = Address2;
            cmd.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = City;
            cmd.Parameters.Add("@Zip", SqlDbType.Int).Value = Zip;

            //Exception handling
            try
            {
                //Open a connection string to DB
                conn.Open();
                //Execute query
                rows = cmd.ExecuteNonQuery();
                if (rows <= 0)
                {
                    Success = false;
                }
                else
                {
                    Success = true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return Success;
        }

        public Boolean updateCustomer(int CustID, String FirstName, String MiddleName, String LastName, String Address, String Address2, String City, String State, int Zip)
        {
            Boolean Success = false;
            String Query;
            SqlConnection conn;
            SqlCommand cmd;
            int rows;

            Query = "UPDATE CustomerInformation SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Address = @Address, Address2 = @Address2, City = @City, State = @State, Zip = @Zip WHERE CustID = @CustID;";

            conn = new SqlConnection(this.ConnectionString);
            cmd = new SqlCommand(Query, conn);

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = FirstName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar, 50).Value = MiddleName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = LastName;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar, 50).Value = Address;
            cmd.Parameters.Add("@Address2", SqlDbType.VarChar, 50).Value = Address2;
            cmd.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = City;
            cmd.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = State;
            cmd.Parameters.Add("@Zip", SqlDbType.Int).Value = Zip;
            cmd.Parameters.Add("@CustID", SqlDbType.Int).Value = CustID;

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
                if (rows <= 0)
                {
                    Success = false;
                }
                else
                {
                    Success = true;
                }
            }
            catch (SqlException ex)
            {
                throw new DuplicateNameException(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return Success;
        }

        public Boolean deleteCustomer(int CustID)
        {
            Boolean Success = false;
            String Query;
            SqlConnection conn;
            SqlCommand cmd;
            int rows;

            Query = "DELETE FROM CustomerInformation WHERE CustID = @CustID;";

            conn = new SqlConnection(this.ConnectionString);
            cmd = new SqlCommand(Query, conn);

            cmd.Parameters.Add("@CustID", SqlDbType.Int).Value = CustID;

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
                if (rows <= 0)
                {
                    Success = false;
                }
                else
                {
                    Success = true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return Success;
        }
    }
}