using DISgrupo1.Ideial.Model.DAO;
using DISgrupo1.Ideial.Model.Entity;
using MySql.Data.MySqlClient;

namespace DISgrupo1.Ideial.Controller
{
    public class UtilizadorControl
    {
        public int userID, visitas, pontuacao, id_tipoUtilizador, id_departamento, id_cargo, id_empresa, id_conta;
        public string nome, email, foto;

        public static void CriarUtilizador(string user, string pass, string nome, string email, string tipo, int id_tipo, int id_departamento, int id_empresa, int id_cargo)
        {
            Conta conta = new Conta(user, pass);
            UtilizadorDAO utilizadorDAO = new UtilizadorDAO();

            switch (tipo)
            {
                case "Colaborador":
                    Colaborador colaborador = new Colaborador(nome, email, id_tipo, id_departamento, id_cargo);
                    utilizadorDAO.InserirUtilizadorDb(conta, colaborador);    //Chama método para guardar Utilizador na DB
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

        public void SelecionarUtilizadorId(int contaID)
        {
            UtilizadorDAO utilizadorDAO = new UtilizadorDAO();
            MySqlDataReader reader = utilizadorDAO.SelecionarUtilizadorIdDb(contaID);

            userID = (int)reader["ID"];
            nome = (string)reader["nome"];
            email = (string)reader["email"];
            visitas = (int)reader["visitas"];
            pontuacao = (int)reader["puntuacao"];
            id_tipoUtilizador = (int)reader["id_tipoUtilizador"];
            id_departamento = (int)reader["id_departamento"];
            id_cargo = (int)reader["id_cargo"];
            id_empresa = (int)reader["id_empresa"];
            id_conta = (int)reader["id_conta"];
            foto = (string)reader["foto"];

            switch (id_tipoUtilizador)
            {
                case 1:
                    break;
                default:
                    break;
            }
        }

    }
}
