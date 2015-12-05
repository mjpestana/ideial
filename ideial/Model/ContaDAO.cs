using MySql.Data.MySqlClient;

using DISgrupo1.Ideial.Model.Entity;

namespace DISgrupo1.Ideial.Model.DAO
{
    public class ContaDAO
    {
        public string userID;

        public bool VerificarCredencialDb(Conta c)
        {
            try
            {
                MySqlDataReader reader;

                reader = ConexaoDb.SelecionarRegistos("SELECT userName, password FROM conta WHERE userName = '" + c.UserName + "' AND password= '" + c.Password + "'");

                if (reader.Read())
                {
                    return true;
                }
                return false;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void InserirUtilizadorDb(Conta c, Colaborador u)
        {
            try
            {
                long id = ConexaoDb.ExecutarComando("INSERT INTO conta (userName, password) VALUES('" + c.UserName + "', '" + c.Password + "')");   //insere os dados na tabela Conta e retorna o Id

                ConexaoDb.ExecutarComando("INSERT INTO utilizador (nome, email, id_tipoUtilizador, id_departamento, id_cargo, id_conta) VALUES('" + c + "', '" + c.Password + "')");    //insere os dados na tabela Utilizador
            }
            catch (System.Exception)
            {

                throw;
            }
        }

    }
}
