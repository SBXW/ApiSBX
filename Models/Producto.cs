using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Cotizacions = new HashSet<Cotizacion>();
            Kardices = new HashSet<Kardex>();
            OrdenServicios = new HashSet<OrdenServicio>();
            Venta = new HashSet<Ventum>();
        }

        public int Item { get; set; }
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Iva { get; set; }
        public int UnidadMedida { get; set; }
        public double Medida { get; set; }
        public int Estado { get; set; }
        public int Categoria { get; set; }
        public int Marca { get; set; }
        public string Proveedor { get; set; }
        public string ModoVenta { get; set; }
        public int Ubicacion { get; set; }
        public int SalidaPara { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public double? Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public string CodigoBarras { get; set; }
        public double SubCantidad { get; set; }
        public decimal ValorSubcantidad { get; set; }
        public int Sobres { get; set; }
        public decimal ValorSobre { get; set; }
        public byte[] Foto { get; set; }
        public int? Usuario { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Movimiento { get; set; }
        public double? DescuentoProveedor { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public decimal? CostoCalculado { get; set; }
        public string Nota { get; set; }

        public virtual Categorium CategoriaNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual Marca MarcaNavigation { get; set; }
        public virtual Proveedor ProveedorNavigation { get; set; }
        public virtual SalidaPara SalidaParaNavigation { get; set; }
        public virtual Ubicacion UbicacionNavigation { get; set; }
        public virtual UnidadMedidum UnidadMedidaNavigation { get; set; }
        public virtual ICollection<Cotizacion> Cotizacions { get; set; }
        public virtual ICollection<Kardex> Kardices { get; set; }
        public virtual ICollection<OrdenServicio> OrdenServicios { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
