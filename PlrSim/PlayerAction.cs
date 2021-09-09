﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlrSim
{
	abstract class PlayerAction
	{
		public enum ActionType
		{
			MouseAction,
			KeyboardAction,
		}

		public abstract Task Execute();
	}
}
