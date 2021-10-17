using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.Persistencia.Migrations
{
    public partial class Relacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Beneficio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Beneficio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Departamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnderecoId = table.Column<int>(type: "int", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dt_Contratacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Funcionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Funcionario_Tbl_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Tbl_Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Funcionario_Tbl_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Tbl_Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Funcionario_Beneficio",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    BeneficioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Funcionario_Beneficio", x => new { x.BeneficioId, x.FuncionarioId });
                    table.ForeignKey(
                        name: "FK_Tbl_Funcionario_Beneficio_Tbl_Beneficio_BeneficioId",
                        column: x => x.BeneficioId,
                        principalTable: "Tbl_Beneficio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Funcionario_Beneficio_Tbl_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Tbl_Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Funcionario_DepartamentoId",
                table: "Tbl_Funcionario",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Funcionario_EnderecoId",
                table: "Tbl_Funcionario",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Funcionario_Beneficio_FuncionarioId",
                table: "Tbl_Funcionario_Beneficio",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Funcionario_Beneficio");

            migrationBuilder.DropTable(
                name: "Tbl_Beneficio");

            migrationBuilder.DropTable(
                name: "Tbl_Funcionario");

            migrationBuilder.DropTable(
                name: "Tbl_Departamento");

            migrationBuilder.DropTable(
                name: "Tbl_Endereco");
        }
    }
}
