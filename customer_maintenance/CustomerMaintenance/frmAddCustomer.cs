using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomerMaintenance
{
	public partial class frmAddCustomer : Form
	{
		public frmAddCustomer()
		{
			InitializeComponent();
		}

		Customer customer = null;

		public Customer GetNewCustomer()
		{
			this.ShowDialog();
			return customer;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string msg = ""
				+ Validator.IsPresent(txtFirstName.Text, txtFirstName.Tag.ToString())
				+ Validator.IsPresent(txtLastName.Text, txtLastName.Tag.ToString())
				+ Validator.IsValidEmail(txtEmail.Text, txtEmail.Tag.ToString());
			if (msg != "") {
				MessageBox.Show(msg, "Entry Error");
				return;
			}

			customer = new Customer(txtFirstName.Text, txtLastName.Text,
				txtEmail.Text);
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
