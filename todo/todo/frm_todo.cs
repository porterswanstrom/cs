using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo
{
	public partial class frm_todo : Form
	{
		public frm_todo()
		{
			InitializeComponent();
		}

		List<item> todo = new List<item>();

		/* get a user's selected todo item */
		private int itm()
		{
			return lst_todo.SelectedIndex;
		}

		private bool valid()
		{
			/* make sure at least 1 todo item exists */
			if (todo.Count < 1) {
				MessageBox.Show("There are currently no todo items",
					"Selection Error");
				return false;
			}
			/* make sure a todo item is selected */
			if (lst_todo.SelectedIndex == -1) {
				MessageBox.Show("Select a todo item from the list",
					"Selection Error");
				return false;
			}
			return true;
		}

		/* redisplay the todo items in the listbox */
		private void refresh()
		{
			lst_todo.Items.Clear();
			foreach (item i in todo)
				lst_todo.Items.Add(i.txt());
		}

		/* autoload todo items used for demonstration purposes */
		private void frm_todo_Load(object sender, EventArgs e)
		{
			todo.Add(new item("start working on a todo list program", false));
			todo.Add(new item("finish the todo list program", true));
			todo.Add(new item("make a presentation for the todo list program", true));
			refresh();
		}

		/* switch the status of the selected todo item */
		private void btn_status_Click(object sender, EventArgs e)
		{
			if (!valid())
				return;
			todo[itm()].done();
			refresh();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			/* get a new todo item */
			frm_item frm = new frm_item();
			item new_todo = frm.add();
			/* if a todo item was created then add it to the list */
			if (new_todo == null)
				return;
			todo.Add(new_todo);
			refresh();
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			if (!valid())
				return;
			frm_item frm = new frm_item();
			/* replace the description of a todo item */
			todo[itm()].desc = frm.edit(todo[itm()].desc);
			refresh();
		}

		/* delete the selected todo item */
		private void btn_del_Click(object sender, EventArgs e)
		{
			if (!valid())
				return;
			todo.RemoveAt(itm());
			refresh();
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
