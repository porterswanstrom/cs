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
    public partial class frmInvoiceTotal3 : Form
    {
        public frmInvoiceTotal3()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			string customerType = txtCustomerType.Text.ToUpper();
			decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
			decimal discountPercent = .0m;

			/* if (customerType == "R") {
				if (subtotal >= 250 && subtotal < 500)
					discountPercent = .25m;
				else if (subtotal >= 500)
					discountPercent = .3m;
				else
					discountPercent = .1m;
			}
			else if (customerType == "C")
				discountPercent = .2m;
			else if (customerType == "T")
				if (subtotal >= 500)
					discountPercent = .5m;
				else
					discountPercent = .4m;
			else
				discountPercent = .1m; */

			switch (customerType) {
				case "R":
					if (subtotal >= 250 && subtotal < 500)
						discountPercent = .25m;
					else if (subtotal >= 500)
						discountPercent = .3m;
					else
						discountPercent = .1m;
					break;
				case "C":
					discountPercent = .2m;
					break;
				case "T":
					if (subtotal >= 500)
						discountPercent = .5m;
					else
						discountPercent = .4m;
					break;
				default:
					discountPercent = .1m;
					break;
			}

			decimal discountAmount = subtotal * discountPercent;
			decimal invoiceTotal = subtotal - discountAmount;

			txtDiscountPercent.Text = discountPercent.ToString("p1");
			txtDiscountAmount.Text = discountAmount.ToString("c");
			txtTotal.Text = invoiceTotal.ToString("c");

			txtCustomerType.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmInvoiceTotal3_Load(object sender, EventArgs e)
		{
			txtSubtotal.Text = "";
		}

	}
}
