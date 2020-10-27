using System;
using System.Security;

namespace MiNegocio.Models.Models
{
    public class TbUsuario
    {
        public string DocId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public int IdPerfil { get; set; }
        public sbyte Estado { get; set; }
        public string CodigoRecuperacion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
