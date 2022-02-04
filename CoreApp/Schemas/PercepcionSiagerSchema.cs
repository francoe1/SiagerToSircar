using CoreApp.Core;
using System;

namespace CoreApp.Schemas
{
    public class PercepcionSiagerSchema : Schema
    {
        [SchemaProperty(1, 1)]
        public int TipoDeAgente { get; set; }

        [SchemaProperty(2, 4)]
        public int MotivoMovimeinto { get; set; }

        [SchemaProperty(5, 15)]
        public long CuitDelProveedor { get; set; }

        [SchemaProperty(16, 25)]
        public DateTime FechaPercepcion { get; set; }

        [SchemaProperty(26, 31)]
        public string TipoDeComprobante { get; set; }

        [SchemaProperty(32, 32)]
        public string LetraDeComprobante { get; set; }

        [SchemaProperty(33, 44)]
        public long NumeroDeComprobante { get; set; }

        [SchemaProperty(45, 59, true)]
        public float ImporteBase { get; set; }

        [SchemaProperty(60, 65, true)]
        public float Alicuota { get; set; }

        [SchemaProperty(66, 80, true)]
        public float ImportePercibido { get; set; }

        [SchemaProperty(81, 81)]
        public int Anulacion { get; set; }

        [SchemaProperty(82, 82)]
        public int Multilateral { get; set; }
    }
}
