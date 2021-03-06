﻿using SimonSaysApp.Model.Game;
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
		private List<int> _lightIds;
		private List<int> _lightSequence;


		public EasyGameFactory(TimeSpan gameOverTime, double sequenceSpeed, List<int> lightIds, List<int> lightSequence)
		{
			_gameOverTime = gameOverTime;
			_sequenceSpeed = sequenceSpeed;
			_lightIds = lightIds;
			_lightSequence = lightSequence;
		}

		public override Game.Game GetGame()
		{
			return new EasyGame(_gameOverTime, _sequenceSpeed, _lightIds, _lightSequence);
		}
	}
}
