namespace Payment
{
    partial class frmPayment
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
            if (disposing && (components != null)) {
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
            boxBilling = new System.Windows.Forms.GroupBox();
            rdoBill = new System.Windows.Forms.RadioButton();
            rdoCreditCard = new System.Windows.Forms.RadioButton();
            lblCard = new System.Windows.Forms.Label();
            lstCreditCardType = new System.Windows.Forms.ListBox();
            lblNum = new System.Windows.Forms.Label();
            txtNum = new System.Windows.Forms.TextBox();
            lblExpire = new System.Windows.Forms.Label();
            cboExpirationMonth = new System.Windows.Forms.ComboBox();
            cboExpirationYear = new System.Windows.Forms.ComboBox();
            chkDefault = new System.Windows.Forms.CheckBox();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            boxBilling.SuspendLayout();
            SuspendLayout();
            // 
            // boxBilling
            // 
            boxBilling.Controls.Add(rdoBill);
            boxBilling.Controls.Add(rdoCreditCard);
            boxBilling.Location = new System.Drawing.Point(17, 12);
            boxBilling.Name = "boxBilling";
            boxBilling.Size = new System.Drawing.Size(320, 58);
            boxBilling.TabIndex = 0;
            boxBilling.TabStop = false;
            boxBilling.Text = "Billing";
            // 
            // rdoBill
            // 
            rdoBill.AutoSize = true;
            rdoBill.Location = new System.Drawing.Point(189, 22);
            rdoBill.Name = "rdoBill";
            rdoBill.Size = new System.Drawing.Size(94, 19);
            rdoBill.TabIndex = 1;
            rdoBill.Text = "Bill customer";
            rdoBill.UseVisualStyleBackColor = true;
            rdoBill.CheckedChanged += Billing_CheckedChanged;
            // 
            // rdoCreditCard
            // 
            rdoCreditCard.AutoSize = true;
            rdoCreditCard.Checked = true;
            rdoCreditCard.Location = new System.Drawing.Point(33, 22);
            rdoCreditCard.Name = "rdoCreditCard";
            rdoCreditCard.Size = new System.Drawing.Size(83, 19);
            rdoCreditCard.TabIndex = 0;
            rdoCreditCard.TabStop = true;
            rdoCreditCard.Text = "Credit card";
            rdoCreditCard.UseVisualStyleBackColor = true;
            rdoCreditCard.CheckedChanged += Billing_CheckedChanged;
            // 
            // lblCard
            // 
            lblCard.AutoSize = true;
            lblCard.Location = new System.Drawing.Point(8, 86);
            lblCard.Name = "lblCard";
            lblCard.Size = new System.Drawing.Size(94, 15);
            lblCard.TabIndex = 1;
            lblCard.Text = "Credit card type:";
            // 
            // lstCreditCardType
            // 
            lstCreditCardType.FormattingEnabled = true;
            lstCreditCardType.ItemHeight = 15;
            lstCreditCardType.Location = new System.Drawing.Point(105, 86);
            lstCreditCardType.Name = "lstCreditCardType";
            lstCreditCardType.Size = new System.Drawing.Size(238, 79);
            lstCreditCardType.TabIndex = 2;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new System.Drawing.Point(8, 174);
            lblNum.Name = "lblNum";
            lblNum.Size = new System.Drawing.Size(80, 15);
            lblNum.TabIndex = 3;
            lblNum.Text = "Card number:";
            // 
            // txtNum
            // 
            txtNum.Location = new System.Drawing.Point(105, 174);
            txtNum.Name = "txtNum";
            txtNum.Size = new System.Drawing.Size(238, 23);
            txtNum.TabIndex = 4;
            // 
            // lblExpire
            // 
            lblExpire.AutoSize = true;
            lblExpire.Location = new System.Drawing.Point(8, 213);
            lblExpire.Name = "lblExpire";
            lblExpire.Size = new System.Drawing.Size(88, 15);
            lblExpire.TabIndex = 5;
            lblExpire.Text = "Expiration date:";
            // 
            // cboExpirationMonth
            // 
            cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboExpirationMonth.FormattingEnabled = true;
            cboExpirationMonth.Location = new System.Drawing.Point(105, 213);
            cboExpirationMonth.Name = "cboExpirationMonth";
            cboExpirationMonth.Size = new System.Drawing.Size(116, 23);
            cboExpirationMonth.TabIndex = 6;
            // 
            // cboExpirationYear
            // 
            cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboExpirationYear.FormattingEnabled = true;
            cboExpirationYear.Location = new System.Drawing.Point(227, 213);
            cboExpirationYear.Name = "cboExpirationYear";
            cboExpirationYear.Size = new System.Drawing.Size(116, 23);
            cboExpirationYear.TabIndex = 7;
            // 
            // chkDefault
            // 
            chkDefault.AutoSize = true;
            chkDefault.Checked = true;
            chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            chkDefault.Location = new System.Drawing.Point(14, 252);
            chkDefault.Name = "chkDefault";
            chkDefault.Size = new System.Drawing.Size(177, 19);
            chkDefault.TabIndex = 8;
            chkDefault.Text = "Set as default billing method";
            chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(177, 286);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(75, 23);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(259, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(354, 321);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkDefault);
            Controls.Add(cboExpirationYear);
            Controls.Add(cboExpirationMonth);
            Controls.Add(lblExpire);
            Controls.Add(txtNum);
            Controls.Add(lblNum);
            Controls.Add(lstCreditCardType);
            Controls.Add(lblCard);
            Controls.Add(boxBilling);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmPayment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += frmPayment_Load;
            boxBilling.ResumeLayout(false);
            boxBilling.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox boxBilling;
        private System.Windows.Forms.RadioButton rdoBill;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblExpire;
        private System.Windows.Forms.ComboBox cboExpirationMonth;
        private System.Windows.Forms.ComboBox cboExpirationYear;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}