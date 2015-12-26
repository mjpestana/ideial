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

        /*
        public void AtualizarConta(Conta c)
        {
            try
            {
                //Atualiza os dados na tabela Conta
                ConexaoDb.ExecutarComando("UPDATE conta SET password = '" + c.Password + "' WHERE userName = '" + c.UserName + "')");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        */

    }
}
