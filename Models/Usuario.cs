using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Usuario
    {
        public int Codigo { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public int? Rol { get; set; }

        public virtual Rol RolNavigation { get; set; }
    }
}
