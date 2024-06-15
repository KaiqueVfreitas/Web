using aula08.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Data;

namespace aula08.Repositorio
{
    public class TabelaRepositorio : ITabelaRepositorio
    {
        private readonly string _conexaoMySQL;
        public TabelaRepositorio(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }
        public IEnumerable<Usuario> TodaTabela()
        {
            List<Usuario>  ListarTabela = new List<Usuario>();
            using(var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * from tbCompras", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexao.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    ListarTabela.Add(
                            new Usuario
                            {
                                //Precisa da conversão para inteiro
                                Id = Convert.ToInt32(dr["codCli"]),
                                Produto = ((string)dr["nome"]),
                                Valor = ((string)dr["telefone"]),
                                DataCompra = ((string)dr["email"]),

                            });
                }
                return Clientlist;


            }
        }

    }
}
