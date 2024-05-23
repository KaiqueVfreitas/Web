using MySql.Data.MySqlClient;
using ProjetoCliente.Models;
using System.Data;

namespace ProjetoCliente.Repositorio
{
    public class ClienteRepositorio
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
    }
}
