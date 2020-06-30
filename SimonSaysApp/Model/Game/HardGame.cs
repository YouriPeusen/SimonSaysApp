using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysApp.Model.Game
{
	class HardGame : Game
	{
		private readonly string _gameLevel;
		private TimeSpan _gameOverTime;
		private double _sequenceSpeed;
		private List<int> _lights;

		public HardGame(TimeSpan gameOverTime, double sequenceSpeed, List<int> lights)
		{
			_gameLevel = "Hard";
			_gameOverTime = gameOverTime;
			_sequenceSpeed = sequenceSpeed;
			_lights = lights;
		}

		public override string GameLevel
		{
			get { return _gameLevel; }
		}

		public override TimeSpan GameOverTime
		{
			get { return _gameOverTime; }
			set { _gameOverTime = value; }
		}

		public override double SequenceSpeed
		{
			get { return _sequenceSpeed; }
			set { _sequenceSpeed = value; }
		}

		public override List<int> Lights
		{
			get { return _lights; }
			set { _lights = value; }
		}
	}
}
