using System;
using System.Windows.Forms;

using ideial.Model.Entity;
using ideial.Controller;

namespace ideial.View
{
    public partial class CriarIdeia_frm : Form
    {
        private int id_campanha;

        public CriarIdeia_frm(int idCampanha)
        {
            InitializeComponent();

            id_campanha = idCampanha;
        }

        private void CriarIdeia_frm_Load(object sender, System.EventArgs e)
        {
            AdicionaEstado();

            nomeUtilizador_lbl.Text = UserLogged.NomeUtilizador;

            DateTime data = DateTime.Now.Date;
            data_lbl.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
        }

        private void AdicionaEstado()
        {
            //Carrega combobox com dados da Db
            estadoIdeia_cmb.DisplayMember = "nome";
            estadoIdeia_cmb.ValueMember = "ID";
            estadoIdeia_cmb.DataSource = EstadoControl.Estado_DataTable();
            estadoIdeia_cmb.BindingContext = this.BindingContext;
        }

        private void criarIdeia_btn_Click(object sender, EventArgs e)
        {
            //Prepara dados para serem instânciados e posteriormente inseridos na Db
            string titulo = titulo_txt.Text;
            string descricao = descricao_txt.Text;
            int id_utilizador = UserLogged.IdUtilizador;
            string data = DateTime.Now.Date.ToString("yyyy-MM-dd");
            int id_estado = (int)estadoIdeia_cmb.SelectedValue;
            string tags = tags_txt.Text;

            IdeiaControl.CriarIdeia(titulo, descricao, id_utilizador, data, id_estado, tags, id_campanha);
        }
    }
}
