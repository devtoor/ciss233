<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerViewScreen.aspx.cs" Inherits="finalproject.CustomerViewScreenPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <asp:Label ID="lblCustomerInfo" runat="server" CssClass="label" Text="Customer information"></asp:Label>
        <br />
        <br />
        <div style="text-align: right; padding-right: 20%;">
            <asp:Label ID="lblId" runat="server" CssClass="label" Text="ID:"></asp:Label>
            <asp:TextBox ID="tbxId" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblFirstName" runat="server" CssClass="label" Text="Firstname:"></asp:Label>
            <asp:TextBox ID="tbxFirstName" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblLastName" runat="server" CssClass="label" Text="Lastname:"></asp:Label>
            <asp:TextBox ID="tbxLastName" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblStreetAddress" runat="server" CssClass="label" Text="Street Address:"></asp:Label>
            <asp:TextBox ID="tbxStreetAddress" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblCity" runat="server" CssClass="label" Text="City:"></asp:Label>
            <asp:TextBox ID="tbxCity" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblState" runat="server" CssClass="label" Text="State:"></asp:Label>
            <asp:TextBox ID="tbxState" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblZipCode" runat="server" CssClass="label" Text="Zip Code:"></asp:Label>
            <asp:TextBox ID="tbxZipCode" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblPhoneNumber" runat="server" CssClass="label" Text="Phone Number:"></asp:Label>
            <asp:TextBox ID="tbxPhoneNumber" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblPhoneType" runat="server" CssClass="label" Text="Phone Number Type:"></asp:Label>
            <asp:TextBox ID="tbxPhoneType" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
        </div>
    </div>
</asp:Content>
