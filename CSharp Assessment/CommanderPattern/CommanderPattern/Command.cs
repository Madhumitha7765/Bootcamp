using System;

public class Command
{
    private Target target;

    public Command(Target tgt)
    {
        target = tgt;
    }

    public void Execute()
    {
        Console.WriteLine("Command: Execute method is called.");

        target.ExecuteTask();
    }
}
