using NuGet.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace quintaAulaCdrCidade_ProjetoLoja2DS.Models
{
    /*
      Abstração trazer informações do mundo real para o codigo, além de parte mais proxima do banco de dados
      Encapsulamento recebe e proteger dados alem de apresentar dados de uma maneira simples
     */
    public class Cliente
    {
        //Encapsulamento do objeto cliente
        public int Id {get; set;}
        //encapsulamento esta no get e set. Get pega o dado e Set atribui o dado 
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        private List<Cliente>? listaCliente {get; set;}


        public void NovoCliente()
        {
            //tranamento de exeções (try) tente
            try
            {
                listaCliente = new List<Cliente>()
            {
                new Cliente(){ Id = 1,Nome= "Huguinho",Telefone="1111111", Email = "huguinho@email.com"},
                new Cliente(){ Id = 2,Nome= "Zezinho",Telefone="22222222", Email = "zezinho@email.com"},
                new Cliente(){ Id = 3,Nome= "Luizinho",Telefone="33333333", Email = "luizinho@email.com"},
                new Cliente(){ Id = 4,Nome= "Tio patinhas",Telefone="4444444", Email ="patinhas@email.com"},
                new Cliente(){ Id = 5,Nome= "Tio Donald",Telefone="5555555", Email = "donald@email.com"}
            };
            }
            //catch (caso de algo de errado apresente uma mensagem ao invés de crachar o sistema
            catch (System.Exception ex)
            {
                //mensgem de erro caso aconteça
                throw new Exception(ex.Message);
            }

            
        }

        public List<Cliente> ListarCliente()
        {
            try
            {
                return listaCliente;
            }
            catch (System.Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
