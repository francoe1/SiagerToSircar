using System;
using System.Collections.Generic;
using System.IO;

namespace SiagerToSircar.Core
{
    public class Converter<IN, OUT> where IN : Schema, new() where OUT : Schema, new()
    {
        public string[] Output { get; private set; }

        public Converter(string sourcePath, string destinePath, Func<int, IN, OUT> filled)
        {
            Reader<IN> reader = new Reader<IN>(sourcePath);
            IN[] inSchemas = reader.Process();

            List<OUT> outSchemas = new List<OUT>();
            int index = 0;
            foreach (IN inSchema in inSchemas) outSchemas.Add(filled(++index, inSchema));

            Writer<OUT> writer = new Writer<OUT>();
            Output = writer.Write(outSchemas.ToArray());

            File.WriteAllLines(destinePath, Output);
        }
    }
}
