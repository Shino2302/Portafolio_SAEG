using Portafolio_SAEG.Models;
using System.Data.SqlClient;
using System.Data;

namespace Portafolio_SAEG.Datos_Utilidades
{
    public class ProyectosDatos
    {
        private string _cadenaSql = "";
        public ProyectosDatos(IConfiguration configuration)
        {
            _cadenaSql = configuration.GetConnectionString("cadenaSql");
        }
        public List<ProyectosModel> Listar()
        {
            List<ProyectosModel> lista = new List<ProyectosModel>();
            using (var conexion = new SqlConnection(_cadenaSql))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ListarProyectos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ProyectosModel
                        {
                            IdProyecto = Convert.ToInt32(dr["IdProyecto"]),
                            NombreProyecto = dr["NombreProyecto"].ToString(),
                            FechaDeCreacion = dr["FechaDeCreacion"].ToString(),
                            FechaDeFinalizacion = dr["FechaDeFinalizacion"].ToString(),
                            ProyectoIndividualEquipo = Convert.ToInt32(dr["ProyectoIndividualEquipo"]),
                            EquipoDeTrabajo = dr["EquipoDeTrabajo"].ToString(),
                            IdDesarrollador = new InformacionModel
                            {
                                IdInformacion = Convert.ToInt32(dr["IdInformacion"]),
                                Nombres = dr["Nombres"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Edad = Convert.ToInt32(dr["Edad"]),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                GitHub = dr["GitHub"].ToString(),
                                FotoDesarrollador = dr["FotoDesarrollador"] as byte[]
                            },
                            IdFront2 = new TecnologiasFrontEndModel
                            {
                                IdFront = Convert.ToInt32(dr["IdFront"]),
                                Tecnologia = dr["Tecnologia"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Experiencia = dr["Experiencia"].ToString(),
                                Imagen = dr["Imagen"] as byte[]
                            },
                            IdBack2 = new TecnologiasBackEndModel
                            {
                                IdBack = Convert.ToInt32(dr["IdFront"]),
                                Tecnologia = dr["Tecnologia"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Experiencia = dr["Experiencia"].ToString(),
                                Imagen = dr["Imagen"] as byte[]
                            },
                            IdDB2 = new BasesDeDatosModel
                            {
                                IdDB = Convert.ToInt32(dr["IdFront"]),
                                Tecnologia = dr["Tecnologia"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                TipoDeDB = dr["TipoDeDB"].ToString(),
                                Experiencia = dr["Experiencia"].ToString(),
                                Imagen = dr["Imagen"] as byte[]
                            }

                        });
                    }
                }
                return lista;
            }
        }
    }
}
