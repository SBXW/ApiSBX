using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Cotizacions = new HashSet<Cotizacion>();
            Creditos = new HashSet<Credito>();
            Domicilios = new HashSet<Domicilio>();
            OrdenServicios = new HashSet<OrdenServicio>();
            SistemaSeparados = new HashSet<SistemaSeparado>();
            Sucursals = new HashSet<Sucursal>();
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
        public virtual ICollection<Credito> Creditos { get; set; }
        public virtual ICollection<Domicilio> Domicilios { get; set; }
        public virtual ICollection<OrdenServicio> OrdenServicios { get; set; }
        public virtual ICollection<SistemaSeparado> SistemaSeparados { get; set; }
        public virtual ICollection<Sucursal> Sucursals { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
