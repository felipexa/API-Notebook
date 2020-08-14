using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API_Locacao.Data;
using API_Locacao.Models;

namespace API_Locacao.Controllers
{
    public class CotacaoController : Controller
    {
        private readonly API_LocacaoContext _context;

        public CotacaoController(API_LocacaoContext context)
        {
            _context = context;
        }

        // GET: Cotacao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cotacao.ToListAsync());
        }

        // GET: Cotacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotacao = await _context.Cotacao
                .FirstOrDefaultAsync(m => m.CotacaoId == id);
            if (cotacao == null)
            {
                return NotFound();
            }

            return View(cotacao);
        }

        // GET: Cotacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cotacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CotacaoId,Taxa,ValorDiaria,ValorTotal")] Cotacao cotacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cotacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cotacao);
        }

        // GET: Cotacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotacao = await _context.Cotacao.FindAsync(id);
            if (cotacao == null)
            {
                return NotFound();
            }
            return View(cotacao);
        }

        // POST: Cotacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CotacaoId,Taxa,ValorDiaria,ValorTotal")] Cotacao cotacao)
        {
            if (id != cotacao.CotacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cotacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CotacaoExists(cotacao.CotacaoId))
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
            return View(cotacao);
        }

        // GET: Cotacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cotacao = await _context.Cotacao
                .FirstOrDefaultAsync(m => m.CotacaoId == id);
            if (cotacao == null)
            {
                return NotFound();
            }

            return View(cotacao);
        }

        // POST: Cotacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cotacao = await _context.Cotacao.FindAsync(id);
            _context.Cotacao.Remove(cotacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CotacaoExists(int id)
        {
            return _context.Cotacao.Any(e => e.CotacaoId == id);
        }
    }
}
