using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Locacao.Models
{
    public class Locacao
    {

        [Key]
        public int LocacaoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int Dias { get; set; }

        public Cotacao Cotacao { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int CotacaoId { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
    }
}
