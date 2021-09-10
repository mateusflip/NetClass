using ExemploForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploForm.Controllers
{
    public class PadariaController : Controller
    {

        private static List<Padaria> _banco = new List<Padaria>();
        private static int _gerador = 1;

        [HttpGet]
        public IActionResult Remover(int id)
        {
            //Remover Padaria da Lista pela condição
            _banco.RemoveAll(p => p.Codigo == id);
            //Mensagem de Sucesso
            TempData["msg"] = "Padaria Removida";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }


        //Atualizar a padaria na lista
        [HttpPost]
        public IActionResult Editar(Padaria padaria)
        {
            //Atualizar a padaria (findIndex, pesquisa a posição do objeto na lista)
            _banco[_banco.FindIndex(p => p.Codigo == padaria.Codigo)] = padaria;
            //Mensagem de Sucesso
            TempData["msg"] = "Padaria Atualizada!";


            //Redirecionar para listagem
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarCidades();
            //Pesquisar a padaria pelo código
            var padaria = _banco.Find(p=> p.Codigo == id);
            //Enviar a padaria para View
            return View(padaria);
        }
        public IActionResult Index()
        {
            return View(_banco);
        }
        [HttpGet]//Abrir a página de cadastro
        public IActionResult Cadastrar()
        {
            CarregarCidades();
            return View();
        }

        private void CarregarCidades()
        {
            //Criar a lista de cidades (lista de strings)
            var lista = new List<string>(new string[] { "São Paulo", "Rio de Janeiro", "Bauru" });
            ///
            ViewBag.cidades = new SelectList(lista);
        }

        //Criar o POST para cadastrar na lista e exibir uma mensagem de sucesso
        [HttpPost]
        public IActionResult Cadastrar(Padaria padaria)
        {
            padaria.Codigo = _gerador++;
            _banco.Add(padaria);

            TempData["msg"] = "Padaria Registrada!";

            return RedirectToAction("cadastrar");
        }
    
    
    }
}
