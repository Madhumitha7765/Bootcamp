
using System;
using System.Collections.Generic;

class Device
{
    private string _id;
    private int _code;
    private string _description;

    public Device(string id, int code, string description)
    {
        Id = id;
        Code = code;
        Description = description;
    }

    public string Id
    {
        get => _id;
        private set => _id = ValidateAndSetProperty(value, "ID Property Requires Value");
    }

    public int Code
    {
        get => _code;
        private set => _code = ValidateAndSetProperty(value, "Code Value Must Be Within 10-100", 10, 100);
    }

    public string Description
    {
        get => _description;
        private set => _description = ValidateAndSetProperty(value, "Max of 100 Characters are allowed", maxLength: 100);
    }

    private T ValidateAndSetProperty<T>(T value, string errorMessage, T minValue = default, T maxValue = default, int maxLength = 0)
    {
        if ((minValue != null && ((IComparable)value).CompareTo(minValue) < 0) ||
            (maxValue != null && ((IComparable)value).CompareTo(maxValue) > 0) ||
            (maxLength > 0 && value is string strValue && strValue.Length > maxLength))
        {
            throw new ArgumentException(errorMessage);
        }

        return value;
    }
}

class ObjectValidator
{
    public static bool Validate<T>(T obj, out List<string> errors)
    {
        errors = new List<string>();

        if (obj == null)
        {
            errors.Add("Object cannot be null.");
            return false;
        }

        if (obj is Device device)
        {
            try
            {
                device.Id = device.Id;
                device.Code = device.Code;
                device.Description = device.Description;
            }
            catch (ArgumentException ex)
            {
                errors.Add(ex.Message);
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Device deviceObj = new Device("test01", 180, "sample description");

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
