using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Locacao.Models;

namespace API_Locacao.Data
{
    public class API_LocacaoContext : DbContext
    {
        public API_LocacaoContext (DbContextOptions<API_LocacaoContext> options)
            : base(options)
        {
        }

        public DbSet<API_Locacao.Models.Cliente> Cliente { get; set; }

        public DbSet<API_Locacao.Models.Cotacao> Cotacao { get; set; }

        public DbSet<API_Locacao.Models.Produto> Produto { get; set; }

        public DbSet<API_Locacao.Models.Locacao> Locacao { get; set; }

        public DbSet<API_Locacao.Models.Devolucao> Devolucao { get; set; }
    }
}
