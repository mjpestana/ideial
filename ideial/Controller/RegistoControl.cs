using DISgrupo1.Ideial.Model.DAO;
using DISgrupo1.Ideial.Model.Entity;

namespace DISgrupo1.Ideial.Controller
{
    public class RegistoControl
    {
        public static bool EfetuarLogin(string user, string pass)
        {
            Conta conta = new Conta(user, pass);
            ContaDAO contaDAO = new ContaDAO();
            bool result = contaDAO.VerificarCredencialDb(conta);  //Chama método para verificar credenciais na DB

            return result;
        }

        public static void CriarUtilizador(string user, string pass)
        {
            Conta conta = new Conta(user, pass);
            ContaDAO contaDAO = new ContaDAO();
            contaDAO.InserirUtilizadorDb(conta);    //Chama método para guardar Utilizador na DB
        }
    }
}
