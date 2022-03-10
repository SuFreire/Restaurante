using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class RegistoController : Controller
    {
        private readonly RestauranteContext _context;

        public RegistoController(RestauranteContext context)
        {
            _context = context;
        }

        // GET: Registo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registo.ToListAsync());
        }

        // GET: Registo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registo = await _context.Registo
                .FirstOrDefaultAsync(m => m.RegistoID == id);
            if (registo == null)
            {
                return NotFound();
            }

            return View(registo);
        }

        // GET: Registo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegistoID,Nome,Email,Telefone")] Registo registo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registo);
        }

        // GET: Registo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registo = await _context.Registo.FindAsync(id);
            if (registo == null)
            {
                return NotFound();
            }
            return View(registo);
        }

        // POST: Registo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegistoID,Nome,Email,Telefone")] Registo registo)
        {
            if (id != registo.RegistoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistoExists(registo.RegistoID))
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
            return View(registo);
        }

        // GET: Registo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registo = await _context.Registo
                .FirstOrDefaultAsync(m => m.RegistoID == id);
            if (registo == null)
            {
                return NotFound();
            }

            return View(registo);
        }

        // POST: Registo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registo = await _context.Registo.FindAsync(id);
            _context.Registo.Remove(registo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistoExists(int id)
        {
            return _context.Registo.Any(e => e.RegistoID == id);
        }
    }
}
