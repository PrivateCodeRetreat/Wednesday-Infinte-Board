using System.Collections.Generic;

namespace UnitTestProject1
{
    public class Board
    {
        //private bool[,] _cells = new bool[10, 10];
        private readonly Dictionary<string, bool[,]> _cells = new Dictionary<string, bool[,]>();

        public string RenderAt(int x, int y)
        {
            string result = "";
            for (int i = 0; i < 10; i++) // fix
            {
                for (int j = 0; j < 10; j++) // fix
                {
                    var subCells = _cells
                        // get cells, render them
                    //result += this._cells[i, j] ? "*" : "_";
                    result += this
                }

                result += "\n";
            }

            return result;
        }

        public void SetCellAlive(Point point)
        {
            if (!_cells.ContainsKey(point.GetGridHash()))
            {
                _cells[point.GetGridHash()] = new bool[10,10];
            }

            var subCells = _cells[point.GetGridHash()];

            subCells[point.x % 10, point.y % 10] = true;
        }
    }
}