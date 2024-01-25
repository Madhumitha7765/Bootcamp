using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerExercise
{
    public static class TaskManager
    {
        public static void ExecutePrintTask(IPrintable printable, string documentPath)
        {
            printable.Print(documentPath);
        }

        public static void ExecuteScanTask(IScannable scannable, string documentPath)
        {
            scannable.Scan(documentPath);
        }
    }
}
