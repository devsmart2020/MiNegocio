namespace API.Domain.DTOs
{
    public class ClienteDto
    {
        public string DocId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string TelAlternativo { get; set; }
        public string Email { get; set; }
    }
}
