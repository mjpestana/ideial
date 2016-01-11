using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Windows.Forms;
using ideial.Controller;
using ideial.Model.DAO;
using ideial.Model.Entity;

namespace ideial.View
{
    public partial class Main_frm : Form
    {
        private int idCampanha;
        private readonly UtilizadorControl _uc = new UtilizadorControl();
        private static Panel _panel_conteudo;
        private int _scoreUtiliz;
        readonly Bitmap _silverRank = Properties.Resources.silverBadge;
        readonly Bitmap _goldRank = Properties.Resources.goldBadge;

        public Main_frm() {
            InitializeComponent();
            _panel_conteudo = this.panel_conteudo;
        }

        private void Main_frm_Load(object sender, EventArgs e)
        {
            CarregaDadosUtilizador();
            CalculaScoreUtilizador();
            CalculaRankUtilizador();
            PermissoesFormPrincipal();
            UpdateTotalIdeias(UserLogged.IdUtilizador);
            LoadFeed(0);
        }

        private void CalculaRankUtilizador()
        {
            var mediaTotal = CalculaMediaTodosUtilizadores();
            
            if (_scoreUtiliz > mediaTotal)
            {
                rank_img.Image = _goldRank;
            }
            else
            {
                rank_img.Image = _silverRank;
            }
        }

        private int CalculaMediaTodosUtilizadores()
        {
            var media = 0;
            var totalPont = _uc.PontuacaoTodosUtilizadores();
            for(var i= 0; i < totalPont.Count; i ++)
            {
                media += totalPont[i];
            }

            media = media/totalPont.Count;

            return media;
        }

        private void CalculaScoreUtilizador()
        {
            var scoreIdeias = _uc.SelecionarTotalIdeias(UserLogged.IdUtilizador);

            var listaIdeias = _uc.SelecionarListaIdeiasDoUtilizador(UserLogged.IdUtilizador);

            var scoreLikes = 2 * CalculaTotalClassificacoes(listaIdeias);
            var scoreComentariosRecebidos = CalculaTotalComentarios(listaIdeias);

            int pontuacao = scoreIdeias + scoreLikes + scoreComentariosRecebidos;

            _uc.AtualizarPontuacaoUtilizador(UserLogged.IdUtilizador, pontuacao);
            _scoreUtiliz = _uc.PontuacaoUtilizador(UserLogged.IdUtilizador);
            score_lbl.Text = _scoreUtiliz.ToString();
        }

        private int CalculaTotalClassificacoes(List<int> listaIdeias)
        {
            
            var cc = new ComentarioControl();
            var scoreComent = 0;

            for (var i = 0; i < listaIdeias.Count; i++)
            {
                scoreComent += cc.SelecionarComentariosDaIdeia(listaIdeias[i]).Count;
            }
            return scoreComent;
        }

        private int CalculaTotalComentarios(List<int> listaIdeias)
        {
            
            var cic = new ClassificacaoIdeiaControl();
            var scoreLikes = 0;

            for (var i = 0; i < listaIdeias.Count; i++)
            {
                scoreLikes += cic.SelecionarTotalClassif(listaIdeias[i]);
            }
            return scoreLikes;
        }

        public static void AddFormInPanel(Form con)
        {
            if (_panel_conteudo.Controls.Count != 0)
            {
                _panel_conteudo.Controls.RemoveAt(0);
            }
            con.TopLevel = false;
            con.FormBorderStyle = FormBorderStyle.None;
            con.Dock = DockStyle.Fill;

            _panel_conteudo.Controls.Add(con);
            _panel_conteudo.Tag = con;
            con.Show();
        }

        private void utilizadores_btn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<RegistoUtilizador_frm>().FirstOrDefault();
            RegistoUtilizador_frm filho = form ?? new RegistoUtilizador_frm();
            AddFormInPanel(filho);
        }

        private void sair_btn_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void Main_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "Ideial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ConexaoDb conDb = ConexaoDb.GetConexaoDb();
                conDb.FecharConexao();  //chama método para fechar conexão

                Environment.Exit(0);    //fecha a aplicação 
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void editPrfl_button_Click(object sender, EventArgs e)
        {
            editarPerfilForm();
        }

        private void userName_lbl_Click(object sender, EventArgs e)
        {
            editarPerfilForm();
        }

        private void editarPerfilForm()
        {
            var form = Application.OpenForms.OfType<Perfil_frm>().FirstOrDefault();
            Perfil_frm filho = form ?? new Perfil_frm();
            AddFormInPanel(filho);
        }

        private void LoadFeed(int tipo)
        {
            var fc = Application.OpenForms["Feed_frm"];
            fc?.Close();

            var form = Application.OpenForms.OfType<Feed_frm>().FirstOrDefault();
            var filho = form ?? new Feed_frm(tipo);
            AddFormInPanel(filho);
        }

        public static void LoadFeedExternal(int tipo, int id)
        {
            
            var fc = Application.OpenForms["Feed_frm"];
            fc?.Close();

            var form = Application.OpenForms.OfType<Feed_frm>().FirstOrDefault();
            var filho = form ?? new Feed_frm(tipo, id);
            AddFormInPanel(filho);
        }

        private void CarregaDadosUtilizador()
        {
            userName_lbl.Text = UserLogged.User;
            tipoUtilizador_lbl.Text = UserLogged.TipoUtilizador;
        }

        private void PermissoesFormPrincipal()
        {
            switch (UserLogged.TipoUtilizador)
            {
                case "Gestor":
                    criarCampanha_lbl.Visible = true;
                    criarCampanha_btn.Visible = true;
                    campanhas_btn.Visible = true;
                    utilizadores_btn.Visible = true;
                    break;
                default:
                    criarCampanha_lbl.Visible = false;
                    criarCampanha_btn.Visible = false;
                    campanhas_btn.Visible = false;
                    utilizadores_btn.Visible = false;
                    criarIdeia_lbl.Location = new Point(criarIdeia_lbl.Location.X - 15, criarIdeia_lbl.Location.Y + 25);
                    criarIdeia_btn.Location = new Point(criarIdeia_btn.Location.X - 15, criarIdeia_btn.Location.Y + 25);
                    ideias_btn.Location = new Point(ideias_btn.Location.X, ideias_btn.Location.Y - 40);
                    utilizLista_btn.Location = new Point(utilizLista_btn.Location.X, utilizLista_btn.Location.Y - 40);
                    break;
            }
        }

        private void criarIdeia_btn_Click(object sender, EventArgs e)
        {
            criarIdeiaForm();
        }

        private void criarIdeia_lbl_Click(object sender, EventArgs e)
        {
            criarIdeiaForm();
        }

        private void criarIdeiaForm()
        {
            var form = Application.OpenForms.OfType<CriarIdeia_frm>().FirstOrDefault();
            CriarIdeia_frm filho = form ?? new CriarIdeia_frm(idCampanha=0);
            AddFormInPanel(filho);
        }

        private void criarCampanha_btn_Click(object sender, EventArgs e)
        {
            criarCampanhaForm();
        }

        private void criarCampanha_lbl_Click(object sender, EventArgs e)
        {
            criarCampanhaForm();
        }

        private void criarCampanhaForm()
        {
            var form = Application.OpenForms.OfType<CriarCampanha_frm>().FirstOrDefault();
            CriarCampanha_frm filho = form ?? new CriarCampanha_frm();
            AddFormInPanel(filho);
        }

        private void ideias_btn_Click(object sender, EventArgs e)
        {
            LoadFeed(1);
        }

        private void campanhas_btn_Click(object sender, EventArgs e)
        {
            LoadFeed(2);
        }

        private void UpdateTotalIdeias(int idUtiliz)
        {
            var totalIdeias = _uc.SelecionarTotalIdeias(idUtiliz);
            numIdeias_lbl.Text = totalIdeias.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            LoadFeed(0);
        }

        private void utilizLista_btn_Click(object sender, EventArgs e)
        {
            LoadFeed(4);
        }
    }
}
