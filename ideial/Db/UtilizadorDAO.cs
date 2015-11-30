using System;
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

                comando.CommandText = "INSERT INTO utilizador (nome, email, userName, password) VALUES('" + u.Nome + "', '" + u.Email + "', '" + u.userName + "'," + u.password + "')";
                comando.CommandType = CommandType.Text;
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                throw;
            }
        }


        public bool  Login(Utilizador u)
        {
            try
            {
                criarConexao();

             

                comando.CommandText = "SELECT userName, password FROM utilizador WHERE userName = '" + u.userName + "' AND password= '"+ u.password +"'";
                comando.CommandType = CommandType.Text;
                conexao.Open();

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    string jj = reader["userName"].ToString();

                    return true;

                }


                return false;

            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
