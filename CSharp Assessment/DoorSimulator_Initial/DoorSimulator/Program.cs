using System;

namespace DoorSimulator
{
    class Program
    {
        static void Main()
        {
            var smartDoor = new SmartDoor("123", "steel", 50.0);

            var buzzer = new Buzzer(10.0);
            var pager = new Pager(15.0);
            var autoClose = new AutoClose(20.0);

            smartDoor.AddFeature(buzzer);
            smartDoor.AddFeature(pager);
            smartDoor.AddFeature(autoClose);

            var doorOperator = new DoorOperator(smartDoor);

            doorOperator.OperateDoor(true);

            doorOperator.SetTimer(5);
        }
    }
}
