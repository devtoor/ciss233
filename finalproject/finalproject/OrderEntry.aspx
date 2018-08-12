<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderEntry.aspx.cs" Inherits="finalproject.OrderEntryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="table">
            <div class="row">
                <div class="divProduct">
                    <asp:Image ID="Image1" runat="server" CssClass="image" ImageUrl="~/images/cheesepizza.gif" />
                    <br />
                   <asp:Label ID="Description1" runat="server" CssClass="description" Text="Cheese Pizza"></asp:Label>
                    <br />
                    <asp:Label ID="Price1" runat="server" CssClass="price" Text="Special-recipe pizza features a traditional crispy crust with a soft, tender inside that's smothered with our special herb-flavored sauce made with vine-ripened tomatoes. All topped with 100% real mozzarella, cheddar, provolone and Parmesan cheeses. $11.99"></asp:Label>
                    <br />
                    <asp:Label ID="Quatity1" runat="server" CssClass="label" Text="Quatity:"></asp:Label>
                    <asp:TextBox ID="tbxQuatity1" runat="server" CssClass="quatityTextbox" TextMode="Number">0</asp:TextBox>
                </div>
                <div class="divProduct">
                    <asp:Image ID="Image2" runat="server" CssClass="image" ImageUrl="~/images/stromboli.jpg" />
                    <br />
                    <asp:Label ID="Description2" runat="server" CssClass="description" Text="Stromboli"></asp:Label>
                    <br />
                    <asp:Label ID="Price2" runat="server" CssClass="price" Text="Our secret recipe pizza sauce, pepperoni, Italian sausage, ground beef, Italian salami, ham, bacon and our special blend of 100% fresh natural cheeses wrapped in our fresh, never frozen dough. $8.99"></asp:Label>
                    <br />
                    <asp:Label ID="Quatity2" runat="server" CssClass="label" Text="Quatity:"></asp:Label>
                    <asp:TextBox ID="tbxQuatity2" runat="server" CssClass="quatityTextbox" TextMode="Number">0</asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="divProduct">
                    <asp:Image ID="Image3" runat="server" CssClass="image" ImageUrl="~/images/hotchickenwings.jpg" />
                    <br />
                    <asp:Label ID="Description3" runat="server" CssClass="description" Text="Hot Chicken Wings (dozen)"></asp:Label>
                    <br />
                    <asp:Label ID="Price3" runat="server" CssClass="price" Text="Traditional and boneless wings, hand-spun in your favorite buffalo wild wings sauce or dry seasoning. Wings are served with your choice of Bleu Cheese, Ranch, or Lite Ranch dressing on the side. $9.99"></asp:Label>
                    <br />
                    <asp:Label ID="Quatity3" runat="server" CssClass="label" Text="Quatity:"></asp:Label>
                    <asp:TextBox ID="tbxQuatity3" runat="server" CssClass="quatityTextbox" TextMode="Number">0</asp:TextBox>
                </div>
                <div class="divProduct">
                    <asp:Image ID="Image4" runat="server" CssClass="image" ImageUrl="~/images/bbqchickenwings.png" />
                    <br />
                    <asp:Label ID="Description4" runat="server" CssClass="description" Text="BBQ Chicken Wings (dozen)"></asp:Label>
                    <br />
                    <asp:Label ID="Price4" runat="server" CssClass="price" Text="Bold, smoky, sweet and rich, this barbeque sauce has got it all. It’s all the flavors of a summer night distilled into one.  Served with cornbread and your choice of side. $9.99"></asp:Label>
                    <br />
                    <asp:Label ID="Quatity4" runat="server" CssClass="label" Text="Quatity:"></asp:Label>
                    <asp:TextBox ID="tbxQuatity4" runat="server" CssClass="quatityTextbox" TextMode="Number">0</asp:TextBox>
                </div>
            </div>
            <div class="row">
                 <div class="divProduct">
                    <asp:Image ID="Image5" runat="server" CssClass="image" ImageUrl="~/images/spaghettidinner.jpg" />
                    <br />
                    <asp:Label ID="Description5" runat="server" CssClass="description" Text="Spaghetti Dinner"></asp:Label>
                    <br />
                    <asp:Label ID="Price5" runat="server" CssClass="price" Text="Topped with our pomodoro sauce, bolognese meat sauce, meatballs or sausage. Crushed tomatoes, garlic, olive oil and basil. Add Chicken or Shrimp for an additional cost. $11.99"></asp:Label>
                    <br />
                    <asp:Label ID="Quatity5" runat="server" CssClass="label" Text="Quatity:"></asp:Label>
                    <asp:TextBox ID="tbxQuatity5" runat="server" CssClass="quatityTextbox" TextMode="Number">0</asp:TextBox>
                </div>
                <div class="divProduct">
                    <asp:Image ID="Image6" runat="server" CssClass="image" ImageUrl="~/images/salad.jpg" />
                    <br />
                    <asp:Label ID="Description6" runat="server" CssClass="description" Text="Salad"></asp:Label>
                    <br />
                    <asp:Label ID="Price6" runat="server" CssClass="price" Text="Whisk together the olive oil, vinegar, lemon juice and salt and pepper to taste in a large bowl add the cherry tomatoes, parsley and avocados to the bowl with the cod and toss to coat. Season with salt and pepper. $9.99"></asp:Label>
                    <br />
                    <asp:Label ID="Quatity6" runat="server" CssClass="label" Text="Quatity:"></asp:Label>
                    <asp:TextBox ID="tbxQuatity6" runat="server" CssClass="quatityTextbox" TextMode="Number">0</asp:TextBox>
                </div>
            </div>
            <div class="lastrow">
                <div class="divresult">
                    Order total:
                    <asp:TextBox ID="tbxOrderTotal" runat="server" CssClass="resulttexbox"></asp:TextBox>
                    <br />
                    Tax:
                    <asp:TextBox ID="tbxTax" runat="server" CssClass="resulttexbox"></asp:TextBox>
                    <br />
                    Grand total:
                    <asp:TextBox ID="tbxGrandTotal" runat="server" CssClass="resulttexbox"></asp:TextBox>
                </div>
                <div class="divresult">
                    <asp:Label ID="Label1" runat="server" CssClass="label" Text="Customer: "></asp:Label>
                    <asp:DropDownList ID="DDCustomer" runat="server" CssClass="textbox" Width="200px"></asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="btnCalculateOrder" runat="server" CssClass="button" Text="Calculate Order" OnClick="btnCalculateOrder_Click" />
                    <asp:Button ID="btnSubmit" runat="server" CssClass="button" Enabled="False" Text="Submit" OnClick="btnSubmit_Click" />
                    <br />
                    <asp:Label ID="lblNotification" runat="server" CssClass="prompt" Text="Order is successfully sumited." Visible="False"></asp:Label>
                </div>
            </div>
        </div>
        
        <br />
    </div>
</asp:Content>
