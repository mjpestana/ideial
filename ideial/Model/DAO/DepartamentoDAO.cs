using System.Data;
using MySql.Data.MySqlClient;

namespace ideial.Model.DAO
{
    class DepartamentoDAO
    {

        public DataTable SelecionarTodos()
        {

            try
            {
                MySqlDataAdapter cc;

                DataSet Departamento_ds = new DataSet();

                ConexaoDb conDb = ConexaoDb.GetConexaoDb();
                conDb.FecharConexao();

                string sql = "SELECT * FROM departamento";
                cc = new MySqlDataAdapter(sql, ConexaoDb.conexaoString);
                cc.Fill(Departamento_ds, "Departamento_dt");

                return Departamento_ds.Tables["Departamento_dt"];
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
