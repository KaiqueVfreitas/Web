using MySqlX.XDevAPI;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aula08.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }
        public List<Usuario>? ListarTabela { get; set; }
        public DateTime DataCompra { get; set;}
    }
}
