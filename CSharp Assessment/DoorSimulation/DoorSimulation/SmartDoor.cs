using System;
using System.Collections.Generic;

public class SmartDoor : SimpleDoor
{
    public double BaseCost { get; private set; }

    private CompositeDoorCommand compositeCommand;
    private CustomTimer doorTimer;  

    public event Action NotifyEvent;

    public SmartDoor(string doorId, string material, double baseCost) : base(doorId, material)
    {
        BaseCost = baseCost;
        compositeCommand = new CompositeDoorCommand();
        doorTimer = new CustomTimer();
        doorTimer.Elapsed += OnTimerElapsed;
    }

    public void AddFeature(Action feature)
    {
        NotifyEvent += feature;
        compositeCommand.AddFeature(feature);
    }

    public void SetTimer(int seconds)
    {
        doorTimer.Start(seconds * 1000);
    }

    private void OnTimerElapsed(object sender, EventArgs e)
    {
        Logger.Log("Timer elapsed. Notifying observers:");
        NotifyEvent?.Invoke();
        compositeCommand.ExecuteFeatures();
    }
}
