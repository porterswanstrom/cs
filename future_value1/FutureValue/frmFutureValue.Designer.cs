namespace FutureValue
{
    partial class frmFutureValue
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
            btnExit = new System.Windows.Forms.Button();
            btnCalculate = new System.Windows.Forms.Button();
            txtYears = new System.Windows.Forms.TextBox();
            txtInterestRate = new System.Windows.Forms.TextBox();
            txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtFutureValue = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(164, 145);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(88, 27);
            btnExit.TabIndex = 19;
            btnExit.Text = "E&xit";
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(63, 145);
            btnCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(88, 27);
            btnCalculate.TabIndex = 18;
            btnCalculate.Text = "&Calculate";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtYears
            // 
            txtYears.Location = new System.Drawing.Point(154, 74);
            txtYears.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtYears.Name = "txtYears";
            txtYears.Size = new System.Drawing.Size(97, 23);
            txtYears.TabIndex = 17;
            txtYears.TextChanged += ClearFutureValue;
            txtYears.DoubleClick += txtYears_DoubleClick;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new System.Drawing.Point(154, 43);
            txtInterestRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new System.Drawing.Size(97, 23);
            txtInterestRate.TabIndex = 16;
            txtInterestRate.TextChanged += ClearFutureValue;
            txtInterestRate.DoubleClick += txtInterestRate_DoubleClick;
            // 
            // txtMonthlyInvestment
            // 
            txtMonthlyInvestment.Location = new System.Drawing.Point(154, 10);
            txtMonthlyInvestment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            txtMonthlyInvestment.Size = new System.Drawing.Size(97, 23);
            txtMonthlyInvestment.TabIndex = 15;
            txtMonthlyInvestment.TextChanged += ClearFutureValue;
            txtMonthlyInvestment.MouseHover += ClearFutureValue;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(14, 106);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 23);
            label4.TabIndex = 13;
            label4.Text = "Future Value:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(14, 74);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 23);
            label3.TabIndex = 12;
            label3.Text = "Number of Years:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(14, 43);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 23);
            label2.TabIndex = 11;
            label2.Text = "Yearly Interest Rate:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 23);
            label1.TabIndex = 10;
            label1.Text = "Monthly Investment:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new System.Drawing.Point(154, 107);
            txtFutureValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.ReadOnly = true;
            txtFutureValue.Size = new System.Drawing.Size(97, 23);
            txtFutureValue.TabIndex = 20;
            txtFutureValue.TabStop = false;
            // 
            // frmFutureValue
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(284, 185);
            Controls.Add(txtFutureValue);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtYears);
            Controls.Add(txtInterestRate);
            Controls.Add(txtMonthlyInvestment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmFutureValue";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Future Value";
            DoubleClick += frmFutureValue_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFutureValue;
    }
}
