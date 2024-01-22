using System;
using System.Collections.Generic;
using System.Reflection;

namespace Assessment_Device
{
    public static class ObjectValidator
    {
        public static bool Validate<T>(T obj, out List<string> errors)
        {
            errors = new List<string>();

            Type type = typeof(T);
            MemberInfo[] members = type.GetMembers();

            foreach (MemberInfo member in members)
            {
                ValidateMember(obj, member, errors);
            }

            return errors.Count == 0;
        }

        private static void ValidateMember<T>(T obj, MemberInfo member, List<string> errors)
        {
            object[] attributes = member.GetCustomAttributes(typeof(ValidateAttribute), false);

            foreach (object attribute in attributes)
            {
                if (attribute is ValidateAttribute validationAttribute)
                {
                    object value = GetMemberValue(obj, member);

                    errors.Add(validationAttribute.IsValid());
                }
            }
        }

        private static object GetMemberValue<T>(T obj, MemberInfo member)
        {
            if (member is FieldInfo field)
            {
                return field.GetValue(obj);
            }
            else if (member is PropertyInfo property)
            {
                return property.GetValue(obj);
            }

            throw new ArgumentException($"Unsupported member type: {member.MemberType}");
        }
    }
}

