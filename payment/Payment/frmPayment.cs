using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Payment
{
	public partial class frmPayment : Form
	{
		public frmPayment()
		{
			InitializeComponent();
		}

		private void frmPayment_Load(object sender, EventArgs e)
		{
			lstCreditCardType.Items.Add("Visa");
			lstCreditCardType.Items.Add("Mastercard");
			lstCreditCardType.Items.Add("American Express");
			lstCreditCardType.SelectedIndex = 0;

			string[] months = {"Select a month...",
				"January", "February", "March",
				"April", "May", "June",
				"July", "August", "September",
				"October", "November", "December"};
			foreach (string month in months)
				cboExpirationMonth.Items.Add(month);
			cboExpirationMonth.SelectedIndex = 0;

			int year = DateTime.Today.Year;
			int endYear = year+8;
			cboExpirationYear.Items.Add("Select a year...");
			while (year < endYear) {
				cboExpirationYear.Items.Add(year);
				++year;
			}
			cboExpirationYear.SelectedIndex = 0;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (IsValidData())
				this.SaveData();
		}

		private void Billing_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoCreditCard.Checked)
				EnableControls();
			else
				DisableControls();
		}

		private void EnableControls()
		{
			lstCreditCardType.Enabled = true;
			txtNum.Enabled = true;
			cboExpirationMonth.Enabled = true;
			cboExpirationYear.Enabled = true;
		}

		private void DisableControls()
		{
			lstCreditCardType.Enabled = false;
			txtNum.Enabled = false;
			cboExpirationMonth.Enabled = false;
			cboExpirationYear.Enabled = false;
		}

		private bool IsValidData()
		{
			if (rdoCreditCard.Checked) {
				if (lstCreditCardType.SelectedIndex == -1) {
					MessageBox.Show("You must select a credit card type",
						"Entry Error");
					lstCreditCardType.Focus();
					return false;
				}
				if (txtNum.Text == "") {
					MessageBox.Show("You must enter a credit card number",
						"Entry Error");
					txtNum.Focus();
					return false;
				}
				if (cboExpirationMonth.SelectedIndex == 0) {
					MessageBox.Show("You must select a month", "Entry Error");
					cboExpirationMonth.Focus();
					return false;
				}
				if (cboExpirationYear.SelectedIndex == 0) {
					MessageBox.Show("You must select a year", "Entry Error");
					cboExpirationYear.Focus();
					return false;
				}
			}
			return true;
		}

		private void SaveData()
		{
			string msg = null;
			if (rdoCreditCard.Checked)
				msg = "Charge to credit card"
					+ "\n\nCard type: " + lstCreditCardType.Text
					+ "\nCard number: " + txtNum.Text
					+ "\nExpiration date: " + cboExpirationMonth.Text
					+ "/" + cboExpirationYear.Text + "\n";
			else
				msg = "Send bill to customer" + "\n\n";
			msg += "Default billing: " + (bool)chkDefault.Checked;

			this.Tag = msg;
			this.DialogResult = DialogResult.OK;
		}
	}
}
