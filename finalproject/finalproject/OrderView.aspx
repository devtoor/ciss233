<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderView.aspx.cs" Inherits="finalproject.OrderViewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <asp:Label ID="lblOrderInfo" runat="server" CssClass="label" Text="Order information"></asp:Label>
        <br />
        <br />
        <div style="text-align: right; padding-right: 20%;">
            <asp:Label ID="lblCustId" runat="server" CssClass="label" Text="Customer ID:"></asp:Label>
            <asp:TextBox ID="tbxCustId" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblName" runat="server" CssClass="label" Text="Name:"></asp:Label>
            <asp:TextBox ID="tbxName" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrder" runat="server" CssClass="label" Text="Order:"></asp:Label>
            <asp:TextBox ID="tbxOrder" runat="server" CssClass="textbox" ReadOnly="True" Height="110px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Label ID="lblDate" runat="server" CssClass="label" Text="Date:"></asp:Label>
            <asp:TextBox ID="tbxDate" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblTime" runat="server" CssClass="label" Text="Time:"></asp:Label>
            <asp:TextBox ID="tbxTime" runat="server" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblSubtotal" runat="server" CssClass="label" Text="Subtotal:"></asp:Label>
            <asp:TextBox ID="tbxSubtotal" runat="server" CssClass="resulttexbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblTax" runat="server" CssClass="label" Text="Tax:"></asp:Label>
            <asp:TextBox ID="tbxTax" runat="server" CssClass="resulttexbox" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblGrandTotal" runat="server" CssClass="label" Text="Grand Total:"></asp:Label>
            <asp:TextBox ID="tbxGrandTotal" runat="server" CssClass="resulttexbox" ReadOnly="True"></asp:TextBox>
            <br />
        </div>
    </div>
</asp:Content>
