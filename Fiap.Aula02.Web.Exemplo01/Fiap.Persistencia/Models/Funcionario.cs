using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Persistencia.Models
{
    [Table("Tbl_Funcionario")]
    public class Funcionario
    {   [Column("Id")]
        public int FuncionarioId { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        [Column("Dt_Contratacao")]
        public DateTime DataContratacao { get; set; }
        public bool Ativo { get; set; }
        [Required]
        public Genero genero { get; set; }
        [Required]
        public decimal salario { get; set; }
    }

    public enum Genero
    {
        Masculino, Feminino, Outros
    }
}
