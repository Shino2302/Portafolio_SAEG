namespace Portafolio_SAEG.Models
{
    public class TecnologiasModel
    {
        public int IdTecnologia { get; set; }
        public string NombreTecnologia { get; set; }
        public string Experiencia { get; set; }
        public DesarrolladorModel Desarrollador { get; set;}
    }
}
