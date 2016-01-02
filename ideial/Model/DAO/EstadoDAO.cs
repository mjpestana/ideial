using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ideial.Model.DAO
{
    class EstadoDAO
    {
        public DataTable SelecionarTodos()
        {
            try
            {
                MySqlDataAdapter cc;

                DataSet estado_ds = new DataSet();
                ConexaoDb.FecharConexao();

                string sql = "SELECT * FROM estado";
                cc = new MySqlDataAdapter(sql, ConexaoDb.conexao);
                cc.Fill(estado_ds, "estado_dt");
                return estado_ds.Tables["estado_dt"];
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}