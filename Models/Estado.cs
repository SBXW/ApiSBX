using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Productos = new HashSet<Producto>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
