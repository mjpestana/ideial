namespace ideial.Model.Entity
{
    public class ConcreteFornecedor : Utilizador
    {
        //ConcreteFornecedor herda as propriedades de Utilizador e tem outras propriedades específicas
        public int IdEmpresa { get; set; }

        public ConcreteFornecedor(int idConta, string nome, string email, string foto, string tipoUtilizador, int idEmpresa)
        {
            this.IdConta = idConta;
            this.Nome = nome;
            this.Email = email;
            this.Foto = foto;
            this.TipoUtilizador = tipoUtilizador;
            this.IdEmpresa = idEmpresa;

            //Console.WriteLine("Nome:{0} - Tipo Utilizador:{1}", this.Nome, this.TipoUtilizador);
        }
    }
}
