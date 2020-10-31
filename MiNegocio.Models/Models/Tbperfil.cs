using System.Collections.Generic;

namespace MiNegocio.Models.Models
{
    public partial class Tbperfil
    {
        public Tbperfil()
        {
            Tbusuario = new HashSet<Tbusuario>();
        }

        public int IdPerfil { get; set; }
        public string Perfil { get; set; }

        public virtual ICollection<Tbusuario> Tbusuario { get; set; }
    }
}
