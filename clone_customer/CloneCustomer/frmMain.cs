using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerMaintenance;

namespace CloneCustomer
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private Customer customer;
		private List<Customer> customers;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			customer = new Customer("John", "Mendez", "jmendez@msysco.com");
			lblCustomer.Text = customer.GetDisplayText();
		}

		private void btnClone_Click(object sender, EventArgs e)
		{
			if (Validator.IsPresent(txtCopies.Text, txtCopies.Name) != "") {
				MessageBox.Show("You need to enter the amount of copies to create");
				return;
			}
			if (Validator.IsInt32(txtCopies.Text, txtCopies.Name) != "") {
				MessageBox.Show("The amount of copies must be a whole number");
				return;
			}
			int copies = int.Parse(txtCopies.Text);

			customers = new List<Customer>(copies);
			for (int i = 0; i < copies; ++i)
				customers.Add((Customer)customer.Clone());
			foreach (Customer i in customers)
				lstCustomers.Items.Add(i.GetDisplayText());
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
