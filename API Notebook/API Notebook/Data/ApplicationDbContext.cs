using API_Notebook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace API_Notebook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cotacao> Cotacaos { get; set; }
        public DbSet<Devolucao> Devolucaos { get; set; }
        public DbSet<Locacao> Locacaos{ get; set; }
        public DbSet<Produtos> Produtos { get; set; }

    }
}
