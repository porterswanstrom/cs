namespace InvoiceTotal
{
    partial class frmInvoiceTotal3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomerType = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            btnCalculate = new System.Windows.Forms.Button();
            txtSubtotal = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtDiscountPercent = new System.Windows.Forms.TextBox();
            txtDiscountAmount = new System.Windows.Forms.TextBox();
            txtTotal = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtCustomerType
            // 
            txtCustomerType.Location = new System.Drawing.Point(147, 10);
            txtCustomerType.Margin = new System.Windows.Forms.Padding(4);
            txtCustomerType.Name = "txtCustomerType";
            txtCustomerType.Size = new System.Drawing.Size(98, 23);
            txtCustomerType.TabIndex = 1;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(25, 10);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(109, 23);
            label5.TabIndex = 0;
            label5.Text = "Customer &type:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(25, 75);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(109, 23);
            label4.TabIndex = 4;
            label4.Text = "Discount percent:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(158, 186);
            btnExit.Margin = new System.Windows.Forms.Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(88, 26);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(48, 186);
            btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(88, 26);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "&Calculate";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new System.Drawing.Point(147, 43);
            txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(98, 23);
            txtSubtotal.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(25, 140);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 23);
            label3.TabIndex = 8;
            label3.Text = "Total:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(25, 107);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 23);
            label2.TabIndex = 6;
            label2.Text = "Discount amount:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(25, 43);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 23);
            label1.TabIndex = 2;
            label1.Text = "&Subtotal:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Location = new System.Drawing.Point(147, 74);
            txtDiscountPercent.Margin = new System.Windows.Forms.Padding(4);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.ReadOnly = true;
            txtDiscountPercent.Size = new System.Drawing.Size(98, 23);
            txtDiscountPercent.TabIndex = 5;
            txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new System.Drawing.Point(147, 107);
            txtDiscountAmount.Margin = new System.Windows.Forms.Padding(4);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new System.Drawing.Size(98, 23);
            txtDiscountAmount.TabIndex = 7;
            txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(147, 141);
            txtTotal.Margin = new System.Windows.Forms.Padding(4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(98, 23);
            txtTotal.TabIndex = 9;
            txtTotal.TabStop = false;
            // 
            // frmInvoiceTotal3
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(277, 229);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(txtCustomerType);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtSubtotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmInvoiceTotal3";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            Load += frmInvoiceTotal3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

