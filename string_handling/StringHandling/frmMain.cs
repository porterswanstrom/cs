#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnParseName_Click(object sender, System.EventArgs e)
		{
			// DONE: Add code to parse name
			string fName = "";
			string? mName = null;
			string lName = "";

			string name = txtFullName.Text.Trim();
			string[] names = name.ToLower().Split(' ');

			if (names.Length == 2) {
				fName = names[0];
				lName = names[1];
			}
			else if (names.Length == 3) {
				fName = names[0];
				mName = names[1];
				lName = names[2];
			}
			else {
				MessageBox.Show("You need to enter a full name "
					+ "consisting of 2 or optionally 3 words",
					"Error");
				return;
			}

			string msg = "First name:\t" + ToInitialCap(fName)
				+ "\n\nMiddle Name:";
			if (mName != null)
				msg += "\t" + ToInitialCap(mName);
			msg += "\n\nLast name:\t" + ToInitialCap(lName);

			MessageBox.Show(msg, "Parse Name");
		}

		private void btnEditPhoneNumber_Click(object sender, System.EventArgs e)
		{
			// DONE: Add code to edit the phone number
			string phone = txtPhoneNumber.Text.Trim();

			string digits = "";
			foreach (char i in phone)
				if (i >= '0' && i <= '9')
					digits += i;

			string standard = digits;
			standard = standard.Insert(3, "-");
			standard = standard.Insert(7, "-");

			MessageBox.Show("Entered:\t\t"
				+ phone + "\n\nDigits only:\t"
				+ digits + "\n\nStandard format:\t"
				+ standard, "Edit Phone Number");
		}

		// DONE: Add ToInitialCap method here
		private string ToInitialCap(string s)
		{
			return s[0].ToString().ToUpper()
				+ s.Remove(0, 1);
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}
