namespace SimonSaysApp.Views
{
	partial class LoginPage
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
			this.lbl_Username = new System.Windows.Forms.Label();
			this.btn_Login = new System.Windows.Forms.Button();
			this.txtb_Username = new System.Windows.Forms.TextBox();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.txtb_Password = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbl_Username
			// 
			this.lbl_Username.AutoSize = true;
			this.lbl_Username.Location = new System.Drawing.Point(57, 44);
			this.lbl_Username.Name = "lbl_Username";
			this.lbl_Username.Size = new System.Drawing.Size(55, 13);
			this.lbl_Username.TabIndex = 0;
			this.lbl_Username.Text = "Username";
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(51, 173);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(100, 23);
			this.btn_Login.TabIndex = 1;
			this.btn_Login.Text = "Login";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// txtb_Username
			// 
			this.txtb_Username.Location = new System.Drawing.Point(51, 60);
			this.txtb_Username.Name = "txtb_Username";
			this.txtb_Username.Size = new System.Drawing.Size(100, 20);
			this.txtb_Username.TabIndex = 2;
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(57, 103);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(53, 13);
			this.lbl_Password.TabIndex = 3;
			this.lbl_Password.Text = "Password";
			// 
			// txtb_Password
			// 
			this.txtb_Password.Location = new System.Drawing.Point(51, 119);
			this.txtb_Password.Name = "txtb_Password";
			this.txtb_Password.Size = new System.Drawing.Size(100, 20);
			this.txtb_Password.TabIndex = 4;
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(239, 282);
			this.Controls.Add(this.txtb_Password);
			this.Controls.Add(this.lbl_Password);
			this.Controls.Add(this.txtb_Username);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.lbl_Username);
			this.Name = "LoginPage";
			this.Text = "LoginPage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_Username;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.TextBox txtb_Username;
		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.TextBox txtb_Password;
	}
}