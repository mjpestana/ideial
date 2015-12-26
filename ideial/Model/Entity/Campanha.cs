using System;
using System.Collections.Generic;
using ideial.Controller;

namespace ideial.Model.Entity
{
    public class Campanha : ISubscricaoCampanha
    {

        public ConcreteGestor Autor { get; protected set; }   //declaração do atributo autor do tipo gestor
        public string Titulo { get; protected set; }
        public string Descricao { get; protected set; }
        public DateTime Data { get; protected set; }
        public List<Ideia> Ideias { get; protected set; }    //declaração do atributo ideias do tipo List<ideia>
        public List<Utilizador> Subscricoes { get; protected set; }   //declaração do atributo subscricoes do tipo List<utilizador> 

        //Implementa o método Subscrever da interface ISubscricaoCampanha
        public void Subscrever()
        {

        }
    }
}
