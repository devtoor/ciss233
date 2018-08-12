using System;
using System.Linq;
using System.Web.UI;

namespace finalproject
{
    public partial class CustomerEntryPage : Page
    {
        protected void Page_Load(object sender, EventArgs e) {}

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ClearError();
            if (!FieldsIsValid()) return;
            var firstName = UppercaseFirstLetterPerWord(tbxFirstName.Text);
            var lastName = UppercaseFirstLetterPerWord(tbxLastName.Text);
            var streetAddress = UppercaseFirstLetterPerWord(tbxStreetAddress.Text);
            var city = UppercaseFirstLetterPerWord(tbxCity.Text);
            var state = UppercaseFirstLetterPerWord(tbxState.Text);
            var zipCode = tbxZipCode.Text;
            var phoneNumber = tbxPhoneNumber.Text;
            var phoneType = DDPhoneType.SelectedValue;
            DataUtilityClass.InsertCustomer(
                new Customer(firstName, lastName, streetAddress, city, state, zipCode, phoneNumber, phoneType));
            lblNotification.Visible = true;
            ClearFields();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            ClearError();
        }

        private bool FieldsIsValid()
        {
            return FirstNameIsValid() & LastNameIsValid() & StreetAddressIsValid() & CityIsValid() &
                StateIsValid() & ZipCodeIsValid() & PhoneNumberIsValid() & PhoneTypeIsValid();
        }

        private bool FirstNameIsValid()
        {
            if (string.IsNullOrEmpty(tbxFirstName.Text))
            {
                errFirstName.Text = "Required! >>";
                errFirstName.Visible = true;
                return false;
            }
            if (tbxFirstName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) return true;
            errFirstName.Text = "Not Valid! >>";
            errFirstName.Visible = true;
            return false;
        }

        private bool LastNameIsValid()
        {
            if (string.IsNullOrEmpty(tbxLastName.Text))
            {
                errLastName.Text = "Required! >>";
                errLastName.Visible = true;
                return false;
            }
            if (tbxLastName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) return true;
            errLastName.Text = "Not Valid! >>";
            errLastName.Visible = true;
            return false;
        }

        private bool StreetAddressIsValid()
        {
            if (!string.IsNullOrEmpty(tbxStreetAddress.Text)) return true;
            errStreeAddress.Text = "Required! >>";
            errStreeAddress.Visible = true;
            return false;
        }
        
        private bool CityIsValid()
        {
            if (string.IsNullOrEmpty(tbxCity.Text))
            {
                errCity.Text = "Required! >>";
                errCity.Visible = true;
                return false;
            }
            if (tbxCity.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) return true;
            errCity.Text = "Not Valid! >>";
            errCity.Visible = true;
            return false;
        }
        
        private bool StateIsValid()
        {
            if (string.IsNullOrEmpty(tbxState.Text))
            {
                errState.Text = "Required! >>";
                errState.Visible = true;
                return false;
            }
            if (tbxState.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) return true;
            errState.Text = "Not Valid! >>";
            errState.Visible = true;
            return false;
        }
        
        private bool ZipCodeIsValid()
        {
            if (string.IsNullOrEmpty(tbxZipCode.Text))
            {
                errZipCode.Text = "Required! >>";
                errZipCode.Visible = true;
                return false;
            }
            if (tbxZipCode.Text.All(char.IsDigit)) return true;
            errZipCode.Text = "Not Valid! >>";
            errZipCode.Visible = true;
            return false;
        }
        
        private bool PhoneNumberIsValid()
        {
            if (string.IsNullOrEmpty(tbxPhoneNumber.Text))
            {
                errPhoneNumber.Text = "Required! >>";
                errPhoneNumber.Visible = true;
                return false;
            }
            if (tbxPhoneNumber.Text.All(char.IsDigit)) return true;
            errPhoneNumber.Text = "Not Valid! >>";
            errPhoneNumber.Visible = true;
            return false;

        }
        
        private bool PhoneTypeIsValid()
        {
            if (DDPhoneType.SelectedIndex != 0) return true;
            errPhoneType.Text = "Required! >>";
            errPhoneType.Visible = true;
            return false;
        }

        private void ClearFields()
        {
            tbxFirstName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            tbxStreetAddress.Text = string.Empty;
            tbxCity.Text = string.Empty;
            tbxState.Text = string.Empty;
            tbxZipCode.Text = string.Empty;
            tbxPhoneNumber.Text = string.Empty;
            DDPhoneType.SelectedIndex = 0;
        }

        private void ClearError()
        {
            errFirstName.Visible = false;
            errLastName.Visible = false;
            errStreeAddress.Visible = false;
            errCity.Visible = false;
            errState.Visible = false;
            errZipCode.Visible = false;
            errPhoneNumber.Visible = false;
            errPhoneType.Visible = false;
            lblNotification.Visible = false;
        }
        
        private static string UppercaseFirstLetterPerWord(string str)
        {
            var output = str.Split().Where(s => !string.IsNullOrEmpty(s))
                .Aggregate("", (current, s) => current + (s[0].ToString().ToUpper() + s.Substring(1).ToLower() + " "));
            return output.Trim();
        }
    }
}