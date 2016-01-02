using MySql.Data.MySqlClient;

using ideial.Model.DAO;
using ideial.Model.Entity;
using System;

namespace ideial.Controller
{
    class IdeiaControl
    {
        private Ideia ideia;

        public static void CriarIdeia(string titulo, string descricao, int id_utilizador, string data, int id_estado, string tags, int id_campanha)
        {
            //Cria instância de Ideia
            Ideia ideia = new Ideia(titulo, descricao, id_utilizador, data, id_estado, tags, id_campanha);

            //Instância IdeiaDAO e chama método para guardar Ideia na DB
            IdeiaDAO ideiaDAO = new IdeiaDAO();
            ideiaDAO.inserirIdeia(ideia);
        }

        public Ideia SelecionarIdeiaId(int id)
        {
            IdeiaDAO ideiaDAO = new IdeiaDAO();

            //Chama o método para selecionar Ideia por Id
            MySqlDataReader row = ideiaDAO.SelecionarIdeiaId(id);

            while (row.Read())
            {
                string titulo = row["titulo"].ToString();
                string descricao = row["descricao"].ToString();
                int id_utilizador = Convert.ToInt32(row["id_utilizador"].ToString());
                string data = row["data"].ToString();
                int id_estado = Convert.ToInt32(row["id_estado"].ToString());
                string tags = row["tags"].ToString();
                int id_campanha = Convert.ToInt32(row["id_campanha"].ToString());

                ideia = new Ideia(titulo, descricao, id_utilizador, data, id_estado, tags, id_campanha);
            }

            return ideia;
        }
    }
}
