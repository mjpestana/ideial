using ideial.Model.DAO;
using ideial.Model.Entity;

namespace ideial.Controller
{
    class ContaControl
    {

        public static bool EfetuarLogin(string user, string pass)
        {
            Conta conta = new Conta(user, pass);
            ContaDAO contaDAO = new ContaDAO();
            int contaID = contaDAO.VerificarCredencialDb(conta);  //Retorna ID da Conta se credencial for válida

            if (contaID != 0)
            {
                Conta contaLogged = new Conta(contaID, user, pass);
                return true;
            }

            return false;
        }

    }
}
