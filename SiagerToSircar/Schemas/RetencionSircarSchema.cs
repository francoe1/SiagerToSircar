using SiagerToSircar.Core;
using System;

namespace SiagerToSircar
{
    [WriteType(WriteType.CSV)]
    public class RetencionSircarSchema : Schema
    {
        [SchemaProperty(1, 5, LeftPad = true, PadChar = '0')]
        public int NumeroReglon { get; set; }

        [SchemaProperty(6, 6)]
        public int OrigenDelComprobante { get; set; }

        [SchemaProperty(7, 7, LeftPad = true, PadChar = '0')]
        public int TipoDeComprobante { get; set; }

        [SchemaProperty(8, 19, LeftPad = true, PadChar = '0')]
        public long NumeroDeComprobante { get; set; }

        [SchemaProperty(20, 30, LeftPad = true, PadChar = '0')]
        public long CuitDelContribuyente { get; set; }

        [SchemaProperty(31, 41)]
        public DateTime FechaDeRetencion { get; set; }

        [SchemaProperty(42, 53, LeftPad = true, PadChar = '0')]
        public decimal MontoSujectoARetencion { get; set; }

        [SchemaProperty(54, 59, LeftPad = true, PadChar = '0')]
        public decimal Alicuota { get; set; }

        [SchemaProperty(60, 71, LeftPad = true, PadChar = '0')]
        public decimal MontoRetenido { get; set; }

        [SchemaProperty(72, 74, LeftPad = true, PadChar = '0')]
        public int TipoDeRegimen { get; set; }

        [SchemaProperty(75, 77, LeftPad = true, PadChar = '0')]
        public int Jurisdiccion { get; set; }
    }
}
