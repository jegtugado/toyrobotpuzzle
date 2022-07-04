public class Left : ICommand
{
    public string Name => "LEFT";

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
                robot.Direction = Direction.WEST;
                break;
            case Direction.SOUTH:
                robot.Direction = Direction.EAST;
                break;
            case Direction.EAST:
                robot.Direction = Direction.NORTH;
                break;
            case Direction.WEST:
                robot.Direction = Direction.SOUTH;
                break;
            default:
                break;
        }
    }
}