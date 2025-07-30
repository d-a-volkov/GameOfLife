namespace GameOfLife
{
    public partial class FormMain : Form
    {
        private Graphics graphics;
        private int resolution = 3;
        private int density = 2;
        private bool[,] field;
        private int rows;
        private int cols;
        private int currentGeneratuion;

        public FormMain()
        {
            InitializeComponent();
        }

        private void numericUpDownResolution_ValueChanged(object sender, EventArgs e)
        {
            resolution = (int)numericUpDownResolution.Value;
        }

        private void numericUpDownDensity_ValueChanged(object sender, EventArgs e)
        {
            density = (int)numericUpDownDensity.Value;
        }

        private void setFields()
        {
            currentGeneratuion = 0;
            pictureBoxFields.Image = new Bitmap(pictureBoxFields.Width, pictureBoxFields.Height);
            graphics = Graphics.FromImage(pictureBoxFields.Image);
            graphics.FillRectangle(Brushes.Crimson, 0, 0, resolution, resolution);

            rows = pictureBoxFields.Height / resolution;
            cols = pictureBoxFields.Width / resolution;
            field = new bool[cols, rows];

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(density) == 0;
                }
            }

        }

        private void NextGeneration()
        {
            graphics.Clear(Color.Black);

            var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neightbourCount = CountNeighbour(x, y);
                    var haslife = field[x, y];

                    if (!haslife && neightbourCount == 3)
                        newField[x, y] = true;
                    else if (haslife && (neightbourCount < 2 || neightbourCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];

                    if (haslife)
                    {
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution, resolution);
                    }

                }
            }
            field = newField;
            pictureBoxFields.Refresh();
            this.Text = $"Поколение {++currentGeneratuion}";
        }

        private int CountNeighbour(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;
                    var haslife = field[col, row];

                    if (haslife && !isSelfChecking)
                        count++;
                }
            }
            return count;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            numericUpDownResolution.Enabled = false;
            numericUpDownDensity.Enabled = false;

            setFields();

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
            NextGeneration();
        }

        private void pictureBoxFields_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled) 
                return;

            var x = e.X / resolution;
            var y = e.Y / resolution;

            if (!ValidateMousePicture(x, y))
                return;

            if (e.Button == MouseButtons.Left)
                field[x,y] = true;

            if (e.Button == MouseButtons.Right)
                field[x, y] = false;
        }

        private bool ValidateMousePicture(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }
    }
}
