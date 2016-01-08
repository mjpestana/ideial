using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ideial.Model.Entity
{
    class ClassificacaoIdeia
    {
        public int Id { get; set; }
        public int IdIdeia { get; set; }
        public int IdUtilizador { get; set; }
        public int Classificacao { get; set; }


        public ClassificacaoIdeia(int idideia, int idUtiliz, int classif)
        {
            IdIdeia = idideia;
            IdUtilizador = idUtiliz;
            Classificacao = classif;
        }
    }
}
