using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class OrdenServicio
    {
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string NombreDocumento { get; set; }
        public double? ConsecutivoDocumento { get; set; }
        public int? Producto { get; set; }
        public string ModoVenta { get; set; }
        public string Um { get; set; }
        public double? Cantidad { get; set; }
        public decimal? Costo { get; set; }
        public decimal? PrecioVenta { get; set; }
        public double? Descuento { get; set; }
        public decimal? Efectivo { get; set; }
        public decimal? Tdebito { get; set; }
        public string NumBaucherDebito { get; set; }
        public decimal? Tcredito { get; set; }
        public string NumBaucherCredito { get; set; }
        public decimal? Cambio { get; set; }
        public decimal? Total { get; set; }
        public string Proveedor { get; set; }
        public int? Cliente { get; set; }
        public int? Domicilio { get; set; }
        public int? SistemaSeparado { get; set; }
        public double? Iva { get; set; }
        public int? Usuario { get; set; }
        public double? DescuentoProveedor { get; set; }
        public string Nota { get; set; }
        public int? Sucursal { get; set; }
        public int? Credito { get; set; }

        public virtual Cliente ClienteNavigation { get; set; }
        public virtual Credito CreditoNavigation { get; set; }
        public virtual Domicilio DomicilioNavigation { get; set; }
        public virtual Producto ProductoNavigation { get; set; }
        public virtual Proveedor ProveedorNavigation { get; set; }
        public virtual SistemaSeparado SistemaSeparadoNavigation { get; set; }
        public virtual Sucursal SucursalNavigation { get; set; }
    }
}
