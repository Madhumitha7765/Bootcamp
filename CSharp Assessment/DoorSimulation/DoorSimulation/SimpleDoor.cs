using System;
using System.Collections.Generic;

public class SimpleDoor
{
    public string DoorId { get; }
    public string Material { get; }
    public DoorState State { get; private set; }

    public SimpleDoor(string doorId, string material)
    {
        DoorId = doorId;
        Material = material;
        State = DoorState.Closed;
    }

    public void Open()
    {
        State = DoorState.Open;
        Logger.Log($"Door {DoorId} is now open.");
    }

    public void Close()
    {
        State = DoorState.Closed;
        Logger.Log($"Door {DoorId} is now closed.");
    }
}
