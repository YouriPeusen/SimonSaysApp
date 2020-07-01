using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysApp.Model.Game
{
	abstract class Game
	{
		public abstract string GameLevel { get; }
		public abstract TimeSpan GameOverTime { get; set; }
		public abstract double SequenceSpeed { get; set; }
		public abstract List<int> LightIds { get; set; }
		public abstract List<int> LightSequence { get; set; }
	}
}
