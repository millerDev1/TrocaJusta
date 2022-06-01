using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrocaJusta.Models;

namespace TrocaJusta.Controllers
{
    public class AuxiliarEnderecoController : Controller
    {
        private readonly TrocaJustaContext _context;

        public AuxiliarEnderecoController(TrocaJustaContext context)
        {
            _context = context;
        }

        // GET: AuxiliarEndereco
        public async Task<IActionResult> Index()
        {
            return View(await _context.AuxiliarEndereco.ToListAsync());
        }

        // GET: AuxiliarEndereco/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auxiliarEndereco = await _context.AuxiliarEndereco
                .FirstOrDefaultAsync(m => m.id == id);
            if (auxiliarEndereco == null)
            {
                return NotFound();
            }

            return View(auxiliarEndereco);
        }

        // GET: AuxiliarEndereco/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AuxiliarEndereco/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,UsuarioId,EnderecoId")] AuxiliarEndereco auxiliarEndereco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(auxiliarEndereco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(auxiliarEndereco);
        }

        // GET: AuxiliarEndereco/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auxiliarEndereco = await _context.AuxiliarEndereco.FindAsync(id);
            if (auxiliarEndereco == null)
            {
                return NotFound();
            }
            return View(auxiliarEndereco);
        }

        // POST: AuxiliarEndereco/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,UsuarioId,EnderecoId")] AuxiliarEndereco auxiliarEndereco)
        {
            if (id != auxiliarEndereco.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auxiliarEndereco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuxiliarEnderecoExists(auxiliarEndereco.id))
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
            return View(auxiliarEndereco);
        }

        // GET: AuxiliarEndereco/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auxiliarEndereco = await _context.AuxiliarEndereco
                .FirstOrDefaultAsync(m => m.id == id);
            if (auxiliarEndereco == null)
            {
                return NotFound();
            }

            return View(auxiliarEndereco);
        }

        // POST: AuxiliarEndereco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auxiliarEndereco = await _context.AuxiliarEndereco.FindAsync(id);
            _context.AuxiliarEndereco.Remove(auxiliarEndereco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuxiliarEnderecoExists(int id)
        {
            return _context.AuxiliarEndereco.Any(e => e.id == id);
        }
    }
}
