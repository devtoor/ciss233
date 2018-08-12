using System;
using System.Linq;

public partial class MainForm : System.Web.UI.Page
{
    public string Name => UppercaseFirstLetterPerWord(TBLastName.Text) + 
                          ", " + UppercaseFirstLetterPerWord(TBFirstName.Text);

    public string Education => DDEducation.SelectedValue;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ClearErrors();
        }
    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        ClearErrors();
        if (FirstNameIsValid() & LastNameIsValid() & EducationIsValid())
        {
            Server.Transfer("Result.aspx");
        }
    }

    protected void BtnReset_Click(object sender, EventArgs e)
    {
        ClearErrors();
        ClearFields();
    }

    private bool FirstNameIsValid()
    {
        if (string.IsNullOrEmpty(TBFirstName.Text) ||
            TBFirstName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) == false)
        {
            LblFirstNameError.Visible = true;
            return false;
        }
        return true;
    }

    private bool LastNameIsValid()
    {
        if (string.IsNullOrEmpty(TBLastName.Text) ||
            TBLastName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) == false)
        {
            LblLastNameError.Visible = true;
            return false;
        }
        return true;
    }

    private bool EducationIsValid()
    {
        if (DDEducation.SelectedIndex == 0)
        {
            LblEducationError.Visible = true;
            return false;
        }
        return true;
    }

    private void ClearErrors()
    {
        LblFirstNameError.Visible = false;
        LblLastNameError.Visible = false;
        LblEducationError.Visible = false;
    }

    private void ClearFields()
    {
        TBFirstName.Text = string.Empty;
        TBLastName.Text = string.Empty;
        DDEducation.SelectedIndex = 0;
    }

    private static string UppercaseFirstLetterPerWord(string str)
    {
        var output = str.Split().Where(s => !string.IsNullOrEmpty(s))
            .Aggregate("", (current, s) => current + (s[0].ToString().ToUpper() + s.Substring(1).ToLower() + " "));

        return output.Trim();
    }
}