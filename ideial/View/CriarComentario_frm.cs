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
    public partial class CriarComentario_frm : Form
    {
        private int _idIdeia;

        public CriarComentario_frm(int id)
        {
            InitializeComponent();
            _idIdeia = id;
        }

        private void submeterComentario_btn_Click(object sender, EventArgs e)
        {
            int id_ideia = _idIdeia;
            int id_utilizador = UserLogged.IdUtilizador;
            string conteudo = conteudo_txt.Text;

            ComentarioControl.InserirComentario(id_ideia, id_utilizador, conteudo);
            Close();

        }

        private void CriarComentario_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
