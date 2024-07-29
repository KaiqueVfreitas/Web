namespace ProjetoCliente.Models
{
    //Criando encapsulamento do projeto 
    public class Cliente
    {
        //Dados que usaremos 
        public int Id {get; set;}
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public List<Cliente>? ListaCliente { get; set; }
        public string? Nome { get; set; }
    }
}
