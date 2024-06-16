namespace EmprestimoLivros.Models
{
    // Esqueleto de tabelas ficam nos models
    public class EmprestimoModel
    {
        public int Id { get; set; } // Colunas que devem ter nas tabelas do banco de dados 
        public string Recebedor { get; set; }
        public string Fornecedor { get; set; }
        public string LivroEmprestado { get; set; }
        // DateTime.Now serve para a data e hora entrar no momento do registro sem necessidade de preenchimento
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now; 

    }
}
