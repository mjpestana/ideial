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
    internal class ClassificacaoIdeiaControl
    {
        private ClassificacaoIdeia _classificacaoIdeia;

        public static void ClassificarIdeia(int idideia, int idUtiliz, int classif)
        {
            var classifIdeia = new ClassificacaoIdeia(idideia, idUtiliz, classif);

            var classifIdeiaDAO = new ClassificacaoIdeiaDAO();
            classifIdeiaDAO.ClassificarIdeia(classifIdeia);
        }

        public ClassificacaoIdeia SelecionarClassif(int idId, int idUti)
        {
            var classifSelec = new ClassificacaoIdeiaDAO();
            var row = classifSelec.SelecionarClassifId(idId, idUti);

            while (row.Read())
            {
                var idideia = Convert.ToInt32(row["id_ideia"]);
                var idUtiliz = Convert.ToInt32(row["id_utilizador"]);
                var classif = Convert.ToInt32(row["classificacao"]);
                _classificacaoIdeia = new ClassificacaoIdeia(idideia, idUtiliz, classif);
            }

            return _classificacaoIdeia;
        }

        public int SelecionarClassifId(int idId, int idUti)
        {
            var classifSelec = new ClassificacaoIdeiaDAO();
            var row = classifSelec.SelecionarClassifId(idId, idUti);

            var idClassif = 0;

            while (row.Read())
            {
                idClassif = Convert.ToInt32(row["ID"]);
            }

            return idClassif;
        }

        public static void AtualizarClassificacao(int id, int classif)
        {
            var classifDAO = new ClassificacaoIdeiaDAO();
            classifDAO.AtualizarClassificacao(id, classif);
        }
    }
}
