namespace TradierClient
{
    using System;
    using System.ComponentModel;
    using System.Reflection;

    public static class Extensions
    {
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);

            if (name == null)
                return null;

            FieldInfo field = type.GetField(name);

            if (field == null)
                return name;

            DescriptionAttribute attr = Attribute
                .GetCustomAttribute(field, typeof(DescriptionAttribute))
                as DescriptionAttribute;

            if (attr == null)
                return name;

            return attr.Description;
        }
    }
}
