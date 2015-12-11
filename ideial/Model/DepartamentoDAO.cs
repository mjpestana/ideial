using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Model.DAO
{
    class DepartamentoDAO
    {

        public DataTable SelecionarTodos()
        {

            try
            {
                MySqlDataAdapter cc;

                DataSet Departamento_ds = new DataSet();
                ConexaoDb.FecharConexao();

                string sql = "SELECT * FROM departamento";
                cc = new MySqlDataAdapter(sql, ConexaoDb.conexao);
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
