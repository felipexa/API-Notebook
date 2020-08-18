using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API_Locacao.Data;
using API_Locacao.Models;
using System.Net.Security;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

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
            var aPI_LocacaoContext = _context.Locacao.Include(l => l.Cliente).Include(l => l.Produto);
            return View(await aPI_LocacaoContext.ToListAsync());
        }

        // GET: Locacao/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locacao = await _context.Locacao
                .Include(l => l.Cliente)
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Nome");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Modelo");
            return View();
        }

        // POST: Locacao/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocacaoId,DataInicio,DataFinal,Dias,ValorDiaria,ValorTotal,ClienteId,ProdutoId")] Locacao locacao)
        {
            if (ModelState.IsValid)
            {

                Produto prod = await _context.Produto
              .FirstOrDefaultAsync(m => m.ProdutoId == locacao.ProdutoId);

                if (prod.Status.Equals("Disponível")){
                    
                  
                    if (prod != null)
                    {
                        prod.Status = "Locado";
                    
                        _context.Add(locacao);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }

                }
                ModelState.AddModelError
                    ("", "Esse produto já está locado!");

            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "ClienteId", "Nome");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Modelo");
            return View(locacao);
        }

        private bool LocacaoExists(int id)
        {
            return _context.Locacao.Any(e => e.LocacaoId == id);           
        }
    }
}
