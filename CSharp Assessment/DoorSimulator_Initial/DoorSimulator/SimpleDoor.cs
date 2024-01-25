using System;

namespace DoorSimulator
{
    public enum DoorState
    {
        Open,
        Closed
    }

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
            Console.WriteLine($"Door {DoorId} is now open.");
        }

        public void Close()
        {
            State = DoorState.Closed;
            Console.WriteLine($"Door {DoorId} is now closed.");
        }
    }
}
