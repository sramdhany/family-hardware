using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Project2.CustomTypes;
using Project2.DBClasses;
//using CustomerDataTierExample.DBClasses;

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
                lblMiddleName.Text = objCustomer.MiddleName;
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerTier ct = new CustomerTier();
            CustomerClass objCustomer = (CustomerClass)Session["CustomerRegistration"];

            try
            {
                ct.insertCustomer(objCustomer.FirstName, objCustomer.MiddleName, objCustomer.LastName, objCustomer.Address, objCustomer.Address2, objCustomer.City, objCustomer.State, objCustomer.Zip);

            }
            catch (Exception ex)
            {
                Response.Redirect("Oops.aspx");
            }

            Response.Redirect("ThankYou.aspx");
        }
    }
}