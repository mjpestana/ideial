using System;
using System.Windows.Forms;

using ideial.Model.Entity;

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
    }
}
