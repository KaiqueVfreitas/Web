using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        // Criando a tabela no banco de dados
        public DbSet<EmprestimoModel> Emprestimos { get; set; } // Emprestimos é o nome da tabela, colunas da tabela ta na model EmprestimoModel
    }
}
