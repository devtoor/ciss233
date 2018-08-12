<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainForm.aspx.cs" Inherits="MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 6</title>
    <link href="styles/styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="FrmEducation" runat="server">
        <div>
            <h1>Education Survey</h1>
        </div>
        <asp:Label ID="LblFirstName" runat="server" Text="Enter your first name: "></asp:Label>
        <asp:TextBox ID="TBFirstName" runat="server" Height="16px"></asp:TextBox>
&nbsp;
        <asp:Label ID="LblFirstNameError" runat="server" Font-Bold="False" Text="Please enter a first name!!!" CssClass="error" Font-Italic="True"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblLastName" runat="server" Text="Enter your last name: "></asp:Label>
        <asp:TextBox ID="TBLastName" runat="server"></asp:TextBox>
&nbsp;
        <asp:Label ID="LblLastNameError" runat="server" Font-Bold="False" Text="Please enter a last name!!!" CssClass="error" Font-Italic="True"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblEducation" runat="server" Text="Enter your highest level of education: "></asp:Label>
        <asp:DropDownList ID="DDEducation" runat="server">
            <asp:ListItem Selected="True">Please choose a level of education...</asp:ListItem>
            <asp:ListItem>High school</asp:ListItem>
            <asp:ListItem>Some college</asp:ListItem>
            <asp:ListItem>Associate&#39;s degree</asp:ListItem>
            <asp:ListItem>Bachelor&#39;s</asp:ListItem>
            <asp:ListItem>Master&#39;s</asp:ListItem>
            <asp:ListItem>PHD</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="LblEducationError" runat="server" Font-Bold="False" Text="Please enter an education level!!!" CssClass="error" Font-Italic="True"></asp:Label>
        <br />
        <br />
        <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" />
&nbsp;
        <button id="BtnReset" runat="server" OnServerClick="BtnReset_Click">Reset</button></form>
</body>
</html>
