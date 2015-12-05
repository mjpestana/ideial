using DISgrupo1.Ideial.Model.DAO;
using DISgrupo1.Ideial.Model.Entity;

namespace DISgrupo1.Ideial.Controller
{
    public class UtilizadorControl
    {
        public static bool EfetuarLogin(string user, string pass)
        {
            Conta conta = new Conta(user, pass);
            ContaDAO contaDAO = new ContaDAO();
            bool result = contaDAO.VerificarCredencialDb(conta);  //Chama método para verificar credenciais na DB

            return result;
        }

        public static void CriarUtilizador(string user, string pass, string nome, string email, string tipo)
        {
            Conta conta = new Conta(user, pass);
            ContaDAO contaDAO = new ContaDAO();

            switch (tipo)
            {
                case "Colaborador":
                    Colaborador colaborador = new Colaborador(nome, email);
                    contaDAO.InserirUtilizadorDb(conta, colaborador);    //Chama método para guardar Utilizador na DB
                    break;

                case "Gestor":
                    break;

                case "Fornecedor":
                    break;

                case "Cliente":
                    break;

                default:
                    break;
            }
        }

    }
}
