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
    class FeedControl
    {
        private Feed _feed;

        public Dictionary<int, DateTime> SelecionarIdeias()
        {
            Dictionary<int, DateTime> listaIdeias = new Dictionary<int, DateTime>();
            MySqlDataReader row = FeedDAO.SelecionarIdeias();

            while (row.Read())
            {
                listaIdeias.Add(Convert.ToInt32(row["ID"].ToString()), Convert.ToDateTime(row["data"].ToString()));
            }

            return listaIdeias;
        }

        public Dictionary<int, DateTime> SelecionarCampanhas()
        {
            Dictionary<int, DateTime> listaCampanhas = new Dictionary<int, DateTime>();
            MySqlDataReader row = FeedDAO.SelecionarCampanhas();

            while (row.Read())
            {
                listaCampanhas.Add(Convert.ToInt32(row["ID"].ToString()), Convert.ToDateTime(row["data"].ToString()));
            }

            return listaCampanhas;
        }

        public Feed GerarFeed(Dictionary<int, DateTime> li, Dictionary<int, DateTime> lc)
        {
            var listaCampanhas = lc;
            var listaIdeias = li;
            var listaGeral = new Dictionary<int, string>();

            foreach (var pair in listaCampanhas)
            {
                var campKey = pair.Key;
                var campDate = pair.Value;
                var added = false;

                foreach (var pair2 in listaIdeias)
                {
                    var ideiaKey = pair.Key;
                    var ideiaDate = pair.Value;

                    if (ideiaDate > campDate)
                    {
                        listaGeral.Add(ideiaKey, "ideia");
                        added = true;
                    }
                    else
                    {
                        if (!added)
                        {
                            listaGeral.Add(campKey, "campanha");
                            added = true;
                        }
                    }
                }

            }
            var feedGeral = new Feed(listaGeral);
            return feedGeral;
        }
    }

}
