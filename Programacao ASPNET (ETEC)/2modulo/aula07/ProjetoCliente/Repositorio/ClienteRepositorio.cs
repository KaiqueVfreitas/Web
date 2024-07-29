using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using ProjetoCliente.Models;
using System.Data;

namespace ProjetoCliente.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {

        private readonly string _conexaoMySQL;
        public ClienteRepositorio(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }
        public IEnumerable<Cliente> TodosClientes()
        {
            List<Cliente> Clientlist = new List<Cliente>();
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * from tbCliente", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexao.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    Clientlist.Add(
                            new Cliente
                            {
                                //Precisa da conversão para inteiro
                                Id = Convert.ToInt32(dr["codCli"]),
                                Nome = ((string)dr["nome"]),
                                Telefone = ((string)dr["telefone"]),
                                Email = ((string)dr["email"]),

                            });
                }
                return Clientlist;

            }
        }

        public void Cadastrar(Cliente cliente)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))

            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into tbCliente(nome,telefone,email) values (@nome, @telefone, @email)", conexao); // @: PARAMETRO

                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = cliente.Nome;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = cliente.Telefone;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = cliente.Email;
                 
                cmd.ExecuteNonQuery();
                conexao.Close();
            }

        }
    }
}
