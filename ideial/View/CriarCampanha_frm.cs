using System;
using System.Windows.Forms;

using ideial.Model.Entity;
using ideial.Controller;

namespace ideial.View
{
    public partial class CriarCampanha_frm : Form
    {
        public CriarCampanha_frm()
        {
            InitializeComponent();
        }

        private void CriarCampanha_frm_Load(object sender, System.EventArgs e)
        {
            nomeUtilizador_lbl.Text = UserLogged.NomeUtilizador;

            DateTime data = DateTime.Now.Date;
            data_lbl.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
        }

        private void criarCampanha_btn_Click(object sender, EventArgs e)
        {
            //Prepara dados para serem instânciados e posteriormente inseridos na Db
            string nome = nome_txt.Text;
            string descricao = descricao_txt.Text;
            int id_utilizador = UserLogged.IdUtilizador;
            string data = DateTime.Now.Date.ToString("yyyy-MM-dd");

            CampanhaControl.CriarCampanha(nome, descricao, id_utilizador, data);
        }
    }
}
