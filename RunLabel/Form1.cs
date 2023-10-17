using System;
using System.Drawing;
using System.Windows.Forms;

namespace RunLabel
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            myLabel.MouseMove += myLabel_MouseMove;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myLabel.Location = new Point(100, 100);
        }

        private void myLabel_MouseMove(object sender, MouseEventArgs e)
        {
            int maxX = this.ClientSize.Width - myLabel.Width;
            int maxY = this.ClientSize.Height - myLabel.Height;
            int newX = random.Next(maxX);
            int newY = random.Next(maxY);

            myLabel.Location = new Point(newX, newY);
        }
    }
}