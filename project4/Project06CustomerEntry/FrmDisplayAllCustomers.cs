using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project06CustomerEntry
{
    public partial class FrmDisplayAllCustomers : Form
    {
        public FrmDisplayAllCustomers(List<ClassCustomer> list)
        {
            InitializeComponent();

            list.ForEach(e =>
            {
                var item = new ListViewItem($"{e.LastName}, {e.FirstName}");
                item.SubItems.Add($"{e.StreeAddress}, {e.City}, {e.State} {e.ZipCode}");
                item.SubItems.Add(e.Phone);
                ListView.Items.Add(item);
            });
        }

        // close button click listener
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}