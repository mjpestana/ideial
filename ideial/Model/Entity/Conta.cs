namespace ideial.Model.Entity
{
    public class Conta
    {
        //Atributos da classe Conta
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        //Construtor
        public Conta(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public Conta(int Id, string userName, string password)
        {
            this.Id = Id;
            this.UserName = userName;
            this.Password = password;
        }

    }
}
