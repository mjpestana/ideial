using System.Data;
using MySql.Data.MySqlClient;

namespace ideial.Model.DAO
{
    class CargoDAO
    {

        public DataTable SelecionarTodos()
        {
            try
            {
                MySqlDataAdapter cc;

                DataSet cargo_ds = new DataSet();

                ConexaoDb conDb = ConexaoDb.GetConexaoDb();
                conDb.FecharConexao();

                string sql = "SELECT * FROM cargo";
                cc = new MySqlDataAdapter(sql, ConexaoDb.conexaoString);
                cc.Fill(cargo_ds, "cargo_dt");
                return cargo_ds.Tables["cargo_dt"];
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
