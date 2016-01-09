using System.Windows.Forms;

namespace ideial.View
{
    public partial class ListaCampanhas_frm : Form
    {
        private int idCampanha;

        public ListaCampanhas_frm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Campanha_frm form = new Campanha_frm(idCampanha = 1); //alterar para receber Id de forma dinâmica
            form.Show();
        }

        private void ListaCampanhas_frm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
