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
            TextBox directionsTextBox = new TextBox();
            directionsTextBox.Left = 100;
            directionsTextBox.Top = top;
            this.Controls.Add(directionsTextBox);
            top = top + 30;
        }
    }
}
