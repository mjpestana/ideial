namespace DISgrupo1.Ideial.Model.Entity
{
    public abstract class Utilizador
    {
        //Atributos da classe Utilizador
        public int Id { get; private set; }
        public Conta conta { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Foto { get; private set; }
        public int Visitas { get; private set; }
        public int Pontuacao { get; private set; }

        //Métodos da classe Utilizador
        public void Editar()
        {

        }

        public void Classificar()
        {

        }

        public void Visualizar()
        {

        }

    }
}
