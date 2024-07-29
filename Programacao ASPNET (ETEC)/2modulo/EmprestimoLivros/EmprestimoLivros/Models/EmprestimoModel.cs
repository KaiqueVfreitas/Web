using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    // Esqueleto de tabelas ficam nos models
    public class EmprestimoModel
    {
       
        public int Id { get; set; } // Colunas que devem ter nas tabelas do banco de dados 

        //Parte que torna obrigatório o preenchimento 
        [Required(ErrorMessage = "Digite o nome do Recebedor!")]
        public string Recebedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        public string Fornecedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Livro emprestado!")]
        public string LivroEmprestado { get; set; }


        // DateTime.Now serve para a data e hora entrar no momento do registro sem necessidade de preenchimento
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now; 

    }
}
