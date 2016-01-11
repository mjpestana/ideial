using ideial.Model.Entity;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;

namespace ideial.Model.DAO
{
    class IdeiaDAO
    {
        public void inserirIdeia(Ideia i)
        {
            try
            {
                ConexaoDb.ExecutarComando("INSERT INTO ideia (titulo, descricao, id_utilizador, data, id_estado, tags, id_campanha) VALUES ('" + i.Titulo + "', '" + i.Descricao + "', '" + i.IdUtilizador + "', '" + i.Data + "', '" + i.IdEstado + "', '" + i.Tags + "', '" + i.IdCampanha + "')");

                MessageBox.Show("Registo inserido com sucesso!", "Ideial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException msg)
            {
                MessageBox.Show("Erro: " + msg.Message);
            }
        }

        public MySqlDataReader SelecionarIdeiaId(int id)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM ideia WHERE ID = '" + id + "'");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void AtualizarEstadoIdeia(int id, int estado)
        {
            try
            {
                //Prepara string para atualizar dados da tabela 
                string sql = "UPDATE ideia SET id_estado = '" + estado + "' WHERE ID = '" + id + "'";

                ConexaoDb conDb = ConexaoDb.GetConexaoDb();
                conDb.AbrirConexao();

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = ConexaoDb.conexaoString;

                //Executa comando e cria um DataReader
                comando.ExecuteReader();
                if (estado == 2)
                {
                    MessageBox.Show("A ideia é agora pública!", "Ideial", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A ideia é agora oculta!", "Ideial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (MySqlException msg)
            {
                MessageBox.Show("Erro: " + msg.Message);
            }
        }
    }
}
