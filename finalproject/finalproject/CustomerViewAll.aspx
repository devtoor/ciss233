<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerViewAll.aspx.cs" Inherits="finalproject.CustomerViewAllPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="divTable">
            <asp:Label ID="lblTableInformation" runat="server" Text="Customer List"></asp:Label>
            <br />
            <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="appDataSource" AllowCustomPaging="True" AllowPaging="True" AllowSorting="True" CellPadding="3" CssClass="tablelist" GridLines="Horizontal" OnSelectedIndexChanged="gvCustomers_SelectedIndexChanged" PageSize="20" RowHeaderColumn="Id" Width="450px">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="Id" >
                    </asp:BoundField>
                    <asp:BoundField DataField="first" HeaderText="First Name" SortExpression="first" />
                    <asp:BoundField DataField="last" HeaderText="Last Name" SortExpression="last" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="appDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:appdb %>" SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
