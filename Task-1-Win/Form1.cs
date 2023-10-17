namespace Task_1_Win
{
    public partial class Form1 : Form
    {
        private Point startPoint; 
        private Rectangle currentRectangle; 
        private bool isDrawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (currentRectangle != null)
            {
                e.Graphics.DrawRectangle(Pens.Black, currentRectangle);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;

                if (currentRectangle != null)
                {
                    Label rectangleLabel = new Label();
                    rectangleLabel.Location = currentRectangle.Location;
                    rectangleLabel.Size = currentRectangle.Size;
                    rectangleLabel.BackColor = Color.MediumPurple;
                    this.Controls.Add(rectangleLabel);

                    rectangleLabel.MouseClick += new MouseEventHandler((s, ev) =>
                    {
                        if (ev.Button == MouseButtons.Left && ev.Clicks == 1)
                        {
                            Point labelLocation = rectangleLabel.Location;
                            string labelInfo = $"Kordinatları: ({labelLocation.X}, {labelLocation.Y})\nÖlçü: {rectangleLabel.Size.Width}x{rectangleLabel.Size.Height}\nRəng: {rectangleLabel.BackColor.Name}";
                            MessageBox.Show(labelInfo, "Label info");
                        }
                    });

                    rectangleLabel.MouseDoubleClick += new MouseEventHandler((s, ev) =>
                    {
                        this.Controls.Remove(rectangleLabel);
                    });

                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                int width = e.X - startPoint.X;
                int height = e.Y - startPoint.Y;

                currentRectangle = new Rectangle(startPoint.X, startPoint.Y, width, height);

                this.Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }
    }
}