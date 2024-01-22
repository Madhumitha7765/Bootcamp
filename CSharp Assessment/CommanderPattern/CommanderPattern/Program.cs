class Program
{
    static void Main()
    {
        Target target = new Target();
        Target2 target2 = new Target2();
        Target3 target3 = new Target3();

        Source source = new Source();

        Command command1 = new Command(target, "ExecuteTask");
        Command command2 = new Command(target2, "DoTask");
        Command command3 = new Command(target3, "Invoke");

        source.SetCommand(command1);

        source.TriggerCommand();

        source.SetCommand(command2);
        source.TriggerCommand();

        source.SetCommand(command3);
        source.TriggerCommand();
    }
}
