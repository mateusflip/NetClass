using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Persistencia.Models
{
    //Mapeia a tabela associativa
    [Table("Tbl_Funcionario_Beneficio")]
    public class FuncionarioBeneficio
    {
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
        public Beneficio Beneficio { get; set; }
        public int BeneficioId { get; set; }
    }
}
