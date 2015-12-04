using System.Data.OleDb;

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
                OleDbDataReader reader;

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

        public void InserirUtilizadorDb(Conta c)
        {
            try
            {
                //ConexaoDb.ExecutarComando("INSERT INTO conta (userName, password) VALUES('" + c.UserName + "', '" + c.Password + "')");
                ConexaoDb.ExecutarComando("INSERT INTO conta (userName, password) VALUES('teste', '123456')");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

    }
}
