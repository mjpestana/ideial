using System;
using System.Windows.Forms;

using ideial.Controller;
using ideial.Model.Entity;

namespace ideial.View
{
    public partial class Campanha_frm : Form
    {
        private int idCampanha;
        private readonly CampanhaControl _cc = new CampanhaControl();

        
         
        public Campanha_frm(int id)
        {
            InitializeComponent();

            idCampanha = id;
        }

        private void Campanha_Load(object sender, EventArgs e)
        {
            CarregaDadosCampanha();
            UpdateTotalIdeias(idCampanha);
        }

        private void CarregaDadosCampanha()
        {
            Campanha c = _cc.SelecionarCampanhaId(idCampanha);

            ideiaTitulo_lbl.Text = c.Nome ;
            ideiaConteudo_lbl.Text = c.Descricao;

            UtilizadorControl uc = new UtilizadorControl();
            string nomeUtilizador = uc.SelecionarUtilizadorId(c.IdUtilizador);

            criadorCampanha_lbl.Text = nomeUtilizador;
        }

        private void adicionarIdeia_btn_Click(object sender, EventArgs e)
        {
            CriarIdeia_frm form = new CriarIdeia_frm(idCampanha); //alterar para receber Id de forma dinâmica
            form.Show();
        }

        private void UpdateTotalIdeias(int idCampanha)
        {
            var totalIdeias = _cc.SelecionarTotalIdeias(idCampanha);
            ideiasNbr_lbl.Text = totalIdeias.ToString();
        }
    }
}
