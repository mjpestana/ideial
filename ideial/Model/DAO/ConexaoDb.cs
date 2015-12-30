﻿using System.Data;
using MySql.Data.MySqlClient;

namespace ideial.Model.DAO
{
    public class ConexaoDb
    {
        public static MySqlConnection conexao = new MySqlConnection();

        public static void AbrirConexao()
        {
            FecharConexao();    //fecha conexão caso ainda esteja aberta

            conexao.ConnectionString = "Server=127.0.0.1; Database=dbIdeial; User=ideial; Password=huqXfzsVXssTUhQJ;";
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

        public static long ExecutarComando(string sql)
        {
            AbrirConexao();

            MySqlCommand comando = new MySqlCommand();  //cria uma nova instância da classe OleDbCommand
            comando.CommandText = sql;  //define a instrução SQL a ser executada
            comando.Connection = conexao;   //define a conexão usada para a instância do OleDbCommand

            //Executa a instrução SQL e retorna o número de linhas afetadas
            int registos = comando.ExecuteNonQuery();

            long id = comando.LastInsertedId;

            return id;  //retorna o id do último registo inserido na Db
        }

        public static MySqlDataReader SelecionarRegistos(string sql)
        {
            AbrirConexao();

            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = sql;
            comando.Connection = conexao;

            //Executa comando e cria um DataReader
            MySqlDataReader reader = comando.ExecuteReader();

            return reader;
        }
    }
}
