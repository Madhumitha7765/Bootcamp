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
            Action methodDelegate = (Action)Delegate.CreateDelegate(typeof(Action), target, methodInfo);

            methodDelegate?.Invoke();
        }
        else
        {
            Console.WriteLine($"Method '{methodName}' not found in the target class.");
        }
    }
}
