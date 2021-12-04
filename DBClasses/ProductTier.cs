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
    public class ProductTier
    {
        public string connectionString { get; set; }

        public ProductTier()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
        }

        public DataSet getProductDataSet()
        {
            DataSet ds;

            return ds;
        }

        public bool insertProduct()
        {

        }

    }
}
