





using TaskManagerExercise;

public class Program
{
    static void Main()
    {
        Printer printerObj = new Printer();
        Scanner scannerObj = new Scanner();
        PrintScanner printScannerObj = new PrintScanner(printerObj, scannerObj);

        TaskManager.ExecutePrintTask(printerObj, "Test.doc");
        TaskManager.ExecuteScanTask(scannerObj, "MyImage.png");
        TaskManager.ExecutePrintTask(printScannerObj, "NewDoc.doc");
        TaskManager.ExecuteScanTask(printScannerObj, "YourImage.png");
    }
}
