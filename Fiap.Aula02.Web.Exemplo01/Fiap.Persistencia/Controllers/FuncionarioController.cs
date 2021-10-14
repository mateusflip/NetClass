using Fiap.Persistencia.Models;
using Fiap.Persistencia.Persistencia;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            var lista = _context.Funcionarios.ToList(); //Recupera todos os funcionários
            return View(lista);
        }


    }
}
