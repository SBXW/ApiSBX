using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class BitKardex
    {
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Accion { get; set; }
        public string CodigoMovimiento { get; set; }
        public string Item { get; set; }
        public string Referencia { get; set; }
        public string CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
