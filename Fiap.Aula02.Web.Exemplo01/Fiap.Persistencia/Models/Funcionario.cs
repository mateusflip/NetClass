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
        [Required, MaxLength(100), Column("Nome_Funcionario")]

        public Endereco Endereco { get; set; }
        public int? EnderecoId { get; set; }

        //N:1
        public Departamento Departamento { get; set; }
        public int? DepartamentoId { get; set; }

        //N:M
        public ICollection<FuncionarioBeneficio> FuncionariosBeneficios { get; set; }

        [Required, MaxLength(80)]
        public string Nome { get; set; }

        [Column("Dt_Contratacao"), DataType(DataType.Date), Display(Name = "Data de Contração")]
        public DateTime DataContratacao { get; set; }
        public bool? Ativo { get; set; }

        //? -> Permite o valor ser null

        [Required]
        public Genero Genero { get; set; }
        [Required]
        public decimal Salario { get; set; }
    }

    public enum Genero
    {
        Masculino, Feminino, Outros
    }
}
