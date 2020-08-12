using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Notebook.Models
{
    public class Locacao
    {
        [Key]
        public int LocacaoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int Dias { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produtos Produtos { get; set; }
        public int ClienteId { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public int CotacaoId { get; set; }
        public virtual ICollection<Cotacao> Cotacaos { get; set; }
        public int DevolucaoId { get; set; }
        public virtual Devolucao Devolucao { get; set; }

    }
}
