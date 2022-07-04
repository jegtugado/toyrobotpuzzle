// See https://aka.ms/new-console-template for more information
Console.WriteLine("=== Toy robot puzzle ===");

CommandFactory commandFactory = new CommandFactory();
commandFactory.RegisterCommand("PLACE", new Place());
commandFactory.RegisterCommand("MOVE", new Move());
commandFactory.RegisterCommand("LEFT", new Left());
commandFactory.RegisterCommand("RIGHT", new Right());
commandFactory.RegisterCommand("REPORT", new Report());
Robot robot = new Robot();
Board board = new Board(5, 5);
do
{
    Console.Write("Input: ");
    var inputString = Console.ReadLine() ?? "";
    var input = new Input(commandFactory, inputString);
    ICommand? command;
    if (input.TryParseCommand(out command))
    {
        command?.Execute(board, robot);
        board.Draw(robot);
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
} while (true);


