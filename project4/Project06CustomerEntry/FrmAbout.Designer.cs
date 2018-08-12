namespace Project06CustomerEntry
{
    partial class FrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMajor = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelClass, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelMajor, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelYear, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.BtnClose, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(304, 265);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(94, 259);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelClass
            // 
            this.labelClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelClass.Location = new System.Drawing.Point(106, 0);
            this.labelClass.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelClass.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(195, 17);
            this.labelClass.TabIndex = 19;
            this.labelClass.Text = "CISS 233 - C# Programming";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelName.Location = new System.Drawing.Point(106, 26);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(195, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Jay Morales";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMajor
            // 
            this.labelMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMajor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelMajor.Location = new System.Drawing.Point(106, 52);
            this.labelMajor.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelMajor.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(195, 17);
            this.labelMajor.TabIndex = 21;
            this.labelMajor.Text = "A.A.S Computer Information Systems";
            this.labelMajor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelYear
            // 
            this.labelYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelYear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelYear.Location = new System.Drawing.Point(106, 78);
            this.labelYear.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelYear.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(195, 17);
            this.labelYear.TabIndex = 22;
            this.labelYear.Text = "2018";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(106, 107);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(195, 126);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnClose.Location = new System.Drawing.Point(226, 239);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 24;
            this.BtnClose.Text = "&Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmAbout
            // 
            this.AcceptButton = this.BtnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Me";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMajor;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label labelClass;
    }
}
