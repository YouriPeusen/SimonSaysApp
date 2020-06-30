using SimonSaysApp.Model.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysApp.Model.GameFactory
{
	class EasyGameFactory : GameFactory
	{
		private TimeSpan _gameOverTime;
		private double _sequenceSpeed;
		private List<int> _lights;

		public EasyGameFactory(TimeSpan gameOverTime, double sequenceSpeed, List<int> lights)
		{
			_gameOverTime = gameOverTime;
			_sequenceSpeed = sequenceSpeed;
			_lights = lights;
		}

		public override Game.Game GetGame()
		{
			return new EasyGame(_gameOverTime, _sequenceSpeed, _lights);
		}
	}
}
