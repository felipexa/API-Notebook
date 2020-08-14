using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Locacao.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Serie { get; set; }
        public string Sistema { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Processador { get; set; }
        public string Memoria { get; set; }
        public string Tela { get; set; }
        public string Condicao { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
    }
}
