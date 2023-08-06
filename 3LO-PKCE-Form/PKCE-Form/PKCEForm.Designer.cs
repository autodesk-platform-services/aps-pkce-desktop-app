namespace PKCE_Form
{
	partial class PKCEForm
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
			btn_Login = new Button();
			textBox1 = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// btn_Login
			// 
			btn_Login.Location = new Point(231, 100);
			btn_Login.Name = "btn_Login";
			btn_Login.Size = new Size(150, 46);
			btn_Login.TabIndex = 0;
			btn_Login.Text = "Login";
			btn_Login.UseVisualStyleBackColor = true;
			btn_Login.Click += btn_Login_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(209, 228);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(200, 39);
			textBox1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(269, 193);
			label1.Name = "label1";
			label1.Size = new Size(78, 32);
			label1.TabIndex = 2;
			label1.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(662, 371);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(btn_Login);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_Login;
		private TextBox textBox1;
		private Label label1;
	}
}