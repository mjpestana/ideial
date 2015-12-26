using System;

namespace ideial.Model.Entity
{
    public class FactoryUtilizador
    {
        public Utilizador getUtilizadorObj(int idConta, string nome, string email, string foto, string tipoUtilizador, int idCargo, int idDepartamento, int idEmpresa)
        {
            Utilizador objUtilizador = null;

            switch (tipoUtilizador)
            {
                case "Cliente":
                    objUtilizador = new ConcreteCliente(idConta, nome, email, foto, "Cliente");
                    break;
                case "Colaborador":
                    objUtilizador = new ConcreteColaborador(idConta, nome, email, foto, "Colaborador", idCargo, idDepartamento);
                    break;
                case "Fornecedor":
                    objUtilizador = new ConcreteFornecedor(idConta, nome, email, foto, "Fornecedor", idEmpresa);
                    break;
                case "Gestor":
                    objUtilizador = new ConcreteGestor(idConta, nome, email, foto, "Gestor", idCargo, idDepartamento);
                    break;
                default:
                    Console.WriteLine("Parâmetro tipoUtilizador:{0} incorreto", tipoUtilizador);
                    objUtilizador = null;
                    break;
            }

            return objUtilizador;
        }
    }
}
