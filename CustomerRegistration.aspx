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
