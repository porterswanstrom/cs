namespace txt_to_html
{
    partial class frm_main
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
            if (disposing && (components != null)) {
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
            lbl_help = new System.Windows.Forms.Label();
            btn_convert = new System.Windows.Forms.Button();
            btn_exit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbl_help
            // 
            lbl_help.AutoSize = true;
            lbl_help.Location = new System.Drawing.Point(43, 49);
            lbl_help.Name = "lbl_help";
            lbl_help.Size = new System.Drawing.Size(204, 15);
            lbl_help.TabIndex = 0;
            lbl_help.Text = "Upload a .txt file to convert it to html.";
            // 
            // btn_convert
            // 
            btn_convert.ForeColor = System.Drawing.Color.Green;
            btn_convert.Location = new System.Drawing.Point(78, 79);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new System.Drawing.Size(129, 32);
            btn_convert.TabIndex = 1;
            btn_convert.Text = "Upload and Convert";
            btn_convert.UseVisualStyleBackColor = true;
            btn_convert.Click += btn_convert_Click;
            // 
            // btn_exit
            // 
            btn_exit.ForeColor = System.Drawing.Color.Maroon;
            btn_exit.Location = new System.Drawing.Point(101, 117);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(75, 32);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // frm_main
            // 
            AcceptButton = btn_convert;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_exit;
            ClientSize = new System.Drawing.Size(284, 201);
            Controls.Add(btn_exit);
            Controls.Add(btn_convert);
            Controls.Add(lbl_help);
            Name = "frm_main";
            Text = "Text to html";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_exit;
    }
}
