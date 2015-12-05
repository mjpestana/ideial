namespace DISgrupo1.Ideial.Model.Entity
{
    public abstract class Funcionario : Utilizador
    {
        //Atributos da classe Funcionario
        public string Departamento { get; protected set; }
        public string Cargo { get; protected set; }

    }
}
