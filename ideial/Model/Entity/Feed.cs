using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ideial.Model.Entity
{
    public class Feed
    {
        public Dictionary<int, string> FeedCompleto;
        
        public Feed(Dictionary<int, string> lista)
        {
            FeedCompleto = lista;
        }
    }
}
