using System;

namespace DoorSimulator
{
    public class Pager : IDoorFeature
    {
        public double Cost { get; }

        public event Action Execute;

        public Pager(double cost)
        {
            Cost = cost;
            Execute += () => Console.WriteLine("Pager is receiving alerts.");
        }
    }
}
