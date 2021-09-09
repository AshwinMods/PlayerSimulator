﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlrSim
{
	public partial class MainMenu : Form
	{
		#region Variable Declarations
		GameConfig m_GameConfig;
		#endregion

		public MainMenu()
		{
			InitializeComponent();
		}

		private void NewGameBtn_Click(object sender, EventArgs e)
		{
			m_GameConfig = new GameConfig();
		}

		private void SaveGameBtn_Click(object sender, EventArgs e)
		{
			SaveLoadFile.WriteToXmlFile<GameConfig>("Test.PlrSim", m_GameConfig);
		}

		private void LoadGameBtn_Click(object sender, EventArgs e)
		{
			m_GameConfig = SaveLoadFile.ReadFromXmlFile<GameConfig>("Test.PlrSim");
		}
	}
}
