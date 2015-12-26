namespace ideial.Model.Entity
{
    public class ConcreteGestor : Utilizador
    {
        //ConcreteGestor herda as propriedades de Utilizador
        public int IdCargo { get; set; }
        public int IdDepartamento { get; set; }

        public ConcreteGestor(int idConta, string nome, string email, string foto, string tipoUtilizador, int idCargo, int idDepartamento)
        {
            this.IdConta = idConta;
            this.Nome = nome;
            this.Email = email;
            this.Foto = foto;
            this.TipoUtilizador = tipoUtilizador;
            this.IdCargo = idCargo;
            this.IdDepartamento = idDepartamento;

            //Console.WriteLine("Nome:{0} - Tipo Utilizador:{1}", this.Nome, this.TipoUtilizador);
        }
    }
}
