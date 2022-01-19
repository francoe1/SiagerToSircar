using System;

namespace SiagerToSircar.Core
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
