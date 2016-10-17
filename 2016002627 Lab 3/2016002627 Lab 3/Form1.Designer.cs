namespace WindowsFormsApplication1
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
            this.StartCalender = new System.Windows.Forms.MonthCalendar();
            this.EndCalender = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LName2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AmtLoaned = new System.Windows.Forms.Label();
            this.Solution = new System.Windows.Forms.TextBox();
            this.InterestRatetxt = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.AmtLoaned1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartCalender
            // 
            this.StartCalender.Location = new System.Drawing.Point(181, 93);
            this.StartCalender.Name = "StartCalender";
            this.StartCalender.TabIndex = 0;
            this.StartCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.StartCalender_DateChanged);
            // 
            // EndCalender
            // 
            this.EndCalender.Location = new System.Drawing.Point(184, 273);
            this.EndCalender.Name = "EndCalender";
            this.EndCalender.TabIndex = 1;
            this.EndCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EndCalender_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan Interest Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name ";
            // 
            // LName2
            // 
            this.LName2.AutoSize = true;
            this.LName2.Location = new System.Drawing.Point(12, 79);
            this.LName2.Name = "LName2";
            this.LName2.Size = new System.Drawing.Size(61, 13);
            this.LName2.TabIndex = 4;
            this.LName2.Text = "Last Name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Interest Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 8;
            // 
            // AmtLoaned
            // 
            this.AmtLoaned.AutoSize = true;
            this.AmtLoaned.Location = new System.Drawing.Point(12, 476);
            this.AmtLoaned.Name = "AmtLoaned";
            this.AmtLoaned.Size = new System.Drawing.Size(61, 13);
            this.AmtLoaned.TabIndex = 9;
            this.AmtLoaned.Text = "AmtLoaned";
            // 
            // Solution
            // 
            this.Solution.Location = new System.Drawing.Point(18, 528);
            this.Solution.Multiline = true;
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(390, 128);
            this.Solution.TabIndex = 14;
            this.Solution.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // InterestRatetxt
            // 
            this.InterestRatetxt.Location = new System.Drawing.Point(181, 447);
            this.InterestRatetxt.Name = "InterestRatetxt";
            this.InterestRatetxt.Size = new System.Drawing.Size(234, 20);
            this.InterestRatetxt.TabIndex = 15;
            this.InterestRatetxt.TextChanged += new System.EventHandler(this.InterestRatetxt_TextChanged);
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(181, 61);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(227, 20);
            this.LName.TabIndex = 16;
            this.LName.TextChanged += new System.EventHandler(this.LName_TextChanged);
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(181, 38);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(227, 20);
            this.FName.TabIndex = 17;
            this.FName.TextChanged += new System.EventHandler(this.FName_TextChanged);
            // 
            // AmtLoaned1
            // 
            this.AmtLoaned1.Location = new System.Drawing.Point(181, 473);
            this.AmtLoaned1.Name = "AmtLoaned1";
            this.AmtLoaned1.Size = new System.Drawing.Size(234, 20);
            this.AmtLoaned1.TabIndex = 18;
            this.AmtLoaned1.TextChanged += new System.EventHandler(this.AmtLoaned1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AmtLoaned1);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.InterestRatetxt);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.AmtLoaned);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndCalender);
            this.Controls.Add(this.StartCalender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar StartCalender;
        private System.Windows.Forms.MonthCalendar EndCalender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LName2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AmtLoaned;
        private System.Windows.Forms.TextBox Solution;
        private System.Windows.Forms.TextBox InterestRatetxt;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox AmtLoaned1;
        private System.Windows.Forms.Button button1;
    }
}

