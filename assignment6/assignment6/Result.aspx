<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Result" %>
<%@ PreviousPageType VirtualPath="~/MainForm.aspx" %> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 6</title>
    <link href="styles/styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Survey Results:</h1>
            <p>
                Name:
                <asp:Label ID="LblResultName" runat="server" CssClass="result"></asp:Label>
            </p>
            <p>
                Education level:
                <asp:Label ID="LblResultEducation" runat="server" CssClass="result"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
