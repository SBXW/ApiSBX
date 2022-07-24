using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string DescripcionRol { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
