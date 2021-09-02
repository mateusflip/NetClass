using Fiap.Aula02.Web.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo01.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar(Ususario usuario)
        {
            ViewData["nome"] = usuario.Nome;
            ViewBag.data = usuario.DataNascimento;
            TempData["msg"] = "Usuário Cadastrado";
            return View(usuario);
        }
    }
}
