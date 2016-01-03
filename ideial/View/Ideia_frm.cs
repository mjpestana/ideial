using System;
using System.Drawing;
using System.Windows.Forms;

using ideial.Controller;
using ideial.Model.Entity;

namespace ideial.View
{
    public partial class Ideia_frm : Form
    {
        readonly Bitmap _starSelected = Properties.Resources.star;
        readonly Bitmap _starDeselected = Properties.Resources.inactiveStar;

        private int idIdeia;
        private bool _classificacaoExistente;

        public Ideia_frm(int id)
        {
            InitializeComponent();

            idIdeia = id;
        }

        private void Ideia_frm_Load(object sender, EventArgs e)
        {
            CarregaDadosIdeia();
            CarregaDadosClassificacao();
        }

        private void CarregaDadosIdeia()
        {
            IdeiaControl ic = new IdeiaControl();
            Ideia i = ic.SelecionarIdeiaId(idIdeia);

            ideiaTitulo_lbl.Text = i.Titulo;
            ideiaConteudo_lbl.Text = i.Descricao;

            UtilizadorControl uc = new UtilizadorControl();
            string nomeUtilizador = uc.SelecionarUtilizadorId(i.IdUtilizador);

            criadorIdeia_lbl.Text = nomeUtilizador;
        }

        private void CarregaDadosClassificacao()
        {
            var cic = new ClassificacaoIdeiaControl();
            var ci = cic.SelecionarClassif(idIdeia, UserLogged.IdUtilizador);
            if (ci != null)
            {
                _classificacaoExistente = true;
                ideiaScore_img.Image = ci.Classificacao == 1 ? _starSelected : _starDeselected;
            }
            else
            {
                _classificacaoExistente = false;
                ideiaScore_img.Image = _starDeselected;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void criar_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ideiaConteudo_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ideiaScore_img_Click(object sender, EventArgs e)
        {
            var tempImage = ideiaScore_img.Image;
            ideiaScore_img.Image = tempImage == _starSelected ? _starDeselected : _starSelected;
            
            var classificacao = ideiaScore_img.Image == _starSelected ? 1 : 0;

            if (_classificacaoExistente)
            {
                var cic = new ClassificacaoIdeiaControl();
                var ideiaId = cic.SelecionarClassifId(idIdeia, UserLogged.IdUtilizador);

                ClassificacaoIdeiaControl.AtualizarClassificacao(ideiaId, classificacao);
            }
            else
            {
                ClassificacaoIdeiaControl.ClassificarIdeia(idIdeia, UserLogged.IdUtilizador, classificacao);
            }
        }

    }
}
