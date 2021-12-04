using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Project2.CustomTypes;

namespace Project2
{
    public partial class RegistrationConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["CustomerRegistration"] != null)
            {
                CustomerClass objCustomer = (CustomerClass)Session["CustomerRegistration"];
                lblFirstName.Text = objCustomer.FirstName;
                lblLastName.Text = objCustomer.LastName;
                lblAddress.Text = objCustomer.Address;
                lblAddress2.Text = objCustomer.Address2;
                lblCity.Text = objCustomer.City;
                lblState.Text = objCustomer.State;
                lblZip.Text = objCustomer.Zip.ToString();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerRegistration.aspx");
        }
    }
}