// Chris Cascioli
// 1/29/25
// Demo of a simple windows forms app with a timer

namespace UICreationAndEventDemo
{
	public partial class Form1 : Form
	{
		// Fields
		private int count;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Sets up the counter and initial display
		/// </summary>
		private void Form1_Load(object sender, EventArgs e)
		{
			// Initialize the count
			count = 0;

			// Display the count
			textCount.Text = count.ToString();

			// Start the timer
			timerCounter.Start();
		}

		/// <summary>
		/// Makes the count go up by 1
		/// </summary>
		private void buttonIncrement_Click(object sender, EventArgs e)
		{
			count++;
			textCount.Text = count.ToString();
		}

		/// <summary>
		/// Makes the count go down by 1
		/// </summary>
		private void buttonDecrement_Click(object sender, EventArgs e)
		{
			count--;
			textCount.Text = count.ToString();
		}

		/// <summary>
		/// Resets the count to zero
		/// </summary>
		private void buttonReset_Click(object sender, EventArgs e)
		{
			count = 0;
			textCount.Text = count.ToString();
		}

		/// <summary>
		/// Increments the counter and redisplays whenver
		/// the timer ticks
		/// </summary>
		private void timerCounter_Tick(object sender, EventArgs e)
		{
			count++;
			textCount.Text = count.ToString();
		}
	}
}
