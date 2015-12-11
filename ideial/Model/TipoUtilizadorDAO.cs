using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Model.DAO
{
    class TipoUtilizadorDAO
    {

        public DataTable SelecionarTodos()
        {
            try
            {

                MySqlDataAdapter cc;

                DataSet TipoUtilizador_ds = new DataSet();
                ConexaoDb.FecharConexao();

                string sql = "SELECT * FROM tipoutilizador";
                cc = new MySqlDataAdapter(sql, ConexaoDb.conexao);
                cc.Fill(TipoUtilizador_ds, "TipoUtilizador_dt");
                return TipoUtilizador_ds.Tables["TipoUtilizador_dt"];    


            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
