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
    }
}
