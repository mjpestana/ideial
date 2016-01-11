namespace ideial.Model.Entity
{
    public abstract class Utilizador
    {
        //Atributos da classe Utilizador
        public int Id { get; set; }
        public int IdConta { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public byte[] Foto { get; set; }
        public string TipoUtilizador { get; set; }
        public int Visitas { get; set; }
        public int Pontuacao { get; set; }

    }
}
