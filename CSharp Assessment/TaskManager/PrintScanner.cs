using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerExercise
{
    public class PrintScanner : IPrintable, IScannable
    {
        private readonly IPrintable printer;
        private readonly IScannable scanner;

        public PrintScanner(IPrintable printer, IScannable scanner)
        {
            this.printer = printer ?? throw new ArgumentNullException(nameof(printer));
            this.scanner = scanner ?? throw new ArgumentNullException(nameof(scanner));
        }

        public void Print(string path)
        {
            printer.Print(path);
        }

        public void Scan(string path)
        {
            scanner.Scan(path);
        }
    }
}
