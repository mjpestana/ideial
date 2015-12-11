using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Model.DAO
{
    class CargoDAO
    {

        //public DataTable Cheia_Cargo()
        public MySqlDataReader SelecionarTodos()
        {
            try
            {
                MySqlDataReader reader;

                //var cargo_dt = new DataTable();

                reader = ConexaoDb.SelecionarRegistos("SELECT * FROM cargo");

                if (reader.Read())
                {
                    //cargo_dt.Load(read);
                    return reader;
                }

                //return cargo_dt;
                return null;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
