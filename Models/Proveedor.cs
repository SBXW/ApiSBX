using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Cotizacions = new HashSet<Cotizacion>();
            OrdenServicios = new HashSet<OrdenServicio>();
            Productos = new HashSet<Producto>();
            Venta = new HashSet<Ventum>();
        }

        public int Codigo { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string SitioWeb { get; set; }

        public virtual ICollection<Cotizacion> Cotizacions { get; set; }
        public virtual ICollection<OrdenServicio> OrdenServicios { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
