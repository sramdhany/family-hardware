using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Project2.CustomTypes;

namespace Project2
{
    public partial class CustomerRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void resetForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int zipCode;
            CustomerClass objCustomer = new CustomTypes.CustomerClass();
            objCustomer.FirstName = txtFirstName.Text;
            objCustomer.LastName = txtLastName.Text;
            objCustomer.Address = txtAddress.Text;
            objCustomer.Address2 = txtAddress2.Text;
            objCustomer.City = txtCity.Text;
            objCustomer.State = txtState.Text;
            try
            {
                zipCode = int.Parse(txtZip.Text);
                objCustomer.Zip = zipCode;
            }
            catch (FormatException ex)
            {
                throw new FormatException("Error with Zip Code: " + ex.Message);
            }
            Session["CustomerRegistration"] = objCustomer;
            Response.Redirect("RegistrationConfirmation.aspx");
        }
    }
}