namespace MultipleFormDemo
{
	partial class OptionsForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			buttonChange = new Button();
			checkBox1 = new CheckBox();
			SuspendLayout();
			// 
			// buttonChange
			// 
			buttonChange.Font = new Font("Segoe UI", 22F);
			buttonChange.Location = new Point(28, 38);
			buttonChange.Name = "buttonChange";
			buttonChange.Size = new Size(417, 251);
			buttonChange.TabIndex = 0;
			buttonChange.Text = "Change the other form's color!";
			buttonChange.UseVisualStyleBackColor = true;
			buttonChange.Click += buttonChange_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(158, 322);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(202, 29);
			checkBox1.TabIndex = 1;
			checkBox1.Text = "Do a different thing?";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// OptionsForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(482, 393);
			Controls.Add(checkBox1);
			Controls.Add(buttonChange);
			Name = "OptionsForm";
			Text = "OptionsForm";
			FormClosing += OptionsForm_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonChange;
		private CheckBox checkBox1;
	}
}