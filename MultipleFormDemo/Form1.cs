// Chris Cascioli
// 1/31/25
// Example of dialogs (Message Boxes) and multiple forms

namespace MultipleFormDemo
{
	public partial class Form1 : Form
	{
		private OptionsForm options;

		public Form1()
		{
			options = new OptionsForm(this);

			InitializeComponent();
		}

		/// <summary>
		/// Show the user a message box and capture their response
		/// </summary>
		private void buttonMessage_Click(object sender, EventArgs e)
		{
			// This display a message to the user and WAITS for
			// the user to click one of the buttons to continue
			DialogResult answer = MessageBox.Show(
				"Do you want to continue?",
				"ANSWER ME",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Warning);


			if (answer == DialogResult.Yes)
			{
				MessageBox.Show("You clicked yes!");
			}
			else if (answer == DialogResult.No)
			{
				MessageBox.Show("You clicked no!");
			}
			else if (answer == DialogResult.Cancel)
			{
				MessageBox.Show("You clicked cancel!");
			}
		}

		/// <summary>
		/// Show the user a save file dialog box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSave_Click(object sender, EventArgs e)
		{
			DialogResult result = saveFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				MessageBox.Show("You chose: " + saveFileDialog1.FileName);
			}
			else if (result == DialogResult.Cancel)
			{
				MessageBox.Show("You canceled the save!");
			}
		}

		/// <summary>
		/// Open the options form
		/// </summary>
		private void buttonOptions_Click(object sender, EventArgs e)
		{
			//OptionsForm options = new OptionsForm();
			options.Show();
		}
	}
}
