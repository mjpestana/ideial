using System.Data;
using MySql.Data.MySqlClient;

namespace ideial.Model.DAO
{
    //Classe Singleton
    public class ConexaoDb
    {
        public static MySqlConnection conexaoString = new MySqlConnection();

        private static ConexaoDb _instance;

        //Construtor Protegido
        protected ConexaoDb()
        {
        }

        public static ConexaoDb GetConexaoDb()
        {
            if (_instance == null)
            {
                _instance = new ConexaoDb();
            }

            return _instance;
        }

        public void AbrirConexao()
        {
            FecharConexao();    //fecha conexão caso ainda esteja aberta

            conexaoString.ConnectionString = "Server=127.0.0.1; Database=dbIdeial; User=ideial; Password=huqXfzsVXssTUhQJ;";
            conexaoString.Open();
        }

        public void FecharConexao()
        {
            if (conexaoString.State == ConnectionState.Open) //verifica se conexão está aberta
            {
                conexaoString.Close();
                conexaoString.Dispose();
            }
        }

        public static long ExecutarComando(string sql)
        {
            ConexaoDb conDb = ConexaoDb.GetConexaoDb();
            conDb.AbrirConexao();

            MySqlCommand comando = new MySqlCommand();  //cria uma nova instância da classe OleDbCommand
            comando.CommandText = sql;  //define a instrução SQL a ser executada
            comando.Connection = conexaoString;   //define a conexão usada para a instância do OleDbCommand

            //Executa a instrução SQL e retorna o número de linhas afetadas
            int registos = comando.ExecuteNonQuery();

            long id = comando.LastInsertedId;

            return id;  //retorna o id do último registo inserido na Db
        }

        public static MySqlDataReader SelecionarRegistos(string sql)
        {
            ConexaoDb conDb = ConexaoDb.GetConexaoDb();
            conDb.AbrirConexao();

            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = sql;
            comando.Connection = conexaoString;

            //Executa comando e cria um DataReader
            MySqlDataReader reader = comando.ExecuteReader();

            return reader;
        }
    }
}
