using Microsoft.AspNetCore.Mvc;
using quintaAulaCdrCidade_ProjetoLoja2DS.Models;
using System.Diagnostics;

namespace quintaAulaCdrCidade_ProjetoLoja2DS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Criando metodo que gera a tela de login
        public IActionResult Login()
        {
            return View();
        }

        //Criando metodo que gera uma tela para contato 
        public IActionResult Contato()
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
