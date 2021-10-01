using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exercicio.Models
{
    public class Jogo
    {
        [HiddenInput]
        public int Codigo { get; set;  }
        public string Nome { get; set; }
        [Display(Name="Data Lançamento"), DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public int Rating { get; set; }
        public bool Multiplayer { get; set; }
        [Display(Name ="Genero")]
        public Genero Genero { get; set; }
        public string Plataforma { get; set; }
    }

    public enum Genero { Esporte, Rpg, Aventura, Corrida, Luta}
}
