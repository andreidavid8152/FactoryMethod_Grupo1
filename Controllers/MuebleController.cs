using FactoryMethod_Grupo1.FactoryMethod;
using FactoryMethod_Grupo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod_Grupo1.Controllers
{
    public class MuebleController : Controller
    {

        public IActionResult Index()
        {
            var muebles = new List<Mueble>();
            return View(muebles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string tipoMueble, string material, string color)
        {
            MuebleFactory factory;

            switch (tipoMueble)
            {
                case "Silla":
                    factory = new SillaFactory();
                    break;
                case "Mesa":
                    factory = new MesaFactory();
                    break;
                default:
                    throw new ArgumentException("Tipo de mueble no válido");
            }

            IMueble mueble = factory.GetMueble(material, color);

            // Aquí puedes procesar el objeto mueble, como guardarlo en la base de datos

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
