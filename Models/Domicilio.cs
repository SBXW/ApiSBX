using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Domicilio
    {
        public Domicilio()
        {
            Cotizacions = new HashSet<Cotizacion>();
            OrdenServicios = new HashSet<OrdenServicio>();
            Venta = new HashSet<Ventum>();
        }

        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Celular { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mensajero { get; set; }
        public decimal? ValorDomicilio { get; set; }
        public int? Cliente { get; set; }
        public string Estado { get; set; }
        public int? Sucursal { get; set; }

        public virtual Cliente ClienteNavigation { get; set; }
        public virtual Mensajero MensajeroNavigation { get; set; }
        public virtual ICollection<Cotizacion> Cotizacions { get; set; }
        public virtual ICollection<OrdenServicio> OrdenServicios { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
