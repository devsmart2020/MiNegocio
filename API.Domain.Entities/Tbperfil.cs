using System.Collections.Generic;

namespace API.Domain.Entities
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
