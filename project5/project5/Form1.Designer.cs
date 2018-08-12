using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;

namespace project5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVisitorTeam = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblVisitorScore = new System.Windows.Forms.Label();
            this.lblHomeScore = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbxVisitorTeam = new System.Windows.Forms.TextBox();
            this.tbxVisitorScore = new System.Windows.Forms.TextBox();
            this.tbxHomeTeam = new System.Windows.Forms.TextBox();
            this.tbxHomeScore = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VisitorTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VisitorScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorHomeScore = new System.Windows.Forms.Label();
            this.lblErrorTeamScore = new System.Windows.Forms.Label();
            this.lblErrorHomeTeam = new System.Windows.Forms.Label();
            this.lblErrorVisitorTeam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(271, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(123, 20);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Sports Scores";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblVisitorTeam
            // 
            this.lblVisitorTeam.AutoSize = true;
            this.lblVisitorTeam.Location = new System.Drawing.Point(185, 21);
            this.lblVisitorTeam.Name = "lblVisitorTeam";
            this.lblVisitorTeam.Size = new System.Drawing.Size(65, 13);
            this.lblVisitorTeam.TabIndex = 0;
            this.lblVisitorTeam.Text = "Visitor Team";
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(413, 21);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(65, 13);
            this.lblHomeTeam.TabIndex = 0;
            this.lblHomeTeam.Text = "Home Team";
            // 
            // lblVisitorScore
            // 
            this.lblVisitorScore.AutoSize = true;
            this.lblVisitorScore.Location = new System.Drawing.Point(185, 79);
            this.lblVisitorScore.Name = "lblVisitorScore";
            this.lblVisitorScore.Size = new System.Drawing.Size(66, 13);
            this.lblVisitorScore.TabIndex = 0;
            this.lblVisitorScore.Text = "Visitor Score";
            // 
            // lblHomeScore
            // 
            this.lblHomeScore.AutoSize = true;
            this.lblHomeScore.Location = new System.Drawing.Point(413, 79);
            this.lblHomeScore.Name = "lblHomeScore";
            this.lblHomeScore.Size = new System.Drawing.Size(66, 13);
            this.lblHomeScore.TabIndex = 0;
            this.lblHomeScore.Text = "Home Score";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(57, 17);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // tbxVisitorTeam
            // 
            this.tbxVisitorTeam.Location = new System.Drawing.Point(256, 17);
            this.tbxVisitorTeam.Name = "tbxVisitorTeam";
            this.tbxVisitorTeam.Size = new System.Drawing.Size(136, 20);
            this.tbxVisitorTeam.TabIndex = 2;
            // 
            // tbxVisitorScore
            // 
            this.tbxVisitorScore.Location = new System.Drawing.Point(256, 75);
            this.tbxVisitorScore.Name = "tbxVisitorScore";
            this.tbxVisitorScore.Size = new System.Drawing.Size(136, 20);
            this.tbxVisitorScore.TabIndex = 3;
            // 
            // tbxHomeTeam
            // 
            this.tbxHomeTeam.Location = new System.Drawing.Point(484, 17);
            this.tbxHomeTeam.Name = "tbxHomeTeam";
            this.tbxHomeTeam.Size = new System.Drawing.Size(136, 20);
            this.tbxHomeTeam.TabIndex = 4;
            // 
            // tbxHomeScore
            // 
            this.tbxHomeScore.Location = new System.Drawing.Point(484, 75);
            this.tbxHomeScore.Name = "tbxHomeScore";
            this.tbxHomeScore.Size = new System.Drawing.Size(136, 20);
            this.tbxHomeScore.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(484, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(578, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.VisitorTeam,
            this.VisitorScore,
            this.HomeTeam,
            this.HomeScore});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 237);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(641, 279);
            this.listView.TabIndex = 0;
            this.listView.TabStop = false;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 115;
            // 
            // VisitorTeam
            // 
            this.VisitorTeam.Text = "Visitor Team";
            this.VisitorTeam.Width = 180;
            // 
            // VisitorScore
            // 
            this.VisitorScore.Text = "Score";
            this.VisitorScore.Width = 80;
            // 
            // HomeTeam
            // 
            this.HomeTeam.Text = "Home Team";
            this.HomeTeam.Width = 180;
            // 
            // HomeScore
            // 
            this.HomeScore.Text = "Score";
            this.HomeScore.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorHomeScore);
            this.panel1.Controls.Add(this.lblErrorTeamScore);
            this.panel1.Controls.Add(this.lblErrorHomeTeam);
            this.panel1.Controls.Add(this.lblErrorVisitorTeam);
            this.panel1.Controls.Add(this.lblHomeTeam);
            this.panel1.Controls.Add(this.tbxVisitorTeam);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.tbxVisitorScore);
            this.panel1.Controls.Add(this.lblVisitorTeam);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.lblVisitorScore);
            this.panel1.Controls.Add(this.tbxHomeTeam);
            this.panel1.Controls.Add(this.tbxHomeScore);
            this.panel1.Controls.Add(this.lblHomeScore);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 129);
            this.panel1.TabIndex = 1;
            // 
            // lblErrorHomeScore
            // 
            this.lblErrorHomeScore.AutoSize = true;
            this.lblErrorHomeScore.ForeColor = System.Drawing.Color.Red;
            this.lblErrorHomeScore.Location = new System.Drawing.Point(481, 98);
            this.lblErrorHomeScore.Name = "lblErrorHomeScore";
            this.lblErrorHomeScore.Size = new System.Drawing.Size(0, 13);
            this.lblErrorHomeScore.TabIndex = 0;
            // 
            // lblErrorTeamScore
            // 
            this.lblErrorTeamScore.AutoSize = true;
            this.lblErrorTeamScore.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTeamScore.Location = new System.Drawing.Point(253, 98);
            this.lblErrorTeamScore.Name = "lblErrorTeamScore";
            this.lblErrorTeamScore.Size = new System.Drawing.Size(0, 13);
            this.lblErrorTeamScore.TabIndex = 0;
            // 
            // lblErrorHomeTeam
            // 
            this.lblErrorHomeTeam.AutoSize = true;
            this.lblErrorHomeTeam.ForeColor = System.Drawing.Color.Red;
            this.lblErrorHomeTeam.Location = new System.Drawing.Point(481, 40);
            this.lblErrorHomeTeam.Name = "lblErrorHomeTeam";
            this.lblErrorHomeTeam.Size = new System.Drawing.Size(0, 13);
            this.lblErrorHomeTeam.TabIndex = 0;
            // 
            // lblErrorVisitorTeam
            // 
            this.lblErrorVisitorTeam.AutoSize = true;
            this.lblErrorVisitorTeam.ForeColor = System.Drawing.Color.Red;
            this.lblErrorVisitorTeam.Location = new System.Drawing.Point(253, 40);
            this.lblErrorVisitorTeam.Name = "lblErrorVisitorTeam";
            this.lblErrorVisitorTeam.Size = new System.Drawing.Size(0, 13);
            this.lblErrorVisitorTeam.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Scores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVisitorTeam;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblVisitorScore;
        private System.Windows.Forms.Label lblHomeScore;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox tbxVisitorTeam;
        private System.Windows.Forms.TextBox tbxVisitorScore;
        private System.Windows.Forms.TextBox tbxHomeTeam;
        private System.Windows.Forms.TextBox tbxHomeScore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader VisitorTeam;
        private System.Windows.Forms.ColumnHeader VisitorScore;
        private System.Windows.Forms.ColumnHeader HomeTeam;
        private System.Windows.Forms.ColumnHeader HomeScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrorVisitorTeam;
        private System.Windows.Forms.Label lblErrorHomeScore;
        private System.Windows.Forms.Label lblErrorTeamScore;
        private System.Windows.Forms.Label lblErrorHomeTeam;
    }
}

