using CoreApp.Schemas;
using System;

namespace CoreApp.Helpers
{
    public static class ConvertHelpers
    {
        private static float ParseIVA(float value)
        {
            return (float)Math.Round((decimal) (100f / value));
        }

        public static Core.Converter<PercepcionSiagerSchema, PercepcionSircarSchema> Percepciones_SIAGER_SIRCAR(string pathIn, bool calculateAlicuota)
        {
            int GetComprobanteTipoSircar(string tipo)
            {
                tipo = tipo.Replace(" ", "");
                return Config.ReadInt("C_" + tipo, -1);
            }

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
                    Alicuota = calculateAlicuota ? ParseIVA(schema.ImporteBase / schema.ImportePercibido) : schema.Alicuota,
                    MontoPercibido = schema.ImportePercibido,
                    TipoDeRegimen = Config.ReadInt("TipoRegimenPercepcion", -1),
                    Jurisdiccion = Config.ReadInt("JurisdiccionPercepcion", -1)
                };
            }

            return new Core.Converter<PercepcionSiagerSchema, PercepcionSircarSchema>(pathIn, PathHelpers.GetOutPath(pathIn, "-sircar"), FilledPercepcion);
        }

        public static Core.Converter<RetencionSiagerSchema, RetencionSircarSchema> Retenciones_SIAGER_SIRCAR(string pathIn, bool calculateAlicuota)
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
                    Alicuota = calculateAlicuota ? ParseIVA(schema.ImporteBase / schema.ImporteRetenido) : schema.Alicuota,
                    MontoRetenido = schema.ImporteRetenido,
                    TipoDeRegimen = Config.ReadInt("TipoRegimenRetencion", -1),
                    Jurisdiccion = Config.ReadInt("JurisdiccionRetencion", -1)
                };
            }

            return new Core.Converter<RetencionSiagerSchema, RetencionSircarSchema>(pathIn, PathHelpers.GetOutPath(pathIn, "-sircar"), FilledPercepcion);
        }
    }
}