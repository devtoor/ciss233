using System;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Web.UI;

namespace finalproject
{
    public partial class OrderEntryPage : Page
    {
        private const decimal Prod1Prize = 11.99m;
        private const decimal Prod2Prize = 8.99m;
        private const decimal Prod3Prize = 9.99m;
        private const decimal Prod4Prize = 9.99m;
        private const decimal Prod5Prize = 11.99m;
        private const decimal Prod6Prize = 9.99m;
        private const decimal Tax = 0.08m;
        private static int _prod1Qty;
        private static int _prod2Qty;
        private static int _prod3Qty;
        private static int _prod4Qty;
        private static int _prod5Qty;
        private static int _prod6Qty;
        private static decimal _grandTotal;
        private static decimal _subTotal;
        private static decimal _taxAmt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var customerList = DataUtilityClass.SelectAllCustomers();
                foreach (var customer in customerList)
                {
                    DDCustomer.Items.Add(new ListItem(customer.Id + ": " + customer.First + " " + customer.Last,
                        customer.Id.ToString()));
                }
            }
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void btnCalculateOrder_Click(object sender, EventArgs e)
        {
            lblNotification.Visible = false;
            if (string.IsNullOrEmpty(tbxQuatity1.Text))
                tbxQuatity1.Text = "0";
            if (string.IsNullOrEmpty(tbxQuatity2.Text))
                tbxQuatity2.Text = "0";
            if (string.IsNullOrEmpty(tbxQuatity3.Text))
                tbxQuatity3.Text = "0";
            if (string.IsNullOrEmpty(tbxQuatity4.Text))
                tbxQuatity4.Text = "0";
            if (string.IsNullOrEmpty(tbxQuatity5.Text))
                tbxQuatity5.Text = "0";
            if (string.IsNullOrEmpty(tbxQuatity6.Text))
                tbxQuatity6.Text = "0";
            _prod1Qty = int.Parse(tbxQuatity1.Text);
            _prod2Qty = int.Parse(tbxQuatity2.Text);
            _prod3Qty = int.Parse(tbxQuatity3.Text);
            _prod4Qty = int.Parse(tbxQuatity4.Text);
            _prod5Qty = int.Parse(tbxQuatity5.Text);
            _prod6Qty = int.Parse(tbxQuatity6.Text);
            if ((_prod1Qty + _prod2Qty + _prod3Qty + _prod4Qty + _prod5Qty + _prod6Qty) > 0)
            {
                _subTotal = 0m;
                _subTotal += Convert.ToDecimal(_prod1Qty) * Prod1Prize;
                _subTotal += Convert.ToDecimal(_prod2Qty) * Prod2Prize;
                _subTotal += Convert.ToDecimal(_prod3Qty) * Prod3Prize;
                _subTotal += Convert.ToDecimal(_prod4Qty) * Prod4Prize;
                _subTotal += Convert.ToDecimal(_prod5Qty) * Prod5Prize;
                _subTotal += Convert.ToDecimal(_prod6Qty) * Prod6Prize;
                _taxAmt = _subTotal * Tax;
                _grandTotal = _subTotal + _taxAmt;
                tbxOrderTotal.Text = _subTotal.ToString("C");
                tbxTax.Text = _taxAmt.ToString("C");
                tbxGrandTotal.Text = _grandTotal.ToString("C");
                btnSubmit.Enabled = true;
            }
            else
            {
                lblNotification.Text = "Add at least one item.";
                lblNotification.ForeColor = Color.Red;
                lblNotification.Visible = true;
                btnSubmit.Enabled = false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var custId = Convert.ToInt32(DDCustomer.SelectedValue);
            var orderdate = DateTime.Today.ToShortDateString();
            var ordertime = DateTime.Now.ToShortTimeString();
            DataUtilityClass.InsertOrder(
                new Order(Convert.ToInt32(custId), orderdate, ordertime, _prod1Qty, _prod2Qty, _prod3Qty, _prod4Qty, _prod5Qty, _prod6Qty, _subTotal, _taxAmt, _grandTotal));
            lblNotification.Text = "Order is successfully sumited.";
            lblNotification.ForeColor = Color.Green;
            lblNotification.Visible = true;
            Reset();
        }

        private void Reset()
        {
            tbxQuatity1.Text = "0";
            tbxQuatity2.Text = "0";
            tbxQuatity3.Text = "0";
            tbxQuatity4.Text = "0";
            tbxQuatity5.Text = "0";
            tbxQuatity6.Text = "0";
            tbxOrderTotal.Text = string.Empty;
            tbxTax.Text = string.Empty;
            tbxGrandTotal.Text = string.Empty;
            btnSubmit.Enabled = false;
        }
    }
}