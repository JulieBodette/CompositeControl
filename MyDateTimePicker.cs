using System;
using System.Drawing;
using Wisej.Web;

namespace CompositeControl
{
	public partial class MyDateTimePicker : Wisej.Web.UserControl
	{
		DateTimePicker dateTimePicker1;
		CheckBox checkBox1;
		public MyDateTimePicker()
		{
			InitializeComponent();
			//Add the DateTimePicker and CheckBox controls to the UserControl
		    dateTimePicker1 = new DateTimePicker();
			checkBox1 = new CheckBox();
			this.Controls.Add(dateTimePicker1);
			this.Controls.Add(checkBox1);

			// Set the location and size of the controls
			dateTimePicker1.Location = new Point(0, 0);
			checkBox1.Location = new Point(dateTimePicker1.Width + 5, 3);
			checkBox1.Size = new Size(15, 15);

			// Set the default properties of the controls
			//dateTimePicker1.Format = DateTimePickerFormat.Short; //FIX THIS
			checkBox1.Checked = true;

			// Wire up the CheckedChanged event of the CheckBox control
			checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			// Enable or disable the DateTimePicker control based on the state of the CheckBox control
			dateTimePicker1.Enabled = checkBox1.Checked;
		}
	}
}
