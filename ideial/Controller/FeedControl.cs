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

        public static Dictionary<int, DateTime> SelecionarIdeias()
        {
            Dictionary<int, DateTime> listaIdeias = new Dictionary<int, DateTime>();
            MySqlDataReader row = FeedDAO.SelecionarIdeias();
            
            while (row.Read())
            {
                listaIdeias.Add(Convert.ToInt32(row["ID"].ToString()), Convert.ToDateTime(row["data"].ToString()));
            }

            return listaIdeias;
        }

        public static Dictionary<int, DateTime> SelecionarCampanhas()
        {
            Dictionary<int, DateTime> listaCampanhas = new Dictionary<int, DateTime>();
            MySqlDataReader row = FeedDAO.SelecionarCampanhas();

            while (row.Read())
            {
                listaCampanhas.Add(Convert.ToInt32(row["ID"].ToString()), Convert.ToDateTime(row["data"].ToString()));
            }

            return listaCampanhas;
        }

        public static Dictionary<string, int> GerarFeed(Dictionary<int, DateTime> li, Dictionary<int, DateTime> lc)
        {
            var listaCampanhas = lc;
            var listaIdeias = li;
            var listaGeral = new Dictionary<string, int>();
            Dictionary<int, DateTime> list1;
            Dictionary<int, DateTime> list2;
            string type1;
            string type2;

            var result = DateTime.Compare(listaIdeias.Values.ElementAt(0), listaCampanhas.Values.ElementAt(0));

            if (result < 0)
            {
                list1 = li;
                type1="ideia";
                list2 = lc;
                type2 = "campanha";
            }
            else
            {
                list1 = lc;
                type1 = "campanha";
                list2 = li;
                type2 = "ideia";
            }

            foreach (var pair in list1)
            {
                var list1Key = pair.Key;
                var list1Date = pair.Value;

                foreach (var pair2 in list2)
                {
                    var list2Key = pair2.Key;
                    var list2Date = pair2.Value;
                    var compare = DateTime.Compare(list2Date, list1Date);

                    if (compare < 0)
                    {
                        if (!listaGeral.ContainsKey(type2 + list2Key))
                        {
                            listaGeral.Add(type2 + list2Key, list2Key);
                        }
                    }
                    else
                    {
                        if (!listaGeral.ContainsKey(type1 + list1Key))
                        {
                            listaGeral.Add(type1 + list1Key, list1Key);
                        }
                    }
                }

                //check if there is some in list1 with date after the latest added
                
                /*var compareLast = DateTime.Compare(list1Date, list2.Values.ElementAt(list2.Count - 1));
                    if (compareLast > 0 && !listaGeral.ContainsKey(type1 + list1Key))
                    {
                        listaGeral.Add(type1 + list1Key, list1Key);
                    }*/
                }
            foreach (var p in list1)
            {
                var lst1Key = p.Key;
                var lst1Date = p.Value;

                if (!listaGeral.ContainsKey(type1 + lst1Key))
                {
                    listaGeral.Add(type1 + lst1Key, lst1Key);
                }
            }
            foreach (var pair2 in list2)
            {
                var list2Key = pair2.Key;
                var list2Date = pair2.Value;
                if (!listaGeral.ContainsKey(type2 + list2Key))
                {
                    listaGeral.Add(type2 + list2Key, list2Key);
                }
            }
            return listaGeral;
        }

        public static Dictionary<int, DateTime> SelecionarIdeiasUtiliz(int id)
        {
            Dictionary<int, DateTime> listaIdeias = new Dictionary<int, DateTime>();
            
            MySqlDataReader row = FeedDAO.SelecionarIdeiasUtiliz(id);

            while (row.Read())
            {
                listaIdeias.Add(Convert.ToInt32(row["ID"].ToString()), Convert.ToDateTime(row["data"].ToString()));
            }

            return listaIdeias;
        }

        public static Dictionary<int, DateTime> SelecionarCampanhasUtiliz()
        {
            Dictionary<int, DateTime> listaCampanhas = new Dictionary<int, DateTime>();
            
            MySqlDataReader row = FeedDAO.SelecionarCampanhasUtiliz(UserLogged.IdUtilizador);

            while (row.Read())
            {
                listaCampanhas.Add(Convert.ToInt32(row["ID"].ToString()), Convert.ToDateTime(row["data"].ToString()));
            }

            return listaCampanhas;
        }

        public static List<int> SelecionarIdeiasDaCampanha(int id)
        {
            List<int> listaIdeiasCamp = new List<int>();

            MySqlDataReader row = FeedDAO.SelecionarIdeiasDaCampanha(id);

            while (row.Read())
            {
                listaIdeiasCamp.Add(Convert.ToInt32(row["ID"].ToString()));
            }

            return listaIdeiasCamp;
        }

        public static List<int> SelecionarTodosUtilizadores()
        {
            List<int> listaUtilizadores = new List<int>();

            MySqlDataReader row = FeedDAO.SelecionarTodosUtilizadores();

            while (row.Read())
            {
                listaUtilizadores.Add(Convert.ToInt32(row["ID"].ToString()));
            }

            return listaUtilizadores;
        }
    }

}
