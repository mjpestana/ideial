using ideial.Model.Entity;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;

namespace ideial.Model.DAO
{
    class ClassificacaoIdeiaDAO
    {
        public void ClassificarIdeia(ClassificacaoIdeia c)
        {
            try
            {
                ConexaoDb.ExecutarComando("INSERT INTO classificacao (id_ideia, id_utilizador, classificacao) VALUES ('" + c.IdIdeia + "', '" + c.IdUtilizador + "', '" + c.Classificacao + "')");

                MessageBox.Show(@"Ideia classificada com sucesso!", @"Ideial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException msg)
            {
                MessageBox.Show(@"Erro: " + msg.Message);
            }
        }

        public MySqlDataReader SelecionarClassifId(int idId, int idUti)
        {
            try
            {
                var reader = ConexaoDb.SelecionarRegistos("SELECT * FROM classificacao WHERE id_ideia = '" + idId + "' AND id_utilizador = '" + idUti + "'");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void AtualizarClassificacao(int id, int classif)
        {
            try
            {
                //Prepara string para atualizar dados da tabela 
                string sql = "UPDATE classificacao SET classificacao = '" + classif + "' WHERE ID = '" + id + "'";

                ConexaoDb.AbrirConexao();

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = ConexaoDb.conexao;

                //Executa comando e cria um DataReader
                comando.ExecuteReader();

                MessageBox.Show("Classificação atualizada com sucesso!", "Ideial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException msg)
            {
                MessageBox.Show("Erro: " + msg.Message);
            }
        }
    }
}
