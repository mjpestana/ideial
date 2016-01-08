using System.Windows.Forms;
using MySql.Data.MySqlClient;

using ideial.Model.Entity;

namespace ideial.Model.DAO
{
    public class ContaDAO
    {
        public int idConta;

        public int VerificarCredencial(string user, string pass)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM conta WHERE userName = '" + user + "' AND password= '" + pass + "'");

                if (reader.Read())
                {
                    idConta = (int)reader["ID"];
                    return idConta;
                }
                return 0;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public long InserirConta(Conta c)
        {
            try
            {
                //Insere os dados na tabela Conta e retorna o IdConta
                long contaId = ConexaoDb.ExecutarComando("INSERT INTO conta (userName, password) VALUES('" + c.UserName + "', '" + c.Password + "')");

                return contaId;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void AtualizarConta(int idConta, string pass)
        {
            try
            {
                //Prepara string para atualizar dados da tabela 
                string sql = "UPDATE conta SET password = '" + pass + "' WHERE ID = '" + idConta + "'";

                ConexaoDb conDb = ConexaoDb.GetConexaoDb();
                conDb.AbrirConexao();

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = ConexaoDb.conexaoString;

                //Executa comando
                comando.ExecuteReader();
            }
            catch (MySqlException msg)
            {
                MessageBox.Show("Erro: " + msg.Message);
            }
        }

    }
}
