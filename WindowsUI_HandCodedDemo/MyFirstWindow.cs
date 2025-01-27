// Chris Cascioli
// 1/27/25
// First example of a "form"

namespace WindowsUI_HandCodedDemo
{
	internal class MyFirstWindow : Form
	{
		/// <summary>
		/// Set up the details of the form
		/// </summary>
		public MyFirstWindow()
		{
			this.Size = new Size(800, 400);
			this.Text = "This is the titlebar text";

			// Create a button and put it on the form (window)
			Button b = new Button();
			b.Size = new Size(200, 100);
			b.Text = "I am a button";
			b.Location = new Point(200, 200);
			this.Controls.Add(b);

			// Add an event handler to the button
			b.Click += B_Click;
		}

		private void B_Click(object? sender, EventArgs e)
		{
			// Verify this is actually from a button object
			if (sender is Button)
			{
				Button b = (Button)sender;

				// Randomize the background color
				Random randy = new Random();
				b.BackColor = Color.FromArgb(
					randy.Next(256),
					randy.Next(256),
					randy.Next(256));

				// Randomly increase the size
				// Need to use copy/alter/replace
				Size sizeCopy = b.Size;
				sizeCopy.Width += 10;
				b.Size = sizeCopy;

				Point loc = b.Location;
				loc.X += sizeCopy.Width;
				b.Location = loc;
			}
		}
	}
}
