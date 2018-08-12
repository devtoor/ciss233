using System;

public partial class Result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && PreviousPage != null)
        {
            LblResultName.Text = PreviousPage.Name;
            LblResultEducation.Text = PreviousPage.Education;
        }
    }
}