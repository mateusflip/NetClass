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

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FuncionarioBeneficio> FuncionariosBeneficios { get; set; }

        //Construtor que recebe string de conexão
        public FabricaContext(DbContextOptions op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar a chave composta da tabela associativa
            modelBuilder.Entity<FuncionarioBeneficio>().HasKey(f => new { f.BeneficioId, f.FuncionarioId });

            //Configurar a relação da tabela associativa com o funcionario
            modelBuilder.Entity<FuncionarioBeneficio>()
                .HasOne(f => f.Funcionario)
                .WithMany(f => f.FuncionariosBeneficios)
                .HasForeignKey(f => f.FuncionarioId);

            //Configurar a relação da tabela associativa com o benefício
            modelBuilder.Entity<FuncionarioBeneficio>()
                .HasOne(f => f.Beneficio)
                .WithMany(f => f.FuncionariosBeneficios)
                .HasForeignKey(f => f.BeneficioId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
