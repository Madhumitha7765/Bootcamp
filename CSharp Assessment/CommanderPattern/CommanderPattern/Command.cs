using System;
using System.Reflection;

public class Command
{
    private object target;
    private string methodName;

    public Command(object tgt, string method)
    {
        target = tgt;
        methodName = method;
    }

    public void Execute()
    {
        Console.WriteLine("Command: Execute method is called.");

        MethodInfo methodInfo = target.GetType().GetMethod(methodName);

        if (methodInfo != null)
        {
            methodInfo.Invoke(target, null);
        }
        else
        {
            Console.WriteLine($"Method '{methodName}' not found in the target class.");
        }
    }
}
