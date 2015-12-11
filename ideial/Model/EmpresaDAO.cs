using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Model.DAO
{
    class EmpresaDAO
    {

        //public DataTable Cheia_Empresa()
        public MySqlDataReader SelecionarTodos()
        {
            try
            {
                MySqlDataReader reader;

                //var empresa_dt = new DataTable();

                reader = ConexaoDb.SelecionarRegistos("SELECT * FROM empresa");

                if (reader.Read())
                {
                    //empresa_dt.Load(reader);
                    return reader;
                }

                //return empresa_dt;
                return null;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
