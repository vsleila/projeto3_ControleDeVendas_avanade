using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoControleVendas.Data;
using ProjetoControleVendas.Models;

namespace MiniMundo.Controllers
{
    public class VendasController : Controller
    {
        private readonly ProjetoControleVendasContext _context;

        public VendasController(ProjetoControleVendasContext context)
        {
            _context = context;
        }

        // GET: Vendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vendas.ToListAsync());
        }

        // GET: Vendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendas = await _context.Vendas
                .FirstOrDefaultAsync(m => m.VendasID == id);
            if (vendas == null)
            {
                return NotFound();
            }

            return View(vendas);
        }

        // GET: Vendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendasID,NomeP,Quantidade,FuncionarioVenda,ValorTotal")] Vendas vendas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendas);
        }

        // GET: Vendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendas = await _context.Vendas.FindAsync(id);
            if (vendas == null)
            {
                return NotFound();
            }
            return View(vendas);
        }

        // POST: Vendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VendasID,NomeP,Quantidade,FuncionarioVenda,ValorTotal")] Vendas vendas)
        {
            if (id != vendas.VendasID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendasExists(vendas.VendasID))
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
            return View(vendas);
        }

        // GET: Vendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendas = await _context.Vendas
                .FirstOrDefaultAsync(m => m.VendasID == id);
            if (vendas == null)
            {
                return NotFound();
            }

            return View(vendas);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendas = await _context.Vendas.FindAsync(id);
            if (vendas != null)
            {
                _context.Vendas.Remove(vendas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendasExists(int id)
        {
            return _context.Vendas.Any(e => e.VendasID == id);
        }
    }
}
