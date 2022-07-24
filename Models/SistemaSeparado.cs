using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class SistemaSeparado
    {
        public SistemaSeparado()
        {
            AbonoSistemaSeparados = new HashSet<AbonoSistemaSeparado>();
            Cotizacions = new HashSet<Cotizacion>();
            OrdenServicios = new HashSet<OrdenServicio>();
            Venta = new HashSet<Ventum>();
        }

        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Valor { get; set; }
        public decimal? AbonoInicial { get; set; }
        public string PeriodoPago { get; set; }
        public string Suministrar { get; set; }
        public int? NumCuotas { get; set; }
        public decimal? ValorCuota { get; set; }
        public DateTime? FechaPrimerPago { get; set; }
        public DateTime? FechaVence { get; set; }
        public int? Cliente { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaPago { get; set; }

        public virtual Cliente ClienteNavigation { get; set; }
        public virtual ICollection<AbonoSistemaSeparado> AbonoSistemaSeparados { get; set; }
        public virtual ICollection<Cotizacion> Cotizacions { get; set; }
        public virtual ICollection<OrdenServicio> OrdenServicios { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
