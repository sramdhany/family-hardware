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
    public partial class ListOfCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            CustomerTier ct = new CustomerTier();
            try
            {
                ds = ct.getCustomerDataSet();
            }
            catch(Exception ex)
            {
                Response.Redirect("Oops.aspx");
            }
            gvCustomer.DataSource = ds;
            gvCustomer.DataMember = "CustomerInformation";
            gvCustomer.DataBind();
        }
    }
}