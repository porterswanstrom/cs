using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperatures
{
	public partial class frm_main : Form
	{
		public frm_main()
		{
			InitializeComponent();
		}

		/* 3 lists used to store temperatures from different cities,
		 * those cities being Sioux Falls, New York, and Denver
		 */
		List<int> sf = new List<int>(30);
		List<int> ny = new List<int>(30);
		List<int> dv = new List<int>(30);

		private void frm_main_Load(object sender, EventArgs e)
		{
			Random r = new Random();

			/* fill the cities with temperature data */
			for (int i = 0; i < 30; ++i) {
				sf.Add(r.Next(2, 70));
				ny.Add(r.Next(21, 68));
				dv.Add(r.Next(18, 74));
			}
		}

		private (int, int) high_and_low(List<int> city)
		{
			int low = 999;
			int high = -999;

			/* find the highest and lowest temperatures */
			for (int i = 0; i < 30; ++i) {
				if (city[i] < low)
					low = city[i];
				if (city[i] > high)
					high = city[i];
			}
			/* return the two temperatures as a tuple */
			return (low, high);
		}

		/* convert fahrenheit to celsius */
		private int f2c(int f)
		{
			double c = .56*(f-32);
			return (int)c;
		}

		private void show(List<int> city)
		{
			/* get the highest and lowest temperatures of a city */
			(int low, int high) tmptr = high_and_low(city);

			/* show the temperatures on the form */
			txt_low_f.Text = tmptr.low.ToString() + "°f";
			txt_high_f.Text = tmptr.high.ToString() + "°f";
			txt_low_c.Text = f2c(tmptr.low).ToString() + "°c";
			txt_high_c.Text = f2c(tmptr.high).ToString() + "°c";
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if (txt_add.Text == "") {
				MessageBox.Show("You need to enter a temperature",
					"Entry Error");
				txt_add.Focus();
				return;
			}
			if (!int.TryParse(txt_add.Text, out int i)) {
				MessageBox.Show("The temperature must be a whole number",
					"Entry Error");
				txt_add.Focus();
				return;
			}

			/* find the selected city */
			if (radio_sf.Checked) {
				/* remove the oldest temperature */
				sf.RemoveAt(0);
				/* add a new temperature */
				sf.Add(int.Parse(txt_add.Text));
				/* redisplay the temperatures */
				show(sf);
			}
			else if (radio_ny.Checked) {
				ny.RemoveAt(0);
				ny.Add(int.Parse(txt_add.Text));
				show(ny);
			}
			else if (radio_dv.Checked) {
				dv.RemoveAt(0);
				dv.Add(int.Parse(txt_add.Text));
				show(dv);
			}
			else {
				MessageBox.Show("You need to select a city",
					"Entry Error");
			}
		}

		private void radio_sf_CheckedChanged(object sender, EventArgs e)
		{
			show(sf);
		}

		private void radio_ny_CheckedChanged(object sender, EventArgs e)
		{
			show(ny);
		}

		private void radio_dv_CheckedChanged(object sender, EventArgs e)
		{
			show(dv);
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
