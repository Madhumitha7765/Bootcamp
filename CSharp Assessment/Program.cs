
using System;
using System.Collections.Generic;

class Device
{
    [Required(ErrorMessage = "ID Property Requires Value")]
    private string _id;

    [Range(10, 100, ErrorMessage = "Code Value Must Be Within 10-100")]
    private int _code;

    [MaxLength(100, ErrorMessage = "Max of 100 Characters are allowed")]
    private string _description;

    public Device(string id, int code, string description)
    {
        Id = id;
        Code = code;
        Description = description;
    }

    public string Id { get; private set; }

    public int Code { get; private set; }

    public string Description { get; private set; }
}

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
class RequiredAttribute : Attribute
{
    public string ErrorMessage { get; set; }
}

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
class RangeAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }
    public string ErrorMessage { get; set; }

    public RangeAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
class MaxLengthAttribute : Attribute
{
    public int MaxLength { get; }
    public string ErrorMessage { get; set; }

    public MaxLengthAttribute(int maxLength)
    {
        MaxLength = maxLength;
    }
}

class ObjectValidator
{
    public static bool Validate<T>(T obj, out List<string> errors)
    {
        errors = new List<string>();

        var type = typeof(T);
        var fields = type.GetFields();
        var properties = type.GetProperties();

        foreach (var field in fields)
        {
            ValidateMember(obj, field, errors);
        }

        foreach (var property in properties)
        {
            ValidateMember(obj, property, errors);
        }

        return errors.Count == 0;
    }

    private static void ValidateMember<T>(T obj, System.Reflection.MemberInfo member, List<string> errors)
    {
        var attributes = member.GetCustomAttributes(false);
        foreach (var attribute in attributes)
        {
            if (attribute is RequiredAttribute required)
            {
                var value = member is System.Reflection.FieldInfo ? ((System.Reflection.FieldInfo)member).GetValue(obj) : ((System.Reflection.PropertyInfo)member).GetValue(obj);
                if (value == null || string.IsNullOrEmpty(value.ToString()))
                {
                    errors.Add(required.ErrorMessage);
                }
            }
            else if (attribute is RangeAttribute range)
            {
                var value = member is System.Reflection.FieldInfo ? (int)((System.Reflection.FieldInfo)member).GetValue(obj) : (int)((System.Reflection.PropertyInfo)member).GetValue(obj);
                if (value < range.Min || value > range.Max)
                {
                    errors.Add(range.ErrorMessage);
                }
            }
            else if (attribute is MaxLengthAttribute maxLength)
            {
                var value = member is System.Reflection.FieldInfo ? (string)((System.Reflection.FieldInfo)member).GetValue(obj) : (string)((System.Reflection.PropertyInfo)member).GetValue(obj);
                if (value != null && value.Length > maxLength.MaxLength)
                {
                    errors.Add(maxLength.ErrorMessage);
                }
            }
        }
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
