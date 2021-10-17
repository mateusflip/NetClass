using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Persistencia.Models
{
    [Table("Tbl_Beneficio")]
    public class Beneficio
    {
        [Column("Id")]
        public int BeneficioId { get; set; }

        [Required, MaxLength(80)]
        public string Nome { get; set; }

        //N:M
        public ICollection<FuncionarioBeneficio> FuncionariosBeneficios { get; set; }

        public bool Disponivel { get; set; }
        }
    }
