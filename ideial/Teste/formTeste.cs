using System;
using System.Windows.Forms;

namespace DISgrupo1.Ideial.Teste
{
    public partial class formTeste : Form
    {
        public formTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TesteUtilizadorDAO test = new TesteUtilizadorDAO();
            test.testeCriarUtilizador();
        }
    }
}
