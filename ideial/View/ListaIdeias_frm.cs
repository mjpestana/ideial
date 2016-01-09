using System.Linq;
using System.Windows.Forms;

namespace ideial.View
{
    public partial class ListaIdeias_frm : Form
    {
        private int idIdeia;

        public ListaIdeias_frm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ideia_frm form = new Ideia_frm(idIdeia = 1); //alterar para receber Id de forma dinâmica
            form.Show();
        }
    }
}
