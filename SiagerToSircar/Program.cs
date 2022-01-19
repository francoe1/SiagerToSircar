using SiagerToSircar.Schemas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SiagerToSircar
{
    internal static class Program
    {
        private static Dictionary<string, string> TiposComprobantes { get; } = new Dictionary<string, string>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadTiposComprobantes();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static Core.Converter<PercepcionSiagerSchema, PercepcionSircarSchema> ConvertPercepciones(string pathIn)
        {
            PercepcionSircarSchema FilledPercepcion(int num, PercepcionSiagerSchema schema)
            {
                return new PercepcionSircarSchema
                {
                    NumeroReglon = num,
                    TipoDeComprobante = GetComprobanteTipoSircar(schema.TipoDeComprobante),
                    LetraDelComprobante = schema.LetraDeComprobante,
                    NumeroDeComprobante = schema.NumeroDeComprobante,
                    CuitDelContribuyente = schema.CuitDelProveedor,
                    FechaDePercepcion = schema.FechaPercepcion,
                    MontoSujetoAPercepcion = schema.ImporteBase,
                    Alicuota = schema.Alicuota,
                    MontoPercibido = schema.ImportePercibido,
                    TipoDeRegimen = 011,
                    Jurisdiccion = 914
                };
            }

            return new Core.Converter<PercepcionSiagerSchema, PercepcionSircarSchema>(pathIn, GetOutPath(pathIn), FilledPercepcion);
        }

        public static Core.Converter<RetencionSiagerSchema, RetencionSircarSchema> ConvertRetenciones(string pathIn)
        {
            RetencionSircarSchema FilledPercepcion(int num, RetencionSiagerSchema schema)
            {
                return new RetencionSircarSchema
                {
                    NumeroReglon = num,
                    OrigenDelComprobante = 1,
                    TipoDeComprobante = 1,
                    NumeroDeComprobante = schema.NumeroDeComprobante,
                    CuitDelContribuyente = schema.CUITProveedor,
                    FechaDeRetencion = schema.FechaDeLaRetencion,
                    MontoSujectoARetencion = schema.ImporteBase,
                    Alicuota = schema.Alicuota,
                    MontoRetenido = schema.ImporteRetenido,
                    TipoDeRegimen = 011,
                    Jurisdiccion = 914
                };
            }

            return new Core.Converter<RetencionSiagerSchema, RetencionSircarSchema>(pathIn, GetOutPath(pathIn), FilledPercepcion);
        }

        private static string GetOutPath(string pathIn)
        {
            return Path.Combine(Path.GetDirectoryName(pathIn), Path.GetFileNameWithoutExtension(pathIn) + "-out.txt"); 
        }

        private static void LoadTiposComprobantes()
        {
            TiposComprobantes.Clear();
            string tiposComprobantesFile = AppDomain.CurrentDomain.BaseDirectory + "tipos_comprobantes.ini";
            if (!File.Exists(tiposComprobantesFile)) return;
            foreach (string line in File.ReadAllLines(tiposComprobantesFile))
            {
                string[] pair = line.Split('=');
                if (pair.Length != 2) continue;
                if (!TiposComprobantes.ContainsKey(pair[0]))
                    TiposComprobantes.Add(pair[0], pair[1]);
            }
        }

        private static int GetComprobanteTipoSircar(string tipo)
        {
            tipo = tipo.Replace(" ", "");
            if (TiposComprobantes.ContainsKey(tipo) && int.TryParse(TiposComprobantes[tipo], out int id)) return id;
            MessageBox.Show($"No se encontro tipo de comprobante para '{tipo}', ver tipos_comprobantes.ini");
            return -1;
        }
    }
}
