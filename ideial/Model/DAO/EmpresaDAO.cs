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
                ConexaoDb.FecharConexao();

                string sql = "SELECT * FROM empresa";
                cc = new MySqlDataAdapter(sql, ConexaoDb.conexao);
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
