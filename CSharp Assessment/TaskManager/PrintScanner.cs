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
        private readonly IPrintable printer;
        private readonly IScannable scanner;

        public PrintScanner()
        {
            this.printer = new Printer();
            this.scanner = new Scanner();
        }

        public void Print(string document)
        {
            printer.Print(document);
        }

        public void Scan(string document)
        {
            scanner.Scan(document);
        }
    }

}
