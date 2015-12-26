using System;
using System.Windows.Forms;
using ideial.Controller;

namespace ideial.View
{
    public partial class Login_frm : Form
    {
        public Login_frm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string user = userName_txt.Text;
            string pass = password_txt.Text;

            if (user=="")
            {
                MessageBox.Show("Digite o nome de utilizador", "Login", MessageBoxButtons.OK);
                userName_txt.Focus();
            }
            else if (pass=="")
            {
                MessageBox.Show("Digite a palavra-passe", "Login", MessageBoxButtons.OK);
                password_txt.Focus();
            }
            else
            {
                bool login = ContaControl.EfetuarLogin(user, pass);

                if (login) //credenciais válidas, fecha form Login
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else //credenciais inválidas, apresenta mensagem
                {
                    MessageBox.Show("Utilizador e/ou palavra-passe inválida(s)", "Login" ,MessageBoxButtons.OK);
                }
            }

        }
    }
}
