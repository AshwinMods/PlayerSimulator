using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlrSim
{
	public class GameConfig
	{
		#region Variable Declarations
		public string name = "Default";
		public List<GameTask> gameTasks = new List<GameTask>();
		#endregion

		#region Constructors
		#endregion

		#region Public Functions
		public async Task<bool> Execute()
		{
			foreach (var task in gameTasks)
				if (!await task.Execute())
					return false;
			return true;
		}
		#endregion
	}
}
