using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Locacao.Models
{
    public class Devolucao
    {

        [Key]
        public int DevolucaoId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("DATA DEVOLUÇÃO:")]
        public DateTime Data { get; set; }

        [DisplayName("ID CLIENTE:")]
        public Locacao Locacao { get; set; }
        [DisplayName("PRODUTO:")]
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int LocacaoId { get; set; }
    }
}
