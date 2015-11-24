using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISgrupo1.Ideial.Utilizadores;

namespace DISgrupo1.Ideial.Ideia
{
    public class Campanha : ISubscricaoCampanha
    {

        public Gestor Autor { get; set; }   //declaração do atributo autor do tipo gestor
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public List<Ideia> Ideias { get; set; }    //declaração do atributo ideias do tipo List<ideia>
        public List<Utilizador> Subscricoes { get; set; }   //declaração do atributo subscricoes do tipo List<utilizador> 

        //Implementa o método Subscrever da interface ISubscricaoCampanha
        public void Subscrever()
        {
            
        }
    }
}
