using System.Collections.Generic;

namespace API.Domain.DTOs
{
    public class PerfilDTO
    {
        public int IdPerfil { get; set; }
        public string Perfil { get; set; }

        public IList<UsuarioDTO> Tbusuario { get; set; }
    }
}
