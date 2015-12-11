using System;
using System.Windows.Forms;
using System.Data;

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
            AdicionaEmpresa();
            AdicionaCargo();

            funcionario_panel.Visible = false;
            fornecedor_panel.Visible = false;
        }

        private void AdicionaTipoUtilizador()
        {
            //var TipoUtilizador_dt = new DataTable() ;
            //TipoUtilizador_dt =  UtilizadorControl.Cheia_TipoUtilizador();

            tipoUtilizador_cmb.DisplayMember = "nome";
            tipoUtilizador_cmb.ValueMember = "ID";
            //tipoUtilizador_cmb.DataSource = TipoUtilizador_dt;
            tipoUtilizador_cmb.DataSource = TipoUtilizadorControl.TipoUtilizador_DataTable();
            tipoUtilizador_cmb.BindingContext = this.BindingContext;
        }

        private void AdicionaDepartamento()
        {
            //var Departamento_dt = new DataTable();
            //Departamento_dt = UtilizadorControl.Cheia_Departamento();

            departamento_cmb.DisplayMember = "nome";
            departamento_cmb.ValueMember = "ID";
            //departamento_cmb.DataSource = Departamento_dt;
            departamento_cmb.DataSource = DepartamentoControl.Departamento_DataTable();
            departamento_cmb.BindingContext = this.BindingContext;
        }

        private void AdicionaEmpresa()
        {
            //var empresa_dt = new DataTable();
            //empresa_dt = EmpresaControl.Cheia_Empresa_DataTable();

            empresa_cmb.DisplayMember = "nome";
            empresa_cmb.ValueMember = "ID";
            //empresa_cmb.DataSource = empresa_dt;
            empresa_cmb.DataSource = EmpresaControl.Empresa_DataTable();
            empresa_cmb.BindingContext = this.BindingContext;
        }

        private void AdicionaCargo()
        {
            //var cargo_dt = new DataTable();
            //cargo_dt = CargoControl.Cheia_Cargo();

            cargo_cmb.DisplayMember = "nome";
            cargo_cmb.ValueMember = "ID";
            //cargo_cmb.DataSource = cargo_dt;
            cargo_cmb.DataSource = CargoControl.Cargo_DataTable();
            cargo_cmb.BindingContext = this.BindingContext;
        }

        private void tipoUtilizador_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            string user = userName_txt.Text;
            string pass = password_txt.Text;
            string nome = nome_txt.Text;
            string email = email_txt.Text;
            string tipo = tipoUtilizador_cmb.Text;
            int id_tipo = (int)tipoUtilizador_cmb.SelectedValue;
            int id_departamento = (int)departamento_cmb.SelectedValue;
            int id_empresa = (int)empresa_cmb.SelectedValue;
            int id_cargo = (int)cargo_cmb.SelectedValue;

            UtilizadorControl.CriarUtilizador(user, pass, nome, email, tipo, id_tipo, id_departamento, id_empresa, id_cargo);
        }

    }
}

