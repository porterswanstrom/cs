using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
	public partial class frmCustomers : Form
	{
		public frmCustomers()
		{
			InitializeComponent();
		}

		public List<Customer> customers = null;

		private void frmCustomers_Load(object sender, EventArgs e)
		{
			customers = CustomerDB.GetCustomers();
			foreach (Customer i in customers)
				lstCustomers.Items.Add(i.GetDisplayText());
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmAddCustomer customer = new frmAddCustomer();
			Customer newCustomer = customer.GetNewCustomer();
			if (newCustomer != null)
				customers.Add(newCustomer);

			CustomerDB.SaveCustomers(customers);
			lstCustomers.Items.Clear();
			foreach (Customer i in customers)
				lstCustomers.Items.Add(i.GetDisplayText());
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lstCustomers.SelectedIndex != -1)
				customers.RemoveAt(lstCustomers.SelectedIndex);

			CustomerDB.SaveCustomers(customers);
			lstCustomers.Items.Clear();
			foreach (Customer i in customers)
				lstCustomers.Items.Add(i.GetDisplayText());
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
