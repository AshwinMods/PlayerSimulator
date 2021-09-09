using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlrSim
{
	class DelayAction : PlayerAction
	{
		public int m_DelayMiliSec;
		public override Task Execute()
		{
			return Task.Delay(m_DelayMiliSec);
		}
	}
}
