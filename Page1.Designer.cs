namespace CompositeControl
{
	partial class Page1
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
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.myDateTimePicker1 = new CompositeControl.MyDateTimePicker();
			this.SuspendLayout();
			// 
			// myDateTimePicker1
			// 
			this.myDateTimePicker1.Location = new System.Drawing.Point(419, 131);
			this.myDateTimePicker1.Name = "myDateTimePicker1";
			this.myDateTimePicker1.TabIndex = 0;
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.myDateTimePicker1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1327, 430);
			this.ResumeLayout(false);

		}

		#endregion

		private MyDateTimePicker myDateTimePicker1;
	}
}

