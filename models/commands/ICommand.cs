public interface ICommand
{
    string Name { get; }
    void Set(object? parameters);
    void Execute(Board board, Robot robot);
}