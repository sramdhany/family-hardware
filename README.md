# Family Hardware

This repository contains files used to create an online hardware store for my Web Application Development course

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
