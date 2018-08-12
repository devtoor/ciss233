using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment05
{
    public partial class FrmMagic8Ball : Form
    {
        private readonly List<string> sayings;

        public FrmMagic8Ball()
        {
            InitializeComponent();

            sayings = new List<string>
            {
                "It is certain",
                "It is decidedly so",
                "Without a doubt",
                "Yes, definitely",
                "You may rely on it",
                "As I see it, yes",
                "Most likely",
                "Outlook good",
                "Yes",
                "Signs point to yes",
                "Reply hazy try again",
                "Ask again later",
                "Better not tell you now",
                "Cannot predict now",
                "Concentrate and ask again",
                "Don't count on it",
                "My reply is no",
                "My sources say no",
                "Outlook not so good",
                "Very doubtful"
            };
        }

        private void BtnGetAnswer_Click(object sender, EventArgs e)
        {
            TBAnswer.Text = sayings[new Random().Next(0, sayings.Count - 1)];
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}