namespace Portafolio_SAEG.Models
{
    public class ProyectosModel
    {
        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string FechaDeCreacion { get; set; }
        public string FechaDeFinalizacion { get; set; }
        public int ProyectoIndividualEquipo { get; set; }
        public string EquipoDeTrabajo { get; set; }
        public InformacionModel? IdDesarrollador { get; set; }
        public TecnologiasFrontEndModel? IdFront2 { get; set; }
        public TecnologiasBackEndModel? IdBack2 { get; set; }
        public BasesDeDatosModel? IdDB2 { get; set; }

    }
}
