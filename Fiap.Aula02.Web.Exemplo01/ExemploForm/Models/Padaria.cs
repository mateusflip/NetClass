using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploForm.Models
{
    public class Padaria
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }
        [Display(Name ="Disponível")]
        public bool Disponivel { get; set; }
        [DataType(DataType.Date), Display(Name ="Data de Abertura")]
        public DateTime DataAbertura { get; set; }
        public decimal Faturamento { get; set; }
    }
}
