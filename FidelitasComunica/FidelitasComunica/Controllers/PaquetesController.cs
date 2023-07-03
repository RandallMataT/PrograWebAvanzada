using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FidelitasComunica.Models;

namespace FidelitasComunica.Controllers
{
    public class PaquetesController : Controller
    {
        private readonly FidelitasComunicaContext _context;

        public PaquetesController(FidelitasComunicaContext context)
        {
            _context = context;
        }

        // GET: Paquetes
        public async Task<IActionResult> Index()
        {
              return _context.Paquetes != null ? 
                          View(await _context.Paquetes.ToListAsync()) :
                          Problem("Entity set 'FidelitasComunicaContext.Paquetes'  is null.");
        }

        // GET: Paquetes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Paquetes == null)
            {
                return NotFound();
            }

            var paquetes = await _context.Paquetes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (paquetes == null)
            {
                return NotFound();
            }

            return View(paquetes);
        }

        // GET: Paquetes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Paquetes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,nombre,destino,duracion_dias,precio,fecha_inicio,fecha_fin,descripcion,cantidad_personas")] Paquete paquetes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paquetes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paquetes);
        }

        // GET: Paquetes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Paquetes == null)
            {
                return NotFound();
            }

            var paquetes = await _context.Paquetes.FindAsync(id);
            if (paquetes == null)
            {
                return NotFound();
            }
            return View(paquetes);
        }

        // POST: Paquetes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,nombre,destino,duracion_dias,precio,fecha_inicio,fecha_fin,descripcion,cantidad_personas")] Paquete paquetes)
        {
            if (id != paquetes.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paquetes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaquetesExists(paquetes.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(paquetes);
        }

        // GET: Paquetes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Paquetes == null)
            {
                return NotFound();
            }

            var paquetes = await _context.Paquetes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (paquetes == null)
            {
                return NotFound();
            }

            return View(paquetes);
        }

        // POST: Paquetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Paquetes == null)
            {
                return Problem("Entity set 'FidelitasComunicaContext.Paquetes'  is null.");
            }
            var paquetes = await _context.Paquetes.FindAsync(id);
            if (paquetes != null)
            {
                _context.Paquetes.Remove(paquetes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaquetesExists(int id)
        {
          return (_context.Paquetes?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
