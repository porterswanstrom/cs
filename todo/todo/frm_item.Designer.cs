namespace todo
{
    partial class frm_item
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
            txt_desc = new System.Windows.Forms.TextBox();
            btn_done = new System.Windows.Forms.Button();
            btn_cancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txt_desc
            // 
            txt_desc.Location = new System.Drawing.Point(12, 27);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new System.Drawing.Size(349, 23);
            txt_desc.TabIndex = 0;
            // 
            // btn_done
            // 
            btn_done.Location = new System.Drawing.Point(367, 27);
            btn_done.Name = "btn_done";
            btn_done.Size = new System.Drawing.Size(51, 23);
            btn_done.TabIndex = 1;
            btn_done.Text = "Done";
            btn_done.UseVisualStyleBackColor = true;
            btn_done.Click += btn_done_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new System.Drawing.Point(421, 27);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new System.Drawing.Size(51, 23);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // frm_item
            // 
            AcceptButton = btn_done;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_cancel;
            ClientSize = new System.Drawing.Size(484, 71);
            Controls.Add(btn_cancel);
            Controls.Add(btn_done);
            Controls.Add(txt_desc);
            Name = "frm_item";
            Text = "New To-Do Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_cancel;
    }
}