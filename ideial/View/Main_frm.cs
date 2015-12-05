using System;
using System.Linq;
using System.Windows.Forms;

using DISgrupo1.Ideial.View;
using DISgrupo1.Ideial.Model.DAO;

namespace DISgrupo1.Ideial.View
{
    public partial class Main_frm : Form
    {

        public Main_frm() {
            InitializeComponent();
        }

        private void utilizadores_btn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<RegistoUtilizador_frm>().FirstOrDefault();
            RegistoUtilizador_frm filho = form ?? new RegistoUtilizador_frm();
            AddFormInPanel(filho);
        }

        private void AddFormInPanel(Form con) {

            if (this.panel_conteudo.Controls.Count != 0)
            {
                this.panel_conteudo.Controls.RemoveAt(0);
            }
                con.TopLevel = false;
                con.FormBorderStyle = FormBorderStyle.None;
                con.Dock = DockStyle.Fill;

                this.panel_conteudo.Controls.Add(con);
                this.panel_conteudo.Tag = con;
                con.Show();
        }

        private void ideias_btn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Ideias_frm>().FirstOrDefault();
            Ideias_frm filho = form ?? new Ideias_frm();
            AddFormInPanel(filho);
        }

        private void userName_lbl_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Perfil_frm>().FirstOrDefault();
            Perfil_frm filho = form ?? new Perfil_frm();
            AddFormInPanel(filho);
        }

        private void sair_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "Ideial", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Main_frm_FormClosing(object sender, FormClosingEventArgs e)
        {

            ConexaoDb.FecharConexao();  //chama método para fechar conexão
            Application.Exit(); //fecha a aplicação   

        }

    }
}
