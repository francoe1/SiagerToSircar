using System.Reflection;

namespace CoreApp.Core
{
    public abstract class Schema
    {
        public WriteType GetWriteType()
        {
            foreach (WriteTypeAttribute attr in GetType().GetCustomAttributes(typeof(WriteTypeAttribute)))
                return attr.Type;
            return WriteType.FixedTXT;

        }
    }
}
