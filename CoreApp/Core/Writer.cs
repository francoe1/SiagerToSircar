using System.Collections.Generic;
using System.Reflection;

namespace CoreApp.Core
{
    public class Writer<T> where T : Schema, new()
    {
        public string[] Write(T[] registers)
        {
            List<string> registros = new List<string>();


            foreach (T source in registers)
            {
                string line = "";
                WriteType writeType = source.GetWriteType();

                foreach (PropertyInfo property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    foreach (SchemaPropertyAttribute parse in property.GetCustomAttributes(typeof(SchemaPropertyAttribute), true))
                    {
                        string value = Fixed(property.GetValue(source).ToString(), parse.Hasta - (parse.Desde - 1), parse.LeftPad, parse.PadChar);
                        line += value.Replace(',', '.');
                        if (writeType == WriteType.CSV) line += ",";
                    }
                }

                if (writeType == WriteType.CSV)
                {
                    line = line.Replace(" ", "");
                    line = line.TrimEnd(',');
                }

                registros.Add(line);
            }

            return registros.ToArray();
        }

        private static string Fixed(string data, int length, bool leftPad, char padChar)
        {
            if (data.Length > length) return data.Substring(0, length);
            string pad = "".PadRight(length - data.Length, padChar);
            if (leftPad) return pad + data;
            return data + pad;
        }

    }
}

