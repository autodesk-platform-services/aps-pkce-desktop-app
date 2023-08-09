namespace PKCEForm
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
			this.btn_Login = new System.Windows.Forms.Button();
			this.txt_Result = new System.Windows.Forms.TextBox();
			this.lbl_Status = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(17, 49);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(511, 87);
			this.btn_Login.TabIndex = 0;
			this.btn_Login.Text = "Generate Token";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// txt_Result
			// 
			this.txt_Result.Location = new System.Drawing.Point(17, 243);
			this.txt_Result.Multiline = true;
			this.txt_Result.Name = "txt_Result";
			this.txt_Result.Size = new System.Drawing.Size(511, 171);
			this.txt_Result.TabIndex = 1;
			// 
			// lbl_Status
			// 
			this.lbl_Status.AutoSize = true;
			this.lbl_Status.Location = new System.Drawing.Point(12, 188);
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(322, 25);
			this.lbl_Status.TabIndex = 2;
			this.lbl_Status.Text = "Click on Generate Token to start";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 426);
			this.Controls.Add(this.lbl_Status);
			this.Controls.Add(this.txt_Result);
			this.Controls.Add(this.btn_Login);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "PKCE Token Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.TextBox txt_Result;
		private System.Windows.Forms.Label lbl_Status;
	}
}

