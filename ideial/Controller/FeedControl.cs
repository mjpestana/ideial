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
            var list1 = new Dictionary<int,DateTime>();
            var list2 = new Dictionary<int, DateTime>();
            string type1;
            string type2;
            //Console.WriteLine("1ª ideia: " + listaIdeias.Values.ElementAt(0) + "1ª campanha: " + listaCampanhas.Values.ElementAt(0));
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
                var added = false;
                Console.WriteLine("list1Key: " + list1Key + " list1Date: " + list1Date);
                
                foreach (var pair2 in list2)
                {
                    var list2Key = pair2.Key;
                    var list2Date = pair2.Value;
                    var compare = DateTime.Compare(list2Date, list1Date);

                    Console.WriteLine("list2Key: " + list2Key + " list2Date: " + list2Date);
                    if (compare < 0)
                    {
                        if (!listaGeral.ContainsKey(type2 + list2Key))
                        {
                            listaGeral.Add(type2 + list2Key, list2Key);
                            added = true;
                            Console.WriteLine("Added: " + list2Key + "-" + type2);
                        }   
                    }
                    else
                    {
                        if (!added)
                        {
                            if (!listaGeral.ContainsKey(type1 + list1Key))
                            {
                                listaGeral.Add(type1 + list1Key, list1Key);
                                added = true;
                                Console.WriteLine("Added: " + list1Key + "-" + type1);
                            }  
                        }
                    }
                    
                }
                //check if there is some in list 1 with date after the latest added
                var compareLast = DateTime.Compare(list1Date, list2.Values.ElementAt(list2.Count - 1));
                if (compareLast > 0 && !listaGeral.ContainsKey(type1 + list1Key))
                {
                    listaGeral.Add(type1 + list1Key, list1Key);
                    Console.WriteLine("Added: " + list1Key + "-" + type1);
                }
            }
            return listaGeral;
        }
    }

}
