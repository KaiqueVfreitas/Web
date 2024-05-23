using Microsoft.AspNetCore.Mvc;
using ProjetoCliente.Repositorio;

namespace ProjetoCliente.Controllers
{
    public class ClienteController : Controller
    {

        private readonly ILogger<ClienteController> _logger; // Que é acessado apenas por está controladora
        private IClienteRepositorio? _clienteRepositorio; // Repositório que ainda vai ser criado

        // criando um metodo para receber a interface do looger e do repositorio cliente
        public ClienteController(ILogger<ClienteController> logger, IClienteRepositorio clienteRepositorio)
        {
            _logger = logger; //Avisos do sistema
            _clienteRepositorio = clienteRepositorio; //Repositorio que vai manipular os dados do banco
   
        }


        public IActionResult Cliente()
        {
            //retornando o repositorio com metodo todosClientes
            return View(_clienteRepositorio.TodosClientes());
        }
    }
}
