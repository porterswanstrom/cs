using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace todo
{
	public partial class frm_item : Form
	{
		public frm_item()
		{
			InitializeComponent();
		}

		item todo = null;

		public item add()
		{
			this.ShowDialog();
			return todo;
		}

		private void btn_done_Click(object sender, EventArgs e)
		{
			if (txt_desc.Text == "") {
				MessageBox.Show("Enter a description for the new todo item",
					"Entry Error");
				return;
			}
			todo = new item(txt_desc.Text);
			this.Close();
		}

		public string edit(string desc)
		{
			/* show the old description */
			txt_desc.Text = desc;
			this.ShowDialog();
			/* return the edited description */
			return txt_desc.Text;
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
