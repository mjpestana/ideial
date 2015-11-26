using DISgrupo1.Ideial.Db;
using DISgrupo1.Ideial.Utilizadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ideial
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            UtilizadorDAO uDAO;

            Utilizador u = new Colaborador();

            u.userName = userName_txt.Text;
            u.password = password_txt.Text;

            uDAO = new UtilizadorDAO();
            uDAO.Login(u);

        }
    }
}
