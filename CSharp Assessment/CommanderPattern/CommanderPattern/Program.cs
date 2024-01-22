class Program
{
    static void Main()
    {
        Target target = new Target();

        Command command = new Command(target);

        Source source = new Source();
        source.SetCommand(command);

        source.TriggerCommand();
    }
}
