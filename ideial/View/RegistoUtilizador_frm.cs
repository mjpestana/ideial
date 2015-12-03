using System;
using System.Windows.Forms;

using DISgrupo1.Ideial.Controller;

namespace DISgrupo1.Ideial.View
{
    public partial class RegistoUtilizador_frm : Form
    {
        public RegistoUtilizador_frm()
        {
            InitializeComponent();

            AdicionaTipoUtilizador();
            AdicionaDepartamento();

            funcionario_panel.Visible = false;
            fornecedor_panel.Visible = false;
        }

        private void AdicionaTipoUtilizador()
        {
            tipoUtilizador_cmb.Items.Add("Gestor");
            tipoUtilizador_cmb.Items.Add("Colaborador");
            tipoUtilizador_cmb.Items.Add("Fornecedor");
            tipoUtilizador_cmb.Items.Add("Cliente");
        }

        private void AdicionaDepartamento()
        {
            departamento_cmb.Items.Add("Departamento A");
            departamento_cmb.Items.Add("Departamento B");
        }

        private void tipoUtilizador_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoUtilizador = (string) tipoUtilizador_cmb.SelectedItem;

            switch (tipoUtilizador)
            {
                case "Gestor": case "Colaborador":
                    funcionario_panel.Visible = true;
                    fornecedor_panel.Visible = false;
                    break;
                case "Fornecedor":
                    funcionario_panel.Visible = false;
                    fornecedor_panel.Visible = true;
                    break;
                default:
                    funcionario_panel.Visible = false;
                    fornecedor_panel.Visible = false;
                    break;
            }
        }

        private void registarUtilizador_btn_Click(object sender, EventArgs e)
        {
            string user = userName_txt.Text;
            string pass = password_txt.Text;

            RegistoControl.CriarUtilizador(user, pass);
        }
    }
}
