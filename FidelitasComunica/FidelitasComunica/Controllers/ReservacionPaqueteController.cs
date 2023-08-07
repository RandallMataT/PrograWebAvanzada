using FidelitasComunica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FidelitasComunica.Controllers
{
    public class ReservacionPaqueteController : Controller
    {
        private readonly FidelitasComunicaContext _context;
        public ReservacionPaqueteController(FidelitasComunicaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var paquetes = _context.Paquete.ToList();
            ViewBag.Paquetes = new SelectList(paquetes, "nombre", "nombre");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReservacionPaquete reservacion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.ReservacionPaquete.Add(reservacion);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index","Home");
                }
                else
                {
                    return View(reservacion);
                }

            }
            catch
            {
                return View(reservacion);
            }
        }

    }
}
