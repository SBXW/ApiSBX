using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Caja
    {
        public int Codigo { get; set; }
        public decimal? Valor { get; set; }
        public string TipoOperacion { get; set; }
        public int? Usuario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? CodigoUltimoCierre { get; set; }
        public int? CodigoUltimaVenta { get; set; }
        public int? CodigoCaja { get; set; }
    }
}
