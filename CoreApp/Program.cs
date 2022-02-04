using CoreApp.Helpers;
using CoreApp.Schemas;
using System;

namespace CoreApp
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 2)
                {
                    string path = args[1];

                    if (args[0] == "-p")
                    {
                        Core.Converter<PercepcionSiagerSchema, PercepcionSircarSchema> convert = ConvertHelpers.Percepciones_SIAGER_SIRCAR(path, false);
                        foreach (string output in convert.Output) Console.WriteLine(output);
                        return;
                    }
                    else if (args[0] == "-r")
                    {
                        Core.Converter<RetencionSiagerSchema, RetencionSircarSchema> convert = ConvertHelpers.Retenciones_SIAGER_SIRCAR(path, false);
                        foreach (string output in convert.Output) Console.WriteLine(output);
                        return;
                    }
                }
                throw new Exception("Comando no reconocido");
            }
            catch (Exception ex)
            {
                Console.WriteLine("--error");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
