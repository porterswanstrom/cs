namespace InvoiceTotal
{
	partial class frmInvoiceTotal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblEnterSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtAvgInvoice = new System.Windows.Forms.TextBox();
            this.txtInvoicesTotal = new System.Windows.Forms.TextBox();
            this.txtNumInvoices = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAvgInvoice = new System.Windows.Forms.Label();
            this.lblInvoicesTotal = new System.Windows.Forms.Label();
            this.lblNumInvoices = new System.Windows.Forms.Label();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.txtSmallestInvoice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLargestInvoice = new System.Windows.Forms.Label();
            this.lblSmallestInvoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterSubtotal
            // 
            this.lblEnterSubtotal.AutoSize = true;
            this.lblEnterSubtotal.Location = new System.Drawing.Point(16, 29);
            this.lblEnterSubtotal.Name = "lblEnterSubtotal";
            this.lblEnterSubtotal.Size = new System.Drawing.Size(77, 13);
            this.lblEnterSubtotal.TabIndex = 0;
            this.lblEnterSubtotal.Text = "Enter &Subtotal:";
            this.lblEnterSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(16, 82);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(92, 13);
            this.lblDiscountPercent.TabIndex = 4;
            this.lblDiscountPercent.Text = "Discount Percent:";
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(17, 109);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(91, 13);
            this.lblDiscountAmount.TabIndex = 6;
            this.lblDiscountAmount.Text = "Discount Amount:";
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(17, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Location = new System.Drawing.Point(111, 26);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtEnterSubtotal.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(176, 176);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(338, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(111, 79);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountPercent.TabIndex = 5;
            this.txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(111, 106);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountAmount.TabIndex = 7;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(111, 132);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(257, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(111, 52);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 15;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(17, 55);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAvgInvoice
            // 
            this.txtAvgInvoice.Location = new System.Drawing.Point(322, 104);
            this.txtAvgInvoice.Name = "txtAvgInvoice";
            this.txtAvgInvoice.ReadOnly = true;
            this.txtAvgInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtAvgInvoice.TabIndex = 17;
            this.txtAvgInvoice.TabStop = false;
            // 
            // txtInvoicesTotal
            // 
            this.txtInvoicesTotal.Location = new System.Drawing.Point(322, 130);
            this.txtInvoicesTotal.Name = "txtInvoicesTotal";
            this.txtInvoicesTotal.ReadOnly = true;
            this.txtInvoicesTotal.Size = new System.Drawing.Size(100, 20);
            this.txtInvoicesTotal.TabIndex = 19;
            this.txtInvoicesTotal.TabStop = false;
            // 
            // txtNumInvoices
            // 
            this.txtNumInvoices.Location = new System.Drawing.Point(322, 26);
            this.txtNumInvoices.Name = "txtNumInvoices";
            this.txtNumInvoices.ReadOnly = true;
            this.txtNumInvoices.Size = new System.Drawing.Size(100, 20);
            this.txtNumInvoices.TabIndex = 11;
            this.txtNumInvoices.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 21;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 20;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvgInvoice
            // 
            this.lblAvgInvoice.AutoSize = true;
            this.lblAvgInvoice.Location = new System.Drawing.Point(221, 107);
            this.lblAvgInvoice.Name = "lblAvgInvoice";
            this.lblAvgInvoice.Size = new System.Drawing.Size(87, 13);
            this.lblAvgInvoice.TabIndex = 16;
            this.lblAvgInvoice.Text = "Invoice average:";
            this.lblAvgInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoicesTotal
            // 
            this.lblInvoicesTotal.AutoSize = true;
            this.lblInvoicesTotal.Location = new System.Drawing.Point(221, 133);
            this.lblInvoicesTotal.Name = "lblInvoicesTotal";
            this.lblInvoicesTotal.Size = new System.Drawing.Size(88, 13);
            this.lblInvoicesTotal.TabIndex = 18;
            this.lblInvoicesTotal.Text = "Total of invoices:";
            this.lblInvoicesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumInvoices
            // 
            this.lblNumInvoices.AutoSize = true;
            this.lblNumInvoices.Location = new System.Drawing.Point(220, 29);
            this.lblNumInvoices.Name = "lblNumInvoices";
            this.lblNumInvoices.Size = new System.Drawing.Size(101, 13);
            this.lblNumInvoices.TabIndex = 10;
            this.lblNumInvoices.Text = "Number of invoices:";
            this.lblNumInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Location = new System.Drawing.Point(322, 78);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.ReadOnly = true;
            this.txtLargestInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtLargestInvoice.TabIndex = 15;
            this.txtLargestInvoice.TabStop = false;
            // 
            // txtSmallestInvoice
            // 
            this.txtSmallestInvoice.Location = new System.Drawing.Point(322, 52);
            this.txtSmallestInvoice.Name = "txtSmallestInvoice";
            this.txtSmallestInvoice.ReadOnly = true;
            this.txtSmallestInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtSmallestInvoice.TabIndex = 13;
            this.txtSmallestInvoice.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(324, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 27;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLargestInvoice
            // 
            this.lblLargestInvoice.AutoSize = true;
            this.lblLargestInvoice.Location = new System.Drawing.Point(221, 81);
            this.lblLargestInvoice.Name = "lblLargestInvoice";
            this.lblLargestInvoice.Size = new System.Drawing.Size(82, 13);
            this.lblLargestInvoice.TabIndex = 14;
            this.lblLargestInvoice.Text = "Largest invoice:";
            this.lblLargestInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSmallestInvoice
            // 
            this.lblSmallestInvoice.AutoSize = true;
            this.lblSmallestInvoice.Location = new System.Drawing.Point(221, 55);
            this.lblSmallestInvoice.Name = "lblSmallestInvoice";
            this.lblSmallestInvoice.Size = new System.Drawing.Size(83, 13);
            this.lblSmallestInvoice.TabIndex = 12;
            this.lblSmallestInvoice.Text = "Smallest invoice";
            this.lblSmallestInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(444, 221);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.txtSmallestInvoice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblLargestInvoice);
            this.Controls.Add(this.lblSmallestInvoice);
            this.Controls.Add(this.txtAvgInvoice);
            this.Controls.Add(this.txtInvoicesTotal);
            this.Controls.Add(this.txtNumInvoices);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAvgInvoice);
            this.Controls.Add(this.lblInvoicesTotal);
            this.Controls.Add(this.lblNumInvoices);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblEnterSubtotal);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEnterSubtotal;
		private System.Windows.Forms.Label lblDiscountPercent;
		private System.Windows.Forms.Label lblDiscountAmount;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEnterSubtotal;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtDiscountPercent;
		private System.Windows.Forms.TextBox txtDiscountAmount;
		private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtAvgInvoice;
        private System.Windows.Forms.TextBox txtInvoicesTotal;
        private System.Windows.Forms.TextBox txtNumInvoices;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAvgInvoice;
        private System.Windows.Forms.Label lblInvoicesTotal;
        private System.Windows.Forms.Label lblNumInvoices;
        private System.Windows.Forms.TextBox txtLargestInvoice;
        private System.Windows.Forms.TextBox txtSmallestInvoice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLargestInvoice;
        private System.Windows.Forms.Label lblSmallestInvoice;
    }
}

