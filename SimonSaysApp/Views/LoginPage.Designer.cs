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
			this.lbl_Username.Location = new System.Drawing.Point(76, 54);
			this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Username.Name = "lbl_Username";
			this.lbl_Username.Size = new System.Drawing.Size(73, 17);
			this.lbl_Username.TabIndex = 0;
			this.lbl_Username.Text = "Username";
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(68, 213);
			this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(133, 28);
			this.btn_Login.TabIndex = 1;
			this.btn_Login.Text = "Login";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// txtb_Username
			// 
			this.txtb_Username.Location = new System.Drawing.Point(68, 74);
			this.txtb_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtb_Username.Name = "txtb_Username";
			this.txtb_Username.Size = new System.Drawing.Size(132, 22);
			this.txtb_Username.TabIndex = 2;
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(76, 127);
			this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(69, 17);
			this.lbl_Password.TabIndex = 3;
			this.lbl_Password.Text = "Password";
			// 
			// txtb_Password
			// 
			this.txtb_Password.Location = new System.Drawing.Point(68, 146);
			this.txtb_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtb_Password.Name = "txtb_Password";
			this.txtb_Password.Size = new System.Drawing.Size(132, 22);
			this.txtb_Password.TabIndex = 4;
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 347);
			this.Controls.Add(this.txtb_Password);
			this.Controls.Add(this.lbl_Password);
			this.Controls.Add(this.txtb_Username);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.lbl_Username);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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