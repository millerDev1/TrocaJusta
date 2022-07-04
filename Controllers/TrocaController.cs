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
    public class TrocaController : Controller
    {
        private readonly TrocaJustaContext _context;

        public TrocaController(TrocaJustaContext context)
        {
            _context = context;
        }

        // GET: Troca
        public async Task<IActionResult> Index()
        {
            return View(await _context.Troca.ToListAsync());
        }

        // GET: Troca/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var troca = await _context.Troca
                .FirstOrDefaultAsync(m => m.Trocaid == id);
            if (troca == null)
            {
                return NotFound();
            }

            return View(troca);
        }

        // GET: Troca/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuaurioId", "Nome");
            ViewData["ProfissaoEnum"] = new SelectList(_context.Usuario, "ProfissaoEnum", "Profissao");
            ViewData["ServicoEnum"] = new SelectList(_context.Usuario, "ServicoEnum", "Servico");
            return View();
        }

        // POST: Troca/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrocaId,UsuarioId,Servico,Profissao,Disponivel")] Troca troca)
        {
            if (ModelState.IsValid)
            {
                troca.Disponivel = true;
                _context.Add(troca);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                //ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuaurioId", "Nome");
                ViewData["ProfissaoEnum"] = new SelectList(_context.Usuario, "ProfissaoEnum", "Profissao");
                ViewData["ServicoEnum"] = new SelectList(_context.Usuario, "ServicoEnum", "Servico");
            }
            return View(troca);
        }

        // GET: Troca/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var troca = await _context.Troca.FindAsync(id);
            if (troca == null)
            {
                return NotFound();
            }
            return View(troca);
        }

        // POST: Troca/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TrocaId,UsuarioId,Servico,Profissao,Disponivel")] Troca troca)
        {
            if (id != troca.Trocaid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(troca);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrocaExists(troca.Trocaid))
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
            return View(troca);
        }

        // GET: Troca/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var troca = await _context.Troca
                .FirstOrDefaultAsync(m => m.Trocaid == id);
            if (troca == null)
            {
                return NotFound();
            }

            return View(troca);
        }

        // POST: Troca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var troca = await _context.Troca.FindAsync(id);
            _context.Troca.Remove(troca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrocaExists(int id)
        {
            return _context.Troca.Any(e => e.Trocaid == id);
        }
    }
}
