using CoreApp.Core;
using System;

namespace CoreApp.Schemas
{
    [WriteType(WriteType.CSV)]
    public class PercepcionSircarSchema : Schema
    {
        [SchemaProperty(1, 5, LeftPad = true, PadChar = '0')]
        public int NumeroReglon { get; set; }

        [SchemaProperty(6, 8, LeftPad = true, PadChar = '0')]
        public int TipoDeComprobante { get; set; }

        [SchemaProperty(9, 9)]
        public string LetraDelComprobante { get; set; }

        [SchemaProperty(10, 21, LeftPad = true, PadChar = '0')]
        public long NumeroDeComprobante { get; set; }

        [SchemaProperty(22, 32, LeftPad = true, PadChar = '0')]
        public long CuitDelContribuyente { get; set; }

        [SchemaProperty(33, 43)]
        public DateTime FechaDePercepcion { get; set; }

        [SchemaProperty(44, 56, true)]
        public float MontoSujetoAPercepcion { get; set; }

        [SchemaProperty(57, 62, true)]
        public float Alicuota { get; set; }

        [SchemaProperty(63, 75, true)]
        public float MontoPercibido { get; set; }

        [SchemaProperty(76, 78, LeftPad = true, PadChar = '0')]
        public int TipoDeRegimen { get; set; }

        [SchemaProperty(80, 82, LeftPad = true, PadChar = '0')]
        public int Jurisdiccion { get; set; }
    }
}
