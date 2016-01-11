using System;
using System.Windows.Forms;

using ideial.Controller;

namespace ideial.View
{
    public partial class RegistoUtilizador_frm : Form
    {
        public RegistoUtilizador_frm()
        {
            InitializeComponent();
        }

        private void RegistoUtilizador_frm_Load(object sender, EventArgs e)
        {
            AdicionaTipoUtilizador();
            AdicionaCargo();
            AdicionaDepartamento();
            AdicionaEmpresa();

            funcionario_panel.Visible = false;
            fornecedor_panel.Visible = false;
        }

        private void AdicionaTipoUtilizador()
        {
            //Carrega combobox com dados da Db
            tipoUtilizador_cmb.DisplayMember = "nome";
            tipoUtilizador_cmb.ValueMember = "ID";
            tipoUtilizador_cmb.DataSource = TipoUtilizadorControl.TipoUtilizador_DataTable();
            tipoUtilizador_cmb.BindingContext = this.BindingContext;
        }

        private void AdicionaCargo()
        {
            //Carrega combobox com dados da Db
            cargo_cmb.DisplayMember = "nome";
            cargo_cmb.ValueMember = "ID";
            cargo_cmb.DataSource = CargoControl.Cargo_DataTable();
            cargo_cmb.BindingContext = this.BindingContext;
        }

        private void AdicionaDepartamento()
        {
            //Carrega combobox com dados da Db
            departamento_cmb.DisplayMember = "nome";
            departamento_cmb.ValueMember = "ID";
            departamento_cmb.DataSource = DepartamentoControl.Departamento_DataTable();
            departamento_cmb.BindingContext = this.BindingContext;
        }

        private void AdicionaEmpresa()
        {
            //Carrega combobox com dados da Db
            empresa_cmb.DisplayMember = "nome";
            empresa_cmb.ValueMember = "ID";
            empresa_cmb.DataSource = EmpresaControl.Empresa_DataTable();
            empresa_cmb.BindingContext = this.BindingContext;
        }

        private void tipoUtilizador_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Altera vizualização dos campos de acordo com tipo de utilizador

            string tipoUtilizador = tipoUtilizador_cmb.Text;

            switch (tipoUtilizador)
            {
                case "Gestor":
                case "Colaborador":
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
            //Prepara dados para serem instânciados e posteriormente inseridos na Db
            string user = userName_txt.Text;
            string pass = password_txt.Text;
            string nome = nome_txt.Text;
            string email = email_txt.Text;
            byte[] foto = null;
            string tipo = tipoUtilizador_cmb.Text;
            int idCargo = (int)cargo_cmb.SelectedValue;
            int idDepartamento = (int)departamento_cmb.SelectedValue;
            int idEmpresa = (int)empresa_cmb.SelectedValue;
           
            UtilizadorControl.CriarUtilizador(user, pass, nome, email, foto, tipo, idCargo, idDepartamento, idEmpresa);
        }

    }
}

