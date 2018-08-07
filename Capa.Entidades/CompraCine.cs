using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class CompraCine
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public Ticket Ticket { get; set; }
        public int CantNiños { get; set; }
        public int CantRegula { get; set; }
        public double Descuento { get; set; }
        public double CargoServicio { get; set; }
        public double Total { get; set; }
    }
}
