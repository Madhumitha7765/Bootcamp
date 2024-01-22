using System;
using System.Collections.Generic;

class Device
{
    private string _id;
    private int _code;
    private string _description;

    public Device(string id, int code, string description)
    {
        SetId(id);
        SetCode(code);
        SetDescription(description);
    }

    public string Id
    {
        get { return _id; }
    }

    public int Code
    {
        get { return _code; }
    }

    public string Description
    {
        get { return _description; }
    }

    public void SetId(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentException("ID Property Requires Value");
        }
        _id = id;
    }

    public void SetCode(int code)
    {
        if (code < 10 || code > 100)
        {
            throw new ArgumentException("Code Value Must Be Within 10-100");
        }
        _code = code;
    }

    public void SetDescription(string description)
    {
        if (description != null && description.Length > 100)
        {
            throw new ArgumentException("Max of 100 Characters are allowed");
        }
        _description = description;
    }
}

class ObjectValidator
{
    public static bool Validate<T>(T obj, out List<string> errors)
    {
        errors = new List<string>();

        if (obj is Device)
        {
            Device device = (Device)(object)obj;

            try
            {
                device.SetId(device.Id);
                device.SetCode(device.Code);
                device.SetDescription(device.Description);
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
