namespace Payment
{
    partial class frmCustomer
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
            btnSave = new System.Windows.Forms.Button();
            lblPayment = new System.Windows.Forms.Label();
            btnSelectPayment = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cboNames = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(294, 209);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(88, 27);
            btnExit.TabIndex = 21;
            btnExit.Text = "E&xit";
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(191, 209);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 20;
            btnSave.Text = "&Save";
            btnSave.Click += btnSave_Click;
            // 
            // lblPayment
            // 
            lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPayment.Location = new System.Drawing.Point(14, 89);
            lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new System.Drawing.Size(233, 92);
            lblPayment.TabIndex = 19;
            lblPayment.TextChanged += lblPayment_TextChanged;
            // 
            // btnSelectPayment
            // 
            btnSelectPayment.Location = new System.Drawing.Point(266, 89);
            btnSelectPayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSelectPayment.Name = "btnSelectPayment";
            btnSelectPayment.Size = new System.Drawing.Size(121, 27);
            btnSelectPayment.TabIndex = 18;
            btnSelectPayment.Text = "Select Payment";
            btnSelectPayment.Click += btnSelectPayment_Click;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(14, 61);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 27);
            label2.TabIndex = 17;
            label2.Text = "Payment method:";
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(14, 15);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 27);
            label1.TabIndex = 16;
            label1.Text = "Customer name:";
            // 
            // cboNames
            // 
            cboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboNames.FormattingEnabled = true;
            cboNames.Location = new System.Drawing.Point(154, 15);
            cboNames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboNames.Name = "cboNames";
            cboNames.Size = new System.Drawing.Size(233, 23);
            cboNames.TabIndex = 15;
            cboNames.SelectedIndexChanged += cboNames_SelectedIndexChanged;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(406, 252);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(lblPayment);
            Controls.Add(btnSelectPayment);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboNames);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmCustomer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Customer";
            FormClosing += frmCustomer_FormClosing;
            Load += frmCustomer_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnSelectPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNames;
    }
}

