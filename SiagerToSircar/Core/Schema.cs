using System.Reflection;

namespace SiagerToSircar.Core
{
    public abstract class Schema {
        public WriteType GetWriteType()
        {
            foreach (WriteTypeAttribute attr in GetType().GetCustomAttributes(typeof(WriteTypeAttribute)))
                return attr.Type;
            return WriteType.FixedTXT;
            
        }
    }
}
