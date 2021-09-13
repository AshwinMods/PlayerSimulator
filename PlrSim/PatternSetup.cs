using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlrSim
{
	public partial class PatternSetup : Form
	{
		#region Variable Declarations
		ScreenDetection m_ScreenDetection;
		#endregion

		public PatternSetup()
		{
			InitializeComponent();
			m_ScreenDetection = new ScreenDetection("Unnamed", 0, 0, 32, 32);
		}
		public PatternSetup(ScreenDetection a_ScreenDetection)
		{
			InitializeComponent();
			m_ScreenDetection = a_ScreenDetection;
			TargetImage.Image = m_ScreenDetection.result;
		}

		private void Done_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		private void XOffset_ValueChanged(object sender, EventArgs e)
		{
			m_ScreenDetection.m_Coord.X = (int)XOffset.Value;
			UpdateImage();
		}
		private void YOffset_ValueChanged(object sender, EventArgs e)
		{
			m_ScreenDetection.m_Coord.Y = (int)YOffset.Value;
			UpdateImage();
		}
		private void WidthNumber_ValueChanged(object sender, EventArgs e)
		{
			m_ScreenDetection.m_Resolution.Width = (int)WidthNumber.Value;
			UpdateImage();
		}
		private void HeightNumber_ValueChanged(object sender, EventArgs e)
		{
			m_ScreenDetection.m_Resolution.Height = (int)HeightNumber.Value;
			UpdateImage();
		}
		private void CaptureButton_Click(object sender, EventArgs e)
		{
			UpdateImage();
		}
		private async void UpdateImage()
		{
			await m_ScreenDetection.Execute();
			TargetImage.Image = m_ScreenDetection.result;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var saveDiag = new SaveFileDialog();
			if ( saveDiag.ShowDialog() == DialogResult.OK)
			{
				var path = saveDiag.FileName;
				TargetImage.Image.Save(path);
			}
		}
	}
}
