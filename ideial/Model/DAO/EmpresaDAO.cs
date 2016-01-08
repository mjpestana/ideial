using System.Data;
using MySql.Data.MySqlClient;

namespace ideial.Model.DAO
{
    class EmpresaDAO
    {

        public DataTable SelecionarTodos()
        {
            try
            {
                MySqlDataAdapter cc;

                DataSet empresa_ds = new DataSet();

                ConexaoDb conDb = ConexaoDb.GetConexaoDb();
                conDb.FecharConexao();

                string sql = "SELECT * FROM empresa";
                cc = new MySqlDataAdapter(sql, ConexaoDb.conexaoString);
                cc.Fill(empresa_ds, "empresa_dt");
                return empresa_ds.Tables["empresa_dt"];
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
