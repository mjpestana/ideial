using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ideial.Model.Entity
{
    public class Feed
    {
        public Dictionary<string, int> FeedCompleto;
        
        public Feed(Dictionary<string, int> lista)
        {
            FeedCompleto = lista;
        }
    }
}
