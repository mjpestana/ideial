using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Model.DAO
{
    class TipoUtilizadorDAO
    {

        //public DataTable Cheia_TipoUtilizador()
        public MySqlDataReader SelecionarTodos()
        {
            try
            {
                MySqlDataReader reader;

                //var TipoUtilizador_dt = new DataTable();

                reader = ConexaoDb.SelecionarRegistos("SELECT * FROM tipoutilizador");

                if (reader.Read())
                {
                    //TipoUtilizador_dt.Load(reader);
                    return reader;
                }

                //return TipoUtilizador_dt;
                return null;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
