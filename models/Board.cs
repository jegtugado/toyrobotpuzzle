public class Board
{
    public Cell[,] Cells { get; }

    public Board(int row, int col)
    {
        Cells = new Cell[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Cells[i, j] = new Cell();
            }
        }
    }

    public bool IsWithinBounds(int x, int y)
    {
        return x >= 0 && x < Cells.GetLength(0) &&
            y >= 0 && y < Cells.GetLength(1);
    }

    public void Draw(Robot robot)
    {
        Console.WriteLine();
        for (int x = Cells.GetLength(0) - 1; x >= 0; x--)
        {
            for (int y = 0; y < Cells.GetLength(1); y++)
            {
                // Robot occupies the cell
                if (robot.IsPlaced && robot.Y == x && robot.X == y)
                {
                    Console.Write("[ R ]");
                }
                else
                {
                    Console.Write($"[ X ]");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("===========");
        Console.WriteLine();
    }
}