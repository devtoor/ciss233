<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerEntry.aspx.cs" Inherits="finalproject.CustomerEntryPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <asp:Label ID="lblCustomerInfo" runat="server" CssClass="label" Text="Enter customer information"></asp:Label>
        <br />
        <br />
        <div style="text-align: right; padding-right: 10%;">
            <asp:Label ID="errFirstName" runat="server" CssClass="error" Text="Required &gt;&gt;" Visible="False"></asp:Label>
            <asp:Label ID="lblFirstName" runat="server" CssClass="label" Text="Firstname:"></asp:Label>
            <asp:TextBox ID="tbxFirstName" runat="server" CssClass="textbox"></asp:TextBox>
            <br />
            <asp:Label ID="errLastName" runat="server" CssClass="error" Text="Required &gt;&gt;" Visible="False"></asp:Label>
            <asp:Label ID="lblLastName" runat="server" CssClass="label" Text="Lastname:"></asp:Label>
            <asp:TextBox ID="tbxLastName" runat="server" CssClass="textbox"></asp:TextBox>
            <br />
            <asp:Label ID="errStreeAddress" runat="server" CssClass="error" Text="Required &gt;&gt;" Visible="False"></asp:Label>
            <asp:Label ID="lblStreetAddress" runat="server" CssClass="label" Text="Street Address:"></asp:Label>
            <asp:TextBox ID="tbxStreetAddress" runat="server" CssClass="textbox"></asp:TextBox>
            <br />
            <asp:Label ID="errCity" runat="server" CssClass="error" Text="Required &gt;&gt;" Visible="False"></asp:Label>
            <asp:Label ID="lblCity" runat="server" CssClass="label" Text="City:"></asp:Label>
            <asp:TextBox ID="tbxCity" runat="server" CssClass="textbox"></asp:TextBox>
            <br />
            <asp:Label ID="errState" runat="server" CssClass="error" Text="Required &gt;&gt;" Visible="False"></asp:Label>
            <asp:Label ID="lblState" runat="server" CssClass="label" Text="State:"></asp:Label>
            <asp:TextBox ID="tbxState" runat="server" CssClass="textbox"></asp:TextBox>
            <br />
            <asp:Label ID="errZipCode" runat="server" CssClass="error" Text="Required &gt;&gt;" Visible="False"></asp:Label>
            <asp:Label ID="lblZipCode" runat="server" CssClass="label" Text="Zip Code:"></asp:Label>
            <asp:TextBox ID="tbxZipCode" runat="server" CssClass="textbox"></asp:TextBox>
            <br />
            <asp:Label ID="errPhoneNumber" runat="server" CssClass="error" Text="Required &gt;&gt;" Visible="False"></asp:Label>
            <asp:Label ID="lblPhoneNumber" runat="server" CssClass="label" Text="Phone Number (XXXXXXXXXX format):"></asp:Label>
            <asp:TextBox ID="tbxPhoneNumber" runat="server" CssClass="textbox" TextMode="Phone"></asp:TextBox>
            <br />
            <asp:Label ID="errPhoneType" runat="server" CssClass="error" Text="Required &gt;&gt;" Visible="False"></asp:Label>
            <asp:Label ID="lblPhoneType" runat="server" CssClass="label" Text="Phone Number Type:"></asp:Label>
            <asp:DropDownList ID="DDPhoneType" runat="server" CssClass="textbox" Height="28px" Width="315px">
                <asp:ListItem>Choose a type</asp:ListItem>
                <asp:ListItem>Home</asp:ListItem>
                <asp:ListItem>Mobile</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnClear" runat="server" CssClass="button" Text="Clear" OnClick="btnClear_Click" TabIndex="1" />
            <asp:Button ID="btnAddCustomer" runat="server" CssClass="button" OnClick="btnAddCustomer_Click" Text="Add Customer" />
            <br />
            <asp:Label ID="lblNotification" runat="server" CssClass="prompt" Text="Customer is successfully added." Visible="False"></asp:Label>
        </div>
    </div>
</asp:Content>
