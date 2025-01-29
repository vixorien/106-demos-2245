namespace UICreationAndEventDemo
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			buttonIncrement = new Button();
			buttonDecrement = new Button();
			buttonReset = new Button();
			textCount = new TextBox();
			labelCount = new Label();
			timerCounter = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// buttonIncrement
			// 
			buttonIncrement.Location = new Point(12, 12);
			buttonIncrement.Name = "buttonIncrement";
			buttonIncrement.Size = new Size(112, 34);
			buttonIncrement.TabIndex = 0;
			buttonIncrement.Text = "Increment";
			buttonIncrement.UseVisualStyleBackColor = true;
			buttonIncrement.Click += buttonIncrement_Click;
			// 
			// buttonDecrement
			// 
			buttonDecrement.Location = new Point(130, 12);
			buttonDecrement.Name = "buttonDecrement";
			buttonDecrement.Size = new Size(112, 34);
			buttonDecrement.TabIndex = 1;
			buttonDecrement.Text = "Decrement";
			buttonDecrement.UseVisualStyleBackColor = true;
			buttonDecrement.Click += buttonDecrement_Click;
			// 
			// buttonReset
			// 
			buttonReset.Location = new Point(248, 12);
			buttonReset.Name = "buttonReset";
			buttonReset.Size = new Size(112, 34);
			buttonReset.TabIndex = 2;
			buttonReset.Text = "Reset";
			buttonReset.UseVisualStyleBackColor = true;
			buttonReset.Click += buttonReset_Click;
			// 
			// textCount
			// 
			textCount.Location = new Point(92, 64);
			textCount.Name = "textCount";
			textCount.ReadOnly = true;
			textCount.Size = new Size(268, 31);
			textCount.TabIndex = 3;
			// 
			// labelCount
			// 
			labelCount.AutoSize = true;
			labelCount.Location = new Point(12, 67);
			labelCount.Name = "labelCount";
			labelCount.Size = new Size(64, 25);
			labelCount.TabIndex = 4;
			labelCount.Text = "Count:";
			// 
			// timerCounter
			// 
			timerCounter.Tick += timerCounter_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(375, 111);
			Controls.Add(labelCount);
			Controls.Add(textCount);
			Controls.Add(buttonReset);
			Controls.Add(buttonDecrement);
			Controls.Add(buttonIncrement);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "Form1";
			ShowInTaskbar = false;
			Text = "Counter";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonIncrement;
		private Button buttonDecrement;
		private Button buttonReset;
		private TextBox textCount;
		private Label labelCount;
		private System.Windows.Forms.Timer timerCounter;
	}
}
