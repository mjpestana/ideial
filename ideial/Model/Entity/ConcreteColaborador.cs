namespace ideial.Model.Entity
{
    public class ConcreteColaborador : Utilizador
    {
        //ConcreteColaborador herda as propriedades de Utilizador e tem outras propriedades específicas
        public int IdCargo { get; set; }
        public int IdDepartamento { get; set; }

        public ConcreteColaborador(int idConta, string nome, string email, string foto, string tipoUtilizador, int idCargo, int idDepartamento)
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
