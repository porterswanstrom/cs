namespace CloneCustomer
{
    partial class frmMain
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
            lblCustomer = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtCopies = new System.Windows.Forms.TextBox();
            btnClone = new System.Windows.Forms.Button();
            lstCustomers = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(341, 232);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(88, 27);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // lblCustomer
            // 
            lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblCustomer.Location = new System.Drawing.Point(14, 10);
            lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new System.Drawing.Size(308, 46);
            lblCustomer.TabIndex = 18;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(23, 66);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 27);
            label1.TabIndex = 17;
            label1.Text = "Copies:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCopies
            // 
            txtCopies.Location = new System.Drawing.Point(89, 66);
            txtCopies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new System.Drawing.Size(55, 23);
            txtCopies.TabIndex = 16;
            txtCopies.Tag = "Copies";
            // 
            // btnClone
            // 
            btnClone.Location = new System.Drawing.Point(163, 66);
            btnClone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClone.Name = "btnClone";
            btnClone.Size = new System.Drawing.Size(88, 27);
            btnClone.TabIndex = 15;
            btnClone.Text = "Clone";
            btnClone.Click += btnClone_Click;
            // 
            // lstCustomers
            // 
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new System.Drawing.Point(14, 103);
            lstCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new System.Drawing.Size(307, 154);
            lstCustomers.TabIndex = 14;
            // 
            // frmMain
            // 
            AcceptButton = btnClone;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(451, 271);
            Controls.Add(btnExit);
            Controls.Add(lblCustomer);
            Controls.Add(label1);
            Controls.Add(txtCopies);
            Controls.Add(btnClone);
            Controls.Add(lstCustomers);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clone Customer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.ListBox lstCustomers;
    }
}

