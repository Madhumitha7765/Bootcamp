using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerExercise
{
    public class Scanner : IScannable
    {
        public void Scan(string path)
        {
            Logger.Log($"Scanning .....{path}");
        }
    }
}
