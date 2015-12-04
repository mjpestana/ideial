namespace DISgrupo1.Ideial.Model.Entity
{
    public class Conta
    {
        //Atributos da classe Conta
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }

        //Construtor
        public Conta(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
    }
}
