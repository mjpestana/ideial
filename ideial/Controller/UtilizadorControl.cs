using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using ideial.Model.Entity;
using ideial.Model.DAO;

namespace ideial.Controller
{
    class UtilizadorControl
    {

        public static void CriarUtilizador(string user, string pass, string nome, string email, string foto, string tipo,
            int id_cargo, int id_departamento, int id_empresa)
        {
            //Instância Conta
            Conta c = new Conta(user, pass);

            //Insere Conta na Db e retorna IdConta
            ContaDAO contaDAO = new ContaDAO();
            int contaId = (int) contaDAO.InserirConta(c);

            //Instância Utilizador
            FactoryUtilizador utilizador = new FactoryUtilizador();
            Utilizador u = utilizador.getUtilizadorObj(contaId, nome, email, foto, tipo, id_cargo, id_departamento,
                id_empresa);

            //Instância UtilizadorDAO e chama método para guardar Utilizador na DB e retorna IdConta
            UtilizadorDAO utilizadorDAO = new UtilizadorDAO();
            int userId = (int) utilizadorDAO.InserirUtilizador(u);

            if (userId > 0)
            {
                MessageBox.Show("Registo inserido com sucesso!", "Ideial", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um problema ao inserir o registo!", "Ideial", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void AtualizarUtilizador(int idConta, string user, string pass, int idUtilizador,
            string tipoUtilizador, string nome, string email, string foto, int idCargo, int idDepartamento,
            int idEmpresa)
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

        public void AtualizarPontuacaoUtilizador(int idUtilizador, int pontuacao)
        {

            //Atualiza Utilizador na Db
            UtilizadorDAO utilizadorDAO = new UtilizadorDAO();
            utilizadorDAO.AtualizarPontuacaoUtilizador(idUtilizador, pontuacao);
            MySqlDataReader row = utilizadorDAO.PontuacaoUtilizador(idUtilizador);
            while (row.Read())
            {
                UserLogged.Pontuacao = Convert.ToInt32(row["pontuacao"].ToString());
            }

        }

        public string SelecionarUtilizadorId(int id)
        {
            UtilizadorDAO utilizadorDAO = new UtilizadorDAO();

            //Chama o método para selecionar Utilizador por Id
            MySqlDataReader row = utilizadorDAO.SelecionarUtilizadorId(id);
            string nome = "";
            while (row.Read())
            {
                nome = row["nome"].ToString();
            }
            return nome;
        }

        public int SelecionarTotalIdeias(int id)
        {
            var ideiasUtiliz = new UtilizadorDAO();
            var row = UtilizadorDAO.SelecionarTotalIdeias(id);
            var totalIdeias = 0;
            while (row.Read())
            {
                totalIdeias++;
            }
            return totalIdeias;
        }

        public List<int> SelecionarListaIdeiasDoUtilizador(int id)
        {
            var ideiasUtiliz = new UtilizadorDAO();
            var row = UtilizadorDAO.SelecionarTotalIdeias(id);
            var listaIdeiasUtiliz =new List<int>();
            while (row.Read())
            {
                listaIdeiasUtiliz.Add(Convert.ToInt32(row["ID"].ToString()));
            }
            return listaIdeiasUtiliz;
        }
        
        public int PontuacaoUtilizador(int id)
        {
            var pontuacaoUtiliz = new UtilizadorDAO();
            var row = pontuacaoUtiliz.PontuacaoUtilizador(id);
            var scoreUtiliz = 0;
            while (row.Read())
            {
                scoreUtiliz = Convert.ToInt32(row["pontuacao"].ToString());
            }
            return scoreUtiliz;
        }

        public List<int> PontuacaoTodosUtilizadores()
        {
            var pontuacaoUtiliz = new UtilizadorDAO();
            var row = pontuacaoUtiliz.PontuacaoTodosUtilizadores();
            var todasPontuacoes = new List<int>();
            while (row.Read())
            {
                todasPontuacoes.Add(Convert.ToInt32(row["pontuacao"].ToString()));
            }
            return todasPontuacoes;
        }
    }
}
