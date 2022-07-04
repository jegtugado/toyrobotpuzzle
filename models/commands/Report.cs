public class Report : ICommand
{
    public string Name => "REPORT";

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

        Console.WriteLine($"Robot is at ({robot.X}, {robot.Y}) facing {robot.Direction}.");
    }
}
