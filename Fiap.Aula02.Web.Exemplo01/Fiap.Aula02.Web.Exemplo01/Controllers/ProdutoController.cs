using Fiap.Aula02.Web.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo01.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //produto/cadastrar
        [HttpGet]//Abrir a página de cadastro (formulário)
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]//Recuperar os dados do formulário e realizar algo...
        public IActionResult Cadastrar(Produto produto)
        {
            //Enviar informações para a View
            ViewData["nome"] = produto.Nome;
            ViewData["preco"] = produto.Preco;


            ViewBag.qtd = produto.Quantidade;
            ViewBag.prod = produto;

            return View();
            
            //Retorna um texto para o Browser
           // return Content($"Nome: {produto.nome}, Preço: {produto.preco}, Qtd: {produto.quantidade}");
        }
    }
}
