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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_Refresh = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Login
			// 
			this.btn_Login.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_Login.Location = new System.Drawing.Point(11, 11);
			this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(1145, 72);
			this.btn_Login.TabIndex = 0;
			this.btn_Login.Text = "Generate Token";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// txt_Result
			// 
			this.txt_Result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt_Result.Location = new System.Drawing.Point(11, 251);
			this.txt_Result.Margin = new System.Windows.Forms.Padding(4);
			this.txt_Result.Multiline = true;
			this.txt_Result.Name = "txt_Result";
			this.txt_Result.Size = new System.Drawing.Size(1145, 291);
			this.txt_Result.TabIndex = 1;
			// 
			// lbl_Status
			// 
			this.lbl_Status.AutoSize = true;
			this.lbl_Status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_Status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_Status.Location = new System.Drawing.Point(11, 87);
			this.lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(1145, 80);
			this.lbl_Status.TabIndex = 2;
			this.lbl_Status.Text = "Click on Generate Token to start";
			this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btn_Refresh, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn_Login, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txt_Result, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lbl_Status, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(7);
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1167, 553);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_Refresh.Location = new System.Drawing.Point(11, 171);
			this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(1145, 72);
			this.btn_Refresh.TabIndex = 3;
			this.btn_Refresh.Text = "Refresh Token";
			this.btn_Refresh.UseVisualStyleBackColor = true;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1167, 553);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "PKCE Token Form";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.TextBox txt_Result;
		private System.Windows.Forms.Label lbl_Status;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_Refresh;
	}
}

