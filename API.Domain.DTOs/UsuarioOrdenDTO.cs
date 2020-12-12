namespace API.Domain.DTOs
{
    public class UsuarioOrdenDTO
    {
        public string IdUsuario { get; set; }
        public int IdOrden { get; set; }

        public OrdenDTO IdOrdenNavigation { get; set; }
        public UsuarioDTO IdUsuarioNavigation { get; set; }
    }
}
