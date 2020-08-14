﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Locacao.Models
{
    public class Cotacao
    {
        [Key]
        public int CotacaoId { get; set; }
        public decimal Taxa { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
