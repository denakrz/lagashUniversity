using System;
using System.Collections.Generic;
using System.Linq;
using ExampleAttributes.Attributes;

namespace ExampleAttributes.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var attribute = GetFirstOrDefaultAttribute<DisplayNameAttribute>(enumValue);
            return attribute != null ? attribute.DisplayName : string.Empty;
        } 
       
        private static T GetFirstOrDefaultAttribute<T>(Enum enumValue) where T : Attribute
        {
            var attributes = GetAttributes<T>(enumValue);
            return attributes.FirstOrDefault() as T;
        }

        private static IEnumerable<T> GetAttributes<T>(Enum enumValue) where T : Attribute
        {
            var type = enumValue.GetType();
            var memberInfo = type.GetMember(enumValue.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return attributes.Cast<T>();
        }

    }
}

