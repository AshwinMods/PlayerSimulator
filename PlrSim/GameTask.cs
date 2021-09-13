using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PlrSim
{
	public class GameTask
	{
		public string name;
		public List<PlayerTask> playerTasks;

		public async Task<bool> Execute()
		{
			foreach (var task in playerTasks)
				if (!await task.Execute())
					return false;
			return true;
		}
	}

    public abstract class PlayerTask
    {
        public string name;
        public abstract Task<bool> Execute();
    }

    public class ScreenDetection : PlayerTask
    {
        public Point m_Coord;
        public Size m_Resolution;

        public Bitmap result;
        Graphics graphics;

        public List<bool> m_BoolHash;
        public ScreenDetection() { }
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

        public void Update()
		{
			if (m_Resolution != result.Size)
			{
                var newBitmap = new Bitmap(result, m_Resolution);
                result.Dispose();
                result = newBitmap;
                graphics = Graphics.FromImage(result);
            }
		}
        public async override Task<bool> Execute()
        {
            Update();
            graphics.CopyFromScreen(m_Coord.X, m_Coord.Y, 0, 0, m_Resolution);
            return true;
        }
    }

    public class DelayAction : PlayerTask
    {
        public int m_DelayMiliSec = 1;
        public async override Task<bool> Execute()
        {
            await Task.Delay(m_DelayMiliSec);
            return true;
        }
    }

    public class MouseAction : PlayerTask
    {
        // Credit : Keith
        // https://stackoverflow.com/a/7121314/2435782
        #region Mouse Event Simulation
        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        public static void MouseEvent(MouseEventFlags value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                ((int)value,
                 position.X,
                 position.Y,
                 0,
                 0)
                ;
        }
        #endregion

        public MouseEventFlags mouseEventFlag;
        public MousePoint m_MousePoint;

        public MouseAction(int xPos, int yPos, MouseEventFlags mouseEvent)
        {
            m_MousePoint.X = xPos;
            m_MousePoint.Y = yPos;
            mouseEventFlag = mouseEvent;
        }

        public async override Task<bool> Execute()
        {
            SetCursorPosition(m_MousePoint);
            MouseEvent(mouseEventFlag);
            return true;
        }
    }
}
