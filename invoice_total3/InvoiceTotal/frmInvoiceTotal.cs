using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
	public partial class frmInvoiceTotal : Form
	{
		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try {
				if (txtSubtotal.Text == "") {
					MessageBox.Show("Please enter a subtotal",
						"Entry Error");
					return;
				}
				decimal subtotal = Decimal.Parse(txtSubtotal.Text);
				if (subtotal <= 0 || subtotal >= 10000) {
					MessageBox.Show("The subtotal must be in the "
						+ "range of 1 to 9999", "Entry Error");
					return;
				}
				decimal discountPercent = .25m;
				decimal discountAmount = subtotal * discountPercent;
				decimal invoiceTotal = subtotal - discountAmount;

				discountAmount = Math.Round(discountAmount, 2);
				invoiceTotal = Math.Round(invoiceTotal, 2);

				txtDiscountPercent.Text = discountPercent.ToString("p1");
				txtDiscountAmount.Text = discountAmount.ToString();
				txtTotal.Text = invoiceTotal.ToString();
				txtSubtotal.Focus();
			}
			catch {
				MessageBox.Show(
					"Please enter a valid subtotal for the "
					+ "subtotal field.", "Entry Error");
			}

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}