using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Persistencia.Models
{

    [Table("Tbl_Departamento")]
    public class Departamento
    {
        [Column("Id")]
        public int DepartamentoId { get; set; }

        [Required, MaxLength(80)]
        public string Nome { get; set; }

        //1:N
        public virtual ICollection<Funcionario> Funcionarios { get; set; }

    }
}
