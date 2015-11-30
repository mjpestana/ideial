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

namespace ideial.View
{
    public partial class Utilizador_C : Form
    {
        public Utilizador_C()
        {
            InitializeComponent();
        }

        private void registo_btn_Click(object sender, EventArgs e)
        {


           UtilizadorDAO uDAO;
            Utilizador u = new Colaborador();

            u.Email = email_txt.Text;
            u.Nome = Nome_txt.Text;
            u.password = password_txt.Text;
            u.userName = username_txt.Text;

            uDAO = new UtilizadorDAO();
            uDAO.criarUtilizador(u);

        }
    }
}
