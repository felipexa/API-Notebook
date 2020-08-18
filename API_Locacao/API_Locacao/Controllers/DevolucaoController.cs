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
            var aPI_LocacaoContext = _context.Devolucao.Include(d => d.Locacao).Include(d => d.Produto);
            return View(await aPI_LocacaoContext.ToListAsync());
        }

        // GET: Devolucao/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucao = await _context.Devolucao
                .Include(d => d.Locacao)
                .Include(d => d.Produto)
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
            ViewData["LocacaoId"] = new SelectList(_context.Locacao, "LocacaoId", "ClienteId");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Modelo");
            return View();
        }

        // POST: Devolucao/Create     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DevolucaoId,Data,ProdutoId,LocacaoId")] Devolucao devolucao)
        {
            if (ModelState.IsValid)
            {

                Produto prod = await _context.Produto
               .FirstOrDefaultAsync(m => m.ProdutoId == devolucao.ProdutoId);

                if (prod.Status.Equals("Locado"))
                {


                    if (prod != null)
                    {
                        prod.Status = "Disponível";

                        _context.Add(devolucao);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                   

                }
                ModelState.AddModelError
                  ("", "Esse produto já foi devolvido!");

            }
            ViewData["LocacaoId"] = new SelectList(_context.Locacao, "LocacaoId", "ClienteId");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Modelo");
            return View(devolucao);
        }
       
        private bool DevolucaoExists(int id)
        {
            return _context.Devolucao.Any(e => e.DevolucaoId == id);
        }
    }
}
