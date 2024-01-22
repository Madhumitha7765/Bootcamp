namespace Assessment_Device
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Device deviceObj = new Device("test01", 80, "sample description");

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
