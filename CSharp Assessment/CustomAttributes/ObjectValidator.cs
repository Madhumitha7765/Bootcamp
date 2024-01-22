namespace Assessment_Device
{
    using System;
    using System.Collections.Generic;

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
}
