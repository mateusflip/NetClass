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
        public IActionResult Index()
        {
            return View();
        }
    }
}
