namespace temperatures
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
            radio_sf = new System.Windows.Forms.RadioButton();
            radio_ny = new System.Windows.Forms.RadioButton();
            radio_dv = new System.Windows.Forms.RadioButton();
            btn_add = new System.Windows.Forms.Button();
            txt_high_f = new System.Windows.Forms.TextBox();
            txt_add = new System.Windows.Forms.TextBox();
            btn_exit = new System.Windows.Forms.Button();
            lbl_city = new System.Windows.Forms.Label();
            lbl_high = new System.Windows.Forms.Label();
            lbl_low = new System.Windows.Forms.Label();
            txt_high_c = new System.Windows.Forms.TextBox();
            txt_low_c = new System.Windows.Forms.TextBox();
            txt_low_f = new System.Windows.Forms.TextBox();
            lbl_add = new System.Windows.Forms.Label();
            lbl_help = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // radio_sf
            // 
            radio_sf.AutoSize = true;
            radio_sf.Location = new System.Drawing.Point(31, 49);
            radio_sf.Name = "radio_sf";
            radio_sf.Size = new System.Drawing.Size(79, 19);
            radio_sf.TabIndex = 1;
            radio_sf.TabStop = true;
            radio_sf.Text = "Sioux Falls";
            radio_sf.UseVisualStyleBackColor = true;
            radio_sf.CheckedChanged += radio_sf_CheckedChanged;
            // 
            // radio_ny
            // 
            radio_ny.AutoSize = true;
            radio_ny.Location = new System.Drawing.Point(31, 74);
            radio_ny.Name = "radio_ny";
            radio_ny.Size = new System.Drawing.Size(75, 19);
            radio_ny.TabIndex = 2;
            radio_ny.TabStop = true;
            radio_ny.Text = "New York";
            radio_ny.UseVisualStyleBackColor = true;
            radio_ny.CheckedChanged += radio_ny_CheckedChanged;
            // 
            // radio_dv
            // 
            radio_dv.AutoSize = true;
            radio_dv.Location = new System.Drawing.Point(31, 99);
            radio_dv.Name = "radio_dv";
            radio_dv.Size = new System.Drawing.Size(62, 19);
            radio_dv.TabIndex = 3;
            radio_dv.TabStop = true;
            radio_dv.Text = "Denver";
            radio_dv.UseVisualStyleBackColor = true;
            radio_dv.CheckedChanged += radio_dv_CheckedChanged;
            // 
            // btn_add
            // 
            btn_add.Location = new System.Drawing.Point(57, 183);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(115, 36);
            btn_add.TabIndex = 9;
            btn_add.Text = "Add Temperature";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_high_f
            // 
            txt_high_f.Location = new System.Drawing.Point(115, 52);
            txt_high_f.Name = "txt_high_f";
            txt_high_f.ReadOnly = true;
            txt_high_f.Size = new System.Drawing.Size(50, 23);
            txt_high_f.TabIndex = 5;
            txt_high_f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_add
            // 
            txt_add.Location = new System.Drawing.Point(65, 156);
            txt_add.Name = "txt_add";
            txt_add.Size = new System.Drawing.Size(100, 23);
            txt_add.TabIndex = 8;
            // 
            // btn_exit
            // 
            btn_exit.Location = new System.Drawing.Point(82, 227);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(61, 32);
            btn_exit.TabIndex = 10;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_city
            // 
            lbl_city.AutoSize = true;
            lbl_city.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_city.Location = new System.Drawing.Point(34, 27);
            lbl_city.Name = "lbl_city";
            lbl_city.Size = new System.Drawing.Size(64, 17);
            lbl_city.TabIndex = 0;
            lbl_city.Text = "Pick a city";
            // 
            // lbl_high
            // 
            lbl_high.AutoSize = true;
            lbl_high.Location = new System.Drawing.Point(115, 34);
            lbl_high.Name = "lbl_high";
            lbl_high.Size = new System.Drawing.Size(101, 15);
            lbl_high.TabIndex = 4;
            lbl_high.Text = "High temperature";
            // 
            // lbl_low
            // 
            lbl_low.AutoSize = true;
            lbl_low.Location = new System.Drawing.Point(117, 78);
            lbl_low.Name = "lbl_low";
            lbl_low.Size = new System.Drawing.Size(97, 15);
            lbl_low.TabIndex = 6;
            lbl_low.Text = "Low temperature";
            // 
            // txt_high_c
            // 
            txt_high_c.Location = new System.Drawing.Point(166, 52);
            txt_high_c.Name = "txt_high_c";
            txt_high_c.ReadOnly = true;
            txt_high_c.Size = new System.Drawing.Size(50, 23);
            txt_high_c.TabIndex = 11;
            txt_high_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_low_c
            // 
            txt_low_c.Location = new System.Drawing.Point(166, 96);
            txt_low_c.Name = "txt_low_c";
            txt_low_c.ReadOnly = true;
            txt_low_c.Size = new System.Drawing.Size(50, 23);
            txt_low_c.TabIndex = 13;
            txt_low_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_low_f
            // 
            txt_low_f.Location = new System.Drawing.Point(115, 96);
            txt_low_f.Name = "txt_low_f";
            txt_low_f.ReadOnly = true;
            txt_low_f.Size = new System.Drawing.Size(50, 23);
            txt_low_f.TabIndex = 12;
            txt_low_f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_add
            // 
            lbl_add.AutoSize = true;
            lbl_add.Location = new System.Drawing.Point(12, 137);
            lbl_add.Name = "lbl_add";
            lbl_add.Size = new System.Drawing.Size(224, 15);
            lbl_add.TabIndex = 14;
            lbl_add.Text = "Enter a new Fahrenheit temperature here:";
            // 
            // lbl_help
            // 
            lbl_help.AutoSize = true;
            lbl_help.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_help.Location = new System.Drawing.Point(19, 3);
            lbl_help.Name = "lbl_help";
            lbl_help.Size = new System.Drawing.Size(208, 12);
            lbl_help.TabIndex = 15;
            lbl_help.Text = "Results are from the past 30 recorded temperatures";
            // 
            // frm_main
            // 
            AcceptButton = btn_add;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_exit;
            ClientSize = new System.Drawing.Size(244, 281);
            Controls.Add(lbl_help);
            Controls.Add(lbl_add);
            Controls.Add(txt_low_c);
            Controls.Add(txt_low_f);
            Controls.Add(txt_high_c);
            Controls.Add(lbl_low);
            Controls.Add(lbl_high);
            Controls.Add(lbl_city);
            Controls.Add(btn_exit);
            Controls.Add(txt_add);
            Controls.Add(txt_high_f);
            Controls.Add(btn_add);
            Controls.Add(radio_dv);
            Controls.Add(radio_ny);
            Controls.Add(radio_sf);
            Name = "frm_main";
            Text = "Temperatures";
            Load += frm_main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RadioButton radio_sf;
        private System.Windows.Forms.RadioButton radio_ny;
        private System.Windows.Forms.RadioButton radio_dv;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_high_f;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_high;
        private System.Windows.Forms.Label lbl_low;
        private System.Windows.Forms.TextBox txt_high_c;
        private System.Windows.Forms.TextBox txt_low_c;
        private System.Windows.Forms.TextBox txt_low_f;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.Label lbl_help;
    }
}
