using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click
{
    public partial class Directions : Form
    {
        private int top = 80;
        public Directions()
        {
            InitializeComponent();
        }

        private void addDirectionsButton_Click(object sender, EventArgs e)
        {
            Label xLabel = new Label();
            xLabel.Text = "X:";
            xLabel.Left = 100;
            xLabel.Top = top;

            TextBox xCoordinatesTextBox = new TextBox();
            xCoordinatesTextBox.Left = 100;
            xCoordinatesTextBox.Top = top + 20;

            Label yLabel = new Label();
            yLabel.Text = "Y:";
            yLabel.Left = 250;
            yLabel.Top = top;

            TextBox yCoordinatesTextBox = new TextBox();
            yCoordinatesTextBox.Left = 250;
            yCoordinatesTextBox.Top = top + 20;

            this.Controls.Add(xLabel);
            this.Controls.Add(xCoordinatesTextBox);

            this.Controls.Add(yLabel);
            this.Controls.Add(yCoordinatesTextBox);
            top = top + 50;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            foreach(var value in this.Controls.OfType<TextBox>())
            {
                Console.WriteLine(value);
            }
        }
    }
}
