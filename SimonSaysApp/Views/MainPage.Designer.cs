namespace SimonSaysApp
{
	partial class MainPage
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
			this.clb_GameLevel = new System.Windows.Forms.CheckedListBox();
			this.btn_StartGame = new System.Windows.Forms.Button();
			this.lbl_Level = new System.Windows.Forms.Label();
			this.btn_Leaderboard = new System.Windows.Forms.Button();
			this.lbl_Message = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// clb_GameLevel
			// 
			this.clb_GameLevel.FormattingEnabled = true;
			this.clb_GameLevel.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
			this.clb_GameLevel.Location = new System.Drawing.Point(79, 44);
			this.clb_GameLevel.Name = "clb_GameLevel";
			this.clb_GameLevel.Size = new System.Drawing.Size(70, 49);
			this.clb_GameLevel.TabIndex = 0;
			this.clb_GameLevel.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_GameLevel_ItemCheck);
			this.clb_GameLevel.SelectedIndexChanged += new System.EventHandler(this.clb_GameLevel_SelectedIndexChanged);
			// 
			// btn_StartGame
			// 
			this.btn_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_StartGame.Location = new System.Drawing.Point(26, 134);
			this.btn_StartGame.Name = "btn_StartGame";
			this.btn_StartGame.Size = new System.Drawing.Size(180, 51);
			this.btn_StartGame.TabIndex = 1;
			this.btn_StartGame.Text = "Start Game";
			this.btn_StartGame.UseVisualStyleBackColor = true;
			this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
			// 
			// lbl_Level
			// 
			this.lbl_Level.AutoSize = true;
			this.lbl_Level.Location = new System.Drawing.Point(76, 28);
			this.lbl_Level.Name = "lbl_Level";
			this.lbl_Level.Size = new System.Drawing.Size(74, 13);
			this.lbl_Level.TabIndex = 2;
			this.lbl_Level.Text = "Select a level:";
			this.lbl_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Leaderboard
			// 
			this.btn_Leaderboard.Location = new System.Drawing.Point(13, 247);
			this.btn_Leaderboard.Name = "btn_Leaderboard";
			this.btn_Leaderboard.Size = new System.Drawing.Size(75, 23);
			this.btn_Leaderboard.TabIndex = 3;
			this.btn_Leaderboard.Text = "Leaderboard";
			this.btn_Leaderboard.UseVisualStyleBackColor = true;
			this.btn_Leaderboard.Click += new System.EventHandler(this.btn_Leaderboard_Click);
			// 
			// lbl_Message
			// 
			this.lbl_Message.AutoSize = true;
			this.lbl_Message.Location = new System.Drawing.Point(113, 96);
			this.lbl_Message.Name = "lbl_Message";
			this.lbl_Message.Size = new System.Drawing.Size(0, 13);
			this.lbl_Message.TabIndex = 4;
			this.lbl_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(239, 282);
			this.Controls.Add(this.lbl_Message);
			this.Controls.Add(this.btn_Leaderboard);
			this.Controls.Add(this.lbl_Level);
			this.Controls.Add(this.btn_StartGame);
			this.Controls.Add(this.clb_GameLevel);
			this.Name = "MainPage";
			this.Text = "MainPage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox clb_GameLevel;
		private System.Windows.Forms.Button btn_StartGame;
		private System.Windows.Forms.Label lbl_Level;
		private System.Windows.Forms.Button btn_Leaderboard;
		private System.Windows.Forms.Label lbl_Message;
	}
}

