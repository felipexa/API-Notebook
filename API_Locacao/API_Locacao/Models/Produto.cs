using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Locacao.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [DisplayName("Nº SÉRIE:")]
        public string Serie { get; set; }
        [DisplayName("SISTEMA OPERACIONAL:")]
        public string Sistema { get; set; }
        [DisplayName("MARCA:")]
        public string Marca { get; set; }
        [DisplayName("MODELO:")]
        public string Modelo { get; set; }
        [DisplayName("PROCESSADOR:")]
        public string Processador { get; set; }
        [DisplayName("MEMÓRIA:")]
        public string Memoria { get; set; }
        [DisplayName("TELA:")]
        public string Tela { get; set; }
        [DisplayName("CONDIÇÃO:")]
        public string Condicao { get; set; }
        [DisplayName("OBSERVAÇÃO:")]
        public string Observacao { get; set; }
        [DisplayName("STATUS:")]
        public string Status { get; set; }
    }
}
