using MySql.Data.MySqlClient;
using System.Windows.Forms;

using ideial.Model.Entity;
using System;

namespace ideial.Model.DAO
{
    class CampanhaDAO
    {
        public void InserirCampanha(Campanha c)
        {
            try
            {
                ConexaoDb.ExecutarComando("INSERT INTO campanha (nome, descricao, id_utilizador, data) VALUES ('" + c.Nome + "', '" + c.Descricao + "', '" + c.IdUtilizador + "', '" + c.Data + "')");

                MessageBox.Show("Registo inserido com sucesso!", "Ideial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException msg)
            {
                MessageBox.Show("Erro: " + msg.Message);
            }
        }

        public MySqlDataReader SelecionarCampanhaId(int id)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM campanha WHERE ID = '" + id + "'");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public MySqlDataReader SelecionarTotalIdeiasCamp(int id)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT ID FROM ideia WHERE id_campanha = '" + id + "'");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
