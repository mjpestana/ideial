namespace DISgrupo1.Ideial.Model.Entity
{
    public class Colaborador : Funcionario
    {
        public Colaborador(string nome, string email, int id_tipo, int id_departamento, int id_cargo)
        {
            this.Nome = nome;
            this.Email = email;
            this.id_tipo = id_tipo;
            this.id_departamento = id_departamento;
            this.id_cargo = id_cargo;

        }
    }
}
