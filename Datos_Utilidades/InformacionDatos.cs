using Portafolio_SAEG.Models;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic;

namespace Portafolio_SAEG.Datos_Utilidades
{
    public class InformacionDatos
    {
        private string _cadenaSql = "";
        public InformacionDatos(IConfiguration configuration)
        {
            _cadenaSql = configuration.GetConnectionString("cadenaSql");
        }
        public List<InformacionModel> Listar()
        {
            List<InformacionModel> lista = new List<InformacionModel>();
            using (var conexion = new SqlConnection(_cadenaSql))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ListarInfo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read()) 
                    {
                        lista.Add(new InformacionModel
                        {
                            IdInformacion = Convert.ToInt32(dr["IdInformacion"]),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            Edad = Convert.ToInt32(dr["Edad"]),
                            Telefono = dr["Telefono"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            GitHub = dr["GitHub"].ToString(),
                            FotoDesarrollador = dr["FotoDesarrollador"] as byte[]
                        });
                    }
                }
                return lista;
            }
        }
    }
}
