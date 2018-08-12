using System;
using System.Windows.Forms;

namespace Project06CustomerEntry
{
    internal partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        // close button click listener
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}