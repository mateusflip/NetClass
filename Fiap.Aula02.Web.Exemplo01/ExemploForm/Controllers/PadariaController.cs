using ExemploForm.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploForm.Controllers
{
    public class PadariaController : Controller
    {

        private static List<Padaria> _banco = new List<Padaria>();
        public IActionResult Index()
        {
            return View(_banco);
        }
        [HttpGet]//Abrir a página de cadastro
        public IActionResult Cadastrar()
        {
            return View();
        }
        //Criar o POST para cadastrar na lista e exibir uma mensagem de sucesso
        [HttpPost]
        public IActionResult Cadastrar(Padaria padaria)
        {
            _banco.Add(padaria);

            TempData["msg"] = "Padaria Registrada!";

            return RedirectToAction("cadastrar");
        }
    
    
    }
}
