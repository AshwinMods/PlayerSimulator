using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlrSim
{
	public abstract class PlayerDetection : PlayerTask
	{
		public abstract void Detect();
	}

	public class ScreenDetection : PlayerDetection
	{
		public Point m_Coord;
		public Size m_Resolution;

		public Bitmap result;
		Graphics graphics;

		public ScreenDetection(string a_Name, int xPos, int yPos, int width, int height)
		{
			name = a_Name;
			m_Coord.X = xPos;
			m_Coord.Y = yPos;
			m_Resolution.Width = width;
			m_Resolution.Height = height;
			result = new Bitmap(m_Resolution.Width, m_Resolution.Height);
			graphics = Graphics.FromImage(result);
		}

		public override void Detect()
		{
			graphics.CopyFromScreen(m_Coord.X, m_Coord.Y, 0, 0, m_Resolution);
		}
	}
}
