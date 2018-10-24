using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Click.Services;
using Click.Models;

namespace Click
{
    public partial class Click : Form
    {
        MouseControlService mouseControlService = new MouseControlService();
        int count = 0;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002; // press left mouse button
        const uint MOUSEEVENTF_LEFTUP = 0x0004; // release left mouse button
        const uint MOUSEEVENTF_ABSOLUTE = 0x8000; // whole screen, not just application window
        const uint MOUSEEVENTF_MOVE = 0x0001; // move mouse
        public Click()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(xTextBox.Text, out int x);
            Int32.TryParse(yTextBox.Text, out int y);
            // move mouse
            mouseControlService.SimulateMouseMove(x, y);
            // click
            mouseControlService.SimulateMouseClick();
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
            MouseEvent[0].Data = mouseControlService.CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTDOWN);

            MouseEvent[1].Type = 0; // INPUT_MOUSE; 
            MouseEvent[1].Data = mouseControlService.CreateMouseInput(0, 0, 0, 0, MOUSEEVENTF_LEFTUP);

            Console.WriteLine("Start interval thread");
            Int32.TryParse(intervalLowerBoundTextBox.Text, out int lowerBound);
            Int32.TryParse(intervalUpperBoundTextBox.Text, out int upperBound);
            Int32.TryParse(itemAmountTextBox.Text, out int itemAmount);

            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;

            for (int i = 0; i < itemAmount * 2; i++)
            {
                wait = rnd.Next(lowerBound, upperBound);
                Console.WriteLine(wait);
                MouseControlService.SendInput((uint)MouseEvent.Length, MouseEvent, Marshal.SizeOf(MouseEvent[0].GetType()));
                Thread.Sleep(wait);
                count++;
                if (X != Cursor.Position.X || Y != Cursor.Position.Y)
                {
                    break;
                }
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            count++;
            countTextBox.Text = count.ToString();
        }

        private void directionsButton_Click(object sender, EventArgs e)
        {
            Directions directionsForm = new Directions();
            directionsForm.Show();
        }
    }
}
