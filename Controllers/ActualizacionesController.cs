using Microsoft.AspNetCore.Mvc;

namespace Portafolio_SAEG.Controllers
{
    public class ActualizacionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*[HttpPost]
        public IActionResult Index()
        {
            return View();
        }*/
    }
}
