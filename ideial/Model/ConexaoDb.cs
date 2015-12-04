using System.Data;
using System.Data.OleDb;

namespace DISgrupo1.Ideial.Model.DAO
{
    public class ConexaoDb
    {
        public static OleDbConnection conexao = new OleDbConnection();
        
        public static void AbrirConexao()
        {
            conexao.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbIdeial.mdb";
            conexao.Open();
        }

        public static void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open) //verifica se conexão está aberta
            {
                conexao.Close();
                conexao.Dispose();
            }
        }

        public static void ExecutarComando(string sql)
        {
            if (conexao.State != ConnectionState.Open)  //verifica se conexão não está aberta
            {
                AbrirConexao();
            }

            OleDbCommand comando = new OleDbCommand();  //cria uma nova instância da classe OleDbCommand
            comando.CommandText = sql;  //define a instrução SQL a ser executada
            comando.Connection = conexao;   //define a conexão usada para a instância do OleDbCommand

            //Executa a instrução SQL e retorna o número de linhas afetadas
            int registos = comando.ExecuteNonQuery();
        }

        public static OleDbDataReader SelecionarRegistos(string sql)
        {
            if (conexao.State != ConnectionState.Open)
            {
                AbrirConexao();
            }

            OleDbCommand comando = new OleDbCommand();
            comando.CommandText = sql;
            comando.Connection = conexao;

            //Envia o comando para a conexão e cria um OleDbDataReader
            OleDbDataReader reader = comando.ExecuteReader();

            return reader;
        }
    }
}
