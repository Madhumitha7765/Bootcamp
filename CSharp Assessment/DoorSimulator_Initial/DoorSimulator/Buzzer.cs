using System;

namespace DoorSimulator
{
    public class Buzzer : IDoorFeature
    {
        public double Cost { get; }

        public event Action Execute;

        public Buzzer(double cost)
        {
            Cost = cost;
            Execute += () => Console.WriteLine("Buzzer is making noise.");
        }
    }
}
