using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniMundo.Models;
using ProjetoControleVendas.Data;

namespace MiniMundo.Controllers
{
    public class NivelDeAcessoesController : Controller
    {
        private readonly ProjetoControleVendasContext _context;

        public NivelDeAcessoesController(ProjetoControleVendasContext context)
        {
            _context = context;
        }

        // GET: NivelDeAcessoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.NivelDeAcesso.ToListAsync());
        }

        // GET: NivelDeAcessoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelDeAcesso = await _context.NivelDeAcesso
                .FirstOrDefaultAsync(m => m.NivelDeAcessoID == id);
            if (nivelDeAcesso == null)
            {
                return NotFound();
            }

            return View(nivelDeAcesso);
        }

        // GET: NivelDeAcessoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NivelDeAcessoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NivelDeAcessoID")] NivelDeAcesso nivelDeAcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nivelDeAcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nivelDeAcesso);
        }

        // GET: NivelDeAcessoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelDeAcesso = await _context.NivelDeAcesso.FindAsync(id);
            if (nivelDeAcesso == null)
            {
                return NotFound();
            }
            return View(nivelDeAcesso);
        }

        // POST: NivelDeAcessoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NivelDeAcessoID")] NivelDeAcesso nivelDeAcesso)
        {
            if (id != nivelDeAcesso.NivelDeAcessoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nivelDeAcesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NivelDeAcessoExists(nivelDeAcesso.NivelDeAcessoID))
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
            return View(nivelDeAcesso);
        }

        // GET: NivelDeAcessoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelDeAcesso = await _context.NivelDeAcesso
                .FirstOrDefaultAsync(m => m.NivelDeAcessoID == id);
            if (nivelDeAcesso == null)
            {
                return NotFound();
            }

            return View(nivelDeAcesso);
        }

        // POST: NivelDeAcessoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nivelDeAcesso = await _context.NivelDeAcesso.FindAsync(id);
            if (nivelDeAcesso != null)
            {
                _context.NivelDeAcesso.Remove(nivelDeAcesso);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NivelDeAcessoExists(int id)
        {
            return _context.NivelDeAcesso.Any(e => e.NivelDeAcessoID == id);
        }
    }
}
