using System;
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
                        return -1;  //retorna -1 se TipoUtilizador não especificado
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} : Erro ao tentar inserir o registo", e);
                return -1;
            }
        }

        public MySqlDataReader SelecionarUtilizadorIdConta(int idCconta)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM utilizador WHERE id_conta = '" + idCconta + "'");

                //if (reader.Read())
                //{
                    return reader;
                //}

                //return null;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
