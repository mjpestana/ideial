using MySql.Data.MySqlClient;

using DISgrupo1.Ideial.Model.Entity;

namespace DISgrupo1.Ideial.Model.DAO
{
    public class ContaDAO
    {
        public int contaID;

        public int VerificarCredencialDb(Conta c)
        {
            try
            {
                MySqlDataReader reader;

                reader = ConexaoDb.SelecionarRegistos("SELECT * FROM conta WHERE userName = '" + c.UserName + "' AND password= '" + c.Password + "'");

                if (reader.Read())
                {
                    contaID = (int)reader["ID"];
                    return contaID;
                }
                return 0;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
