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
