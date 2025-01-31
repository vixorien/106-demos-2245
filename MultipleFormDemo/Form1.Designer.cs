namespace MultipleFormDemo
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
			buttonSave = new Button();
			buttonMessage = new Button();
			saveFileDialog1 = new SaveFileDialog();
			buttonOptions = new Button();
			SuspendLayout();
			// 
			// buttonSave
			// 
			buttonSave.Location = new Point(47, 66);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(202, 157);
			buttonSave.TabIndex = 0;
			buttonSave.Text = "Save a file...";
			buttonSave.UseVisualStyleBackColor = true;
			buttonSave.Click += buttonSave_Click;
			// 
			// buttonMessage
			// 
			buttonMessage.Location = new Point(305, 66);
			buttonMessage.Name = "buttonMessage";
			buttonMessage.Size = new Size(202, 157);
			buttonMessage.TabIndex = 1;
			buttonMessage.Text = "Message Box";
			buttonMessage.UseVisualStyleBackColor = true;
			buttonMessage.Click += buttonMessage_Click;
			// 
			// buttonOptions
			// 
			buttonOptions.Location = new Point(561, 66);
			buttonOptions.Name = "buttonOptions";
			buttonOptions.Size = new Size(202, 157);
			buttonOptions.TabIndex = 2;
			buttonOptions.Text = "Open Options";
			buttonOptions.UseVisualStyleBackColor = true;
			buttonOptions.Click += buttonOptions_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(821, 291);
			Controls.Add(buttonOptions);
			Controls.Add(buttonMessage);
			Controls.Add(buttonSave);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button buttonSave;
		private Button buttonMessage;
		private SaveFileDialog saveFileDialog1;
		private Button buttonOptions;
	}
}
