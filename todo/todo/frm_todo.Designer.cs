namespace todo
{
    partial class frm_todo
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
            lst_todo = new System.Windows.Forms.ListBox();
            btn_add = new System.Windows.Forms.Button();
            btn_edit = new System.Windows.Forms.Button();
            btn_del = new System.Windows.Forms.Button();
            btn_exit = new System.Windows.Forms.Button();
            btn_status = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lst_todo
            // 
            lst_todo.FormattingEnabled = true;
            lst_todo.ItemHeight = 15;
            lst_todo.Location = new System.Drawing.Point(12, 12);
            lst_todo.Name = "lst_todo";
            lst_todo.Size = new System.Drawing.Size(340, 184);
            lst_todo.TabIndex = 0;
            // 
            // btn_add
            // 
            btn_add.Location = new System.Drawing.Point(88, 215);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(58, 23);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new System.Drawing.Point(152, 215);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(58, 23);
            btn_edit.TabIndex = 3;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new System.Drawing.Point(216, 215);
            btn_del.Name = "btn_del";
            btn_del.Size = new System.Drawing.Size(58, 23);
            btn_del.TabIndex = 4;
            btn_del.Text = "Delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new System.Drawing.Point(282, 209);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(50, 35);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_status
            // 
            btn_status.Location = new System.Drawing.Point(30, 209);
            btn_status.Name = "btn_status";
            btn_status.Size = new System.Drawing.Size(50, 35);
            btn_status.TabIndex = 1;
            btn_status.Text = "✔";
            btn_status.UseVisualStyleBackColor = true;
            btn_status.Click += btn_status_Click;
            // 
            // frm_todo
            // 
            AcceptButton = btn_status;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_exit;
            ClientSize = new System.Drawing.Size(364, 261);
            Controls.Add(btn_status);
            Controls.Add(btn_exit);
            Controls.Add(btn_del);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(lst_todo);
            Name = "frm_todo";
            Text = "To-Do List";
            Load += frm_todo_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lst_todo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_status;
    }
}
