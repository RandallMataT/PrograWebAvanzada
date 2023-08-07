using FidelitasComunica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace FidelitasComunica.Controllers
{
    public class ReservacionDestinoController : Controller
    {
        private readonly FidelitasComunicaContext _context;
        public ReservacionDestinoController(FidelitasComunicaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create(int? ID)
        {
            Destino destino = _context.Destino.Where(x => x.ID == ID).FirstOrDefault();
            ViewBag.ID_DESTINO = new SelectList("ID_DESTINO", "Nombre Destino", destino.nombre);
            return View(destino);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReservacionDestino reservacion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.ReservacionDestino.Add(reservacion);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
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
