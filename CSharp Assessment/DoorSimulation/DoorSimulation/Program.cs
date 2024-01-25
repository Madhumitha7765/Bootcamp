using System;

class Program
{
    static void Main()
    {
        var smartDoor = new SmartDoor("123", "steel", 50.0);

        var buzzer = new Buzzer(10.0);
        var pager = new Pager(15.0);
        var autoClose = new AutoClose(20.0);

        smartDoor.AddFeature(() => buzzer.Execute());
        smartDoor.AddFeature(() => pager.Execute());
        smartDoor.AddFeature(() => autoClose.Execute());

        // Open the door
        smartDoor.Open();

        // Set a timer for 10 seconds
        smartDoor.SetTimer(10);

        // Simulate other actions or events
        Console.ReadLine(); // To keep the console application running
    }
}
