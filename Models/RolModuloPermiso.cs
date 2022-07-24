using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class RolModuloPermiso
    {
        public int? Rol { get; set; }
        public int? ModuloPermiso { get; set; }

        public virtual ModuloPermiso ModuloPermisoNavigation { get; set; }
        public virtual Rol RolNavigation { get; set; }
    }
}
