namespace Assignment05
{
    partial class FrmMagic8Ball
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
            this.LblMessage = new System.Windows.Forms.Label();
            this.TBAnswer = new System.Windows.Forms.TextBox();
            this.BtnGetAnswer = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(16, 23);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(99, 16);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "Your Answer is:";
            // 
            // TBAnswer
            // 
            this.TBAnswer.AcceptsTab = true;
            this.TBAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAnswer.Location = new System.Drawing.Point(121, 20);
            this.TBAnswer.Name = "TBAnswer";
            this.TBAnswer.ReadOnly = true;
            this.TBAnswer.Size = new System.Drawing.Size(192, 22);
            this.TBAnswer.TabIndex = 0;
            this.TBAnswer.TabStop = false;
            this.TBAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGetAnswer
            // 
            this.BtnGetAnswer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnGetAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetAnswer.Location = new System.Drawing.Point(84, 103);
            this.BtnGetAnswer.Name = "BtnGetAnswer";
            this.BtnGetAnswer.Size = new System.Drawing.Size(85, 30);
            this.BtnGetAnswer.TabIndex = 1;
            this.BtnGetAnswer.Text = "Get Answer";
            this.BtnGetAnswer.UseVisualStyleBackColor = true;
            this.BtnGetAnswer.Click += new System.EventHandler(this.BtnGetAnswer_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(216, 103);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(85, 30);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Close";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblMessage);
            this.groupBox1.Controls.Add(this.TBAnswer);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // FrmMagic8Ball
            // 
            this.AcceptButton = this.BtnGetAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnGetAnswer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMagic8Ball";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic 8 Ball";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.TextBox TBAnswer;
        private System.Windows.Forms.Button BtnGetAnswer;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}