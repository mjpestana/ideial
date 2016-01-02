using System;
using System.Collections.Generic;

namespace ideial.Model.Entity
{
    public class Campanha_old
    {

        public ConcreteGestor Autor { get; set; }   //declaração do atributo autor do tipo gestor
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public List<Ideia> Ideias { get; set; }    //declaração do atributo ideias do tipo List<ideia>
        public List<Utilizador> Subscricoes { get; set; }   //declaração do atributo subscricoes do tipo List<utilizador> 

    }
}
