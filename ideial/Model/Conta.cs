namespace DISgrupo1.Ideial.Model.Entity
{
    public class Conta
    {
        //Atributos da classe Conta
        public int Id { get; protected set; }
        public string UserName { get; protected set; }
        public string Password { get; protected set; }

        //Construtor
        public Conta(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public Conta(int userID, string userName, string password)
        {
            this.Id = userID;
            this.UserName = userName;
            this.Password = password;
        }

    }
}
