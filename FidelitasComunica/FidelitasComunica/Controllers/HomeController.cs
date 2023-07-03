using FidelitasComunica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace FidelitasComunica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly FidelitasComunicaContext _context;
        public HomeController(FidelitasComunicaContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



        public async Task<IActionResult> prueba()
        {
            return View(await _context.Usuario.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Index_admin(Usuario model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string usuario_string = model.usuario.ToString();
                    var nom_usuario = await _context.Usuario.FirstOrDefaultAsync(x => x.usuario.Equals(usuario_string));
                    if (nom_usuario != null)
                    {
                        if (nom_usuario.contrasena.Equals(model.contrasena))
                        {
                            ViewData["TipoError"] = null;
                            return View();
                        }
                        else
                        {
                            ViewData["TipoError"] = 2;
                            return RedirectToAction(nameof(Index));
                        }
                    } else
                    {
                        ViewData["TipoError"] = 1;
                        return RedirectToAction(nameof(Index));

                    }
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}