using System;
using System.Collections.Generic;

namespace DISgrupo1.Ideial.Model.Entity
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
