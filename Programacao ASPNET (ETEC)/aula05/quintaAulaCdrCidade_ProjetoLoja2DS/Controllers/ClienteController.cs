using Microsoft.AspNetCore.Mvc;
using quintaAulaCdrCidade_ProjetoLoja2DS.Models;
/*
    Abstração criar modelo do mundo real no codigo
    Herança classes recebendo classe de outras classes
    Polimorfismo dá apelido a diferentes coisas no codigo
    Encapsulamento interfaces simples que interage com objetos complexos
    
 */

namespace quintaAulaCdrCidade_ProjetoLoja2DS.Controllers
{
    //Herança clientecontroller herdando de controller
    public class ClienteController : Controller
    {
        public IActionResult Cliente()
        {
            //instanciando o objeto cliente, o objeto é cliente
            Cliente cliente = new Cliente();
            
            //Criando uma classe/função, usando o pilhar da programção orientada a objeto: Polimorfismo
            cliente.NovoCliente();

            //Retornando a instancia e chamando o metodo listar cliente
            return View(cliente.ListarCliente());
        }
    }
}
