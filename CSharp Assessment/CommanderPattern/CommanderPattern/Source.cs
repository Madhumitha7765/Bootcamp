using System;

public class Source
{
    private Command command;

    public void SetCommand(Command cmd)
    {
        command = cmd;
    }

    public void TriggerCommand()
    {
        Console.WriteLine("Source: Triggering command...");
        command.Execute();
    }
}
