using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Kardex
    {
        public int Codigo { get; set; }
        public int? CodigoVenta { get; set; }
        public int? Item { get; set; }
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double? Iva { get; set; }
        public string UnidadMedida { get; set; }
        public double? Medida { get; set; }
        public int? Estado { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Dniproveedor { get; set; }
        public string Proveedor { get; set; }
        public string ModoVenta { get; set; }
        public string Ubicacion { get; set; }
        public string SalidaPara { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public double Cantidad { get; set; }
        public decimal? Costo { get; set; }
        public decimal? PrecioVenta { get; set; }
        public string CodigoBarras { get; set; }
        public double? SubCantidad { get; set; }
        public decimal? ValorSubcantidad { get; set; }
        public int? Sobres { get; set; }
        public decimal? ValorSobre { get; set; }
        public int? Usuario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Accion { get; set; }
        public string Movimiento { get; set; }
        public string Um { get; set; }
        public double? DescuentoProveedor { get; set; }
        public string Nota { get; set; }

        public virtual Producto ItemNavigation { get; set; }
    }
}
