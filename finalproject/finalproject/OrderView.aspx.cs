using System;
using System.Web.UI;

namespace finalproject
{
    public partial class OrderViewPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["Id"], out var id))
            {
                var order = DataUtilityClass.SelectOrderById(id);
                var customer = DataUtilityClass.SelectCustomerById(order.CustId);
                if (customer != null)
                {
                    tbxCustId.Text = customer.Id.ToString();
                    tbxName.Text = customer.First + " " + customer.Last;
                    tbxOrder.Text = "";
                    tbxOrder.Text += order.Prod1Qty > 0 ? order.Prod1Qty + "  Cheese Pizza $11.99 ea\n" : "";
                    tbxOrder.Text += order.Prod2Qty > 0 ? order.Prod2Qty + "  Stromboli $8.99 ea\n" : "";
                    tbxOrder.Text += order.Prod3Qty > 0 ? order.Prod3Qty + "  Hot Chicken Wings (dozen) $9.99 ea\n" : "";
                    tbxOrder.Text += order.Prod4Qty > 0 ? order.Prod4Qty + "  BBQ Chicken Wings (dozen) $9.99 ea\n" : "";
                    tbxOrder.Text += order.Prod5Qty > 0 ? order.Prod5Qty + "  Spaghetti Dinner $11.99 ea\n" : "";
                    tbxOrder.Text += order.Prod6Qty > 0 ? order.Prod6Qty + "  Salad $9.99 ea" : "";
                    tbxDate.Text = order.OrderDate;
                    tbxTime.Text = order.OrderTime;
                    tbxSubtotal.Text = order.SubTotal.ToString("C");
                    tbxTax.Text = order.TaxAmt.ToString("C");
                    tbxGrandTotal.Text = order.GrandTotal.ToString("C");
                }
                else
                    Response.Redirect("CustomerViewAll.aspx");
            }
            else
                Response.Redirect("CustomerViewAll.aspx");
        }
    }
}