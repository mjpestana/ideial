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
        private bool _mostraComentarios;
        public int IdIdeia { get; set; }
        private bool _classificacaoExistente;

        private readonly ClassificacaoIdeiaControl _cic = new ClassificacaoIdeiaControl();

        public Ideia_frm(int id, bool mostraComentarios)
        {
            InitializeComponent();
            _mostraComentarios = mostraComentarios;
            IdIdeia = id;
        }

        private void Ideia_frm_Load(object sender, EventArgs e)
        {
            if (_mostraComentarios)
            {
                this.Size = new Size(460, 415);
            }
            else
            {
                this.Size = new Size(460, 265);
            }
            CarregaDadosIdeia();
            CarregaDadosClassificacao();
            UpdateTotalClassif(IdIdeia);
        }

        public int IdDaIdeiaEmFocus()
        {
            return IdIdeia;
        }

        private void CarregaDadosIdeia()
        {
            IdeiaControl ic = new IdeiaControl();
            Ideia i = ic.SelecionarIdeiaId(IdIdeia);

            ideiaTitulo_lbl.Text = i.Titulo;
            ideiaConteudo_lbl.Text = i.Descricao;

            UtilizadorControl uc = new UtilizadorControl();
            string nomeUtilizador = uc.SelecionarUtilizadorId(i.IdUtilizador);

            criadorIdeia_lbl.Text = nomeUtilizador;
        }

        private void CarregaDadosClassificacao()
        {
            var ci = _cic.SelecionarClassif(IdIdeia, UserLogged.IdUtilizador);
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
                var ideiaId = _cic.SelecionarClassifId(IdIdeia, UserLogged.IdUtilizador);
                ClassificacaoIdeiaControl.AtualizarClassificacao(ideiaId, classificacao);
            }
            else
            {
                ClassificacaoIdeiaControl.ClassificarIdeia(IdIdeia, UserLogged.IdUtilizador, classificacao);
            }

            UpdateTotalClassif(IdIdeia);
        }

        private void UpdateTotalClassif(int idId)
        {
            var totalClassif = _cic.SelecionarTotalClassif(IdIdeia);
            scoresNbr_lbl.Text = totalClassif.ToString();
        }

        private void adicionarComentario_btn_Click(object sender, EventArgs e)
        {
            CriarComentario_frm form = new CriarComentario_frm(IdIdeia); //alterar para receber Id de forma dinâmica
            form.Show();
        }
    }
}
