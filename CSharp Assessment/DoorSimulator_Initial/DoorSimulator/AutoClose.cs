using System;

namespace DoorSimulator
{
    public class AutoClose : IDoorFeature
    {
        public double Cost { get; }

        public event Action Execute;

        public AutoClose(double cost)
        {
            Cost = cost;
            Execute += () => Console.WriteLine("AutoClose is changing the state of the door to closed.");
        }
    }
}
