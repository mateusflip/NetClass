using Fiap.Persistencia.Models;
using Fiap.Persistencia.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Persistencia.Controllers
{
    public class FuncionarioController : Controller
    {
        private FabricaContext _context;

        //Receber por injeção de dependencia o contexto
        public FuncionarioController(FabricaContext context) 
        {
            _context = context;
        }

        public IActionResult Pesquisar(string nomeBusca) {
            var lista = "";
            return View(lista);
        }

        public IActionResult Remover(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);//Pesquisar pela PK
            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();
            TempData["msg"] = "Funcionário removido com sucesso";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);
            return View(funcionario);
        }

        [HttpPost]
        public IActionResult Editar(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            _context.SaveChanges();
            TempData["msg"] = "Funcionario atualizado";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges(); //O commit
            TempData["msg"] = "Funcionario Cadastrado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Index(string nomeBusca, Genero? generoBusca)
        {
            var lista = _context.Funcionarios.Where(f=> 
            (f.Nome.Contains(nomeBusca) || nomeBusca == null) &&
            (generoBusca == f.Genero || generoBusca == null))
                .Include(f => f.Endereco)//Inlclui endereço no resultado da pesquisa
                .ToList(); //Recupera todos os funcionários
            return View(lista);
        }


    }
}
