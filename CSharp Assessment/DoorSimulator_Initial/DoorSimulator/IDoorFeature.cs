using System;

namespace DoorSimulator
{
    public interface IDoorFeature
    {
        double Cost { get; }
        event Action Execute;
    }
}
