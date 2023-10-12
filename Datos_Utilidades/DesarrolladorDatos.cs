using Portafolio_SAEG.Models;

namespace Portafolio_SAEG.Datos_Utilidades
{
    public class DesarrolladorDatos
    {
        private string _cadenaSql = "";
        public DesarrolladorDatos(IConfiguration configuration)
        {
            _cadenaSql = configuration.GetConnectionString("cadenaSql");
        }
        /*public List<DesarrolladorModel> Listar()
        {
            List<DesarrolladorDatos> lista = new List<DesarrolladorDatos>();
            using (var conexion = new SqlConnection(_cadenaSql))
            {

            }
        }*/
    }
}
