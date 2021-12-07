<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin/Admin.Master" AutoEventWireup="true" CodeBehind="NewProducts.aspx.cs" Inherits="Project2.SiteAdmin.NewProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
            <tr><td><h3>New Products</h3></td></tr>
            <tr><td><strong><asp:Label ID="lblProductDescription" runat="server" Text="Product Description"></asp:Label></strong></td></tr>
            <tr><td><asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox></td></tr>
            <tr><td><strong><asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label></strong></td></tr>
            <tr><td><asp:TextBox ID="txtProductName" runat="server"></asp:TextBox></td></tr>
            <tr><td><strong><asp:Label ID="lblProductPrice" runat="server" Text="Product Price"></asp:Label></strong></td></tr>
            <tr><td><asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox></td></tr>
            <tr><td><strong><asp:Label ID="lblQuantityOnHand" runat="server" Text="Quantity on Hand"></asp:Label></strong></td></tr>
            <tr><td><asp:TextBox ID="txtQuantityOnHand" runat="server"></asp:TextBox></td></tr>
            <tr><td><strong><asp:Label ID="lblProductImage" runat="server" Text="Product Image"></asp:Label></strong></td></tr>
            <tr><td><asp:TextBox ID="txtProductImage" runat="server"></asp:TextBox></td></tr>
        </table>
    </div>
    <asp:GridView ID="gvProduct" runat="server" AllowPaging="true"></asp:GridView>
</asp:Content>
