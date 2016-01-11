using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ideial.Controller;
using ideial.Model.Entity;

namespace ideial.View
{
    public partial class PerfilResumoFrm : Form
    {
        private UtilizadorControl _uc = new UtilizadorControl();
        public int IdUtiliz { get; set; }
        readonly Bitmap _silverRank = Properties.Resources.silverBadge;
        readonly Bitmap _goldRank = Properties.Resources.goldBadge;

        public PerfilResumoFrm(int id)
        {
            InitializeComponent();
            IdUtiliz = id;
        }

        private void perfilResumo_frm_Load(object sender, EventArgs e)
        {
            CarregaDadosUtilizador();
            UpdateTotalIdeias(IdUtiliz);
            CalculaRankUtilizador();
        }

        private void CarregaDadosUtilizador()
        {
            userName_lbl.Text = _uc.SelecionarUtilizadorId(IdUtiliz);
            tipoUtilizador_lbl.Text = _uc.SelecionarTipoUtilizadorId(IdUtiliz);
            score_lbl.Text = _uc.PontuacaoUtilizador(IdUtiliz).ToString();
        }

        private void UpdateTotalIdeias(int idUtiliz)
        {
            var totalIdeias = _uc.SelecionarTotalIdeias(idUtiliz);
            numIdeias_lbl.Text = totalIdeias.ToString();
        }

        private void CalculaRankUtilizador()
        {
            var mediaTotal = CalculaMediaTodosUtilizadores();
            var scoreUtiliz = _uc.PontuacaoUtilizador(IdUtiliz);

            if (scoreUtiliz > mediaTotal)
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
            for (var i = 0; i < totalPont.Count; i++)
            {
                media += totalPont[i];
            }

            media = media / totalPont.Count;

            return media;
        }

        private void userPic_img_Click(object sender, EventArgs e)
        {
            Main_frm.LoadFeedExternal(1, IdUtiliz);
        }
    }
}
