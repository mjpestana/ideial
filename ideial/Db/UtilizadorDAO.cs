using System.Data;
using System.Data.OleDb;

using DISgrupo1.Ideial.Utilizadores;

namespace DISgrupo1.Ideial.Db
{
    class UtilizadorDAO
    {
        OleDbConnection conexao;
        OleDbCommand comando;

        private void criarConexao()
        {
            conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbIdeial.mdb");
            comando = conexao.CreateCommand();
        }

        public void criarUtilizador(Utilizador u)
        {
            try
            {
                criarConexao();

                comando.CommandText = "INSERT INTO utilizador (nome, email) VALUES('" + u.Nome + "', '" + u.Email + "')";
                comando.CommandType = CommandType.Text;
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
