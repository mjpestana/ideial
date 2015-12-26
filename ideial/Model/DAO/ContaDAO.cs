using ideial.Model.Entity;
using MySql.Data.MySqlClient;

namespace ideial.Model.DAO
{
    public class ContaDAO
    {
        public int contaId;

        public int VerificarCredencialDb(Conta c)
        {
            try
            {
                MySqlDataReader reader;

                reader = ConexaoDb.SelecionarRegistos("SELECT * FROM conta WHERE userName = '" + c.UserName + "' AND password= '" + c.Password + "'");

                if (reader.Read())
                {
                    contaId = (int)reader["ID"];
                    return contaId;
                }
                return 0;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public long InserirContaDb(Conta c)
        {
            try
            {
                //Insere os dados na tabela Conta e retorna o Id
                long contaId = ConexaoDb.ExecutarComando("INSERT INTO conta (userName, password) VALUES('" + c.UserName + "', '" + c.Password + "')");

                return contaId;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
