namespace DISgrupo1.Ideial.Model.DAO
{
    class UtilizadorDAO
    {
        /*
        OleDbConnection conexao;
        OleDbCommand comando;

        public void criarConexao()
        {
            conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbIdeial.mdb");
            comando = conexao.CreateCommand();
        }
        */

        /*
        //Registar utilizador
        //public void criarUtilizador(Utilizador u)
        public void criarUtilizador(Conta c)
        {
            try
            {
                criarConexao();

                //comando.CommandText = "INSERT INTO utilizador (nome, email) VALUES('" + u.Nome + "', '" + u.Email + "')";
                comando.CommandText = "INSERT INTO conta (userName, password) VALUES ('@userName', '@password')";

                //Parâmetros
                comando.Parameters.AddWithValue("@userName", c.UserName);
                comando.Parameters.AddWithValue("@password", c.Password);

                comando.CommandType = CommandType.Text;
                conexao.Open();

                comando.ExecuteNonQuery();  //executa string SQL
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        

        //Verificação de credencias
        public bool  Login(Conta c)
        //public bool  Login(Utilizador u)
        {
            try
            {
                criarConexao();

                //comando.CommandText = "SELECT userName, password FROM conta WHERE userName = '" + u.UserName + "' AND password= '" + u.Password + "'";

                comando.CommandText = "SELECT userName, password FROM conta WHERE userName = @userName AND password = @password";

                //Parâmetros
                comando.Parameters.AddWithValue("@userName", c.UserName);
                comando.Parameters.AddWithValue("@password", c.Password);

                comando.CommandType = CommandType.Text;
                conexao.Open();

                OleDbDataReader reader = comando.ExecuteReader();   //executa string SQL

                while (reader.Read())   //se encontrar na db, retorna true
                {
                    return true;
                }
                return false;
            }
            catch (System.Exception)
            {
                throw;
            }

        }
        */
    }
}
