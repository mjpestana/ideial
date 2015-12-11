using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Model.DAO
{
    class DepartamentoDAO
    {

        //public DataTable Cheia_Departamento()
        public MySqlDataReader SelecionarTodos()
        {

            try
            {
                MySqlDataReader reader;

                //var Departamento_dt = new DataTable();

                reader = ConexaoDb.SelecionarRegistos("SELECT * FROM departamento");

                if (reader.Read())
                {
                    //Departamento_dt.Load(reader);
                    return reader;
                }

                //return Departamento_dt;
                return null;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
