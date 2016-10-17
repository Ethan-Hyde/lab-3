using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime StartDate, EndDate;
            StartDate = StartCalender.SelectionStart;
            EndDate = EndCalender.SelectionStart;

            string FirstName;
            FirstName = FName.Text;

            string LastName;
            LastName = LName.Text;

            string loan;
            loan = AmtLoaned1.Text;
            double Loan1= Double.Parse(loan);

            string InterestRate;

            InterestRate = InterestRatetxt.Text;
            double intRate = Double.Parse(InterestRate) / 100;

            double interest;

            double dateDiffereence;

            double dateCal;

            double totalInterest;



            /* interest Rate code*/

            interest = Loan1 * intRate;
            dateCal = 12 * (StartDate.Year - EndDate.Year) + (StartDate.Month - EndDate.Month);
            dateDiffereence = dateCal - (dateCal * 2);

            if (dateDiffereence >= 11)
                totalInterest = interest * 2;

            else
                totalInterest = interest;

            /* TextBox code */

            Solution.Text += "First Name:" + FirstName + "\r\n";
            Solution.Text += "Last Name:" + LastName + "\r\n";
            Solution.Text += "Start Date" + StartDate + "\r\n";
            Solution.Text += "End Date" + EndDate + "\r\n";
            Solution.Text += "Loan Amount" + Loan1+ "\r\n";
            Solution.Text += "Interest Per Year" + interest.ToString() + "\r\n";
            Solution.Text += "Total Interest" + totalInterest.ToString() + "\r\n";
            Solution.Text += "Number of Months" + dateDiffereence.ToString() + "\r\n";


        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LName_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartCalender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void EndCalender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void InterestRatetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmtLoaned1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
