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
		private List<int> _lightIds;
		private List<int> _lightSequence;

		public HardGame(TimeSpan gameOverTime, double sequenceSpeed, List<int> lightIds, List<int> lightSequence)
		{
			_gameLevel = "Hard";
			_gameOverTime = gameOverTime;
			_sequenceSpeed = sequenceSpeed;
			_lightIds = lightIds;
			_lightSequence = lightSequence;
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

		public override List<int> LightIds
		{
			get { return _lightIds; }
			set { _lightIds = value; }
		}

		public override List<int> LightSequence
		{
			get { return _lightSequence; }
			set { _lightSequence = value; }
		}
	}
}
