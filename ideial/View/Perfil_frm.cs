using System;
using System.Windows.Forms;

using ideial.Model.Entity;
using ideial.Controller;

namespace ideial.View
{
    public partial class Perfil_frm : Form
    {
        public Perfil_frm()
        {
            InitializeComponent();
        }

        private void Perfil_frm_Load(object sender, EventArgs e)
        {
            CarregaDadosUtilizador();
            MostrarCamposUtilizador();

            AdicionaCargo();
            AdicionaDepartamento();
            AdicionaEmpresa();
        }

        private void CarregaDadosUtilizador()
        {
            //Preenche formulário com dados pré-carregados
            userName_lbl.Text = UserLogged.User;

            nome_txt.Text = UserLogged.NomeUtilizador;
            email_txt.Text = UserLogged.Email;
            tipoUtilizador_lbl.Text = UserLogged.TipoUtilizador;
            
        }

        private void MostrarCamposUtilizador()
        {
            //Altera vizualização dos campos de acordo com tipo de utilizador

            string tipoUtilizador = tipoUtilizador_lbl.Text;

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

        private void AdicionaCargo()
        {
            //Carrega ComboBox com dados da Db
            cargo_cmb.DisplayMember = "nome";
            cargo_cmb.ValueMember = "ID";
            cargo_cmb.DataSource = CargoControl.Cargo_DataTable();
            cargo_cmb.BindingContext = this.BindingContext;

            //Seleciona o valor do ComboBox de acordo com o UserLogged
            cargo_cmb.SelectedValue = UserLogged.IdCargo;
        }

        private void AdicionaDepartamento()
        {
            //Carrega ComboBox com dados da Db
            departamento_cmb.DisplayMember = "nome";
            departamento_cmb.ValueMember = "ID";
            departamento_cmb.DataSource = DepartamentoControl.Departamento_DataTable();
            departamento_cmb.BindingContext = this.BindingContext;

            //Seleciona o valor do ComboBox de acordo com o UserLogged
            departamento_cmb.SelectedValue = UserLogged.IdDepartamento;
        }

        private void AdicionaEmpresa()
        {
            //Carrega ComboBox com dados da Db
            empresa_cmb.DisplayMember = "nome";
            empresa_cmb.ValueMember = "ID";
            empresa_cmb.DataSource = EmpresaControl.Empresa_DataTable();
            empresa_cmb.BindingContext = this.BindingContext;

            //Seleciona o valor do ComboBox de acordo com o UserLogged
            empresa_cmb.SelectedValue = UserLogged.IdEmpresa;
        }

        private void atualizar_btn_Click(object sender, EventArgs e)
        {
            string user, pass, tipoUtilizador, nome, email, foto;
            int idConta=0, idUtilizador=0, idCargo=0, idDepartamento=0, idEmpresa=0;

            //Prepara dados do utilizador
            idConta = UserLogged.IdConta;
            user = UserLogged.User;
            idUtilizador = UserLogged.IdUtilizador;
            tipoUtilizador = UserLogged.TipoUtilizador;
            foto = UserLogged.Foto;

            //Atribuir valores as variáveis de acordo com os campos alterados
            pass = password_txt.Text;
            nome = nome_txt.Text;
            email = email_txt.Text;

            //Atribui valores as variáveis de acordo com o valor selecionado nas ComboBox
            if (cargo_cmb.SelectedValue != null) { idCargo = (int) cargo_cmb.SelectedValue; }
            if (departamento_cmb.SelectedValue != null) { idDepartamento = (int)departamento_cmb.SelectedValue; }
            if (empresa_cmb.SelectedValue != null) { idEmpresa = (int)empresa_cmb.SelectedValue; }

            //Chama método para atualizar utilizador de acordo com os parâmetros enviados
            UtilizadorControl.AtualizarUtilizador(idConta, user, pass, idUtilizador, tipoUtilizador, nome, email, foto, idCargo, idDepartamento, idEmpresa);
        }
    }
}
