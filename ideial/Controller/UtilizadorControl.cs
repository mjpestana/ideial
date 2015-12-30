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

        public static void AtualizarUtilizador(int idConta, string user, string pass, int idUtilizador, string tipoUtilizador, string nome, string email, string foto, int idCargo, int idDepartamento, int idEmpresa)
        {
            if (pass != "")
            {
                //Atualiza Conta na Db
                ContaDAO contaDAO = new ContaDAO();
                contaDAO.AtualizarConta(idConta, pass);
            }

            //Atualiza Utilizador na Db
            UtilizadorDAO utilizadorDAO = new UtilizadorDAO();
            utilizadorDAO.AtualizarUtilizador(idUtilizador, nome, email, idCargo, idDepartamento, idEmpresa);

            //Atualiza os dados do objeto UserLogged
            UserLogged.IdConta = idConta;
            UserLogged.User = user;
            UserLogged.IdUtilizador = idUtilizador;
            UserLogged.NomeUtilizador = nome;
            UserLogged.Email = email;
            UserLogged.Foto = foto;
            UserLogged.TipoUtilizador = tipoUtilizador;
            UserLogged.IdCargo = idCargo;
            UserLogged.IdDepartamento = idDepartamento;
            UserLogged.IdEmpresa = idEmpresa;
        }
        
    }
}
