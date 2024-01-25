using System;

namespace DoorSimulator
{
    public class DoorOperator
    {
        private SmartDoor door;

        public DoorOperator(SmartDoor door)
        {
            this.door = door;
            this.door.NotifyEvent += () => Console.WriteLine("SmartDoor: Notifying observers.");
        }

        public void OperateDoor(bool open)
        {
            if (open)
            {
                door.Open();
            }
            else
            {
                door.Close();
            }
        }

        public void SetTimer(int seconds)
        {
            door.SetTimer(seconds);
        }
    }
}
