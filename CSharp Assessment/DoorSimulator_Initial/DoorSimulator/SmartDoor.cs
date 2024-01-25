using System;
using System.Threading;

namespace DoorSimulator
{
    public class SmartDoor : SimpleDoor
    {
        public double BaseCost { get; private set; }

        private CompositeDoorCommand compositeCommand;

        public event Action NotifyEvent;

        public SmartDoor(string doorId, string material, double baseCost) : base(doorId, material)
        {
            BaseCost = baseCost;
            compositeCommand = new CompositeDoorCommand();
            compositeCommand.Execute += () => NotifyEvent?.Invoke();
        }

        public void AddFeature(IDoorFeature feature)
        {
            compositeCommand.AddCommand(feature);
        }

        public void SetTimer(int seconds)
        {
            // Simulating the timer using Thread.Sleep
            Thread.Sleep(seconds * 1000);

            // Execute the composite command
            compositeCommand.ExecuteCommands();
        }
    }
}
