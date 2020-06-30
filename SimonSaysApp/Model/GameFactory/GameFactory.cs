using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysApp.Model.GameFactory
{
	abstract class GameFactory
	{
		public abstract SimonSaysApp.Model.Game.Game GetGame();
	}
}
