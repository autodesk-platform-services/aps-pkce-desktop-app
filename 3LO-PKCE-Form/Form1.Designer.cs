namespace _3LO_PKCE_Form
{
	partial class Form1
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
			this.login_button = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// login_button
			// 
			this.login_button.Location = new System.Drawing.Point(234, 69);
			this.login_button.Name = "login_button";
			this.login_button.Size = new System.Drawing.Size(165, 100);
			this.login_button.TabIndex = 0;
			this.login_button.Text = "Login";
			this.login_button.UseVisualStyleBackColor = true;
			this.login_button.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 251);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(449, 31);
			this.textBox1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(690, 441);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.login_button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button login_button;
		private System.Windows.Forms.TextBox textBox1;
	}
}

