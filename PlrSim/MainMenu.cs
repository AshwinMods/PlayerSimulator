using System;
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

		private void MainMenu_Load(object sender, EventArgs e)
		{
			//listView1.BackgroundImage = screenrect.result;
			//listView1.LargeImageList = new ImageList();
			//listView1.LargeImageList.ImageSize = new Size(100, 100);
			//listView1.Items[0].ImageIndex = 0;
			//listView1.Items[1].ImageIndex = 0;

			//MouseAction act = new MouseAction(0, 0, MouseAction.MouseEventFlags.LeftDown | MouseAction.MouseEventFlags.LeftUp);
			//act.Execute();
		}

		private void NewGameBtn_Click(object sender, EventArgs e)
		{
			m_GameConfig = new GameConfig();
		}

		private void SaveGameBtn_Click(object sender, EventArgs e)
		{
			Utility.WriteToXmlFile("Test.PlrSim", m_GameConfig);
		}

		private void LoadGameBtn_Click(object sender, EventArgs e)
		{
			m_GameConfig = Utility.ReadFromXmlFile<GameConfig>("Test.PlrSim");
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void AddNewImage_Click(object sender, EventArgs e)
		{
			var l_ImgSetup = new PatternSetup();
			var l_Result = l_ImgSetup.ShowDialog(this);
			if (l_Result == DialogResult.OK)
			{

			}
		}
	}
}
