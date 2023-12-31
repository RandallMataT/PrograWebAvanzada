﻿using Microsoft.AspNetCore.Mvc;
using FidelitasComunica.Models;
using Microsoft.EntityFrameworkCore;

namespace FidelitasComunica.Controllers

{
    public class PaqueteController : Controller
    {
        private readonly FidelitasComunicaContext _context;
        public PaqueteController(FidelitasComunicaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Paquete.ToListAsync());
        }

        public async Task<IActionResult> IndexCliente()
        {
            return View(await _context.Paquete.ToListAsync());
        }

        //Aqui inicia el crear
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Paquete paquete)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Paquete.Add(paquete);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(paquete);
                }

            }
            catch
            {
                return View(paquete);
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
            var paquete = await _context.Paquete.FindAsync(ID);
            if (paquete == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }
            return View(paquete);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(Paquete paquete)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Paquete.Update(paquete);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(paquete);
                }

            }
            catch
            {
                return View(paquete);
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

            var paquete = await _context.Paquete.FindAsync(ID);

            if (paquete == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            return View(paquete);
        }

        public async Task<IActionResult> DetallesCliente(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var paquete = await _context.Paquete.FindAsync(ID);

            if (paquete == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            return View(paquete);
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

            var paquete = await _context.Paquete.FindAsync(ID);

            if (paquete == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            return View(paquete);
        }

        [HttpPost, ActionName("Eliminar")]
        public async Task<IActionResult> ConfirmarEliminar(int? ID)
        {
            if (ID == null)
            {
                ViewData["TipoError"] = 1;
                return View();
            }

            var paquete = await _context.Paquete.FindAsync(ID);

            if (paquete == null)
            {
                ViewData["TipoError"] = 2;
                return View();
            }

            try
            {
                _context.Paquete.Remove(paquete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["TipoError"] = 3;
                return View(paquete);
            }
        }














    }
}
