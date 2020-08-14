using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Locacao.Models
{
    public class Devolucao
    {

        [Key]
        public int DevolucaoId { get; set; }
        public DateTime Data { get; set; }
        public decimal Multa { get; set; }

        public Locacao Locacao { get; set; }
        public int LocacaoId { get; set; }
    }
}
