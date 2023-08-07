using FidelitasComunica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReservacionDestino.ToListAsync());
        }


        [HttpGet]
        public IActionResult Create()
        {
            var destinos = _context.Destino.ToList();
            ViewBag.Destinos = new SelectList(destinos, "nombre", "nombre");
            return View();
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

        [HttpGet]
        public async Task<IActionResult> Eliminar(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var reservacion = await _context.ReservacionDestino.FindAsync(ID);

            if (reservacion == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            return View(reservacion);
        }

        [HttpPost, ActionName("Eliminar")]
        public async Task<IActionResult> ConfrimarEliminar(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var reservacion = await _context.ReservacionDestino.FindAsync(ID);

            if (reservacion == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            try
            {
                _context.ReservacionDestino.Remove(reservacion);
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
