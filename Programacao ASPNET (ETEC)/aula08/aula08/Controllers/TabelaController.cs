using aula08.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace aula08.Controllers
{
    public class TabelaController : Controller
    {
        private readonly ILogger<TabelaController> _logger; // Que é acessado apenas por está controladora
        private ITabelaRepositorio? _tabelaRepositorio; // Repositório que ainda vai ser criado

        // criando um metodo para receber a interface do looger e do repositorio cliente
        public TabelaController(ILogger<TabelaController> logger, ITabelaRepositorio tabelaRepositorio)
        {
            _logger = logger; //Avisos do sistema
            _tabelaRepositorio = tabelaRepositorio; //Repositorio que vai manipular os dados do banco

        }
        public IActionResult Tabela()
        {
            return View(_tabelaRepositorio.TodaTabela());
        }
    }
}
