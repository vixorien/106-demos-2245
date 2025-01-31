// Chris Cascioli
// 1/31/25
// A second form that is created and shown by the app's main form

namespace MultipleFormDemo
{
	public partial class OptionsForm : Form
	{
		private Form1 mainForm;

		public OptionsForm(Form1 mainForm)
		{
			this.mainForm = mainForm;

			InitializeComponent();
		}

		/// <summary>
		/// This event occurs when the form is ABOUT TO close
		/// </summary>
		private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// We can adjust exactly what happens next
			e.Cancel = true; // Stop the form from actually closing
			this.Hide();
		}

		/// <summary>
		/// Change something about the original form
		/// </summary>
		private void buttonChange_Click(object sender, EventArgs e)
		{
			mainForm.BackColor = Color.Aquamarine;
		}
	}
}
