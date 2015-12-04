using System;
using System.Linq;
using System.Windows.Forms;

using DISgrupo1.Ideial.View;

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
    }
}
