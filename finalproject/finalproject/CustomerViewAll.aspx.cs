using System;
using System.Web.UI;

namespace finalproject
{
    public partial class CustomerViewAllPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DataUtilityClass.SelectCustomerCount() == 0)
            {
                lblTableInformation.Text = "No customers have been added.";
                gvCustomers.Visible = false;
            }
            else
                lblTableInformation.Text = "Customer List";
        }

        protected void gvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("CustomerViewScreen.aspx?Id=" + gvCustomers.SelectedValue);
        }
    }
}