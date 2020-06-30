using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysApp.Model
{
	class History
	{
		public int GameId { get; set; }
		public int UserId { get; set; }
		public string GameLevel { get; set; }
		public int GameScore { get; set; }
	}
}
