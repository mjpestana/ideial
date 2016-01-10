using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ideial.Model.Entity
{
    class Comentario
    {
        public int Id { get; set; }
        public int IdIdeia { get; set; }
        public int IdUtilizador { get; set; }
        public string Conteudo { get; set; }

        public Comentario(int idideia, int idUtiliz, string cont)
        {
            IdIdeia = idideia;
            IdUtilizador = idUtiliz;
            Conteudo = cont;
        }
    }

    
}
