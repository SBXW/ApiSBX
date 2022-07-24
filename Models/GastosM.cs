using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class GastosM
    {
        public int Codigo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? Gasto { get; set; }
        public decimal? Valor { get; set; }
        public int? Proveedor { get; set; }
        public decimal? ValorIva { get; set; }
        public int? Usuario { get; set; }

        public virtual Gasto GastoNavigation { get; set; }
    }
}
