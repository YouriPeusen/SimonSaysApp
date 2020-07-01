using SimonSaysApp.Model;
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

		public List<int> LightSequence = new List<int>();
 		public Random Random = new Random();
		public bool GameOver;
		public double LightOnTime = 0;
		public int ScorePoints = 0;

		public MainPage()
		{
			InitializeComponent();
			factory = null;
		}

		public async void StartGame()
		{
			GameOver = false;
			
			if (clb_GameLevel.SelectedItem != null)
			{
				//Sets the level
				switch (clb_GameLevel.SelectedItem.ToString())
				{
					case "Easy":
						GameOverTime = new TimeSpan(0, 0, 0);
						SequenceTime = 2;
						Lights = new List<int> { 10, 2, 3 };
						factory = new EasyGameFactory(GameOverTime, SequenceTime, Lights);
						break;
					case "Normal":
						GameOverTime = new TimeSpan(0, 0, 5);
						SequenceTime = 1;
						Lights = new List<int> { 10, 2, 3, 4, 5, 6 };
						factory = new NormalGameFactory(GameOverTime, SequenceTime, Lights);
						break;
					case "Hard":
						GameOverTime = new TimeSpan(0, 0, 2);
						SequenceTime = 0.5;
						Lights = new List<int> { 10, 2, 3, 4, 5, 6, 7, 8, 9 };
						factory = new HardGameFactory(GameOverTime, SequenceTime, Lights);
						break;
					default:
						break;
				}
				Game game = factory.GetGame();
				//MessageBox.Show("Starting " + game.GameLevel + " game");


				//Generate Light-Sequence
				for (int i = 0; i < 3; i++)
				{
					int index = Random.Next(Lights.Count);
					LightSequence.Add(Lights[index]);
				}

				/*Displays Light-Sequence
				string message = "";
				foreach (int num in LightSequence)
				{
					message += num.ToString();
					message += " ";
				}
				MessageBox.Show(message);*/
				

				//While GameOver is false, keep playing
				while (!GameOver)
				{
					//Executes LightSequence
					foreach (int lightId in LightSequence)
					{
						Light light = new Light();
						light.LightId = lightId;
						light.SetLightOn();
						await Task.Delay(new TimeSpan(0, 0, Convert.ToInt32(SequenceTime)));
						light.SetLightOff();
					}


					//Trac Button-Sequence
					//Code die de input van de speler checkt:
					bool Mistake = false;
					//--------------------------------------


					if (!Mistake)
					{
						int index = Random.Next(Lights.Count);
						LightSequence.Add(Lights[index]);

						ScorePoints += 1;
						lbl_ScorePoints.Text = ScorePoints.ToString();
					}
					else
					{
						GameOver = true;
						EndGame();
					}
				}
			}
			else
			{
				MessageBox.Show("No level selected... Select a level to start the game");
			}
		}

		public void EndGame()
		{
			LightSequence = new List<int>();
			MessageBox.Show("GAME OVER");
		}

		public void ShowLeaderboard()
		{
			Leaderboard form = new Leaderboard();
			form.Show();
		}

		private void btn_StartGame_Click(object sender, EventArgs e)
		{
			StartGame();
		}

		private void clb_GameLevel_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			for (int ix = 0; ix < clb_GameLevel.Items.Count; ++ix)
				if (ix != e.Index) clb_GameLevel.SetItemChecked(ix, false);
		}

		private void btn_Leaderboard_Click(object sender, EventArgs e)
		{
			ShowLeaderboard();
		}
	}
}
