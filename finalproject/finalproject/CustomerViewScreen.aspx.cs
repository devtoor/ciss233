using System;
using System.Web.UI;

namespace finalproject
{
    public partial class CustomerViewScreenPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["Id"], out var id))
            {
                var customer = DataUtilityClass.SelectCustomerById(id);
                if (customer != null)
                {
                    tbxId.Text = id.ToString();
                    tbxFirstName.Text = customer.First;
                    tbxLastName.Text = customer.Last;
                    tbxStreetAddress.Text = customer.Street;
                    tbxCity.Text = customer.City;
                    tbxState.Text = customer.State;
                    tbxZipCode.Text = customer.Zip;
                    tbxPhoneNumber.Text = customer.Phone;
                    tbxPhoneType.Text = customer.PhoneType;
                }
                else
                    Response.Redirect("CustomerViewAll.aspx");
            }
            else
                Response.Redirect("CustomerViewAll.aspx");
        }
    }
}