using SimonSaysApp.Model.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysApp.Model.GameFactory
{
	class HardGameFactory : GameFactory
	{
		private TimeSpan _gameOverTime;
		private double _sequenceSpeed;
		private List<int> _lights;

		public HardGameFactory(TimeSpan gameOverTime, double sequenceSpeed, List<int> lights)
		{
			_gameOverTime = gameOverTime;
			_sequenceSpeed = sequenceSpeed;
			_lights = lights;
		}

		public override Game.Game GetGame()
		{
			return new HardGame(_gameOverTime, _sequenceSpeed, _lights);
		}
	}
}
