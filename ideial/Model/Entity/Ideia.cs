using System;

namespace ideial.Model.Entity
{
    public class Ideia
    {
        //Atributos da classe Ideia
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int IdUtilizador { get; set; }
        public string Data { get; set; }
        public int IdEstado { get; set; }
        public string Tags { get; set; }
        public int IdCampanha { get; set; }

        public Ideia(string titulo, string descricao, int id_utilizador, string data, int id_estado, string tags, int id_campanha)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.IdUtilizador = id_utilizador;
            this.Data = data;
            this.IdEstado = id_estado;
            this.Tags = tags;
            this.IdCampanha = id_campanha;
        }
    }
}
