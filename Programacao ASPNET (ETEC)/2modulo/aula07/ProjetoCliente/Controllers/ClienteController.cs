using Microsoft.AspNetCore.Mvc;
using ProjetoCliente.Models;
using ProjetoCliente.Repositorio;
using System.Diagnostics;

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

        public IActionResult CadCliente()
        {
            //retornando o repositorio com metodo todosClientes
            return View();
        }



        //Página Cadastro Cliente que envia os dados(post)
        [HttpPost]
        public IActionResult CadCliente(Cliente cliente)
        {
            //metodo cadastra 
            _clienteRepositorio.Cadastrar(cliente);

            //redireciona para index
            return RedirectToAction(nameof(Cliente));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
