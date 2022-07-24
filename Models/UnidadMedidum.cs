using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class UnidadMedidum
    {
        public UnidadMedidum()
        {
            Productos = new HashSet<Producto>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
