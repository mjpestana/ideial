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
    public partial class Comentario_frm : Form
    {
        private int _idComentario;

        public Comentario_frm(int id)
        {
            InitializeComponent();
            _idComentario = id;
        }

        private void Comentario_frm_Load(object sender, EventArgs e)
        {
            CarregaDadosComentario();
        }

        public void CarregaDadosComentario()
        {
            ComentarioControl cc = new ComentarioControl();
            Comentario i = cc.SelecionarComentarioId(_idComentario);

            comentarioConteudo_lbl.Text = i.Conteudo;

            UtilizadorControl uc = new UtilizadorControl();
            string nomeUtilizador = uc.SelecionarUtilizadorId(i.IdUtilizador);

            criadorComentario_lbl.Text = nomeUtilizador;
        }
    }
}
