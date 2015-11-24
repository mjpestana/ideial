using DISgrupo1.Ideial.Db;
using DISgrupo1.Ideial.Utilizadores;

namespace DISgrupo1.Ideial.Teste
{
    class TesteUtilizadorDAO
    {
        public void testeCriarUtilizador()
        {
            UtilizadorDAO uDAO;

            Utilizador u = new Colaborador();
            u.Nome = "Mais Um Nome";
            u.Email = "Mais Um Email";

            uDAO = new UtilizadorDAO();
            uDAO.criarUtilizador(u);
        }
    }
}
