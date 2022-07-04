public class Place : ICommand
{
    public string Name => "PLACE";
    public int X { get; private set; }
    public int Y { get; private set; }
    public Direction Direction { get; private set; }

    public void Set(object parameters)
    {
        // Expected format x,y,direction
        var split = (parameters as string)?.Split(',');
        if (split?.Count() != 3)
        {
            throw new ArgumentException("Invalid format.");
        }
        int x, y;
        Direction direction;
        if (int.TryParse(split[0], out x) &&
            int.TryParse(split[1], out y) &&
            Enum.IsDefined(typeof(Direction), split[2]) &&
            Enum.TryParse<Direction>(split[2], ignoreCase: true, out direction))
        {
            X = x;
            Y = y;
            Direction = direction;
        }
        else
        {
            throw new ArgumentException("Invalid value.");
        }
    }

    public void Execute(Board board, Robot robot)
    {
        if (board.IsWithinBounds(X, Y))
        {
            robot.X = X;
            robot.Y = Y;
            robot.Direction = Direction;
            robot.IsPlaced = true;
        }
        else
        {
            Console.WriteLine("Invalid placement values.");
        }
    }
}