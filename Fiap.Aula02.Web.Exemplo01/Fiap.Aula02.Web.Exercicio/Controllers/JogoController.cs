using Fiap.Aula02.Web.Exercicio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exercicio.Controllers
{
    public class JogoController : Controller
    {

        private static List<Jogo> _jogos = new List<Jogo>();
        private static int _codigo = 1;
        public IActionResult Index()
        {
            return View();
        }
    }
}
