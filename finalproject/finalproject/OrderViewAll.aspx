<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderViewAll.aspx.cs" Inherits="finalproject.OrderViewAllPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="divTable">
            <asp:Label ID="lblTableInformation" runat="server" Text="Order List"></asp:Label>
            <br />
            <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="appDataSource" AllowCustomPaging="True" AllowPaging="True" AllowSorting="True" CellPadding="3" CssClass="tablelist" GridLines="Horizontal" OnSelectedIndexChanged="gvOders_SelectedIndexChanged" PageSize="20" RowHeaderColumn="Id" Width="500px">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    <asp:BoundField DataField="orderdate" HeaderText="Date" SortExpression="orderdate" >
                    </asp:BoundField>
                    <asp:BoundField DataField="ordertime" HeaderText="Time" SortExpression="ordertime" />
                    <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Id" InsertVisible="False" ReadOnly="True" />
                    <asp:BoundField DataField="custId" HeaderText="Customer ID" SortExpression="custId" />
                    <asp:BoundField DataField="grandtotal" HeaderText="Grand Total" SortExpression="grandtotal" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="appDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:appdb %>" SelectCommand="SELECT * FROM [Orders]"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
