using System;
using System.Drawing;
using System.Windows.Forms;

using ideial.Controller;
using ideial.Model.Entity;

namespace ideial.View
{
    public partial class Campanha_frm : Form
    {
        public int IdCampanha { get; set; }
        private readonly CampanhaControl _cc = new CampanhaControl();
        
        public Campanha_frm(int id)
        {
            InitializeComponent();

            IdCampanha = id;
        }

        private void Campanha_Load(object sender, EventArgs e)
        {
            
            CarregaDadosCampanha();
            UpdateTotalIdeias(IdCampanha);
        }

        private void CarregaDadosCampanha()
        {
            Campanha c = _cc.SelecionarCampanhaId(IdCampanha);

            ideiaTitulo_lbl.Text = c.Nome ;
            ideiaConteudo_lbl.Text = c.Descricao;

            UtilizadorControl uc = new UtilizadorControl();
            string nomeUtilizador = uc.SelecionarUtilizadorId(c.IdUtilizador);

            criadorCampanha_lbl.Text = nomeUtilizador;
        }

        private void adicionarIdeia_btn_Click(object sender, EventArgs e)
        {
            CriarIdeia_frm form = new CriarIdeia_frm(IdCampanha); //alterar para receber Id de forma dinâmica
            form.Show();
        }

        private void UpdateTotalIdeias(int idCampanha)
        {
            var totalIdeias = _cc.SelecionarTotalIdeiasCamp(idCampanha);
            ideiasNbr_lbl.Text = totalIdeias.ToString();
        }

        private void ideias_img_Click(object sender, EventArgs e)
        {
            Main_frm.LoadFeedExternal(3, IdCampanha);
        }

        private void ideias_img_Hover(object sender, EventArgs e)
        {
            ideias_img.Size = new Size(ideias_img.Width + 4, ideias_img.Height + 4);
            ideias_img.Location = new Point(ideias_img.Location.X - 2, ideias_img.Location.Y - 2);
        }

        private void ideias_img_Leave(object sender, EventArgs e)
        {
            ideias_img.Size = new Size(ideias_img.Width - 4, ideias_img.Height - 4);
            ideias_img.Location = new Point(ideias_img.Location.X + 2, ideias_img.Location.Y + 2);
        }
    }
}
