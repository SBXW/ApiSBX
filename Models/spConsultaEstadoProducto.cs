using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SBX.Models
{
    [Keyless]
    public class spConsultaEstadoProducto
    {
        public string Item { get; set; }
        public string Nombre { get; set; }
        public string Referencia { get; set; }
        public string CodigoBarras { get; set; }
        public string ModoV { get; set; }
        public double Stock { get; set; }
        public decimal Precio { get; set; }
        public double StockSub { get; set; }
        public decimal VlrSub { get; set; }
        public double Stockund { get; set; }
        public decimal Vlrund { get; set; }
    }
}
