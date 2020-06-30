using SimonSaysApp.Model.Game;
using SimonSaysApp.Model.GameFactory;
using SimonSaysApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSaysApp
{
	public partial class MainPage : Form
	{
		private GameFactory factory = null;
		public TimeSpan GameOverTime = new TimeSpan();
		public double SequenceTime;
		public List<int> Lights = new List<int>();

		public MainPage()
		{
			InitializeComponent();
			factory = null;
		}

		public void StartGame()
		{
			if(clb_GameLevel.SelectedItem != null)
			{
				switch (clb_GameLevel.SelectedItem.ToString())
				{
					case "Easy":
						GameOverTime = new TimeSpan(0, 0, 0);
						SequenceTime = 2;
						Lights = new List<int> { 0, 1, 2};
						factory = new EasyGameFactory(GameOverTime, SequenceTime, Lights);
						break;
					case "Normal":
						GameOverTime = new TimeSpan(0, 0, 5);
						SequenceTime = 1;
						Lights = new List<int> { 0, 1, 2, 3};
						factory = new NormalGameFactory(GameOverTime, SequenceTime, Lights);
						break;
					case "Hard":
						GameOverTime = new TimeSpan(0, 0, 2);
						SequenceTime = 0.5;
						Lights = new List<int> { 0, 1, 2, 3, 4};
						factory = new HardGameFactory(GameOverTime, SequenceTime, Lights);
						break;
					default:
						break;
				}
				Game game = factory.GetGame();
				lbl_Message.Text = "Starting " + game.GameLevel + " game";
			}
			else
			{
				lbl_Message.Text = "No level selected... Select a level to start the game";
			}
		}

		public void EndGame()
		{

		}

		public void ShowLeaderboard()
		{

		}


		private void btn_StartGame_Click(object sender, EventArgs e)
		{
			StartGame();
		}

		private void clb_GameLevel_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void clb_GameLevel_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			for (int ix = 0; ix < clb_GameLevel.Items.Count; ++ix)
				if (ix != e.Index) clb_GameLevel.SetItemChecked(ix, false);
		}

		private void btn_Leaderboard_Click(object sender, EventArgs e)
		{
			Leaderboard form = new Leaderboard();
			form.Show();
		}
	}
}
