using System;
using System.Collections.Generic;

namespace DoorSimulator
{
    public class CompositeDoorCommand : IDoorFeature
    {
        private List<IDoorFeature> commands = new List<IDoorFeature>();

        public double Cost
        {
            get
            {
                double totalCost = 0.0;
                foreach (var command in commands)
                {
                    totalCost += command.Cost;
                }
                return totalCost;
            }
        }

        public event Action Execute;

        public void AddCommand(IDoorFeature command)
        {
            commands.Add(command);
            command.Execute += () => Execute?.Invoke();
        }

        public void ExecuteCommands()
        {
            Execute?.Invoke();
        }
    }
}
