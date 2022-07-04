public class Input
{
    private readonly CommandFactory commandFactory;

    public string Text { get; }
    public int X { get; private set; }
    public int Y { get; private set; }
    public Direction Direction { get; private set; }

    public Input(CommandFactory commandFactory, string text)
    {
        this.commandFactory = commandFactory;
        this.Text = text;
    }

    public bool TryParseCommand(out ICommand? command)
    {
        command = null;
        var invalid = string.IsNullOrEmpty(Text) || !Text.IsUpper();
        if (!invalid)
        {
            var split = Text.Split(' ');
            var commandName = split[0];

            if ((commandName != "PLACE" && split.Length != 1) ||
                (commandName == "PLACE" && split.Length != 2))
            {
                invalid = true;
            }
            else
            {
                try
                {
                    command = commandFactory.GetCommand(commandName);
                    invalid = command == null;
                    var parameters = split.Length == 2 ? split[1] : null;
                    command?.Set(parameters);
                }
                catch
                {
                    invalid = true;
                }
            }
        }

        return !invalid;
    }
}