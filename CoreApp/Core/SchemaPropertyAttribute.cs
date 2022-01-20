using System;

namespace CoreApp.Core
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SchemaPropertyAttribute : Attribute
    {
        public int Desde { get; }
        public int Hasta { get; }
        public bool LeftPad { get; set; }
        public char PadChar { get; set; } = ' ';

        public SchemaPropertyAttribute(int desde, int hasta, bool leftPad = false)
        {
            Desde = desde;
            Hasta = hasta;
            LeftPad = leftPad;
        }
    }
}
