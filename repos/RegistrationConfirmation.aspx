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
