using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CoreApp.Core
{
    public class Reader<T> where T : new()
    {
        private string[] _lines { get; }

        public Reader(string filePath)
        {
            _lines = File.ReadAllLines(filePath);
        }

        public T[] Process()
        {
            List<T> registros = new List<T>();
            foreach (string source in _lines)
            {
                T registro = new T();

                foreach (PropertyInfo property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    foreach (SchemaPropertyAttribute parse in property.GetCustomAttributes(typeof(SchemaPropertyAttribute), true))
                    {
                        string data = source.Substring(parse.Desde - 1, parse.Hasta - (parse.Desde - 1));
                        data = data.Replace('.', ',');
                        property.SetValue(registro, System.Convert.ChangeType(data, property.PropertyType));
                    }
                }

                registros.Add(registro);
            }

            return registros.ToArray();
        }
    }
}
