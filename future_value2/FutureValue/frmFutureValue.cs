using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
	public partial class frmFutureValue : Form
	{
		public frmFutureValue()
		{
			InitializeComponent();
		}

		private bool IsDecimal(string txt, string name)
		{
			if (Decimal.TryParse(txt, out _))
				return true;
			MessageBox.Show(name + " must be a decimal");
			return false;
		}

		private bool IsInt32(string txt, string name)
		{
			if (Int32.TryParse(txt, out _))
				return true;
			MessageBox.Show(name + " must be an integer");
			return false;
		}

		private bool IsWithinRange(string txt, string name, decimal min, decimal max)
		{
			if (Decimal.TryParse(txt, out decimal i))
				if (i < min || i > max) {
					MessageBox.Show(name + " must be in the range of "
					+ min + " to " + max + "\n");
					return false;
				}
			return true;
		}

		private bool IsValidData()
		{
			bool valid = true;

			if(!IsDecimal(txtMonthlyInvestment.Text,
				txtMonthlyInvestment.Name))
				valid = false;
			if(!IsWithinRange(txtMonthlyInvestment.Text,
				txtMonthlyInvestment.Name, 0, 10000))
				valid = false;

			if(!IsDecimal(txtInterestRate.Text,
				txtInterestRate.Name))
				valid = false;
			if(!IsWithinRange(txtInterestRate.Text,
				txtInterestRate.Name, 0, 10000))
				valid = false;

			if(!IsInt32(txtYears.Text,
				txtYears.Name))
				valid = false;
			if(!IsWithinRange(txtYears.Text,
				txtYears.Name, 0, 10000))
				valid = false;

			return valid;
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try {
				if (!IsValidData())
					return;

				decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
				decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
				int years = Convert.ToInt32(txtYears.Text);

				int months = years * 12;
				decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

				decimal futureValue = this.CalculateFutureValue(
					monthlyInvestment, monthlyInterestRate, months);
				txtFutureValue.Text = futureValue.ToString("c");
				txtMonthlyInvestment.Focus();

				/* throw new Exception("There was an unknown error"); */
			}
			/* catch (FormatException) {
				MessageBox.Show("Invalid format: Try entering " +
					"numbers between 1 and 9999", "Entry Error");
			}
			catch (OverflowException) {
				MessageBox.Show("Overflow Error: Try entering"
					+ "smaller numbers", "Entry Error");
			} */
			catch (Exception ex){
				MessageBox.Show(ex.Message + "\n" +
				ex.GetType().ToString() +  "\n" +
				ex.StackTrace, "Entry Error");
			}
		}

		private decimal CalculateFutureValue(decimal monthlyInvestment,
			decimal monthlyInterestRate, int months)
		{
			decimal futureValue = 0m;
			for (int i = 0; i < months; i++)
			{
				futureValue = (futureValue + monthlyInvestment)
							* (1 + monthlyInterestRate);
			}
			return futureValue;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
