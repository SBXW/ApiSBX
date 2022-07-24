using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class CierreCaja
    {
        public int? Codigo { get; set; }
        public decimal? BaseCaja { get; set; }
        public decimal? Ingresos { get; set; }
        public decimal? Gastos { get; set; }
        public decimal? CierreCaja1 { get; set; }
        public decimal? ConteoDinero { get; set; }
        public decimal? TotalDiferencia { get; set; }
    }
}
