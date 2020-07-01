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
			this.lbl_Score = new System.Windows.Forms.Label();
			this.lbl_ScorePoints = new System.Windows.Forms.Label();
			this.btn_Help = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// clb_GameLevel
			// 
			this.clb_GameLevel.FormattingEnabled = true;
			this.clb_GameLevel.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
			this.clb_GameLevel.Location = new System.Drawing.Point(105, 54);
			this.clb_GameLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.clb_GameLevel.Name = "clb_GameLevel";
			this.clb_GameLevel.Size = new System.Drawing.Size(92, 55);
			this.clb_GameLevel.TabIndex = 0;
			this.clb_GameLevel.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_GameLevel_ItemCheck);
			// 
			// btn_StartGame
			// 
			this.btn_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_StartGame.Location = new System.Drawing.Point(35, 149);
			this.btn_StartGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_StartGame.Name = "btn_StartGame";
			this.btn_StartGame.Size = new System.Drawing.Size(240, 63);
			this.btn_StartGame.TabIndex = 1;
			this.btn_StartGame.Text = "Start Game";
			this.btn_StartGame.UseVisualStyleBackColor = true;
			this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
			// 
			// lbl_Level
			// 
			this.lbl_Level.AutoSize = true;
			this.lbl_Level.Location = new System.Drawing.Point(101, 34);
			this.lbl_Level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Level.Name = "lbl_Level";
			this.lbl_Level.Size = new System.Drawing.Size(96, 17);
			this.lbl_Level.TabIndex = 2;
			this.lbl_Level.Text = "Select a level:";
			this.lbl_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Leaderboard
			// 
			this.btn_Leaderboard.Location = new System.Drawing.Point(17, 304);
			this.btn_Leaderboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Leaderboard.Name = "btn_Leaderboard";
			this.btn_Leaderboard.Size = new System.Drawing.Size(100, 28);
			this.btn_Leaderboard.TabIndex = 3;
			this.btn_Leaderboard.Text = "Leaderboard";
			this.btn_Leaderboard.UseVisualStyleBackColor = true;
			this.btn_Leaderboard.Click += new System.EventHandler(this.btn_Leaderboard_Click);
			// 
			// lbl_Score
			// 
			this.lbl_Score.AutoSize = true;
			this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Score.Location = new System.Drawing.Point(117, 215);
			this.lbl_Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Score.Name = "lbl_Score";
			this.lbl_Score.Size = new System.Drawing.Size(58, 20);
			this.lbl_Score.TabIndex = 4;
			this.lbl_Score.Text = "Score:";
			this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_ScorePoints
			// 
			this.lbl_ScorePoints.AutoSize = true;
			this.lbl_ScorePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ScorePoints.Location = new System.Drawing.Point(133, 250);
			this.lbl_ScorePoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_ScorePoints.Name = "lbl_ScorePoints";
			this.lbl_ScorePoints.Size = new System.Drawing.Size(27, 29);
			this.lbl_ScorePoints.TabIndex = 5;
			this.lbl_ScorePoints.Text = "0";
			this.lbl_ScorePoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Help
			// 
			this.btn_Help.Location = new System.Drawing.Point(196, 306);
			this.btn_Help.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Help.Name = "btn_Help";
			this.btn_Help.Size = new System.Drawing.Size(100, 28);
			this.btn_Help.TabIndex = 6;
			this.btn_Help.Text = "Help";
			this.btn_Help.UseVisualStyleBackColor = true;
			this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 347);
			this.Controls.Add(this.btn_Help);
			this.Controls.Add(this.lbl_ScorePoints);
			this.Controls.Add(this.lbl_Score);
			this.Controls.Add(this.btn_Leaderboard);
			this.Controls.Add(this.lbl_Level);
			this.Controls.Add(this.btn_StartGame);
			this.Controls.Add(this.clb_GameLevel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
		private System.Windows.Forms.Label lbl_Score;
		private System.Windows.Forms.Label lbl_ScorePoints;
		private System.Windows.Forms.Button btn_Help;
	}
}

