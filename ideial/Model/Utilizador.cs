namespace DISgrupo1.Ideial.Model.Entity
{
    public abstract class Utilizador
    {
        //Atributos da classe Utilizador
        public int Id { get; protected set; }
        public Conta conta { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public string Foto { get; protected set; }
        public int Visitas { get; protected set; }
        public int Pontuacao { get; protected set; }
        public string tipo { get; protected set; }
        public int id_tipo { get; protected set; }
        public int id_departamento { get; protected set; }
        public int id_empresa { get; protected set; }
        public int id_cargo { get; protected set; }

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
