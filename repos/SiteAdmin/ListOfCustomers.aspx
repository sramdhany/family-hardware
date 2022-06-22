<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin/Admin.Master" AutoEventWireup="true" CodeBehind="ListOfCustomers.aspx.cs" Inherits="Project2.SiteAdmin.ListOfCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Customers</h3>
    <asp:GridView ID="gvCustomer" runat="server" AllowPaging="true"></asp:GridView>
</asp:Content>
