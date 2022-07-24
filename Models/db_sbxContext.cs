using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API_SBX.Models
{
    public partial class db_sbxContext : DbContext
    {
        public db_sbxContext()
        {
        }

        public db_sbxContext(DbContextOptions<db_sbxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbonoCredito> AbonoCreditos { get; set; }
        public virtual DbSet<AbonoSistemaSeparado> AbonoSistemaSeparados { get; set; }
        public virtual DbSet<BitKardex> BitKardices { get; set; }
        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<CierreCaja> CierreCajas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cotizacion> Cotizacions { get; set; }
        public virtual DbSet<Credito> Creditos { get; set; }
        public virtual DbSet<Domicilio> Domicilios { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<FechasVencimiento> FechasVencimientos { get; set; }
        public virtual DbSet<Gasto> Gastos { get; set; }
        public virtual DbSet<GastosM> GastosMs { get; set; }
        public virtual DbSet<Kardex> Kardices { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Mensajero> Mensajeros { get; set; }
        public virtual DbSet<Modulo> Modulos { get; set; }
        public virtual DbSet<ModuloPermiso> ModuloPermisos { get; set; }
        public virtual DbSet<OrdenServicio> OrdenServicios { get; set; }
        public virtual DbSet<Parametro> Parametros { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolModuloPermiso> RolModuloPermisos { get; set; }
        public virtual DbSet<SalidaPara> SalidaParas { get; set; }
        public virtual DbSet<SistemaSeparado> SistemaSeparados { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }
        public virtual DbSet<Ubicacion> Ubicacions { get; set; }
        public virtual DbSet<UnidadMedidum> UnidadMedida { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Ventum> Venta { get; set; }
        public virtual DbSet<spConsultaEstadoProducto> ConsultaEstadoProducto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source=DESKTOP-NP9LMO8\\SQLEXPRESS; Initial Catalog=db_sbx; user id=sa; password=admin2021; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AbonoCredito>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__AbonoCre__06370DAD2DC61947");

                entity.ToTable("AbonoCredito");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.ValorAbono).HasColumnType("money");

                entity.HasOne(d => d.CreditoNavigation)
                    .WithMany(p => p.AbonoCreditos)
                    .HasForeignKey(d => d.Credito)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__AbonoCred__Credi__60A75C0F");
            });

            modelBuilder.Entity<AbonoSistemaSeparado>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__AbonoSis__06370DAD3F80FD2C");

                entity.ToTable("AbonoSistemaSeparado");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.ValorAbono).HasColumnType("money");

                entity.HasOne(d => d.SistemaSeparadoNavigation)
                    .WithMany(p => p.AbonoSistemaSeparados)
                    .HasForeignKey(d => d.SistemaSeparado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__AbonoSist__Siste__619B8048");
            });

            modelBuilder.Entity<BitKardex>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Bit_Kard__06370DADF33796BE");

                entity.ToTable("Bit_Kardex");

                entity.Property(e => e.Accion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMovimiento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Item)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Caja>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Caja__06370DAD3E15D3CF");

                entity.ToTable("Caja");

                entity.Property(e => e.CodigoUltimaVenta).HasColumnName("Codigo_Ultima_venta");

                entity.Property(e => e.CodigoUltimoCierre).HasColumnName("Codigo_Ultimo_cierre");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.TipoOperacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Categori__06370DAD59A650C9");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CierreCaja>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cierre_Caja");

                entity.Property(e => e.BaseCaja).HasColumnType("money");

                entity.Property(e => e.CierreCaja1)
                    .HasColumnType("money")
                    .HasColumnName("CierreCaja");

                entity.Property(e => e.ConteoDinero).HasColumnType("money");

                entity.Property(e => e.Gastos).HasColumnType("money");

                entity.Property(e => e.Ingresos).HasColumnType("money");

                entity.Property(e => e.TotalDiferencia).HasColumnType("money");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Cliente__06370DADA12FF8BD");

                entity.ToTable("Cliente");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SitioWeb)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cotizacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Cotizaci__06370DADB1558045");

                entity.ToTable("Cotizacion");

                entity.Property(e => e.Cambio).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.Efectivo).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.ModoVenta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.NumBaucherCredito)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumBaucherDebito)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioVenta).HasColumnType("money");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tcredito).HasColumnType("money");

                entity.Property(e => e.Tdebito).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Um)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UM");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Cotizacions)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Cotizacio__Clien__628FA481");

                entity.HasOne(d => d.CreditoNavigation)
                    .WithMany(p => p.Cotizacions)
                    .HasForeignKey(d => d.Credito)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Cotizacio__Credi__6383C8BA");

                entity.HasOne(d => d.DomicilioNavigation)
                    .WithMany(p => p.Cotizacions)
                    .HasForeignKey(d => d.Domicilio)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Cotizacio__Domic__6477ECF3");

                entity.HasOne(d => d.ProductoNavigation)
                    .WithMany(p => p.Cotizacions)
                    .HasForeignKey(d => d.Producto)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Cotizacio__Produ__656C112C");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Cotizacions)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Cotizacio__Prove__66603565");

                entity.HasOne(d => d.SistemaSeparadoNavigation)
                    .WithMany(p => p.Cotizacions)
                    .HasForeignKey(d => d.SistemaSeparado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Cotizacio__Siste__6754599E");

                entity.HasOne(d => d.SucursalNavigation)
                    .WithMany(p => p.Cotizacions)
                    .HasForeignKey(d => d.Sucursal)
                    .HasConstraintName("FK__Cotizacio__Sucur__693CA210");
            });

            modelBuilder.Entity<Credito>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Credito__06370DADB5D9AE68");

                entity.ToTable("Credito");

                entity.Property(e => e.AbonoInicial).HasColumnType("money");

                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaPago).HasColumnType("datetime");

                entity.Property(e => e.FechaPrimerPago).HasColumnType("date");

                entity.Property(e => e.FechaVence).HasColumnType("date");

                entity.Property(e => e.PeriodoPago)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Suministrar)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorCuota).HasColumnType("money");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Creditos)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Credito__Cliente__6B24EA82");
            });

            modelBuilder.Entity<Domicilio>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Domicili__06370DAD97CD9371");

                entity.ToTable("Domicilio");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Mensajero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal).HasColumnName("sucursal");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorDomicilio).HasColumnType("money");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Domicilios)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Domicilio__Clien__6C190EBB");

                entity.HasOne(d => d.MensajeroNavigation)
                    .WithMany(p => p.Domicilios)
                    .HasForeignKey(d => d.Mensajero)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Domicilio__Mensa__6D0D32F4");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.Dni)
                    .HasName("PK__Empresa__C035B8DC8467A359");

                entity.ToTable("Empresa");

                entity.Property(e => e.Dni)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Detalle)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.Impresora)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Licencia)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("licencia");

                entity.Property(e => e.NomDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomDocCtz)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomDocOrds)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SitioWeb)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TamanoPapel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tamano_papel");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Estado__06370DAD581F9166");

                entity.ToTable("Estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FechasVencimiento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FechasVencimiento");

                entity.Property(e => e.FechaVecimiento).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Gastos__40F9A20766150C46");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GastosM>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__GastosM__40F9A207B6677A86");

                entity.ToTable("GastosM");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Proveedor).HasColumnName("proveedor");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorIva).HasColumnType("money");

                entity.HasOne(d => d.GastoNavigation)
                    .WithMany(p => p.GastosMs)
                    .HasForeignKey(d => d.Gasto)
                    .HasConstraintName("FK__GastosM__Gasto__6E01572D");
            });

            modelBuilder.Entity<Kardex>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Kardex__06370DAD0E890AC8");

                entity.ToTable("Kardex");

                entity.Property(e => e.Accion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Categoria)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dniproveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNIproveedor");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.Marca)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModoVenta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Movimiento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("movimiento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nota)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioVenta).HasColumnType("money");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalidaPara)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Salida_para");

                entity.Property(e => e.StockMaximo).HasColumnName("Stock_maximo");

                entity.Property(e => e.StockMinimo).HasColumnName("Stock_minimo");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Um)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UM");

                entity.Property(e => e.UnidadMedida)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ValorSobre).HasColumnType("money");

                entity.Property(e => e.ValorSubcantidad).HasColumnType("money");

                entity.HasOne(d => d.ItemNavigation)
                    .WithMany(p => p.Kardices)
                    .HasForeignKey(d => d.Item)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Kardex__Item__6FE99F9F");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Marca__06370DADBEDB1013");

                entity.ToTable("Marca");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mensajero>(entity =>
            {
                entity.HasKey(e => e.Dni)
                    .HasName("PK__Mensajer__C035B8DC16159316");

                entity.ToTable("Mensajero");

                entity.Property(e => e.Dni)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Modulo__40F9A207F803BF22");

                entity.ToTable("Modulo");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo");

                entity.Property(e => e.DescripcionModulo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModuloPermiso>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Modulo_p__06370DAD61318FB3");

                entity.ToTable("Modulo_permiso");
            });

            modelBuilder.Entity<OrdenServicio>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__ordenSer__06370DADC57C4696");

                entity.ToTable("ordenServicio");

                entity.Property(e => e.Cambio).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.Efectivo).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.ModoVenta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.NumBaucherCredito)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumBaucherDebito)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioVenta).HasColumnType("money");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tcredito).HasColumnType("money");

                entity.Property(e => e.Tdebito).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Um)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UM");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.OrdenServicios)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__ordenServ__Clien__70DDC3D8");

                entity.HasOne(d => d.CreditoNavigation)
                    .WithMany(p => p.OrdenServicios)
                    .HasForeignKey(d => d.Credito)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ordenServ__Credi__71D1E811");

                entity.HasOne(d => d.DomicilioNavigation)
                    .WithMany(p => p.OrdenServicios)
                    .HasForeignKey(d => d.Domicilio)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ordenServ__Domic__72C60C4A");

                entity.HasOne(d => d.ProductoNavigation)
                    .WithMany(p => p.OrdenServicios)
                    .HasForeignKey(d => d.Producto)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ordenServ__Produ__73BA3083");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.OrdenServicios)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__ordenServ__Prove__74AE54BC");

                entity.HasOne(d => d.SistemaSeparadoNavigation)
                    .WithMany(p => p.OrdenServicios)
                    .HasForeignKey(d => d.SistemaSeparado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ordenServ__Siste__75A278F5");

                entity.HasOne(d => d.SucursalNavigation)
                    .WithMany(p => p.OrdenServicios)
                    .HasForeignKey(d => d.Sucursal)
                    .HasConstraintName("FK__ordenServ__Sucur__76969D2E");
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BuscarAutomaticamente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Buscar_automaticamente");

                entity.Property(e => e.DatosPaginados)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Datos_paginados");

                entity.Property(e => e.RutaBackupDb)
                    .IsUnicode(false)
                    .HasColumnName("rutaBackupDB");
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Permiso__40F9A2070863BF8B");

                entity.ToTable("Permiso");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo");

                entity.Property(e => e.DescripcionPermiso)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Item)
                    .HasName("PK__Producto__9CBB9A4F82825192");

                entity.ToTable("Producto");

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.CostoCalculado).HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.ModoVenta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Movimiento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("movimiento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nota)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioVenta).HasColumnType("money");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalidaPara).HasColumnName("Salida_para");

                entity.Property(e => e.StockMaximo).HasColumnName("Stock_maximo");

                entity.Property(e => e.StockMinimo).HasColumnName("Stock_minimo");

                entity.Property(e => e.ValorSobre).HasColumnType("money");

                entity.Property(e => e.ValorSubcantidad).HasColumnType("money");

                entity.HasOne(d => d.CategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Categoria)
                    .HasConstraintName("FK__Producto__Catego__797309D9");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK__Producto__Estado__7A672E12");

                entity.HasOne(d => d.MarcaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Marca)
                    .HasConstraintName("FK__Producto__Marca__7B5B524B");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Producto__Provee__7C4F7684");

                entity.HasOne(d => d.SalidaParaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.SalidaPara)
                    .HasConstraintName("FK__Producto__Salida__7D439ABD");

                entity.HasOne(d => d.UbicacionNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Ubicacion)
                    .HasConstraintName("FK__Producto__Ubicac__7E37BEF6");

                entity.HasOne(d => d.UnidadMedidaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.UnidadMedida)
                    .HasConstraintName("FK__Producto__Unidad__7F2BE32F");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.Dni)
                    .HasName("PK__Proveedo__C035B8DC97728EC8");

                entity.ToTable("Proveedor");

                entity.Property(e => e.Dni)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SitioWeb)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Rol__06370DAD2DB652E8");

                entity.ToTable("Rol");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.DescripcionRol)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolModuloPermiso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rol_Modulo_Permiso");

                entity.Property(e => e.ModuloPermiso).HasColumnName("Modulo_permiso");

                entity.HasOne(d => d.ModuloPermisoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ModuloPermiso)
                    .HasConstraintName("FK__Rol_Modul__Modul__00200768");

                entity.HasOne(d => d.RolNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Rol)
                    .HasConstraintName("FK__Rol_Modulo___Rol__02084FDA");
            });

            modelBuilder.Entity<SalidaPara>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__SalidaPa__06370DAD708667FE");

                entity.ToTable("SalidaPara");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SistemaSeparado>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__SistemaS__06370DAD70E2D25D");

                entity.ToTable("SistemaSeparado");

                entity.Property(e => e.AbonoInicial).HasColumnType("money");

                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaPago).HasColumnType("datetime");

                entity.Property(e => e.FechaPrimerPago).HasColumnType("date");

                entity.Property(e => e.FechaVence).HasColumnType("date");

                entity.Property(e => e.PeriodoPago)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Suministrar)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.Property(e => e.ValorCuota).HasColumnType("money");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.SistemaSeparados)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__SistemaSe__Clien__03F0984C");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Sucursal__06370DAD2A949562");

                entity.ToTable("Sucursal");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SitioWeb)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Sucursals)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK__Sucursal__Client__04E4BC85");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Ubicacio__06370DAD492C650C");

                entity.ToTable("Ubicacion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnidadMedidum>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__UnidadMe__06370DADF045EF68");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Usuario__06370DAD78AFFBBB");

                entity.ToTable("Usuario");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena).IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.RolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Rol)
                    .HasConstraintName("FK__Usuario__Rol__06CD04F7");
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Venta__06370DAD8B5F671F");

                entity.Property(e => e.Cambio).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Cotizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cotizacion");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.Efectivo).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.ModoVenta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nota).IsUnicode(false);

                entity.Property(e => e.NumBaucherCredito)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumBaucherDebito)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioVenta).HasColumnType("money");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tcredito).HasColumnType("money");

                entity.Property(e => e.Tdebito).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Um)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UM");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Venta__Cliente__08B54D69");

                entity.HasOne(d => d.CreditoNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Credito)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Venta__Credito__09A971A2");

                entity.HasOne(d => d.DomicilioNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Domicilio)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Venta__Domicilio__0A9D95DB");

                entity.HasOne(d => d.ProductoNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Producto)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Venta__Producto__0B91BA14");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Venta__Proveedor__0C85DE4D");

                entity.HasOne(d => d.SistemaSeparadoNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.SistemaSeparado)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Venta__SistemaSe__0D7A0286");

                entity.HasOne(d => d.SucursalNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Sucursal)
                    .HasConstraintName("FK__Venta__Sucursal__0E6E26BF");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
