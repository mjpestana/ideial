using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using ideial.Model.Entity;

namespace ideial.Model.DAO
{
    class UtilizadorDAO
    {
        public long InserirUtilizador(Utilizador u)
        {
            try
            {
                switch (u.TipoUtilizador)
                {
                    case "Cliente":
                        ConcreteCliente cliente = (ConcreteCliente)u;   //conversão Utilizador -> ConcreteCliente
                        return ConexaoDb.ExecutarComando("INSERT INTO utilizador (id_conta, nome, email, foto, tipoutilizador) VALUES('" + cliente.IdConta + "', '" + cliente.Nome + "', '" + cliente.Email + "', '" + cliente.Foto + "', '" + cliente.TipoUtilizador + "' )");
                    case "Colaborador":
                        ConcreteColaborador colaborador = (ConcreteColaborador)u;   //conversão Utilizador -> ConcreteColaborador
                        return ConexaoDb.ExecutarComando("INSERT INTO utilizador (id_conta, nome, email, foto, tipoutilizador, id_cargo, id_departamento) VALUES('" + colaborador.IdConta + "', '" + colaborador.Nome + "', '" + colaborador.Email + "', '" + colaborador.Foto + "', '" + colaborador.TipoUtilizador + "', '" + colaborador.IdCargo + "', '" + colaborador.IdDepartamento + "' )");
                    case "Fornecedor":
                        ConcreteFornecedor fornecedor = (ConcreteFornecedor)u;   //conversão Utilizador -> ConcreteFornecedor
                        return ConexaoDb.ExecutarComando("INSERT INTO utilizador (id_conta, nome, email, foto, tipoutilizador, id_empresa) VALUES('" + fornecedor.IdConta + "', '" + fornecedor.Nome + "', '" + fornecedor.Email + "', '" + fornecedor.Foto + "', '" + fornecedor.TipoUtilizador + "', '" + fornecedor.IdEmpresa + "' )");
                    case "Gestor":
                        ConcreteGestor gestor = (ConcreteGestor)u;   //conversão Utilizador -> ConcreteGestor
                        return ConexaoDb.ExecutarComando("INSERT INTO utilizador (id_conta, nome, email, foto, tipoutilizador, id_cargo, id_departamento) VALUES('" + gestor.IdConta + "', '" + gestor.Nome + "', '" + gestor.Email + "', '" + gestor.Foto + "', '" + gestor.TipoUtilizador + "', '" + gestor.IdCargo + "', '" + gestor.IdDepartamento + "' )");
                    default:
                        return 0;  //retorna 0 se TipoUtilizador não especificado
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} : Erro ao tentar inserir o registo", e);
                return 0;
            }
        }

        public MySqlDataReader SelecionarUtilizadorIdConta(int idCconta)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM utilizador WHERE id_conta = '" + idCconta + "'");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public MySqlDataReader SelecionarUtilizadorId(int id)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM utilizador WHERE ID = '" + id + "'");
                
                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        
        public void AtualizarUtilizador(int idUtilizador, string nome, string email, int idCargo, int idDepartamento, int idEmpresa)
        {
            try
            {
                //Prepara string para atualizar dados da tabela 
                string sql = "UPDATE utilizador SET nome = '" + nome + "', email = '" + email + "', id_cargo = '" + idCargo + "', id_departamento = '" + idDepartamento + "', id_empresa = '" + idEmpresa + "' WHERE ID = '" + idUtilizador + "'";

                ConexaoDb conDb = ConexaoDb.GetConexaoDb();
                conDb.AbrirConexao();

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = ConexaoDb.conexaoString;

                //Executa comando e cria um DataReader
                comando.ExecuteReader();

                MessageBox.Show("Registo atualizado com sucesso!", "Ideial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException msg)
            {
                MessageBox.Show("Erro: " + msg.Message);
            }
        }

        public static MySqlDataReader SelecionarTotalIdeias(int id)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM ideia WHERE id_utilizador = '" + id + "'");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
