using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ideial.Model.Entity;
using MySql.Data.MySqlClient;

namespace ideial.Model.DAO
{
    class ComentarioDAO
    {
        public void InserirComentario(Comentario c)
        {
            try
            {
                ConexaoDb.ExecutarComando("INSERT INTO comentario (id_ideia, id_utilizador, conteudo) VALUES ('" + c.IdIdeia + "', '" + c.IdUtilizador + "', '" + c.Conteudo + "')");

                MessageBox.Show(@"Comentário inserido com sucesso!", @"Ideial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException msg)
            {
                MessageBox.Show(@"Erro: " + msg.Message);
            }
        }

        public MySqlDataReader SelecionarComentarioId(int id)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM comentario WHERE ID = '" + id + "'");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static MySqlDataReader SelecionarComentariosDaIdeia(int id)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT ID FROM comentario WHERE id_ideia = '" + id + "'");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
