namespace Portafolio_SAEG.Models
{
    public class InformacionModel
    {
        public int IdInformacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string GitHub { get; set; }
        public byte[] FotoDesarrollador { get; set; }
    }
}
