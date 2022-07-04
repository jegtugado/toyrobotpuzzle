public class Move : ICommand
{
    public string Name => "MOVE";

    public void Set(object parameters)
    {

    }

    public void Execute(Board board, Robot robot)
    {
        if (!robot.IsPlaced)
        {
            Console.WriteLine("Robot not in place.");
            return;
        }

        int x = robot.X;
        int y = robot.Y;

        switch (robot.Direction)
        {
            case Direction.NORTH:
                y++;
                break;
            case Direction.SOUTH:
                y--;
                break;
            case Direction.EAST:
                x++;
                break;
            case Direction.WEST:
                x--;
                break;
            default:
                break;
        }

        if (board.IsWithinBounds(x, y))
        {
            robot.X = x;
            robot.Y = y;
        }
        else
        {
            Console.WriteLine("You almost fell off the table.");
        }
    }
}