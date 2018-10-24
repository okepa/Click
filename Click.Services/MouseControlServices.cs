using Click.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click.Services
{
    public class MouseControlService
    {
        // P/Invoke function for controlling the mouse
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        // constants for mouse flags
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002; // press left mouse button
        const uint MOUSEEVENTF_LEFTUP = 0x0004; // release left mouse button
        const uint MOUSEEVENTF_ABSOLUTE = 0x8000; // whole screen, not just application window
        const uint MOUSEEVENTF_MOVE = 0x0001; // move mouse

        public MouseInput CreateMouseInput(int x, int y, uint data, uint time, uint flag)
        {
            // create from the given data an object of the type MouseInput, which then can be send
            MouseInput Result = new MouseInput();
            Result.X = x;
            Result.Y = y;
            Result.MouseData = data;
            Result.Time = time;
            Result.DwFlags = flag;
            return Result;
        }

        public void SimulateMouseClick()
        {
            Input[] MouseEvent = new Input[2];
            MouseEvent[0].Type = 0;
            MouseEvent[0].Data = CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTDOWN);

            MouseEvent[1].Type = 0; // INPUT_MOUSE; 
            MouseEvent[1].Data = CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTUP);

            SendInput((uint)MouseEvent.Length, MouseEvent, Marshal.SizeOf(MouseEvent[0].GetType()));
        }

        public void SimulateMouseMove(int x, int y)
        {
            Input[] MouseEvent = new Input[1];
            MouseEvent[0].Type = 0;
            // move mouse: Flags ABSOLUTE (whole screen) and MOVE (move)
            MouseEvent[0].Data = CreateMouseInput(x, y, 0, 0, MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE);
            SendInput((uint)MouseEvent.Length, MouseEvent, Marshal.SizeOf(MouseEvent[0].GetType()));
        }

        public KeyValuePair<int, int> getCursorPosition()
        {
            Thread.Sleep(3000);
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            return new KeyValuePair<int, int>(X, Y);
        }
    }
}
