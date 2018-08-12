// CISS 233-300: Project 04
// Author:   Jay Morales
// Date:     03/02/2018
// Project:  Customer Display Windows Form Project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project06CustomerEntry
{
    public partial class FrmCustomerEntry : Form
    {
        private readonly List<ClassCustomer> customer;
        
        // constructor
        public FrmCustomerEntry()
        {
            InitializeComponent();
            customer = new List<ClassCustomer>();
            CbxState.SelectedIndex = 0;
        }

        #region form validations

        // validate the first name input
        private bool FirstNameIsValid(out string firstName)
        {
            firstName = TbxFirstName.Text;
            
            if (string.IsNullOrEmpty(firstName))
            {
                LblErrFirstName.Text = @"Please enter a firstname";
                return false;
            }

            if (firstName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) == false)
            {
                LblErrFirstName.Text = @"Please enter a valid name";
                return false;
            }

            firstName = UppercaseFirstLetterPerWord(firstName);
            return true;
        }
        
        // validate the last name input
        private bool LastNameIsValid(out string lastName)
        {
            lastName = TbxLastName.Text;

            if (string.IsNullOrEmpty(lastName))
            {
                LblErrLastName.Text = @"Please enter a lastname";
                return false;
            }

            if (lastName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) == false)
            {
                LblErrLastName.Text = @"Please enter a valid name";
                return false;
            }

            lastName = UppercaseFirstLetterPerWord(lastName);
            return true;
        }

        // validate the address input
        private bool AddressIsValid(out string address)
        {
            if (string.IsNullOrEmpty(TbxStreetAddress.Text))
            {
                LblErrStreetAddress.Text = @"Please enter an address";
                address = string.Empty;
                return false;
            }

            address = UppercaseFirstLetterPerWord(TbxStreetAddress.Text);
            return true;
        }

        // validate the city input
        private bool CityIsValid(out string city)
        {
            if (string.IsNullOrEmpty(TbxCity.Text))
            {
                LblErrCity.Text = @"Please enter a city";
                city = string.Empty;
                return false;
            }

            city = UppercaseFirstLetterPerWord(TbxCity.Text);
            return true;
        }
        
        // validate the state input
        private bool StateIsValid(out string state)
        {
            if (CbxState.Text == (string)CbxState.Items[0])
            {
                LblErrState.Text = @"Please choose a state";
                state = string.Empty;
                return false;
            }

            state = CbxState.Text;
            return true;
        }
        
        // validate the zip code input
        private bool ZipCodeIsValid(out string zipCode)
        {
            if (!MtbZipCode.MaskCompleted)
            {
                LblErrZipCode.Text = @"Please enter a valid zip code";
                zipCode = string.Empty;
                return false;
            }

            zipCode = MtbZipCode.Text;
            return true;
        }
        
        // validate the phone input
        private bool PhoneIsValid(out string phone)
        {
            if (!MtbPhone.MaskCompleted)
            {
                LblErrPhone.Text = @"Please enter a valid phone number";
                phone = string.Empty;
                return false;
            }

            phone = MtbPhone.Text;
            return true;
        }

        #endregion
        
        #region internal details

        // trim names and make the first to uppercase and the rest to lowercase, per word
        private static string UppercaseFirstLetterPerWord(string str)
        {
            var output = str.Split().Where(s => !string.IsNullOrEmpty(s))
                .Aggregate("", (current, s) => current + (s[0].ToString().ToUpper() + s.Substring(1).ToLower() + " "));

            return output.Trim();
        }

        // clear the text fields
        private void ClearTextFields()
        {
            TbxFirstName.Clear();
            TbxLastName.Clear();
            TbxStreetAddress.Clear();
            TbxCity.Clear();
            CbxState.SelectedIndex = 0;
            MtbZipCode.Clear();
            MtbPhone.Clear();
        }
        
        private void ClearError()
        {
            LblErrFirstName.Text = "";
            LblErrLastName.Text = "";
            LblErrStreetAddress.Text = "";
            LblErrCity.Text = "";
            LblErrState.Text = "";
            LblErrZipCode.Text = "";
            LblErrPhone.Text = "";
        }

        #endregion
        
        #region events listeners

        // add button click listener
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            ClearError();
            if (FirstNameIsValid(out var firtname) & LastNameIsValid(out var lastName) & AddressIsValid(out var address) 
                & CityIsValid(out var city)& StateIsValid(out var state) & ZipCodeIsValid(out var zipCode) 
                & PhoneIsValid(out var phone))
            {
                customer.Add(new ClassCustomer(firtname, lastName, address, city, state, zipCode, phone));
                MessageBox.Show($@"{firtname} {lastName} has been successfully added to the list.");
                ClearTextFields();
                TbxFirstName.Focus();
            }
        }
        
        // clear button click listener
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearError();
            ClearTextFields();
        }

        // display all menu item click listener
        private void DisplayAllCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customer.Count == 0)
                MessageBox.Show(@"The list is empty");
            else
                new FrmDisplayAllCustomers(customer).ShowDialog();
        }

        // about menu item click listener
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        // clear customer menu item click listener
        private void ClearCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to clear the list?", @"Delete list", MessageBoxButtons.YesNo) == DialogResult.Yes)
                customer.Clear();
        }

        // exit menu click item listener
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}