using System;

namespace CoreApp.Core
{
    public enum WriteType
    {
        FixedTXT,
        CSV
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class WriteTypeAttribute : Attribute
    {
        public WriteType Type { get; }

        public WriteTypeAttribute(WriteType type)
        {
            Type = type;
        }
    }
}
