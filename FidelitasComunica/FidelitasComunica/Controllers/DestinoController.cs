using Microsoft.AspNetCore.Mvc;
using FidelitasComunica.Models;
using Microsoft.EntityFrameworkCore;

namespace FidelitasComunica.Controllers
{
    public class DestinoController : Controller
    {
        private readonly FidelitasComunicaContext _context;
        public DestinoController(FidelitasComunicaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Destino.ToListAsync());
        }

        public async Task<IActionResult> IndexCliente()
        {
            return View(await _context.Destino.ToListAsync());
        }

        //Aqui inicia el crear
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Destino destino)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Destino.Add(destino);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(destino);
                }

            }
            catch
            {
                return View(destino);
            }
        }

        // Aqui inicia editar

        [HttpGet]
        public async Task<IActionResult> Editar(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }
            var destino = await _context.Destino.FindAsync(ID);
            if (destino == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }
            return View(destino);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(Destino destino)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Destino.Update(destino);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(destino);
                }

            }
            catch
            {
                return View(destino);
            }
        }




        // Inciar detalles

        public async Task<IActionResult> Detalles(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var destino = await _context.Destino.FindAsync(ID);

            if (destino == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            return View(destino);
        }

        public async Task<IActionResult> DetallesCliente(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var destino = await _context.Destino.FindAsync(ID);

            if (destino == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            return View(destino);
        }


        // Inicia eliminar

        [HttpGet]
        public async Task<IActionResult> Eliminar(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var destino = await _context.Destino.FindAsync(ID);

            if (destino == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            return View(destino);
        }

        [HttpPost, ActionName("Eliminar")]
        public async Task<IActionResult> ConfirmarEliminar(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var destino = await _context.Destino.FindAsync(ID);

            if (destino == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            try
            {
                _context.Destino.Remove(destino);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["TipoError"] = 3;
                return View(destino);
            }
        }
    }
}