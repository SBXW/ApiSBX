using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class ModuloPermiso
    {
        public int Codigo { get; set; }
        public int? Modulo { get; set; }
        public int? Permiso { get; set; }
    }
}
