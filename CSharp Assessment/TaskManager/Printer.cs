using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerExercise{
    public class Printer : IPrintable
    {
        public void Print(string path)
        {
            Logger.Log($"Printing .....{path}");
        }
    }
}
