using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Locacao.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "CPF inválido")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Tamanho do CPF inválido")]
        [DisplayName("CPF:")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Nome inválido")]
        [DisplayName("NOME:")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "CEP inválido")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Tamanho do CEP inválido")]
        [DisplayName("CEP:")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Endereço inválido")]
        [DisplayName("ENDEREÇO:")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Cidade inválida")]
        [DisplayName("CIDADE:")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Estado inválido")]
        [DisplayName("ESTADO:")]
        public string Estado { get; set; }
    }
}
