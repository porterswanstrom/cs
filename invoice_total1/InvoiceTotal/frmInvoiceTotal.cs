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

		int numInvoices = 0;
		decimal smallestInvoice = Decimal.MaxValue;
		decimal largestInvoice = 0m;
        decimal avgInvoice = 0m;
        decimal invoicesTotal = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal subtotal = Decimal.Parse(txtEnterSubtotal.Text);
			decimal discountPercent = .25m;
			decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
			decimal invoiceTotal = Math.Round(subtotal - discountAmount, 2);

            numInvoices++;
            invoicesTotal += invoiceTotal;
			avgInvoice = invoicesTotal / numInvoices;

			if (invoiceTotal < smallestInvoice)
				smallestInvoice = invoiceTotal;
			if (invoiceTotal > largestInvoice)
				largestInvoice = invoiceTotal;

			txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountPercent.Text = discountPercent.ToString("p1");
			txtDiscountAmount.Text = discountAmount.ToString("c");
			txtTotal.Text = invoiceTotal.ToString("c");
			txtNumInvoices.Text = numInvoices.ToString();
            txtSmallestInvoice.Text = smallestInvoice.ToString("c");
            txtLargestInvoice.Text = largestInvoice.ToString("c");
            txtAvgInvoice.Text = avgInvoice.ToString("c");
            txtInvoicesTotal.Text = invoicesTotal.ToString("c");

            txtEnterSubtotal.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void btnClear_Click(object sender, EventArgs e)
        {
            numInvoices = 0;
            smallestInvoice = Decimal.MaxValue;
            largestInvoice = 0m;
            avgInvoice = 0m;
            invoicesTotal = 0m;

            txtEnterSubtotal.Text = "";
			txtSubtotal.Text = "";
			txtDiscountPercent.Text = "";
			txtDiscountAmount.Text = "";
			txtTotal.Text = "";
			txtNumInvoices.Text = "";
			txtInvoicesTotal.Text = "";
			txtSmallestInvoice.Text = "";
			txtLargestInvoice.Text = "";
            txtAvgInvoice.Text = "";

			txtEnterSubtotal.Focus();
        }
    }
}