using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Locacao.Models
{
    public class Locacao
    {

        [Key]
        public int LocacaoId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("DATA INÍCIO:")]
        public DateTime DataInicio { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("DATA FINAL:")]
        public DateTime DataFinal { get; set; }
        [Required(ErrorMessage = "Campo preenchimento automático")]
        [DisplayName("DIAS:")]
        public int Dias { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("VALOR DIÁRIA:")]
        public decimal ValorDiaria { get; set; }
        [Required(ErrorMessage = "Campo preenchimento automático")]
        [DisplayName("VALOR TOTAL:")]
        public decimal ValorTotal { get; set; }

        [DisplayName("CLIENTE:")]
        public Cliente Cliente { get; set; }
        [DisplayName("PRODUTO:")]
        public Produto Produto { get; set; }
 
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
    }
}
