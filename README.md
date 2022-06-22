# Family Hardware

This repository contains files used to create an online hardware store for my Web Application Development course

## Homepage

![](screenshots/homepage.png)


## Master Page

This site uses a master page

### Site.Master

```html
<%@ Master Language="C#" AutoEventWireup="true" CodeBehind="Site.master.cs" Inherits="Project2.Site" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Family Hardware</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <asp:ContentPlaceHolder ID="head" runat="server"/>
</head>
<body>

        <div class="container">
            <div class="jumbotron text-center">
                <h1>Family Hardware</h1>
            </div>
            <nav class="nav navbar-light" style="background-color:#e3f2fd;">
                <div class="container-fluid text-center">
                    <%-- 
                    <div class="navbar-header">
                        <a class="navbar-brand" href="#"></a>
                    </div>
                    --%>
                    <ul class="nav navbar-nav">
                        <li><a href="Default.aspx">Home</a></li>
                        <li><a href="About.aspx">About</a></li>
                        <li><a href="Contact.aspx">Contact</a></li>
                        <li><a href="CustomerRegistration.aspx">Register</a></li>
                    </ul>
                </div>
            </nav>
                
            <asp:ContentPlaceHolder ID="body" runat="server" />
        </div>
</body>
</html>
```

### Default.aspx

```aspx
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project2.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>Welcome!</h2>
</asp:Content>
```

### About.aspx

```aspx
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Project2.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>About</h2>
    Family Hardware online is a convenient location for you to browse our merchandise.
</asp:Content>
```

### Contact

```aspx
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Project2.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>Contact</h2>
    24 Stuart Ave, Garden City, New York 11530
    <br>
    Phone. 555-555-5555
    <br>
    <a href="mailto:<% =ConfigurationManager.AppSettings["SiteManager"] %>"><% =ConfigurationManager.AppSettings["SiteManager"] %></a>
</asp:Content>
```

### Web.Config

```html
<?xml version="1.0"?>
<!--
  For more information on how to configure your ASP.NET application, please visit
  https://go.microsoft.com/fwlink/?LinkId=169433
  -->
<configuration>
  <!--
    For a description of web.config changes see http://go.microsoft.com/fwlink/?LinkId=235367.

    The following attributes can be set on the <httpRuntime> tag.
      <system.Web>
        <httpRuntime targetFramework="4.8" />
      </system.Web>
  -->
  <system.web>
    <compilation debug="true" targetFramework="4.8"/>
    <httpRuntime targetFramework="4.6.1"/>
  </system.web>
  <appSettings>
    <add key="SiteManager" value="support@familyHardware.com"/>
    <add key="ValidationSettings:UnobtrusiveValidationMode" value="None"/>
  </appSettings>
  <connectionStrings>
    <add name="MyData" connectionString="Data Source=10.22.12.71; Initial Catalog=HardwareStore; User ID=Student1; Password=CSC283;" providerName="System.Data.SqlClient"/>
  </connectionStrings>
  <system.codedom>
    <compilers>
      <compiler language="c#;cs;csharp" extension=".cs" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:default /nowarn:1659;1699;1701"/>
      <compiler language="vb;vbs;visualbasic;vbscript" extension=".vb" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.VBCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:default /nowarn:41008 /define:_MYTYPE=\&quot;Web\&quot; /optionInfer+"/>
    </compilers>
  </system.codedom>
</configuration>
```
### CustomerRegistration.aspx

```aspx
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerRegistration.aspx.cs" Inherits="Project2.CustomerRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <form id="frmCustomerRegistration" runat="server">
        <div class="panel-heading">
            <h2>Customer Registration</h2>
        </div>
        <div class="panel-body">
            <div class="form-group">
                <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Please enter a First Name" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <strong><label>First Name:</label></strong>
                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
                <strong><label>Middle Name:</label></strong>
                <asp:TextBox ID="txtMiddleName" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Please enter a Last Name" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <strong><label>Last Name:</label></strong>
                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Please enter an Address" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <strong><label>Address:</label></strong>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
                <strong><label>Apt/Suite:</label></strong>
                <asp:TextBox ID="txtAddress2" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="Please enter a City" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <strong><label>City:</label></strong>
                <asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvState" runat="server" ControlToValidate="txtState" ErrorMessage="Please enter a State" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <strong><label>State:</label></strong>
                <asp:TextBox ID="txtState" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvZip" runat="server" ControlToValidate="txtZip" ErrorMessage="Please enter a Zip Code" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <strong><label>Zip:</label></strong>
                <asp:TextBox ID="txtZip" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-success" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" CssClass="btn btn-success" CausesValidation="false" />
            </div>
            <div>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="BulletList" ShowSummary="true" HeaderText="Please fix the following errors" ForeColor="Red" />
            </div>
        </div>
            </form>
</asp:Content>
```

### Customer Registration.aspx.cs

```cs
//Event handlers including submit button
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Project2.CustomTypes;
using Project2.DBClasses;  //For CustomerTier.cs

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
            txtMiddleName.Text = "";
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
            objCustomer.MiddleName = txtMiddleName.Text;
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
```

### CustomerClass.cs

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2.CustomTypes
{
    public class CustomerClass
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public CustomerClass()
        {
            FirstName = "";
            MiddleName = "";
            LastName = "";
            Address = "";
            Address2 = "";
            City = "";
            State = "";
            Zip = 0;
        }
    }
}
```

### RegistrationConfirmation.aspx
```aspx
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrationConfirmation.aspx.cs" Inherits="Project2.RegistrationConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <form id="frmRegistrationConfirmation" runat="server">
    <br />
    <h2>Registration Confirmation</h2>
    <div class="panel-body">
        <div class="form-group">
            <strong><label>First Name:</label></strong>
            <asp:Label ID="lblFirstName" runat="server"></asp:Label>
            <br />
            <strong><label>Middle Name:</label></strong>
            <asp:Label ID ="lblMiddleName" runat="server"></asp:Label>
            <br />
            <strong><label>Last Name:</label></strong>
            <asp:Label ID="lblLastName" runat="server"></asp:Label>
            <br />
            <strong><label>Address:</label></strong>
            <asp:Label ID="lblAddress" runat="server"></asp:Label>
            <br />
            <strong><label>Apt/Suite:</label></strong>
            <asp:Label ID="lblAddress2" runat="server"></asp:Label>
            <br />
            <strong><label>City:</label></strong>
            <asp:Label ID="lblCity" runat="server"></asp:Label>
            <br />
            <strong><label>State:</label></strong>
            <asp:Label ID="lblState" runat="server"></asp:Label>
            <br />
            <strong><label>Zip Code:</label></strong>
            <asp:Label ID="lblZip" runat="server"></asp:Label>
        </div>
    </div>
    <div class="text-center">
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </div>
        </form>
</asp:Content>
```

### RegistrationConfirmation.aspx.cs

```aspx
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
```

### CustomerTier.cs

```cs
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
```
