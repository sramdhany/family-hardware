using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project2.DBClasses;
using System.Data;

namespace Project2.SiteAdmin
{
    public partial class NewProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ProductTier pt = new ProductTier();
            try
            {
                ds = pt.getProductDataSet();
            }
            catch (Exception ex)
            {
                Response.Redirect("Oops.aspx");
            }
            gvProduct.DataSource = ds;
            gvProduct.DataMember = "Products";
            gvProduct.DataBind();
        }
    }
}