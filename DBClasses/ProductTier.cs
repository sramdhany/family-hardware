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
{
    public class ProductTier  //Can build more attributes and methods
    {
        public string connectionString { get; set; }

        public ProductTier()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
        }

        #region get or accessor methods for the product tier

        public DataSet getProductDataSet()
        {
            DataSet ds;
            SqlConnection conn;
            string query;
            SqlDataAdapter da;
            //DataSet ds;

            query = "SELECT * FROM Products;";

            conn = new SqlConnection(connectionString);
            da = new SqlDataAdapter(query, conn);

            ds = new DataSet();

            try
            {
                da.Fill(ds, "Products");  //DataSet can have more than 1 table
            }
            catch (SqlException ex)
            {
                throw new Exception("Error with getting Product DataSet ", ex);
                //If ASP .NET web app, redirect to Oops.aspx.  However, if Windows application, do the above
            }
            /*  Commented out b/c this complicates things
            finally
            {
                conn.Close();  //DataAdapter usually closes
                da.Dispose();  //We are done using the dataset, so we can dispose it.  
            }
            */

            return ds;
        }

        public byte[] getProductImage(int productID)
        {
            byte[] theImage = null;

            return theImage;
        }

        #endregion

        public bool insertProduct(string productDescription, string productName, float productPrice, int quantityOnHand, int departmentID, int categoryID, byte[] productImage = null)  
        //Has default parameter
        {
            bool success = false;
            SqlConnection conn;
            SqlCommand cmd;
            string query;
            int rows;

            //All clauses in uppercase for readability
            //VALUES is parameters
            //Semicolon at end of query
            //Change query to UPDATE instead of INSERT
            query = "INSERT INTO Products (ProductDescription, ProductName, ProductPrice, QuantityOnHand, DepartmentID, CategoryID, ProductImage) " +
                "VALUES(@DESC,@NAMES,@PRICE,@Quantity,@DeptID,@CatID,@Image);";

            //Instantiate the connection object
            conn = new SqlConnection(connectionString);
            //Command will grab the connection and execute the query
            cmd = new SqlCommand(query, conn);

            //Add product ID
            cmd.Parameters.Add("@DESC", SqlDbType.VarChar, 300).Value = productDescription;
            cmd.Parameters.Add("@NAMES", SqlDbType.VarChar, 50).Value = productName;
            cmd.Parameters.Add("@PRICE", SqlDbType.Float).Value = productPrice;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantityOnHand;
            cmd.Parameters.Add("@DeptID", SqlDbType.Int).Value = departmentID;
            cmd.Parameters.Add("@CatID", SqlDbType.Int).Value = categoryID;
            if (productImage == null)
            {
                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = productImage;
            }

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
                throw new Exception("Error inserting product", ex);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }

        //Complete update for hw / asmgt
        public bool updateProduct(int productID, string productDescription, string productName, float productPrice, int quantityOnHand, int departmentID, int categoryID, byte[] productImage = null)
        //Has default parameter
        //Exactly like insert function (like on the slides).  Except add productID.  Insert uses INSERT keyword.  Update uses UPDATE keyword in query.  
        //  Everything else is exactly the same.
        {
            bool success = false;
            SqlConnection conn;
            SqlCommand cmd;
            string query;
            int rows;

            //Change query to UPDATE instead of INSERT
            query = "UPDATE Products SET ProductID = @productID, ProductDescription = @productDescription, ProductName = @productName, ProductPrice = @productPrice, QuantityOnHand = @QuantityOnHand, DepartmentID = @departmentID, CategoryID = @categoryID, ProductImage = @productImage; ";

            //Instantiate the connection object
            conn = new SqlConnection(connectionString);
            //Command will grab the connection and execute the query
            cmd = new SqlCommand(query, conn);

            //Add product ID
            cmd.Parameters.Add("@productID", SqlDbType.Int).Value = productID;
            cmd.Parameters.Add("@DESC", SqlDbType.VarChar, 300).Value = productDescription;
            cmd.Parameters.Add("@NAMES", SqlDbType.VarChar, 50).Value = productName;
            cmd.Parameters.Add("@PRICE", SqlDbType.Float).Value = productPrice;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantityOnHand;
            cmd.Parameters.Add("@DeptID", SqlDbType.Int).Value = departmentID;
            cmd.Parameters.Add("@CatID", SqlDbType.Int).Value = categoryID;
            if (productImage == null)
            {
                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = productImage;
            }

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
                throw new Exception("Error inserting product", ex);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }

        public bool deleteProduct(int productID)
        {
            bool success = false;
            int rows;
            SqlConnection conn;
            SqlCommand cmd;
            string query;

            //Only 1 row should delete b/c you are using the primary key
            query = "DELETE FROM Products WHERE ProductID = @ID;";

            conn = new SqlConnection(connectionString);

            cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = productID;

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
                throw new Exception("Error deleting product ", ex);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }

    }
}