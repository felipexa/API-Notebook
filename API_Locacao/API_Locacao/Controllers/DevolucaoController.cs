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
    public class DevolucaoController : Controller
    {
        private readonly API_LocacaoContext _context;

        public DevolucaoController(API_LocacaoContext context)
        {
            _context = context;
        }

        // GET: Devolucao
        public async Task<IActionResult> Index()
        {
            var aPI_LocacaoContext = _context.Devolucao.Include(d => d.Locacao);
            return View(await aPI_LocacaoContext.ToListAsync());
        }

        // GET: Devolucao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucao = await _context.Devolucao
                .Include(d => d.Locacao)
                .FirstOrDefaultAsync(m => m.DevolucaoId == id);
            if (devolucao == null)
            {
                return NotFound();
            }

            return View(devolucao);
        }

        // GET: Devolucao/Create
        public IActionResult Create()
        {
            ViewData["LocacaoId"] = new SelectList(_context.Locacao, "LocacaoId", "LocacaoId");
            return View();
        }

        // POST: Devolucao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DevolucaoId,Data,Multa,LocacaoId")] Devolucao devolucao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(devolucao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocacaoId"] = new SelectList(_context.Locacao, "LocacaoId", "LocacaoId", devolucao.LocacaoId);
            return View(devolucao);
        }

        // GET: Devolucao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucao = await _context.Devolucao.FindAsync(id);
            if (devolucao == null)
            {
                return NotFound();
            }
            ViewData["LocacaoId"] = new SelectList(_context.Locacao, "LocacaoId", "LocacaoId", devolucao.LocacaoId);
            return View(devolucao);
        }

        // POST: Devolucao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DevolucaoId,Data,Multa,LocacaoId")] Devolucao devolucao)
        {
            if (id != devolucao.DevolucaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(devolucao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DevolucaoExists(devolucao.DevolucaoId))
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
            ViewData["LocacaoId"] = new SelectList(_context.Locacao, "LocacaoId", "LocacaoId", devolucao.LocacaoId);
            return View(devolucao);
        }

        // GET: Devolucao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucao = await _context.Devolucao
                .Include(d => d.Locacao)
                .FirstOrDefaultAsync(m => m.DevolucaoId == id);
            if (devolucao == null)
            {
                return NotFound();
            }

            return View(devolucao);
        }

        // POST: Devolucao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var devolucao = await _context.Devolucao.FindAsync(id);
            _context.Devolucao.Remove(devolucao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DevolucaoExists(int id)
        {
            return _context.Devolucao.Any(e => e.DevolucaoId == id);
        }
    }
}
