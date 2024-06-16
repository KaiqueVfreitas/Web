using EmprestimoLivros.Data;
using EmprestimoLivros.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class EmprestimoController : Controller
    {
        /*
            Precisamos passar aqui toda a conexão que fizemos para banco de dados.
            Passamos ApplicationDbContext, que tem apenas a ordem de criar a tabela no SQL Server
            para informar o controller da conexão ao banco de dados, criamos o db em um método publico
            para usar em outras partes do codigo.
            Readonly, é apenas para ler algo e captar a informação, private só para esta controller usar, 
            ApplicationDbContext é para saber que é parte do contexto do banco de dados, _db por ser privado         
        */
        readonly private ApplicationDbContext _db;
        /*
            O caminho que está variavel vai fazer é:
            Ir no programa.cs e acessar a builder que criamos e adicionamos a o ApplicationDbContext dentro do arquivo Data,
            Pegamos este acesso e colocamos dentro da classe, a importancia de colocar readonly é para ler, mas em outros casos
            seria usada para outras partes do CRUD
        */
        public EmprestimoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            /*
                Para conseguirmos mandar retornar os dados dentro do banco usamos de novo o Ienumerable para retorna o dados em sequencia
             */
            IEnumerable<EmprestimoModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }
        
    }
}
