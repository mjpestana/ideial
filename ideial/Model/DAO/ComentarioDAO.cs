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
    }
}
