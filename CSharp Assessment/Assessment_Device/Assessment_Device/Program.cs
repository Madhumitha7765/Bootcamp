using System;
using System.Collections.Generic;
using ZeissObjectValidator;

namespace Assessment_Device
{

    class Program
    {
        static void Main()
        {
            Device deviceObj = new Device("sample11", 90, "sample description", "Zxxx123454324532");

            List<string> errors;
            bool isValid = ObjectValidator.Validate(deviceObj, out errors);

            if (!isValid)
            {
                foreach (string item in errors)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No Errors");
            }
        }
    }
}
