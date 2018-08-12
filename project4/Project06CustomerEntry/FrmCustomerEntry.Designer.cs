namespace Project06CustomerEntry
{
    partial class FrmCustomerEntry
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
            this.GbxCustomer = new System.Windows.Forms.GroupBox();
            this.LblErrPhone = new System.Windows.Forms.Label();
            this.LblErrZipCode = new System.Windows.Forms.Label();
            this.LblErrState = new System.Windows.Forms.Label();
            this.LblErrCity = new System.Windows.Forms.Label();
            this.LblErrStreetAddress = new System.Windows.Forms.Label();
            this.LblErrLastName = new System.Windows.Forms.Label();
            this.LblErrFirstName = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblZipCode = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.MtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.MtbZipCode = new System.Windows.Forms.MaskedTextBox();
            this.CbxState = new System.Windows.Forms.ComboBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblStreetAddress = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TbxLastName = new System.Windows.Forms.TextBox();
            this.TbxCity = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TbxStreetAddress = new System.Windows.Forms.TextBox();
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayAllCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.GbxCustomer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxCustomer
            // 
            this.GbxCustomer.Controls.Add(this.LblErrPhone);
            this.GbxCustomer.Controls.Add(this.LblErrZipCode);
            this.GbxCustomer.Controls.Add(this.LblErrState);
            this.GbxCustomer.Controls.Add(this.LblErrCity);
            this.GbxCustomer.Controls.Add(this.LblErrStreetAddress);
            this.GbxCustomer.Controls.Add(this.LblErrLastName);
            this.GbxCustomer.Controls.Add(this.LblErrFirstName);
            this.GbxCustomer.Controls.Add(this.LblPhone);
            this.GbxCustomer.Controls.Add(this.LblZipCode);
            this.GbxCustomer.Controls.Add(this.LblState);
            this.GbxCustomer.Controls.Add(this.MtbPhone);
            this.GbxCustomer.Controls.Add(this.MtbZipCode);
            this.GbxCustomer.Controls.Add(this.CbxState);
            this.GbxCustomer.Controls.Add(this.LblCity);
            this.GbxCustomer.Controls.Add(this.LblStreetAddress);
            this.GbxCustomer.Controls.Add(this.LblLastName);
            this.GbxCustomer.Controls.Add(this.TbxLastName);
            this.GbxCustomer.Controls.Add(this.TbxCity);
            this.GbxCustomer.Controls.Add(this.LblFirstName);
            this.GbxCustomer.Controls.Add(this.TbxStreetAddress);
            this.GbxCustomer.Controls.Add(this.TbxFirstName);
            this.GbxCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GbxCustomer.Location = new System.Drawing.Point(12, 38);
            this.GbxCustomer.Name = "GbxCustomer";
            this.GbxCustomer.Size = new System.Drawing.Size(410, 323);
            this.GbxCustomer.TabIndex = 0;
            this.GbxCustomer.TabStop = false;
            this.GbxCustomer.Text = "Customer";
            // 
            // LblErrPhone
            // 
            this.LblErrPhone.AutoSize = true;
            this.LblErrPhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblErrPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrPhone.ForeColor = System.Drawing.Color.Red;
            this.LblErrPhone.Location = new System.Drawing.Point(210, 287);
            this.LblErrPhone.Name = "LblErrPhone";
            this.LblErrPhone.Size = new System.Drawing.Size(0, 13);
            this.LblErrPhone.TabIndex = 0;
            // 
            // LblErrZipCode
            // 
            this.LblErrZipCode.AutoSize = true;
            this.LblErrZipCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblErrZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrZipCode.ForeColor = System.Drawing.Color.Red;
            this.LblErrZipCode.Location = new System.Drawing.Point(9, 287);
            this.LblErrZipCode.Name = "LblErrZipCode";
            this.LblErrZipCode.Size = new System.Drawing.Size(0, 13);
            this.LblErrZipCode.TabIndex = 0;
            // 
            // LblErrState
            // 
            this.LblErrState.AutoSize = true;
            this.LblErrState.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblErrState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrState.ForeColor = System.Drawing.Color.Red;
            this.LblErrState.Location = new System.Drawing.Point(210, 214);
            this.LblErrState.Name = "LblErrState";
            this.LblErrState.Size = new System.Drawing.Size(0, 13);
            this.LblErrState.TabIndex = 0;
            // 
            // LblErrCity
            // 
            this.LblErrCity.AutoSize = true;
            this.LblErrCity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblErrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrCity.ForeColor = System.Drawing.Color.Red;
            this.LblErrCity.Location = new System.Drawing.Point(9, 215);
            this.LblErrCity.Name = "LblErrCity";
            this.LblErrCity.Size = new System.Drawing.Size(0, 13);
            this.LblErrCity.TabIndex = 0;
            // 
            // LblErrStreetAddress
            // 
            this.LblErrStreetAddress.AutoSize = true;
            this.LblErrStreetAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblErrStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrStreetAddress.ForeColor = System.Drawing.Color.Red;
            this.LblErrStreetAddress.Location = new System.Drawing.Point(9, 143);
            this.LblErrStreetAddress.Name = "LblErrStreetAddress";
            this.LblErrStreetAddress.Size = new System.Drawing.Size(0, 13);
            this.LblErrStreetAddress.TabIndex = 0;
            // 
            // LblErrLastName
            // 
            this.LblErrLastName.AutoSize = true;
            this.LblErrLastName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblErrLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrLastName.ForeColor = System.Drawing.Color.Red;
            this.LblErrLastName.Location = new System.Drawing.Point(210, 71);
            this.LblErrLastName.Name = "LblErrLastName";
            this.LblErrLastName.Size = new System.Drawing.Size(0, 13);
            this.LblErrLastName.TabIndex = 0;
            // 
            // LblErrFirstName
            // 
            this.LblErrFirstName.AutoSize = true;
            this.LblErrFirstName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblErrFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrFirstName.ForeColor = System.Drawing.Color.Red;
            this.LblErrFirstName.Location = new System.Drawing.Point(9, 71);
            this.LblErrFirstName.Name = "LblErrFirstName";
            this.LblErrFirstName.Size = new System.Drawing.Size(0, 13);
            this.LblErrFirstName.TabIndex = 0;
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblPhone.Location = new System.Drawing.Point(210, 246);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(38, 13);
            this.LblPhone.TabIndex = 0;
            this.LblPhone.Text = "Phone";
            // 
            // LblZipCode
            // 
            this.LblZipCode.AutoSize = true;
            this.LblZipCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblZipCode.Location = new System.Drawing.Point(9, 246);
            this.LblZipCode.Name = "LblZipCode";
            this.LblZipCode.Size = new System.Drawing.Size(50, 13);
            this.LblZipCode.TabIndex = 0;
            this.LblZipCode.Text = "Zip Code";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblState.Location = new System.Drawing.Point(210, 173);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(32, 13);
            this.LblState.TabIndex = 0;
            this.LblState.Text = "State";
            // 
            // MtbPhone
            // 
            this.MtbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbPhone.Location = new System.Drawing.Point(207, 261);
            this.MtbPhone.Mask = "(000) 000-0000";
            this.MtbPhone.Name = "MtbPhone";
            this.MtbPhone.PromptChar = ' ';
            this.MtbPhone.Size = new System.Drawing.Size(197, 24);
            this.MtbPhone.TabIndex = 7;
            // 
            // MtbZipCode
            // 
            this.MtbZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbZipCode.Location = new System.Drawing.Point(6, 261);
            this.MtbZipCode.Mask = "00000";
            this.MtbZipCode.Name = "MtbZipCode";
            this.MtbZipCode.PromptChar = ' ';
            this.MtbZipCode.Size = new System.Drawing.Size(195, 24);
            this.MtbZipCode.TabIndex = 6;
            // 
            // CbxState
            // 
            this.CbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxState.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxState.FormattingEnabled = true;
            this.CbxState.Items.AddRange(new object[] {
            "Please choose a state . . .",
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.CbxState.Location = new System.Drawing.Point(207, 188);
            this.CbxState.MaxDropDownItems = 10;
            this.CbxState.Name = "CbxState";
            this.CbxState.Size = new System.Drawing.Size(197, 24);
            this.CbxState.TabIndex = 5;
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblCity.Location = new System.Drawing.Point(9, 174);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(24, 13);
            this.LblCity.TabIndex = 0;
            this.LblCity.Text = "City";
            // 
            // LblStreetAddress
            // 
            this.LblStreetAddress.AutoSize = true;
            this.LblStreetAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblStreetAddress.Location = new System.Drawing.Point(9, 102);
            this.LblStreetAddress.Name = "LblStreetAddress";
            this.LblStreetAddress.Size = new System.Drawing.Size(73, 13);
            this.LblStreetAddress.TabIndex = 0;
            this.LblStreetAddress.Text = "StreetAddress";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblLastName.Location = new System.Drawing.Point(210, 30);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(58, 13);
            this.LblLastName.TabIndex = 0;
            this.LblLastName.Text = "Last Name";
            // 
            // TbxLastName
            // 
            this.TbxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxLastName.Location = new System.Drawing.Point(207, 45);
            this.TbxLastName.Name = "TbxLastName";
            this.TbxLastName.Size = new System.Drawing.Size(197, 24);
            this.TbxLastName.TabIndex = 2;
            // 
            // TbxCity
            // 
            this.TbxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCity.Location = new System.Drawing.Point(6, 189);
            this.TbxCity.Name = "TbxCity";
            this.TbxCity.Size = new System.Drawing.Size(195, 24);
            this.TbxCity.TabIndex = 4;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblFirstName.Location = new System.Drawing.Point(9, 30);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(57, 13);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name";
            // 
            // TbxStreetAddress
            // 
            this.TbxStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxStreetAddress.Location = new System.Drawing.Point(6, 117);
            this.TbxStreetAddress.Name = "TbxStreetAddress";
            this.TbxStreetAddress.Size = new System.Drawing.Size(398, 24);
            this.TbxStreetAddress.TabIndex = 3;
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxFirstName.Location = new System.Drawing.Point(6, 45);
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(195, 24);
            this.TbxFirstName.TabIndex = 1;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(434, 24);
            this.MenuStrip.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayAllCustomerToolStripMenuItem,
            this.toolStripSeparator1,
            this.ClearCustomersToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileToolStripMenuItem.Text = "&Database";
            // 
            // DisplayAllCustomerToolStripMenuItem
            // 
            this.DisplayAllCustomerToolStripMenuItem.Name = "DisplayAllCustomerToolStripMenuItem";
            this.DisplayAllCustomerToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.DisplayAllCustomerToolStripMenuItem.Text = "Display &All Customers";
            this.DisplayAllCustomerToolStripMenuItem.Click += new System.EventHandler(this.DisplayAllCustomerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // ClearCustomersToolStripMenuItem
            // 
            this.ClearCustomersToolStripMenuItem.Name = "ClearCustomersToolStripMenuItem";
            this.ClearCustomersToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ClearCustomersToolStripMenuItem.Text = "&Clear Customers";
            this.ClearCustomersToolStripMenuItem.Click += new System.EventHandler(this.ClearCustomersToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "A&bout";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustomer.Location = new System.Drawing.Point(312, 371);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(110, 28);
            this.BtnAddCustomer.TabIndex = 1;
            this.BtnAddCustomer.Text = "&Add Customer";
            this.BtnAddCustomer.UseVisualStyleBackColor = false;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(231, 371);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 28);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmCustomerEntry
            // 
            this.AcceptButton = this.BtnAddCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClear;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAddCustomer);
            this.Controls.Add(this.GbxCustomer);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmCustomerEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Customer";
            this.GbxCustomer.ResumeLayout(false);
            this.GbxCustomer.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxCustomer;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label LblErrPhone;
        private System.Windows.Forms.Label LblErrZipCode;
        private System.Windows.Forms.Label LblErrState;
        private System.Windows.Forms.Label LblErrCity;
        private System.Windows.Forms.Label LblErrStreetAddress;
        private System.Windows.Forms.Label LblErrLastName;
        private System.Windows.Forms.Label LblErrFirstName;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblZipCode;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.MaskedTextBox MtbPhone;
        private System.Windows.Forms.MaskedTextBox MtbZipCode;
        private System.Windows.Forms.ComboBox CbxState;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblStreetAddress;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TbxLastName;
        private System.Windows.Forms.TextBox TbxCity;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TbxStreetAddress;
        private System.Windows.Forms.TextBox TbxFirstName;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ToolStripMenuItem DisplayAllCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ClearCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    }
}

