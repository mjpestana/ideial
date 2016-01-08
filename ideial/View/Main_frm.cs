using System;
using System.Diagnostics;
using System.Linq;
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
        
        public Main_frm() {
            InitializeComponent();
        }

        private void Main_frm_Load(object sender, EventArgs e)
        {
            CarregaDadosUtilizador();
            PermissoesFormPrincipal();
            UpdateTotalIdeias(UserLogged.IdUtilizador);
        }

        private void AddFormInPanel(Form con)
        {

            if (this.panel_conteudo.Controls.Count != 0)
            {
                this.panel_conteudo.Controls.RemoveAt(0);
            }
            con.TopLevel = false;
            con.FormBorderStyle = FormBorderStyle.None;
            con.Dock = DockStyle.Fill;

            this.panel_conteudo.Controls.Add(con);
            this.panel_conteudo.Tag = con;
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
            this.Close();
            
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
            var form = Application.OpenForms.OfType<ListaIdeias_frm>().FirstOrDefault();
            ListaIdeias_frm filho = form ?? new ListaIdeias_frm();
            AddFormInPanel(filho);
        }

        private void campanhas_btn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<ListaCampanhas_frm>().FirstOrDefault();
            ListaCampanhas_frm filho = form ?? new ListaCampanhas_frm();
            AddFormInPanel(filho);
        }

        private void UpdateTotalIdeias(int idUtiliz)
        {
            var totalIdeias = _uc.SelecionarTotalIdeias(idUtiliz);
            numIdeias_lbl.Text = totalIdeias.ToString();
        }
    }
}
