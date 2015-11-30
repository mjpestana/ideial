using DISgrupo1.Ideial.Db;
using DISgrupo1.Ideial.Utilizadores;
using ideial.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISgrupo1.Ideial.View
{
    public partial class Main : Form
    {

        public Main() {
            InitializeComponent();
        }

      private void utilizadores_btn_Click(object sender, EventArgs e)
        {

            var form = Application.OpenForms.OfType<Utilizador_C>().FirstOrDefault();
            Utilizador_C filho = form ?? new Utilizador_C();
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

            var form = Application.OpenForms.OfType<Ideias>().FirstOrDefault();
            Ideias filho = form ?? new Ideias();
            AddFormInPanel(filho);

        }
    }
}
