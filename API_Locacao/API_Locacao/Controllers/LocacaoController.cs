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
    public class LocacaoController : Controller
    {
        private readonly API_LocacaoContext _context;

        public LocacaoController(API_LocacaoContext context)
        {
            _context = context;
        }

        // GET: Locacao
        public async Task<IActionResult> Index()
        {
            var aPI_LocacaoContext = _context.Locacao.Include(l => l.Cliente).Include(l => l.Cotacao).Include(l => l.Produto);
            return View(await aPI_LocacaoContext.ToListAsync());
        }

        // GET: Locacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locacao = await _context.Locacao
                .Include(l => l.Cliente)
                .Include(l => l.Cotacao)
                .Include(l => l.Produto)
                .FirstOrDefaultAsync(m => m.LocacaoId == id);
            if (locacao == null)
            {
                return NotFound();
            }

            return View(locacao);
        }

        // GET: Locacao/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId");
            ViewData["CotacaoId"] = new SelectList(_context.Cotacao, "CotacaoId", "CotacaoId");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "ProdutoId");
            return View();
        }

        // POST: Locacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocacaoId,DataInicio,DataFinal,Dias,CotacaoId,ClienteId,ProdutoId")] Locacao locacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", locacao.ClienteId);
            ViewData["CotacaoId"] = new SelectList(_context.Cotacao, "CotacaoId", "CotacaoId", locacao.CotacaoId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "ProdutoId", locacao.ProdutoId);
            return View(locacao);
        }

        // GET: Locacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locacao = await _context.Locacao.FindAsync(id);
            if (locacao == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", locacao.ClienteId);
            ViewData["CotacaoId"] = new SelectList(_context.Cotacao, "CotacaoId", "CotacaoId", locacao.CotacaoId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "ProdutoId", locacao.ProdutoId);
            return View(locacao);
        }

        // POST: Locacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocacaoId,DataInicio,DataFinal,Dias,CotacaoId,ClienteId,ProdutoId")] Locacao locacao)
        {
            if (id != locacao.LocacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocacaoExists(locacao.LocacaoId))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "ClienteId", locacao.ClienteId);
            ViewData["CotacaoId"] = new SelectList(_context.Cotacao, "CotacaoId", "CotacaoId", locacao.CotacaoId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "ProdutoId", locacao.ProdutoId);
            return View(locacao);
        }

        // GET: Locacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locacao = await _context.Locacao
                .Include(l => l.Cliente)
                .Include(l => l.Cotacao)
                .Include(l => l.Produto)
                .FirstOrDefaultAsync(m => m.LocacaoId == id);
            if (locacao == null)
            {
                return NotFound();
            }

            return View(locacao);
        }

        // POST: Locacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locacao = await _context.Locacao.FindAsync(id);
            _context.Locacao.Remove(locacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocacaoExists(int id)
        {
            return _context.Locacao.Any(e => e.LocacaoId == id);
        }
    }
}
