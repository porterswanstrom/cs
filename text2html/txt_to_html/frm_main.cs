using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* to read/write files */
using System.IO;

namespace txt_to_html
{
	public partial class frm_main : Form
	{
		public frm_main()
		{
			InitializeComponent();
		}

		private void btn_convert_Click(object sender, EventArgs e)
		{
			/* show a dialog that lets the user choose a text file to read */
			OpenFileDialog txt = new OpenFileDialog();
			txt.Filter = "Text File|*.txt";
			if (txt.ShowDialog() != DialogResult.OK)
				return;

			/* show a dialog that lets the user create an output html file */
			SaveFileDialog html = new SaveFileDialog();
			html.Filter = "Hyper Text Markup File|*.html";
			if (html.ShowDialog() != DialogResult.OK)
				return;

			/* copy the contents of the selected text file to an array */
			string[] input = File.ReadAllLines(txt.FileName);

			/* create the output html file and start writing the html */
			StreamWriter output = File.CreateText(html.FileName);
			output.WriteLine("<html><body bgcolor='#F6F3F0'>");
			for (int i = 0; i < input.Count(); i++)
				/* check for special syntax and convert it to html */
				switch (input[i]) {
					case string s when s.StartsWith("	"):
						output.WriteLine(input[i].Replace("	",
							"<p>") + "</p>");
						break;
					case string s when s.StartsWith("! "):
						output.WriteLine(input[i].Replace("! ",
							"<a href='http://") + "'>" +
							input[i].Replace("! ", "") + "</a>");
						break;
					case string s when s.StartsWith("# "):
						output.WriteLine(input[i].Replace("# ",
							"<h1>") + "</h1>");
						break;
					case string s when s.StartsWith("## "):
						output.WriteLine(input[i].Replace("## ",
							"<h2>") + "</h2>");
						break;
					case string s when s.StartsWith("### "):
						output.WriteLine(input[i].Replace("### ",
							"<h3>") + "</h3>");
						break;
				}
			output.WriteLine("</body></html>");

			/* close the file and tell the user that the conversion was successful */
			output.Close();
			MessageBox.Show("Converted Successfully! Your html file is located at: " + html.FileName);
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
