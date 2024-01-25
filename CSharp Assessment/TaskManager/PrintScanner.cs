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
    private readonly IPrinter printer;
    private readonly IScanner scanner;

    public PrintScanner()
    {
        this.printer = new Printer();
        this.scanner = new Scanner();
    }

    public void Print(string document)
    {
        this.printer.print()
    }

    public void Scan(string document)
    {
        this.scanner.scan()
    }
}
    
}
