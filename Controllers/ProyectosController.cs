using Microsoft.AspNetCore.Mvc;
using Portafolio_SAEG.Datos_Utilidades;


namespace Portafolio_SAEG.Controllers
{
    public class ProyectosController : Controller
    {
        private IConfiguration _configuration;
        public ProyectosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ProyectosDatos lista = new ProyectosDatos(_configuration);
            return View(lista.Listar());
        }
    }
}
