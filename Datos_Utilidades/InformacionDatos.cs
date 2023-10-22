using Portafolio_SAEG.Models;
using System.Data.SqlClient;
using System.Data;

namespace Portafolio_SAEG.Datos_Utilidades
{
    public class InformacionDatos
    {
        private string _cadenaSql = "";
        public InformacionDatos(IConfiguration configuration)
        {
            _cadenaSql = configuration.GetConnectionString("cadenaSql");
        }/*
        public List<DesarrolladorModel> Listar()
        {
            List<DesarrolladorDatos> lista = new List<DesarrolladorDatos>();
            using (var conexion = new SqlConnection(_cadenaSql))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_")
            }
        }*/
    }
}
