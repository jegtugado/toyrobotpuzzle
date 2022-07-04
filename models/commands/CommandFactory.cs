public class CommandFactory
{
    private readonly Dictionary<string, ICommand> _commands;

    public CommandFactory()
    {
        _commands = new Dictionary<string, ICommand>();
    }

    public void RegisterCommand(string commandName, ICommand command)
    {
        _commands.Add(commandName, command);
    }

    public ICommand? GetCommand(string commandName)
    {
        if (_commands.ContainsKey(commandName))
            return _commands[commandName];
        else
            return null;
    }
}