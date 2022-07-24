using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class AbonoCredito
    {
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? ValorAbono { get; set; }
        public int? Credito { get; set; }
        public int? Usuario { get; set; }

        public virtual Credito CreditoNavigation { get; set; }
    }
}
