using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ideial.Model.DAO;
using ideial.Model.Entity;

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
    }    
}
