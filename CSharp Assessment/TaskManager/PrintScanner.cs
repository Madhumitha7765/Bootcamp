using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerExercise
{
    public class PrintScanner : IPrintable, IScannable
    {
        public void Print(string path)
        {
            System.Console.WriteLine($"Printing  .....{path}");
        }

        public void Scan(string path)
        {
            System.Console.WriteLine($"Scanning  .....{path}");
        }
    }
}
