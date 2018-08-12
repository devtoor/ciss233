using System;
using System.Web.UI;

namespace finalproject
{
    public partial class OrderViewAllPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DataUtilityClass.SelectOrderCount() == 0)
            {
                lblTableInformation.Text = "No orders have been added.";
                gvOrders.Visible = false;
            }
            else
                lblTableInformation.Text = "Order List";
        }

        protected void gvOders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("OrderView.aspx?Id=" + gvOrders.SelectedValue.ToString());
        }
    }
}