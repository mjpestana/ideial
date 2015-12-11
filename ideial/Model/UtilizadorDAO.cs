using DISgrupo1.Ideial.Model.Entity;
using MySql.Data.MySqlClient;

namespace DISgrupo1.Ideial.Model.DAO
{
    class UtilizadorDAO
    {

        public void InserirUtilizadorDb(Conta c, Colaborador u)
        {
            try
            {
                long contaID = ConexaoDb.ExecutarComando("INSERT INTO conta (userName, password) VALUES('" + c.UserName + "', '" + c.Password + "')");   //insere os dados na tabela Conta e retorna o Id

                ConexaoDb.ExecutarComando("INSERT INTO utilizador (nome, email, id_conta, id_tipoutilizador, id_departamento, id_Cargo) VALUES('" + u.Nome + "', '" + u.Email + "', '" + contaID + "', '" + u.id_tipo + "', '" + u.id_departamento + "', '" + u.id_cargo + "' )");    //insere os dados na tabela Utilizador
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public MySqlDataReader SelecionarUtilizadorIdDb(int contaID)
        {
            try
            {
                MySqlDataReader reader;

                reader = ConexaoDb.SelecionarRegistos("SELECT * FROM utilizador WHERE id_conta = '" + contaID + "'");

                if (reader.Read())
                {
                    return reader;
                }

                return null;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
