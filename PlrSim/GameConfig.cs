using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlrSim
{
	class GameConfig
	{
		#region Variable Declarations
		string m_GameName;
		List<PatternRect> m_Patterns;
		List<ActionSequence> m_ActionSequence;
		#endregion

		#region Constructors
		public GameConfig(string path)
		{

		}
		#endregion
	}
}
