using FidelitasComunica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FidelitasComunica.Controllers
{
    public class ReservacionPaqueteController : Controller
    {
        private readonly FidelitasComunicaContext _context;
        public ReservacionPaqueteController(FidelitasComunicaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReservacionPaquete.ToListAsync());
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

        [HttpGet]
        public async Task<IActionResult> Eliminar(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var reservacion = await _context.ReservacionPaquete.FindAsync(ID);

            if (reservacion == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            return View(reservacion);
        }

        [HttpPost, ActionName("Eliminar")]
        public async Task<IActionResult> ConfirmarEliminar(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var reservacion = await _context.ReservacionPaquete.FindAsync(ID);

            if (reservacion == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            try
            {
                _context.ReservacionPaquete.Remove(reservacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["TipoError"] = 3;
                return View();
            }
        }
    }
}
