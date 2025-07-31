namespace GameOfLife
{
    public partial class FormMain : Form
    {
        private Engine Population;
        private Graphics graphics;
        private int resolution = 3;

        public FormMain()
        {
            InitializeComponent();            
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            pictureBoxFields.Image = new Bitmap(pictureBoxFields.Width, pictureBoxFields.Height);
            graphics = Graphics.FromImage(pictureBoxFields.Image);
            graphics.FillRectangle(Brushes.Crimson, 0, 0, resolution - 1, resolution - 1);
        }

        private void numericUpDownResolution_ValueChanged(object sender, EventArgs e)
        {
            resolution = (int)numericUpDownResolution.Value;
        }

        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);
            
            Population.NextGeneration();

            for (int x = 0; x < Population.Space.GetUpperBound(0); x++)
            {
                for (int y = 0; y < Population.Space.GetUpperBound(1); y++)
                {
                    var haslife = Population.Space[x, y];

                    if (haslife)
                    {
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    }
                }
            }
            pictureBoxFields.Refresh();
            this.Text = $"Поколение {Population.CurrentGeneratuion}";
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            numericUpDownResolution.Enabled = false;
            numericUpDownDensity.Enabled = false;

            Population = new Engine(
                rows: pictureBoxFields.Height / resolution,
                cols: pictureBoxFields.Width / resolution,
                density: (int)numericUpDownDensity.Maximum - (int)numericUpDownDensity.Value + 2
                );

            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            numericUpDownResolution.Enabled = true;
            numericUpDownDensity.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void pictureBoxFields_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            var x = e.X / resolution;
            var y = e.Y / resolution;

            if (e.Button == MouseButtons.Left)
                Population.SetHasLifeTrue(x, y);

            if (e.Button == MouseButtons.Right)
                Population.SetHasLifeFalse(x, y);
        }
    }
}
