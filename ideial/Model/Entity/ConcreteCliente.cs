namespace ideial.Model.Entity
{
    public class ConcreteCliente : Utilizador
    {
        //ConcreteGestor herda as propriedades de Utilizador

        public ConcreteCliente(int idConta, string nome, string email, string foto, string tipoUtilizador)
        {
            this.IdConta = idConta;
            this.Nome = nome;
            this.Email = email;
            this.Foto = foto;
            this.TipoUtilizador = tipoUtilizador;

            //Console.WriteLine("Nome:{0} - Tipo Utilizador:{1}", this.Nome, this.TipoUtilizador);
        }
    }
}
