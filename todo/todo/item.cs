using System;
using System.Collections.Generic;
using System.Text;

namespace todo
{
	public class item
	{
		public string desc{get; set;}
		public bool todo{get; set;}

		public item(string arg_desc = "", bool arg_todo = true) =>
			(this.desc, this.todo) = (arg_desc, arg_todo);

		/* return a todo item description prefixed by its status */
		public string txt()
		{
			if (todo)
				return ("TODO: " + desc);
			else
				return ("DONE: " + desc);
		}

		/* switch the status of a todo item */
		public void done()
		{
			if (todo)
				todo = false;
			else
				todo = true;
		}
	}
}
