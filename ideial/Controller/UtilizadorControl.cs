using ideial.Model.DAO;
using ideial.Model.Entity;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace ideial.Controller
{
    public class UtilizadorControl
    {
        public int id_conta, userID, visitas, pontuacao, id_cargo, id_departamento, id_empresa;
        public string nome, email, foto, tipoUtilizador;

        public static void CriarUtilizador(string user, string pass, string nome, string email, string foto, string tipo, int id_cargo, int id_departamento, int id_empresa)
        {
            //Instância Conta
            Conta c = new Conta(user, pass);

            //Insere Conta na Db e retorna IdConta
            ContaDAO contaDAO = new ContaDAO();
            int contaId = (int)contaDAO.InserirConta(c);

            //Instância Utilizador
            FactoryUtilizador utilizador = new FactoryUtilizador();
            Utilizador u = utilizador.getUtilizadorObj(contaId, nome, email, foto, tipo, id_cargo, id_departamento, id_empresa);
            
            //Instância UtilizadorDAO e chama método para guardar Utilizador na DB e retorna IdConta
            UtilizadorDAO utilizadorDAO = new UtilizadorDAO();
            int userId = (int)utilizadorDAO.InserirUtilizador(u);

            if (userId > 0)
            {
                MessageBox.Show("Registo inserido com sucesso!", "Ideial", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um problema ao inserir o registo!", "Ideial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
        public static void AtualizarUtilizador(string user, string pass, int idUtilizador, string nome, string email, int idCargo, int idDepartamento, int idEmpresa)
        {
            if (pass != "")
            {
                //Instância Conta
                Conta c = new Conta(user, pass);

                //Atualiza Conta na Db
                ContaDAO contaDAO = new ContaDAO();
                contaDAO.AtualizarConta(c);
            }
            
        }
        */

        /*
        public void SelecionarUtilizadorId(int contaID)
        {
            UtilizadorDAO utilizadorDAO = new UtilizadorDAO();
            MySqlDataReader reader = utilizadorDAO.SelecionarUtilizadorIdConta(contaID);

            userID = (int)reader["ID"];
            nome = (string)reader["nome"];
            email = (string)reader["email"];
            foto = (string)reader["foto"];
            visitas = (int)reader["visitas"];
            pontuacao = (int)reader["puntuacao"];
            //id_tipoUtilizador = (int)reader["id_tipoUtilizador"];
            tipoUtilizador = (string)reader["tipoUtilizador"];
            id_departamento = (int)reader["id_departamento"];
            id_cargo = (int)reader["id_cargo"];
            id_empresa = (int)reader["id_empresa"];
            id_conta = (int)reader["id_conta"];

            
            switch (id_tipoUtilizador)
            {
                case 1:
                    break;
                default:
                    break;
            }
          
        }
        */

    }
}
