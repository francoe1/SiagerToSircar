using SiagerToSircar.Core;
using System;

namespace SiagerToSircar.Schemas
{
    public class RetencionSiagerSchema : Schema
    {
        [SchemaProperty(1, 1)]
        public int TipoDeAgente { get; set; }

        [SchemaProperty(2, 4)]
        public int MotivoMovimiento { get; set; }

        [SchemaProperty(5, 15)]
        public long CUITProveedor { get; set; }

        [SchemaProperty(16, 27)]
        public string NumeroDeConstancia { get; set; }

        [SchemaProperty(28, 37)]
        public DateTime FechaDeLaRetencion { get; set; }

        [SchemaProperty(38, 47)]
        public DateTime FechaDelComprobante { get; set; }

        [SchemaProperty(48, 53)]
        public string TipoDeComprobante { get; set; }

        [SchemaProperty(54, 54)]
        public string LetraDeComprobante { get; set; }

        [SchemaProperty(55, 66)]
        public long NumeroDeComprobante { get; set; }

        [SchemaProperty(67, 81, true)]
        public decimal ImporteBase { get; set; }

        [SchemaProperty(82, 87, true)]
        public decimal Alicuota { get; set; }

        [SchemaProperty(88, 102, true)]
        public decimal ImporteRetenido { get; set; }

        [SchemaProperty(103, 103)]
        public int Anulacion { get; set; }

        [SchemaProperty(104, 104)]
        public int ContribuyenteConvenioMultilateral { get; set; }
    }
}
