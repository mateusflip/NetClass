using Fiap.Persistencia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Persistencia.Persistencia
{   //Classe que gerencia as entidades
    public class FabricaContext : DbContext
    {
        //Propriedades que representam as entidades no banco de dados
        public DbSet<Funcionario> Funcionarios { get; set; }
        
        
        
        //Construtor que recebe string de conexão
        public FabricaContext(DbContextOptions op) : base(op) { }
    }
}
