public class Right : ICommand
{
    public string Name => "RIGHT";

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

        switch (robot.Direction)
        {
            case Direction.NORTH:
                robot.Direction = Direction.EAST;
                break;
            case Direction.SOUTH:
                robot.Direction = Direction.WEST;
                break;
            case Direction.EAST:
                robot.Direction = Direction.SOUTH;
                break;
            case Direction.WEST:
                robot.Direction = Direction.NORTH;
                break;
            default:
                break;
        }
    }
}