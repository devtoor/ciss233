// CISS 233-300: Project 05
// Author:   Jay Morales
// Date:     04/01/2018
// Project:  Windows Form, Serialization and Deserialization, Sport Scores
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Console;

namespace project5
{
    public partial class Form1 : Form
    {
        private const string FILENAME = "Data.bin";
        private List<SportsScore> list;

        /// <summary>
        /// constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            GetBinary();
        }

        /// <summary>
        /// this method adds an entry to the list view.
        /// </summary>
        /// <param name="e">Sport score entry</param>
        private void AddToListView(SportsScore e)
        {
            var item = new ListViewItem(e.Date);
            item.SubItems.Add(e.VisitorTeam);
            item.SubItems.Add(e.VisitorScore.ToString());
            item.SubItems.Add(e.HomeTeam);
            item.SubItems.Add(e.HomeScore.ToString());
            listView.Items.Add(item);
        }

        /// <summary>
        /// clear error labels
        /// </summary>
        private void ClearError()
        {
            lblErrorVisitorTeam.Text = string.Empty;
            lblErrorTeamScore.Text = string.Empty;
            lblErrorHomeTeam.Text = string.Empty;
            lblErrorHomeScore.Text = string.Empty;
        }

        /// <summary>
        /// clear textfields
        /// </summary>
        private void ClearTextFields()
        {
            dateTimePicker.Value = DateTime.Now;
            tbxVisitorTeam.Clear();
            tbxVisitorScore.Clear();
            tbxHomeTeam.Clear();
            tbxHomeScore.Clear();
        }
        
        /// <summary>
        /// trim names and make the first letter per word to uppercase and the rest to lowercase
        /// </summary>
        /// <param name="str">String to modify</param>
        /// <returns>Modified string</returns>
        private static string UppercaseFirstLetterPerWord(string str)
        {
            var output = str.Split().Where(s => !string.IsNullOrEmpty(s))
                .Aggregate("", (current, s) => current + (s[0].ToString().ToUpper() + s.Substring(1).ToLower() + " "));

            return output.Trim();
        }

        /// <summary>
        /// get list of objects from the bin file
        /// </summary>
        private void GetBinary()
        {
            try
            {
                if (File.Exists(FILENAME))
                {
                    using (var fs = new FileStream(FILENAME, FileMode.Open))
                    {
                        list = (List<SportsScore>) new BinaryFormatter().Deserialize(fs);
                        list.ForEach(AddToListView);
                    }
                }
                else
                    list = new List<SportsScore>();
            }
            catch (Exception e)
            {
                Error.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// save the list of object to the bin file
        /// </summary>
        private void SetBinary()
        {
            try
            {
                using (var fs = new FileStream(FILENAME, FileMode.Create))
                {
                    new BinaryFormatter().Serialize(fs, list);
                }
            }
            catch (Exception ex)
            {
                Error.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// add button click listener
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="e">event</param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearError();
            if (VisitorTeamIsValid(out var visitorTeam) & VisitorScoreIsValid(out var visitorScore) & 
                HomeTeamIsValid(out var homeTeam) & HomeScoreIsValid(out var homeScore))
            {
                var newEntry = new SportsScore(list.Count + 1, dateTimePicker.Value.ToShortDateString(), visitorTeam,
                    visitorScore, homeTeam, homeScore);
                list.Add(newEntry);
                AddToListView(newEntry);
                ClearTextFields();
                SetBinary();   
            }
        }

        /// <summary>
        /// clear button click listener
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="e">event</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearError();
            ClearTextFields();
        }

        /// <summary>
        /// validate the visitor team name textfield
        /// </summary>
        /// <param name="visitorTeam">empty if invalid or return input</param>
        /// <returns>true if valid otherwise false</returns>
        private bool VisitorTeamIsValid(out string visitorTeam)
        {
            if (string.IsNullOrEmpty(tbxVisitorTeam.Text))
            {
                lblErrorVisitorTeam.Text = @"Team name required";
                visitorTeam = string.Empty;
                return false;
            }

            visitorTeam = UppercaseFirstLetterPerWord(tbxVisitorTeam.Text);
            return true;
        }

        /// <summary>
        /// validate the visitor team score textfield
        /// </summary>
        /// <param name="visitorScore">zero if invalid or return input</param>
        /// <returns>true if valid otherwise false</returns>
        private bool VisitorScoreIsValid(out int visitorScore)
        {
            visitorScore = 0;
            
            if (string.IsNullOrEmpty(tbxVisitorScore.Text))
            {
                lblErrorTeamScore.Text = @"Team score required";
                return false;
            }

            if (int.TryParse(tbxVisitorScore.Text, out var n) == false)
            {
                lblErrorTeamScore.Text = @"Enter valid score";
                return false;
            }
            
            visitorScore = n;
            return true;
        }

        /// <summary>
        /// validate the home team name textfield
        /// </summary>
        /// <param name="homeTeam">empty if invalid or return input</param>
        /// <returns>true if valid otherwise false</returns>
        private bool HomeTeamIsValid(out string homeTeam)
        {
            if (string.IsNullOrEmpty(tbxHomeTeam.Text))
            {
                lblErrorHomeTeam.Text = @"Team name required";
                homeTeam = string.Empty;
                return false;
            }

            homeTeam = UppercaseFirstLetterPerWord(tbxHomeTeam.Text);
            return true;
        }

        /// <summary>
        /// validate the home team score textfield
        /// </summary>
        /// <param name="homeScore">zero if invalid or return input</param>
        /// <returns>true if valid otherwise false</returns>
        private bool HomeScoreIsValid(out int homeScore)
        {
            homeScore = 0;

            if (string.IsNullOrEmpty(tbxHomeScore.Text))
            {
                lblErrorHomeScore.Text = @"Home score required";
                return false;
            }

            if (int.TryParse(tbxHomeScore.Text, out var n) == false)
            {
                lblErrorHomeScore.Text = @"Enter valid score";
                return false;
            }

            homeScore = n;
            return true;
        }
    }
}