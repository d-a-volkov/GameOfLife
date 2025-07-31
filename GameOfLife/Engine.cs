namespace GameOfLife
{
    internal class Engine
    {
        public bool[,] Space { get; private set; }

        private readonly int _density;
        private readonly int _rows;
        private readonly int _cols;

        public int CurrentGeneratuion { get; private set; }

        public Engine(int rows, int cols, int density)
        {
            _density = density;
            _rows = rows;
            _cols = cols;

            Space = new bool[cols, rows];

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    Space[x, y] = random.Next(_density) == 0;
                }
            }
        }

        public void NextGeneration()
        {
            var newField = new bool[_cols, _rows];

            for (int x = 0; x < _cols; x++)
            {
                for (int y = 0; y < _rows; y++)
                {
                    var neightbourCount = CountNeighbour(x, y);
                    var haslife = Space[x, y];

                    if (!haslife && neightbourCount == 3)
                        newField[x, y] = true;
                    else if (haslife && (neightbourCount < 2 || neightbourCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = Space[x, y];
                }
            }
            Space = newField;

            CurrentGeneratuion++;
        }

        private int CountNeighbour(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + _cols) % _cols;
                    var row = (y + j + _rows) % _rows;

                    var isSelfChecking = col == x && row == y;
                    var haslife = Space[col, row];

                    if (haslife && !isSelfChecking)
                        count++;
                }
            }
            return count;
        }

        private bool ValidateMousePicture(int x, int y)
        {
            return x >= 0 && y >= 0 && x < _cols && y < _rows;
        }

        private void SetHasLife(int x, int y, bool set)
        {
            Space[x, y] = set;
        }

        public void SetHasLifeTrue(int x, int y)
        {
            if (ValidateMousePicture(x, y))
                SetHasLife(x, y, true);
        }

        public void SetHasLifeFalse(int x, int y)
        {
            if (ValidateMousePicture(x, y))
                SetHasLife(x, y, false);
        }
    }
}
