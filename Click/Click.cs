using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Threading;

namespace Click
{
    public partial class Click : Form
    {
        public Click()
        {
            InitializeComponent();
        }

        // P/Invoke function for controlling the mouse
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        /// <summary>
        /// structure for mouse data
        /// </summary>
        struct MouseInput
        {
            public int X; // X coordinate
            public int Y; // Y coordinate
            public uint MouseData; // mouse data, e.g. for mouse wheel
            public uint DwFlags; // further mouse data, e.g. for mouse buttons
            public uint Time; // time of the event
            public IntPtr DwExtraInfo; // further information
        }

        /// <summary>
        /// super structure for input data of the function SendInput
        /// </summary>
        struct Input
        {
            public int Type; // type of the input, 0 for mouse  
            public MouseInput Data; // mouse data
        }

        int count = 0;

        // constants for mouse flags
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002; // press left mouse button
        const uint MOUSEEVENTF_LEFTUP = 0x0004; // release left mouse button
        const uint MOUSEEVENTF_ABSOLUTE = 0x8000; // whole screen, not just application window
        const uint MOUSEEVENTF_MOVE = 0x0001; // move mouse

        private MouseInput CreateMouseInput(int x, int y, uint data, uint time, uint flag)
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

        private void SimulateMouseClick()
        {
            // Linksklick simulieren: Maustaste drücken und loslassen
            Input[] MouseEvent = new Input[2];
            MouseEvent[0].Type = 0;
            MouseEvent[0].Data = CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTDOWN);

            MouseEvent[1].Type = 0; // INPUT_MOUSE; 
            MouseEvent[1].Data = CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTUP);

            SendInput((uint)MouseEvent.Length, MouseEvent, Marshal.SizeOf(MouseEvent[0].GetType()));
        }

        //private void IntervalLeftClick(int lowerBound, int upperBound)
        //{
        //    Random rnd = new Random();
        //    int wait;
        //    // Linksklick simulieren: Maustaste drücken und loslassen
        //    Input[] MouseEvent = new Input[2];
        //    MouseEvent[0].Type = 0;
        //    MouseEvent[0].Data = CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTDOWN);

        //    MouseEvent[1].Type = 0; // INPUT_MOUSE; 
        //    MouseEvent[1].Data = CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTUP);

        //    wait = rnd.Next(lowerBound, upperBound) * 1000;
        //    SendInput((uint)MouseEvent.Length, MouseEvent, Marshal.SizeOf(MouseEvent[0].GetType()));
        //    Thread.Sleep(wait);
        //}

        private void SimulateMouseMove(int x, int y)
        {
            Input[] MouseEvent = new Input[1];
            MouseEvent[0].Type = 0;
            // move mouse: Flags ABSOLUTE (whole screen) and MOVE (move)
            MouseEvent[0].Data = CreateMouseInput(x, y, 0, 0, MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE);
            SendInput((uint)MouseEvent.Length, MouseEvent, Marshal.SizeOf(MouseEvent[0].GetType()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(xTextBox.Text, out int x);
            Int32.TryParse(yTextBox.Text, out int y);
            // move mouse
            SimulateMouseMove(x, y);
            // click
            SimulateMouseClick();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ThreadStart intervalRef = new ThreadStart(intervalStart);
            Thread countThread = new Thread(intervalRef);
            countThread.Start();
            Thread.Sleep(5000);
        }

        private void intervalStart()
        {
            Random rnd = new Random();
            int wait;
            int count = 0;

            Input[] MouseEvent = new Input[2];
            MouseEvent[0].Type = 0;
            MouseEvent[0].Data = CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTDOWN);

            MouseEvent[1].Type = 0; // INPUT_MOUSE; 
            MouseEvent[1].Data = CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTUP);

            Console.WriteLine("Start interval thread");
            Int32.TryParse(intervalLowerBoundTextBox.Text, out int lowerBound);
            Int32.TryParse(intervalUpperBoundTextBox.Text, out int upperBound);
            Int32.TryParse(itemAmountTextBox.Text, out int itemAmount);

            for (int i = 0; i < itemAmount * 2; i++)
            {
                wait = rnd.Next(lowerBound, upperBound);
                Console.WriteLine(wait);
                SendInput((uint)MouseEvent.Length, MouseEvent, Marshal.SizeOf(MouseEvent[0].GetType()));
                Thread.Sleep(wait);
                count++;
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            count++;
            countTextBox.Text = count.ToString();
        }    
    }
}
