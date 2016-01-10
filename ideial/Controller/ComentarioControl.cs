using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ideial.Model.DAO;
using ideial.Model.Entity;
using MySql.Data.MySqlClient;

namespace ideial.Controller
{
    class ComentarioControl
    {
        private Comentario _comentario;

        public static void InserirComentario(int idideia, int idUtiliz, string cont)
        {
            var coment = new Comentario(idideia, idUtiliz, cont);

            var comentDao = new ComentarioDAO();
            comentDao.InserirComentario(coment);
        }
        
        public Comentario SelecionarComentarioId(int id)
        {
            ComentarioDAO comentDAO = new ComentarioDAO();

            //Chama o método para selecionar Ideia por Id
            MySqlDataReader row = comentDAO.SelecionarComentarioId(id);

            while (row.Read())
            {
                int id_ideia = Convert.ToInt32(row["id_ideia"].ToString());
                int id_utilizador = Convert.ToInt32(row["id_utilizador"].ToString());
                string conteudo = row["conteudo"].ToString();

                _comentario = new Comentario(id_ideia, id_utilizador, conteudo);   
            }

            return _comentario;
        }

        public List<int> SelecionarComentariosDaIdeia(int id)
        {
            List<int> listaComentarios = new List<int>();

            MySqlDataReader row = ComentarioDAO.SelecionarComentariosDaIdeia(id);

            while (row.Read())
            {
                listaComentarios.Add(Convert.ToInt32(row["ID"].ToString()));
            }

            return listaComentarios;
        }
    }    
}
