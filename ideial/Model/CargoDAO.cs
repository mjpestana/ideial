using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Model.DAO
{
    class CargoDAO
    {

        public DataTable SelecionarTodos()
        {
            try
            {
                MySqlDataAdapter cc;

                DataSet cargo_ds = new DataSet();
                ConexaoDb.FecharConexao();

                string sql = "SELECT * FROM cargo";
                cc = new MySqlDataAdapter(sql, ConexaoDb.conexao);
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
