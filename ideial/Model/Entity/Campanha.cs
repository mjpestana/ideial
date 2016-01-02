namespace ideial.Model.Entity
{
    public class Campanha
    {
        //Atributos da classe Ideia
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int IdUtilizador { get; set; }
        public string Data { get; set; }

        public Campanha(string nome, string descricao, int id_utilizador, string data)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.IdUtilizador = id_utilizador;
            this.Data = data;
        }
    }
}
