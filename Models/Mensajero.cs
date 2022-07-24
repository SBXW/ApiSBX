using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Mensajero
    {
        public Mensajero()
        {
            Domicilios = new HashSet<Domicilio>();
        }

        public int Codigo { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Domicilio> Domicilios { get; set; }
    }
}
