using MySql.Data.MySqlClient;
using System;

using ideial.Model.DAO;
using ideial.Model.Entity;

namespace ideial.Controller
{
    class CampanhaControl
    {
        private Campanha campanha;

        public static void CriarCampanha(string nome, string descricao, int id_utilizador, string data)
        {
            //Cria instância de Campanha
            Campanha campanha = new Campanha(nome, descricao, id_utilizador, data);

            //Instância CampanhaDAO e chama método para guardar Ideia na DB
            CampanhaDAO campanhaDAO = new CampanhaDAO();
            campanhaDAO.InserirCampanha(campanha);
        }

        public Campanha SelecionarCampanhaId(int id)
        {
            CampanhaDAO campanhaDAO = new CampanhaDAO();

            //Chama o método para selecionar Campanha por Id
            MySqlDataReader row = campanhaDAO.SelecionarCampanhaId(id);

            while (row.Read())
            {
                string nome = row["nome"].ToString();
                string descricao = row["descricao"].ToString();
                int id_utilizador = Convert.ToInt32(row["id_utilizador"].ToString());
                string data = row["data"].ToString();

                campanha = new Campanha(nome, descricao, id_utilizador, data);
            }            

            return campanha;
        }

        public int SelecionarTotalIdeias(int id)
        {
            var ideiasCamp = new CampanhaDAO();
            var row = ideiasCamp.SelecionarTotalIdeias(id);
            var totalIdeias = 0;
            while (row.Read())
            {
                totalIdeias ++;
            }
            return totalIdeias;
        }
    }
}
