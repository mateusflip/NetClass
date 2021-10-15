using Fiap.Persistencia.Models;
using Fiap.Persistencia.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Persistencia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private FabricaContext _context;

        

        public HomeController(ILogger<HomeController> logger, FabricaContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["qtdFuncionarios"] = _context.Funcionarios.Count();
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
