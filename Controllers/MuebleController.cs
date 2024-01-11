using FactoryMethod_Grupo1.Data;
using FactoryMethod_Grupo1.FactoryMethod;
using FactoryMethod_Grupo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod_Grupo1.Controllers
{
    public class MuebleController : Controller
    {

        private readonly ApplicationDbContext _context;

        public MuebleController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public IActionResult Index()
        {
            var muebles = _context.Muebles.ToList();
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

            if (mueble is Mueble muebleConcreto)
            {
                _context.Muebles.Add(muebleConcreto);
                _context.SaveChanges();
                return RedirectToAction("Success");
            }
            else
            {
                // Manejar el caso en que mueble no es del tipo esperado
                return View("Error");
            }
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
