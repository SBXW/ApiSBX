using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Gasto
    {
        public Gasto()
        {
            GastosMs = new HashSet<GastosM>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<GastosM> GastosMs { get; set; }
    }
}
