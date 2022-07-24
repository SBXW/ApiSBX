using System;
using System.Collections.Generic;

#nullable disable

namespace API_SBX.Models
{
    public partial class Empresa
    {
        public int Codigo { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string SitioWeb { get; set; }
        public string Licencia { get; set; }
        public string Impresora { get; set; }
        public byte[] Foto { get; set; }
        public double? ConsecutivoInicial { get; set; }
        public double? ConsecutivoFinal { get; set; }
        public string Detalle { get; set; }
        public int? Alerta { get; set; }
        public string NomDoc { get; set; }
        public string TamanoPapel { get; set; }
        public string NomDocCtz { get; set; }
        public string NomDocOrds { get; set; }
    }
}
